/* 
 * Selling Partner API for Direct Fulfillment Payments
 *
 * The Selling Partner API for Direct Fulfillment Payments provides programmatic access to a direct fulfillment vendor's invoice data.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentPayments;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing TaxDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TaxDetailTests
    {
        // TODO uncomment below to declare an instance variable for TaxDetail
        //private TaxDetail instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TaxDetail
            //instance = new TaxDetail();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaxDetail
        /// </summary>
        [Test]
        public void TaxDetailInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TaxDetail
            //Assert.IsInstanceOfType<TaxDetail> (instance, "variable 'instance' is a TaxDetail");
        }


        /// <summary>
        /// Test the property 'TaxType'
        /// </summary>
        [Test]
        public void TaxTypeTest()
        {
            // TODO unit test for the property 'TaxType'
        }
        /// <summary>
        /// Test the property 'TaxRate'
        /// </summary>
        [Test]
        public void TaxRateTest()
        {
            // TODO unit test for the property 'TaxRate'
        }
        /// <summary>
        /// Test the property 'TaxAmount'
        /// </summary>
        [Test]
        public void TaxAmountTest()
        {
            // TODO unit test for the property 'TaxAmount'
        }
        /// <summary>
        /// Test the property 'TaxableAmount'
        /// </summary>
        [Test]
        public void TaxableAmountTest()
        {
            // TODO unit test for the property 'TaxableAmount'
        }

    }

}
