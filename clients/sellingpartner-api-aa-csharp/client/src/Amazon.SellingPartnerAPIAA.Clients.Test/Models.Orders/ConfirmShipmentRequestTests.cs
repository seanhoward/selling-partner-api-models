/* 
 * Orders v0
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.Orders;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Orders.Test
{
    /// <summary>
    ///  Class for testing ConfirmShipmentRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConfirmShipmentRequestTests
    {
        // TODO uncomment below to declare an instance variable for ConfirmShipmentRequest
        //private ConfirmShipmentRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ConfirmShipmentRequest
            //instance = new ConfirmShipmentRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConfirmShipmentRequest
        /// </summary>
        [Test]
        public void ConfirmShipmentRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ConfirmShipmentRequest
            //Assert.IsInstanceOfType<ConfirmShipmentRequest> (instance, "variable 'instance' is a ConfirmShipmentRequest");
        }


        /// <summary>
        /// Test the property 'PackageDetail'
        /// </summary>
        [Test]
        public void PackageDetailTest()
        {
            // TODO unit test for the property 'PackageDetail'
        }
        /// <summary>
        /// Test the property 'CodCollectionMethod'
        /// </summary>
        [Test]
        public void CodCollectionMethodTest()
        {
            // TODO unit test for the property 'CodCollectionMethod'
        }
        /// <summary>
        /// Test the property 'MarketplaceId'
        /// </summary>
        [Test]
        public void MarketplaceIdTest()
        {
            // TODO unit test for the property 'MarketplaceId'
        }

    }

}
