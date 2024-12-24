/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * With the Selling Partner API for Merchant Fulfillment, you can build applications that sellers can use to purchase shipping for non-Prime and Prime orders using Amazon's Buy Shipping Services.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.MerchantFulfillment;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing GetEligibleShipmentServicesResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetEligibleShipmentServicesResultTests
    {
        // TODO uncomment below to declare an instance variable for GetEligibleShipmentServicesResult
        //private GetEligibleShipmentServicesResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetEligibleShipmentServicesResult
            //instance = new GetEligibleShipmentServicesResult();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetEligibleShipmentServicesResult
        /// </summary>
        [Test]
        public void GetEligibleShipmentServicesResultInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetEligibleShipmentServicesResult
            //Assert.IsInstanceOfType<GetEligibleShipmentServicesResult> (instance, "variable 'instance' is a GetEligibleShipmentServicesResult");
        }


        /// <summary>
        /// Test the property 'ShippingServiceList'
        /// </summary>
        [Test]
        public void ShippingServiceListTest()
        {
            // TODO unit test for the property 'ShippingServiceList'
        }
        /// <summary>
        /// Test the property 'RejectedShippingServiceList'
        /// </summary>
        [Test]
        public void RejectedShippingServiceListTest()
        {
            // TODO unit test for the property 'RejectedShippingServiceList'
        }
        /// <summary>
        /// Test the property 'TemporarilyUnavailableCarrierList'
        /// </summary>
        [Test]
        public void TemporarilyUnavailableCarrierListTest()
        {
            // TODO unit test for the property 'TemporarilyUnavailableCarrierList'
        }
        /// <summary>
        /// Test the property 'TermsAndConditionsNotAcceptedCarrierList'
        /// </summary>
        [Test]
        public void TermsAndConditionsNotAcceptedCarrierListTest()
        {
            // TODO unit test for the property 'TermsAndConditionsNotAcceptedCarrierList'
        }

    }

}
