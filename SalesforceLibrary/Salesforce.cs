using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceLibrary
{
    public static class Salesforce
    {
        private const string LOGIN_ENDPOINT = "https://login.salesforce.com/services/oauth2/token";
        private const string API_ENDPOINT = "/services/data/v36.0/";

        private static HttpClient APIClient { get; set; }
        private static string AuthToken { get; set; }
        private static string InstanceUrl { get; set; }

        public static bool LoggedIn { get; private set; } = false;

        public static async Task Login(string strClientId, string strClientSecret, string strUsername, string strPassword, string strSecurityToken)
        {
            // SF requires this
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;

            var request = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"grant_type", "password"},
                {"client_id", strClientId},
                {"client_secret", strClientSecret},
                {"username", strUsername},
                {"password", strPassword + strSecurityToken}
            });

            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            request.Headers.Add("X-PrettyPrint", "1");
            using (HttpResponseMessage response = await APIClient.PostAsync(LOGIN_ENDPOINT, request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonResponse);
                    AuthToken = values["access_token"];
                    InstanceUrl = values["instance_url"];
                    LoggedIn = true;
                    return;
                }
                throw (new Exception(response.ReasonPhrase));
            }
        }

        public static async Task<List<Contact>> SearchContacts(string strPhoneNumber)
        {
            if (!LoggedIn)
                throw new Exception("You must login before you can search for contacts");

            // Clean up the phone number
            strPhoneNumber = new String(strPhoneNumber.
                Where(x => Char.IsDigit(x)).ToArray());
            if (strPhoneNumber.Length > 10)
                strPhoneNumber = strPhoneNumber.Substring(strPhoneNumber.Length - 10);

            if (strPhoneNumber == "")
                return new List<Contact>();

            string sosl = "FIND {" + strPhoneNumber + "} IN Phone FIELDS RETURNING Contact(FirstName, LastName)";
            string restRequest = InstanceUrl + API_ENDPOINT + "search/?q=" + sosl;
            var request = new HttpRequestMessage(HttpMethod.Get, restRequest);
            request.Headers.Add("Authorization", "Bearer " + AuthToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("X-PrettyPrint", "1");
            using (HttpResponseMessage response = await APIClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    string strJson = await response.Content.ReadAsStringAsync();
                    List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(strJson);
                    return contacts;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
