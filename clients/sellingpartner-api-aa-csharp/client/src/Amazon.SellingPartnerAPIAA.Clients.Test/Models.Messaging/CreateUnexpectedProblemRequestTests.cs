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
    ///  Class for testing CreateUnexpectedProblemRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CreateUnexpectedProblemRequestTests
    {
        // TODO uncomment below to declare an instance variable for CreateUnexpectedProblemRequest
        //private CreateUnexpectedProblemRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreateUnexpectedProblemRequest
            //instance = new CreateUnexpectedProblemRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateUnexpectedProblemRequest
        /// </summary>
        [Test]
        public void CreateUnexpectedProblemRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateUnexpectedProblemRequest
            //Assert.IsInstanceOfType<CreateUnexpectedProblemRequest> (instance, "variable 'instance' is a CreateUnexpectedProblemRequest");
        }


        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Test]
        public void TextTest()
        {
            // TODO unit test for the property 'Text'
        }

    }

}