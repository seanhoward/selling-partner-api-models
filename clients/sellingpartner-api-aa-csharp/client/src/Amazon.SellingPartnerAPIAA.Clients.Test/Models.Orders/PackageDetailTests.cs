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

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing PackageDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PackageDetailTests
    {
        // TODO uncomment below to declare an instance variable for PackageDetail
        //private PackageDetail instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PackageDetail
            //instance = new PackageDetail();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PackageDetail
        /// </summary>
        [Test]
        public void PackageDetailInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PackageDetail
            //Assert.IsInstanceOfType<PackageDetail> (instance, "variable 'instance' is a PackageDetail");
        }


        /// <summary>
        /// Test the property 'PackageReferenceId'
        /// </summary>
        [Test]
        public void PackageReferenceIdTest()
        {
            // TODO unit test for the property 'PackageReferenceId'
        }
        /// <summary>
        /// Test the property 'CarrierCode'
        /// </summary>
        [Test]
        public void CarrierCodeTest()
        {
            // TODO unit test for the property 'CarrierCode'
        }
        /// <summary>
        /// Test the property 'CarrierName'
        /// </summary>
        [Test]
        public void CarrierNameTest()
        {
            // TODO unit test for the property 'CarrierName'
        }
        /// <summary>
        /// Test the property 'ShippingMethod'
        /// </summary>
        [Test]
        public void ShippingMethodTest()
        {
            // TODO unit test for the property 'ShippingMethod'
        }
        /// <summary>
        /// Test the property 'TrackingNumber'
        /// </summary>
        [Test]
        public void TrackingNumberTest()
        {
            // TODO unit test for the property 'TrackingNumber'
        }
        /// <summary>
        /// Test the property 'ShipDate'
        /// </summary>
        [Test]
        public void ShipDateTest()
        {
            // TODO unit test for the property 'ShipDate'
        }
        /// <summary>
        /// Test the property 'ShipFromSupplySourceId'
        /// </summary>
        [Test]
        public void ShipFromSupplySourceIdTest()
        {
            // TODO unit test for the property 'ShipFromSupplySourceId'
        }
        /// <summary>
        /// Test the property 'OrderItems'
        /// </summary>
        [Test]
        public void OrderItemsTest()
        {
            // TODO unit test for the property 'OrderItems'
        }

    }

}
