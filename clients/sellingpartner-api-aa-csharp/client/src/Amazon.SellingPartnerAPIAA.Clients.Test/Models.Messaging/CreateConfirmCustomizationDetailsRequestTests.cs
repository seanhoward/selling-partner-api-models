/* 
 * Selling Partner API for Messaging
 *
 * With the Messaging API you can build applications that send messages to buyers. You can get a list of message types that are available for an order that you specify, then call an operation that sends a message to the buyer for that order. The Messaging API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing CreateConfirmCustomizationDetailsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CreateConfirmCustomizationDetailsRequestTests
    {
        // TODO uncomment below to declare an instance variable for CreateConfirmCustomizationDetailsRequest
        //private CreateConfirmCustomizationDetailsRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreateConfirmCustomizationDetailsRequest
            //instance = new CreateConfirmCustomizationDetailsRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateConfirmCustomizationDetailsRequest
        /// </summary>
        [Test]
        public void CreateConfirmCustomizationDetailsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateConfirmCustomizationDetailsRequest
            //Assert.IsInstanceOfType<CreateConfirmCustomizationDetailsRequest> (instance, "variable 'instance' is a CreateConfirmCustomizationDetailsRequest");
        }


        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Test]
        public void TextTest()
        {
            // TODO unit test for the property 'Text'
        }
        /// <summary>
        /// Test the property 'Attachments'
        /// </summary>
        [Test]
        public void AttachmentsTest()
        {
            // TODO unit test for the property 'Attachments'
        }

    }

}
