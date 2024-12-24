/* 
 * Selling Partner API for Direct Fulfillment Payments
 *
 * The Selling Partner API for Direct Fulfillment Payments provides programmatic access to a direct fulfillment vendor's invoice data.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentPayments;

namespace Amazon.SellingPartnerAPIAA.Clients.VendorDirectFulfillmentPayments.Test
{
    /// <summary>
    ///  Class for testing VendorInvoiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VendorInvoiceApiTests
    {
        private VendorInvoiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new VendorInvoiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VendorInvoiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VendorInvoiceApi
            //Assert.IsInstanceOfType(typeof(VendorInvoiceApi), instance, "instance is a VendorInvoiceApi");
        }

        
        /// <summary>
        /// Test SubmitInvoice
        /// </summary>
        [Test]
        public void SubmitInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubmitInvoiceRequest body = null;
            //var response = instance.SubmitInvoice(body);
            //Assert.IsInstanceOf<SubmitInvoiceResponse> (response, "response is SubmitInvoiceResponse");
        }
        
    }

}