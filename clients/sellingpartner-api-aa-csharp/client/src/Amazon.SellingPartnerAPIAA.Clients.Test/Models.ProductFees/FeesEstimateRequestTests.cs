/* 
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.ProductFees;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing FeesEstimateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FeesEstimateRequestTests
    {
        // TODO uncomment below to declare an instance variable for FeesEstimateRequest
        //private FeesEstimateRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FeesEstimateRequest
            //instance = new FeesEstimateRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeesEstimateRequest
        /// </summary>
        [Test]
        public void FeesEstimateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FeesEstimateRequest
            //Assert.IsInstanceOfType<FeesEstimateRequest> (instance, "variable 'instance' is a FeesEstimateRequest");
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
        /// Test the property 'IsAmazonFulfilled'
        /// </summary>
        [Test]
        public void IsAmazonFulfilledTest()
        {
            // TODO unit test for the property 'IsAmazonFulfilled'
        }
        /// <summary>
        /// Test the property 'PriceToEstimateFees'
        /// </summary>
        [Test]
        public void PriceToEstimateFeesTest()
        {
            // TODO unit test for the property 'PriceToEstimateFees'
        }
        /// <summary>
        /// Test the property 'Identifier'
        /// </summary>
        [Test]
        public void IdentifierTest()
        {
            // TODO unit test for the property 'Identifier'
        }
        /// <summary>
        /// Test the property 'OptionalFulfillmentProgram'
        /// </summary>
        [Test]
        public void OptionalFulfillmentProgramTest()
        {
            // TODO unit test for the property 'OptionalFulfillmentProgram'
        }

    }

}