using System;
using System.Collections.Generic;
using System.Text;

namespace SalesforceLambda
{
    public class ConnectLambdaRequest
    {
        public ConnectLambdaDetails Details { get; set; }
        public string Name { get; set; }
    }

    public class ConnectLambdaDetails
    {
        public ConnectLambdaContactData ContactData { get; set; }
        public dynamic Parameters { get; set; }
    }

    public class ConnectLambdaContactData
    {
        public dynamic Attributes { get; set; }
        public string Channel { get; set; }
        public string ContactId { get; set; }
        public ConnectLambdaEndPoint CustomerEndpoint { get; set; }
        public string InitialContactId { get; set; }
        public string InitiationMethod { get; set; }
        public string InstanceARN { get; set; }
        public string PreviousContactId { get; set; }
        public string Queue { get; set; }
        public ConnectLambdaEndPoint SystemEndPoint { get; set; }
    }

    public class ConnectLambdaEndPoint
    {
        public string Address { get; set; }
        public string Type { get; set; }
    }
}
