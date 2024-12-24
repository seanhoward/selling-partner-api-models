/* 
 * Selling Partner API for FBA Inbound Eligibilty
 *
 * With the FBA Inbound Eligibility API, you can build applications that let sellers get eligibility previews for items before shipping them to Amazon's fulfillment centers. With this API you can find out if an item is eligible for inbound shipment to Amazon's fulfillment centers in a specific marketplace. You can also find out if an item is eligible for using the manufacturer barcode for FBA inventory tracking. Sellers can use this information to inform their decisions about which items to ship Amazon's fulfillment centers.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.FbaInbound;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing ItemEligibilityPreview
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ItemEligibilityPreviewTests
    {
        // TODO uncomment below to declare an instance variable for ItemEligibilityPreview
        //private ItemEligibilityPreview instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ItemEligibilityPreview
            //instance = new ItemEligibilityPreview();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemEligibilityPreview
        /// </summary>
        [Test]
        public void ItemEligibilityPreviewInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ItemEligibilityPreview
            //Assert.IsInstanceOfType<ItemEligibilityPreview> (instance, "variable 'instance' is a ItemEligibilityPreview");
        }


        /// <summary>
        /// Test the property 'Asin'
        /// </summary>
        [Test]
        public void AsinTest()
        {
            // TODO unit test for the property 'Asin'
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
        /// Test the property 'Program'
        /// </summary>
        [Test]
        public void ProgramTest()
        {
            // TODO unit test for the property 'Program'
        }
        /// <summary>
        /// Test the property 'IsEligibleForProgram'
        /// </summary>
        [Test]
        public void IsEligibleForProgramTest()
        {
            // TODO unit test for the property 'IsEligibleForProgram'
        }
        /// <summary>
        /// Test the property 'IneligibilityReasonList'
        /// </summary>
        [Test]
        public void IneligibilityReasonListTest()
        {
            // TODO unit test for the property 'IneligibilityReasonList'
        }

    }

}
