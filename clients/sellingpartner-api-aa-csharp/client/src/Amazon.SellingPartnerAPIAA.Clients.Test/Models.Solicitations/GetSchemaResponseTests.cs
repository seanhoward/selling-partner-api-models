/* 
 * Selling Partner API for Solicitations
 *
 * With the Solicitations API you can build applications that send non-critical solicitations to buyers. You can get a list of solicitation types that are available for an order that you specify, then call an operation that sends a solicitation to the buyer for that order. Buyers cannot respond to solicitations sent by this API, and these solicitations do not appear in the Messaging section of Seller Central or in the recipient's Message Center. The Solicitations API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.Solicitations;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing GetSchemaResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetSchemaResponseTests
    {
        // TODO uncomment below to declare an instance variable for GetSchemaResponse
        //private GetSchemaResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetSchemaResponse
            //instance = new GetSchemaResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetSchemaResponse
        /// </summary>
        [Test]
        public void GetSchemaResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetSchemaResponse
            //Assert.IsInstanceOfType<GetSchemaResponse> (instance, "variable 'instance' is a GetSchemaResponse");
        }


        /// <summary>
        /// Test the property 'Links'
        /// </summary>
        [Test]
        public void LinksTest()
        {
            // TODO unit test for the property 'Links'
        }
        /// <summary>
        /// Test the property 'Payload'
        /// </summary>
        [Test]
        public void PayloadTest()
        {
            // TODO unit test for the property 'Payload'
        }
        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Test]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }

    }

}
