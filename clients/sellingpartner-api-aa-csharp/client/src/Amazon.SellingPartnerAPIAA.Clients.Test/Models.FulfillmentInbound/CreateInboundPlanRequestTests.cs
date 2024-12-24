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
    ///  Class for testing CreateInboundPlanRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CreateInboundPlanRequestTests
    {
        // TODO uncomment below to declare an instance variable for CreateInboundPlanRequest
        //private CreateInboundPlanRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreateInboundPlanRequest
            //instance = new CreateInboundPlanRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateInboundPlanRequest
        /// </summary>
        [Test]
        public void CreateInboundPlanRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateInboundPlanRequest
            //Assert.IsInstanceOfType<CreateInboundPlanRequest> (instance, "variable 'instance' is a CreateInboundPlanRequest");
        }


        /// <summary>
        /// Test the property 'DestinationMarketplaces'
        /// </summary>
        [Test]
        public void DestinationMarketplacesTest()
        {
            // TODO unit test for the property 'DestinationMarketplaces'
        }
        /// <summary>
        /// Test the property 'Items'
        /// </summary>
        [Test]
        public void ItemsTest()
        {
            // TODO unit test for the property 'Items'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'SourceAddress'
        /// </summary>
        [Test]
        public void SourceAddressTest()
        {
            // TODO unit test for the property 'SourceAddress'
        }

    }

}