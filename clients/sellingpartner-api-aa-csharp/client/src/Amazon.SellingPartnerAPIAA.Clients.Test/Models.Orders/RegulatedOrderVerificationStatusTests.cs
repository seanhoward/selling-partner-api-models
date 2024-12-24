/* 
 * Orders v0
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
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
using Amazon.SellingPartnerAPIAA.Clients.Models.Orders;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing RegulatedOrderVerificationStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RegulatedOrderVerificationStatusTests
    {
        // TODO uncomment below to declare an instance variable for RegulatedOrderVerificationStatus
        //private RegulatedOrderVerificationStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RegulatedOrderVerificationStatus
            //instance = new RegulatedOrderVerificationStatus();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RegulatedOrderVerificationStatus
        /// </summary>
        [Test]
        public void RegulatedOrderVerificationStatusInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RegulatedOrderVerificationStatus
            //Assert.IsInstanceOfType<RegulatedOrderVerificationStatus> (instance, "variable 'instance' is a RegulatedOrderVerificationStatus");
        }


        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'RequiresMerchantAction'
        /// </summary>
        [Test]
        public void RequiresMerchantActionTest()
        {
            // TODO unit test for the property 'RequiresMerchantAction'
        }
        /// <summary>
        /// Test the property 'ValidRejectionReasons'
        /// </summary>
        [Test]
        public void ValidRejectionReasonsTest()
        {
            // TODO unit test for the property 'ValidRejectionReasons'
        }
        /// <summary>
        /// Test the property 'RejectionReason'
        /// </summary>
        [Test]
        public void RejectionReasonTest()
        {
            // TODO unit test for the property 'RejectionReason'
        }
        /// <summary>
        /// Test the property 'ReviewDate'
        /// </summary>
        [Test]
        public void ReviewDateTest()
        {
            // TODO unit test for the property 'ReviewDate'
        }
        /// <summary>
        /// Test the property 'ExternalReviewerId'
        /// </summary>
        [Test]
        public void ExternalReviewerIdTest()
        {
            // TODO unit test for the property 'ExternalReviewerId'
        }
        /// <summary>
        /// Test the property 'ValidVerificationDetails'
        /// </summary>
        [Test]
        public void ValidVerificationDetailsTest()
        {
            // TODO unit test for the property 'ValidVerificationDetails'
        }

    }

}
