SalesforceLambda

Video available on Youtube:
https://youtu.be/WeHJDOWKS_M

This Visual Studio 2017 Solution shows how to build an Amazon AWS Lambda Function which uses Salesforce's REST interface, specifically Saleforce's SOSL query feature to lookup and return Contacts which match a passed phone number.  This lambda function is called from a Amazon Connect Contact Flow.

You will need to have a Salesforce account with API access enabled in order to test this code.  You can also sign up for a free developer account (see links below).

This Visual Studio 2017 solution contains three projects:

- SalesforceLibrary 
  A .NET Standard library written in C# that handles Salesforce REST requests.
- SalesforceForm 
  A .NET Framework Forms application written in C# that acts as a simple test application for the SalesforceLibrary.
- SalesforceLambda 
  A .NET Core library which provides the Lambda Function interface.

The Lambda function should be configured with five environment variables with required authentication information.  Specifically:
- ClientId
- ClientSecret
- Username
- Password
- SecruityToken

This function is intended to be called from Amazon Connect so it must accept the standard JSON request data passed by Amazon Connect call flow when a Lambda function is invoked.  It will use the caller's phone number passed to perform the search.

If a single contact match for the phone number is found then it will return the contact's full name.  For example:
{ 
	"Contact": "\"John Smith\"" 
}

When used from an Amazon Connect Call Flow, the results would be accessed as the External Attribute "Contact".

Links
-----
Salesforce Developer Edition Signup:
https://developer.salesforce.com/signup

Salesforce's SOSL Query Language Documentation:
https://developer.salesforce.com/docs/atlas.en-us.soql_sosl.meta/soql_sosl/sforce_api_calls_sosl.htm

Article on Integrating .NET and Salesforce with REST:
https://blog.mkorman.uk/integrating-net-and-salesforce-part-1-rest-api/          	

Using AWS Lambda Functions with Amazon Connect:
https://docs.aws.amazon.com/connect/latest/adminguide/connect-lambda-functions.html

Amazon Command Line Interface for Windows:
https://docs.aws.amazon.com/cli/latest/userguide/install-windows.html

AWS SDK for .NET
https://aws.amazon.com/sdk-for-net/
