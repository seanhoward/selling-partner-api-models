/* 
 * Fulfillment Inbound v2024-03-20
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.FulfillmentInbound;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing TaxRate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TaxRateTests
    {
        // TODO uncomment below to declare an instance variable for TaxRate
        //private TaxRate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TaxRate
            //instance = new TaxRate();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaxRate
        /// </summary>
        [Test]
        public void TaxRateInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TaxRate
            //Assert.IsInstanceOfType<TaxRate> (instance, "variable 'instance' is a TaxRate");
        }


        /// <summary>
        /// Test the property 'CessRate'
        /// </summary>
        [Test]
        public void CessRateTest()
        {
            // TODO unit test for the property 'CessRate'
        }
        /// <summary>
        /// Test the property 'GstRate'
        /// </summary>
        [Test]
        public void GstRateTest()
        {
            // TODO unit test for the property 'GstRate'
        }
        /// <summary>
        /// Test the property 'TaxType'
        /// </summary>
        [Test]
        public void TaxTypeTest()
        {
            // TODO unit test for the property 'TaxType'
        }

    }

}