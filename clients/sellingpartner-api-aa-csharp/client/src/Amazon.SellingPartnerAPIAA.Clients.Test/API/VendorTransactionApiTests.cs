/* 
 * Selling Partner API for Direct Fulfillment Transaction Status
 *
 * The Selling Partner API for Direct Fulfillment Transaction Status provides programmatic access to a direct fulfillment vendor's transaction status.
 *
 * OpenAPI spec version: 2021-12-28
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
using Amazon.SellingPartnerAPIAA.Clients.Models.VendorDirectFulfillmentTransactions;

namespace Amazon.SellingPartnerAPIAA.Clients.VendorDirectFulfillmentTransactions.Test
{
    /// <summary>
    ///  Class for testing VendorTransactionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VendorTransactionApiTests
    {
        private VendorTransactionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new VendorTransactionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VendorTransactionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VendorTransactionApi
            //Assert.IsInstanceOfType(typeof(VendorTransactionApi), instance, "instance is a VendorTransactionApi");
        }

        
        /// <summary>
        /// Test GetTransactionStatus
        /// </summary>
        [Test]
        public void GetTransactionStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string transactionId = null;
            //var response = instance.GetTransactionStatus(transactionId);
            //Assert.IsInstanceOf<TransactionStatus> (response, "response is TransactionStatus");
        }
        
    }

}