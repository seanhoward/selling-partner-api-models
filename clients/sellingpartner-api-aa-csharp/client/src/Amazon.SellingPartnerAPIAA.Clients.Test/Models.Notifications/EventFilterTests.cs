/* 
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, refer to the [Notifications Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/notifications-api-v1-use-case-guide).
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
    ///  Class for testing EventFilter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EventFilterTests
    {
        // TODO uncomment below to declare an instance variable for EventFilter
        //private EventFilter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EventFilter
            //instance = new EventFilter();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventFilter
        /// </summary>
        [Test]
        public void EventFilterInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EventFilter
            //Assert.IsInstanceOfType<EventFilter> (instance, "variable 'instance' is a EventFilter");
        }


        /// <summary>
        /// Test the property 'MarketplaceIds'
        /// </summary>
        [Test]
        public void MarketplaceIdsTest()
        {
            // TODO unit test for the property 'MarketplaceIds'
        }
        /// <summary>
        /// Test the property 'OrderChangeTypes'
        /// </summary>
        [Test]
        public void OrderChangeTypesTest()
        {
            // TODO unit test for the property 'OrderChangeTypes'
        }
        /// <summary>
        /// Test the property 'EventFilterType'
        /// </summary>
        [Test]
        public void EventFilterTypeTest()
        {
            // TODO unit test for the property 'EventFilterType'
        }

    }

}
