/* 
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.FbaInventory;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing CreateInventoryItemRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CreateInventoryItemRequestTests
    {
        // TODO uncomment below to declare an instance variable for CreateInventoryItemRequest
        //private CreateInventoryItemRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreateInventoryItemRequest
            //instance = new CreateInventoryItemRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateInventoryItemRequest
        /// </summary>
        [Test]
        public void CreateInventoryItemRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateInventoryItemRequest
            //Assert.IsInstanceOfType<CreateInventoryItemRequest> (instance, "variable 'instance' is a CreateInventoryItemRequest");
        }


        /// <summary>
        /// Test the property 'SellerSku'
        /// </summary>
        [Test]
        public void SellerSkuTest()
        {
            // TODO unit test for the property 'SellerSku'
        }
        /// <summary>
        /// Test the property 'MarketplaceId'
        /// </summary>
        [Test]
        public void MarketplaceIdTest()
        {
            // TODO unit test for the property 'MarketplaceId'
        }
        /// <summary>
        /// Test the property 'ProductName'
        /// </summary>
        [Test]
        public void ProductNameTest()
        {
            // TODO unit test for the property 'ProductName'
        }

    }

}
