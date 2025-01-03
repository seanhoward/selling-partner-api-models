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
    ///  Class for testing GetMessagingActionsForOrderResponseLinks
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetMessagingActionsForOrderResponseLinksTests
    {
        // TODO uncomment below to declare an instance variable for GetMessagingActionsForOrderResponseLinks
        //private GetMessagingActionsForOrderResponseLinks instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetMessagingActionsForOrderResponseLinks
            //instance = new GetMessagingActionsForOrderResponseLinks();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetMessagingActionsForOrderResponseLinks
        /// </summary>
        [Test]
        public void GetMessagingActionsForOrderResponseLinksInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetMessagingActionsForOrderResponseLinks
            //Assert.IsInstanceOfType<GetMessagingActionsForOrderResponseLinks> (instance, "variable 'instance' is a GetMessagingActionsForOrderResponseLinks");
        }


        /// <summary>
        /// Test the property 'Self'
        /// </summary>
        [Test]
        public void SelfTest()
        {
            // TODO unit test for the property 'Self'
        }
        /// <summary>
        /// Test the property 'Actions'
        /// </summary>
        [Test]
        public void ActionsTest()
        {
            // TODO unit test for the property 'Actions'
        }

    }

}
