/* 
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * OpenAPI spec version: 2020-07-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentOutbound;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing InvalidReturnItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InvalidReturnItemTests
    {
        // TODO uncomment below to declare an instance variable for InvalidReturnItem
        //private InvalidReturnItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvalidReturnItem
            //instance = new InvalidReturnItem();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvalidReturnItem
        /// </summary>
        [Test]
        public void InvalidReturnItemInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvalidReturnItem
            //Assert.IsInstanceOfType<InvalidReturnItem> (instance, "variable 'instance' is a InvalidReturnItem");
        }


        /// <summary>
        /// Test the property 'SellerReturnItemId'
        /// </summary>
        [Test]
        public void SellerReturnItemIdTest()
        {
            // TODO unit test for the property 'SellerReturnItemId'
        }
        /// <summary>
        /// Test the property 'SellerFulfillmentOrderItemId'
        /// </summary>
        [Test]
        public void SellerFulfillmentOrderItemIdTest()
        {
            // TODO unit test for the property 'SellerFulfillmentOrderItemId'
        }
        /// <summary>
        /// Test the property 'InvalidItemReason'
        /// </summary>
        [Test]
        public void InvalidItemReasonTest()
        {
            // TODO unit test for the property 'InvalidItemReason'
        }

    }

}
