/* 
 * Selling Partner API for Easy Ship
 *
 * The Selling Partner API for Easy Ship helps you build applications that help sellers manage and ship Amazon Easy Ship orders.  Your Easy Ship applications can:  * Get available time slots for packages to be scheduled for delivery.  * Schedule, reschedule, and cancel Easy Ship orders.  * Print labels, invoices, and warranties.  See the [Marketplace Support Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-table) for the differences in Easy Ship operations by marketplace.
 *
 * OpenAPI spec version: 2022-03-23
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.EasyShip;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing CreateScheduledPackagesRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CreateScheduledPackagesRequestTests
    {
        // TODO uncomment below to declare an instance variable for CreateScheduledPackagesRequest
        //private CreateScheduledPackagesRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreateScheduledPackagesRequest
            //instance = new CreateScheduledPackagesRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateScheduledPackagesRequest
        /// </summary>
        [Test]
        public void CreateScheduledPackagesRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateScheduledPackagesRequest
            //Assert.IsInstanceOfType<CreateScheduledPackagesRequest> (instance, "variable 'instance' is a CreateScheduledPackagesRequest");
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
        /// Test the property 'OrderScheduleDetailsList'
        /// </summary>
        [Test]
        public void OrderScheduleDetailsListTest()
        {
            // TODO unit test for the property 'OrderScheduleDetailsList'
        }
        /// <summary>
        /// Test the property 'LabelFormat'
        /// </summary>
        [Test]
        public void LabelFormatTest()
        {
            // TODO unit test for the property 'LabelFormat'
        }

    }

}
