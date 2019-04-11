using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using SalesforceLibrary;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace SalesforceLambda
{
    public class Function
    {
        /// <summary>
        /// A function that uses the phone number to search for a matching contact in Salesforce and if any is found the contacts name is played to the party
        /// </summary>
        /// <param name="connectLambdaRequest"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<object> FunctionHandler(ConnectLambdaRequest connectLambdaRequest, ILambdaContext context)
        {
            Console.WriteLine("-------- Function Handler ----------");
            Console.WriteLine(connectLambdaRequest);

            // Are we logged in yet?
            if (!Salesforce.LoggedIn)
            {
                // Retrieve the authentication settings from the environment that the Lambda function is executing in
                string strClientId = Environment.GetEnvironmentVariable("ClientId");
                string strClientSecret = Environment.GetEnvironmentVariable("ClientSecret");
                string strUsername = Environment.GetEnvironmentVariable("Username");
                string strPassword = Environment.GetEnvironmentVariable("Password");
                string strSecurityToken = Environment.GetEnvironmentVariable("SecurityToken");
                Console.WriteLine($"ClientId: {strClientId}, ClientSecret: {strClientSecret}, Username: {strUsername}");

                // Use the credentials to login to Salesforce
                await Salesforce.Login(strClientId, strClientSecret, strUsername, strPassword, strSecurityToken);
            }

            // Get the phone number passed with the Connect Lambda request
            string strPhoneNumber = connectLambdaRequest?.Details?.ContactData?.CustomerEndpoint?.Address;
            Console.WriteLine($"Searching Salesforce contacts for phone number: {strPhoneNumber}");

            // Search Salesforce contacts for the phone number
            List<Contact> contacts = await Salesforce.SearchContacts(strPhoneNumber);

            // If we got exactly one contact then return it
            Console.WriteLine($"Retrieved {contacts.Count} contacts");

            // Return results in a format that makes Connect happy
            if (contacts.Count == 1)
            {
                Console.WriteLine($"Returning contact {contacts[0]}");
                var result = new
                {
                    Contact = $"\"{contacts[0]}\""
                };
                return result;
            }

            // Return no contacts even if we got multiple hits
            Console.WriteLine("Returning empty contact result");
            var emptyResult = new
            {
                Contact = "unknown"
            };
            return emptyResult;
        }
    }
}
