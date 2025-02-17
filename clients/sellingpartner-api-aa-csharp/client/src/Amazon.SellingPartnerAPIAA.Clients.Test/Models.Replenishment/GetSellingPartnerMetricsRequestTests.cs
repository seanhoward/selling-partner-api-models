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
    ///  Class for testing GetSellingPartnerMetricsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetSellingPartnerMetricsRequestTests
    {
        // TODO uncomment below to declare an instance variable for GetSellingPartnerMetricsRequest
        //private GetSellingPartnerMetricsRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetSellingPartnerMetricsRequest
            //instance = new GetSellingPartnerMetricsRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetSellingPartnerMetricsRequest
        /// </summary>
        [Test]
        public void GetSellingPartnerMetricsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetSellingPartnerMetricsRequest
            //Assert.IsInstanceOfType<GetSellingPartnerMetricsRequest> (instance, "variable 'instance' is a GetSellingPartnerMetricsRequest");
        }


        /// <summary>
        /// Test the property 'AggregationFrequency'
        /// </summary>
        [Test]
        public void AggregationFrequencyTest()
        {
            // TODO unit test for the property 'AggregationFrequency'
        }
        /// <summary>
        /// Test the property 'TimeInterval'
        /// </summary>
        [Test]
        public void TimeIntervalTest()
        {
            // TODO unit test for the property 'TimeInterval'
        }
        /// <summary>
        /// Test the property 'Metrics'
        /// </summary>
        [Test]
        public void MetricsTest()
        {
            // TODO unit test for the property 'Metrics'
        }
        /// <summary>
        /// Test the property 'TimePeriodType'
        /// </summary>
        [Test]
        public void TimePeriodTypeTest()
        {
            // TODO unit test for the property 'TimePeriodType'
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
        /// Test the property 'ProgramTypes'
        /// </summary>
        [Test]
        public void ProgramTypesTest()
        {
            // TODO unit test for the property 'ProgramTypes'
        }

    }

}
