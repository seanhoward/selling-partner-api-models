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
    ///  Class for testing UpdatePackageDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UpdatePackageDetailsTests
    {
        // TODO uncomment below to declare an instance variable for UpdatePackageDetails
        //private UpdatePackageDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UpdatePackageDetails
            //instance = new UpdatePackageDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UpdatePackageDetails
        /// </summary>
        [Test]
        public void UpdatePackageDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdatePackageDetails
            //Assert.IsInstanceOfType<UpdatePackageDetails> (instance, "variable 'instance' is a UpdatePackageDetails");
        }


        /// <summary>
        /// Test the property 'ScheduledPackageId'
        /// </summary>
        [Test]
        public void ScheduledPackageIdTest()
        {
            // TODO unit test for the property 'ScheduledPackageId'
        }
        /// <summary>
        /// Test the property 'PackageTimeSlot'
        /// </summary>
        [Test]
        public void PackageTimeSlotTest()
        {
            // TODO unit test for the property 'PackageTimeSlot'
        }

    }

}