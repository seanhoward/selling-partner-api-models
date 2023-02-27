/* 
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, see the [Notifications Use Case Guide](doc:notifications-api-v1-use-case-guide).
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
using Amazon.SellingPartnerAPIAA.Clients.Models.Notifications;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Notifications.Test
{
    /// <summary>
    ///  Class for testing DestinationResourceSpecification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DestinationResourceSpecificationTests
    {
        // TODO uncomment below to declare an instance variable for DestinationResourceSpecification
        //private DestinationResourceSpecification instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DestinationResourceSpecification
            //instance = new DestinationResourceSpecification();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DestinationResourceSpecification
        /// </summary>
        [Test]
        public void DestinationResourceSpecificationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DestinationResourceSpecification
            //Assert.IsInstanceOfType<DestinationResourceSpecification> (instance, "variable 'instance' is a DestinationResourceSpecification");
        }


        /// <summary>
        /// Test the property 'Sqs'
        /// </summary>
        [Test]
        public void SqsTest()
        {
            // TODO unit test for the property 'Sqs'
        }
        /// <summary>
        /// Test the property 'EventBridge'
        /// </summary>
        [Test]
        public void EventBridgeTest()
        {
            // TODO unit test for the property 'EventBridge'
        }

    }

}