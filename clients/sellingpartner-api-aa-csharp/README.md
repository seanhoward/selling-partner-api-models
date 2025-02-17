# Selling Partner API Authentication/Authorization Library
This is a fork of the Amazon SP-API SDK. I have replaced the RateLimiter library because the original simply does not work. 
There are other changes as well. See the source code at selling-partner-api-models. 
If you would like additional SP-API models added to the library, please contact me directly.

## LWAAuthorizationSigner
Obtains and signs a request with an access token from LWA (Login with Amazon) for the specified endpoint using the provided LWA credentials.

*Example*
```
using RestSharp;
using Amazon.SellingPartnerAPIAA;

string resource = "/my/api/path";
RestClient restClient = new RestClient("https://...");
IRestRequest restRequest = new RestRequest(resource, Method.GET);

// Seller APIs
LWAAuthorizationCredentials lwaAuthorizationCredentials = new LWAAuthorizationCredentials
{
    ClientId = "...",
    ClientSecret = "",
    RefreshToken = "",
    Endpoint = new Uri("...")
};

/* Sellerless APIs
The Selling Partner API scopes can be retrieved from the ScopeConstants class and used to specify a list of scopes of an LWAAuthorizationCredentials instance. */
LWAAuthorizationCredentials lwaAuthorizationCredentials = new LWAAuthorizationCredentials
{
    ClientId = "...",
    ClientSecret = "",
    Scopes = new List<string>() { ScopeConstants.ScopeNotificationsAPI, ScopeConstants.ScopeMigrationAPI }
    Endpoint = new Uri("...")
};

restRequest = new LWAAuthorizationSigner(lwaAuthorizationCredentials).Sign(restRequest);  
```
Note the IRestRequest reference is treated as **mutable** when signed.

## RateLimitConfiguration
Interface to set and get rateLimit configurations that are used with RateLimiter. RateLimiter is used on client side to restrict the rate at which requests are made. RateLimiter Configuration takes Permit, rate which requests are made and TimeOut 

*Example*
```
RateLimitConfiguration rateLimitConfig = new RateLimitConfigurationOnRequests
            {
                RateLimitPermit = ..,
                WaitTimeOutInMilliSeconds = ...
            }; 

```

## Exception 
This package returns a custom LWAException when there is an error returned during LWA authorization. LWAException provides additional details like errorCode and errorDescription to help fix the issue.
 
*Example*
```
catch (LWAException e)
            {
                Console.WriteLine("LWA Exception when calling Selling partner API");
                Console.WriteLine(e.getErrorCode());
                Console.WriteLine(e.getErrorMessage());
                Console.WriteLine(e.Message);
            }
```

## Version
Selling Partner API Authentication/Authorization Library version 2.0.

## Resources
This package features Mustache templates designed for use with [swagger codegen](https://swagger.io/tools/swagger-codegen/). 
When you build Selling Partner API Swagger models with these templates, they help generate a rich SDK with functionality to invoke Selling Partner APIs built in. The templates are located in *resources/swagger-codegen*.
 
## Building
This package is built as a .NET Standard Library via a Visual Studio Solution with implementation and test projects.  The Visual Studio Community Edition can be obtained for free from Microsoft and used to build the solution and generate a .dll assembly which can be imported into other projects.

## Dependencies
All dependencies can be installed via NuGet
- RestSharp - 106.12.0 
- Newtonsoft.Json 13.0.3
- NETStandard.Library 2.0.3 (platform-specific implementation requirements are documented on the [Microsoft .NET Guide](https://docs.microsoft.com/en-us/dotnet/standard/net-standard))

## License
Swagger Codegen templates are subject to the [Swagger Codegen License](https://github.com/swagger-api/swagger-codegen#license).

All other work licensed as follows:

Copyright 2020 Amazon.com, Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this library except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.