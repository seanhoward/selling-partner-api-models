/* 
 * Selling Partner API for Replenishment
 *
 * The Selling Partner API for Replenishment (Replenishment API) provides programmatic access to replenishment program metrics and offers. These programs provide recurring delivery of any replenishable item at a frequency chosen by the customer.  The Replenishment API is available worldwide wherever Amazon Subscribe & Save is available or is supported. The API is available to vendors and FBA selling partners.
 *
 * OpenAPI spec version: 2022-11-07
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.Replenishment;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing Promotion
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PromotionTests
    {
        // TODO uncomment below to declare an instance variable for Promotion
        //private Promotion instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Promotion
            //instance = new Promotion();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Promotion
        /// </summary>
        [Test]
        public void PromotionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Promotion
            //Assert.IsInstanceOfType<Promotion> (instance, "variable 'instance' is a Promotion");
        }


        /// <summary>
        /// Test the property 'SellingPartnerFundedBaseDiscount'
        /// </summary>
        [Test]
        public void SellingPartnerFundedBaseDiscountTest()
        {
            // TODO unit test for the property 'SellingPartnerFundedBaseDiscount'
        }
        /// <summary>
        /// Test the property 'SellingPartnerFundedTieredDiscount'
        /// </summary>
        [Test]
        public void SellingPartnerFundedTieredDiscountTest()
        {
            // TODO unit test for the property 'SellingPartnerFundedTieredDiscount'
        }
        /// <summary>
        /// Test the property 'AmazonFundedBaseDiscount'
        /// </summary>
        [Test]
        public void AmazonFundedBaseDiscountTest()
        {
            // TODO unit test for the property 'AmazonFundedBaseDiscount'
        }
        /// <summary>
        /// Test the property 'AmazonFundedTieredDiscount'
        /// </summary>
        [Test]
        public void AmazonFundedTieredDiscountTest()
        {
            // TODO unit test for the property 'AmazonFundedTieredDiscount'
        }

    }

}
