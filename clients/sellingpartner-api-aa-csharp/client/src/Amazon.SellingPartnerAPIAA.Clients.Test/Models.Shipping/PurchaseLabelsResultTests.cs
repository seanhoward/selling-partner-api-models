/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.   **Note:** If you are new to the Amazon Shipping API, refer to the latest version of <a href=\"https://developer-docs.amazon.com/amazon-shipping/docs/shipping-api-v2-reference\">Amazon Shipping API (v2)</a> on the <a href=\"https://developer-docs.amazon.com/amazon-shipping/\">Amazon Shipping Developer Documentation</a> site.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.Shipping;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing PurchaseLabelsResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PurchaseLabelsResultTests
    {
        // TODO uncomment below to declare an instance variable for PurchaseLabelsResult
        //private PurchaseLabelsResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PurchaseLabelsResult
            //instance = new PurchaseLabelsResult();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PurchaseLabelsResult
        /// </summary>
        [Test]
        public void PurchaseLabelsResultInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PurchaseLabelsResult
            //Assert.IsInstanceOfType<PurchaseLabelsResult> (instance, "variable 'instance' is a PurchaseLabelsResult");
        }


        /// <summary>
        /// Test the property 'ShipmentId'
        /// </summary>
        [Test]
        public void ShipmentIdTest()
        {
            // TODO unit test for the property 'ShipmentId'
        }
        /// <summary>
        /// Test the property 'ClientReferenceId'
        /// </summary>
        [Test]
        public void ClientReferenceIdTest()
        {
            // TODO unit test for the property 'ClientReferenceId'
        }
        /// <summary>
        /// Test the property 'AcceptedRate'
        /// </summary>
        [Test]
        public void AcceptedRateTest()
        {
            // TODO unit test for the property 'AcceptedRate'
        }
        /// <summary>
        /// Test the property 'LabelResults'
        /// </summary>
        [Test]
        public void LabelResultsTest()
        {
            // TODO unit test for the property 'LabelResults'
        }

    }

}