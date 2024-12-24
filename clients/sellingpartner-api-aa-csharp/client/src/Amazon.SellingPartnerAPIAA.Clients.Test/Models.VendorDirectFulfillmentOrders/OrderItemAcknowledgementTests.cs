/* 
 * Selling Partner API for Direct Fulfillment Orders
 *
 * The Selling Partner API for Direct Fulfillment Orders provides programmatic access to a direct fulfillment vendor's order data.
 *
 * OpenAPI spec version: 2021-12-28
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentOrders;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing OrderItemAcknowledgement
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OrderItemAcknowledgementTests
    {
        // TODO uncomment below to declare an instance variable for OrderItemAcknowledgement
        //private OrderItemAcknowledgement instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OrderItemAcknowledgement
            //instance = new OrderItemAcknowledgement();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderItemAcknowledgement
        /// </summary>
        [Test]
        public void OrderItemAcknowledgementInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OrderItemAcknowledgement
            //Assert.IsInstanceOfType<OrderItemAcknowledgement> (instance, "variable 'instance' is a OrderItemAcknowledgement");
        }


        /// <summary>
        /// Test the property 'ItemSequenceNumber'
        /// </summary>
        [Test]
        public void ItemSequenceNumberTest()
        {
            // TODO unit test for the property 'ItemSequenceNumber'
        }
        /// <summary>
        /// Test the property 'BuyerProductIdentifier'
        /// </summary>
        [Test]
        public void BuyerProductIdentifierTest()
        {
            // TODO unit test for the property 'BuyerProductIdentifier'
        }
        /// <summary>
        /// Test the property 'VendorProductIdentifier'
        /// </summary>
        [Test]
        public void VendorProductIdentifierTest()
        {
            // TODO unit test for the property 'VendorProductIdentifier'
        }
        /// <summary>
        /// Test the property 'AcknowledgedQuantity'
        /// </summary>
        [Test]
        public void AcknowledgedQuantityTest()
        {
            // TODO unit test for the property 'AcknowledgedQuantity'
        }

    }

}
