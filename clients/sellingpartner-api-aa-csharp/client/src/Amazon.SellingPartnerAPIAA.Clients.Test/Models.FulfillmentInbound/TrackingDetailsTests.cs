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
    ///  Class for testing TrackingDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TrackingDetailsTests
    {
        // TODO uncomment below to declare an instance variable for TrackingDetails
        //private TrackingDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TrackingDetails
            //instance = new TrackingDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TrackingDetails
        /// </summary>
        [Test]
        public void TrackingDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TrackingDetails
            //Assert.IsInstanceOfType<TrackingDetails> (instance, "variable 'instance' is a TrackingDetails");
        }


        /// <summary>
        /// Test the property 'LtlTrackingDetail'
        /// </summary>
        [Test]
        public void LtlTrackingDetailTest()
        {
            // TODO unit test for the property 'LtlTrackingDetail'
        }
        /// <summary>
        /// Test the property 'SpdTrackingDetail'
        /// </summary>
        [Test]
        public void SpdTrackingDetailTest()
        {
            // TODO unit test for the property 'SpdTrackingDetail'
        }

    }

}
