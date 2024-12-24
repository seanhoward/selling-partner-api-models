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
    ///  Class for testing Package
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PackageTests
    {
        // TODO uncomment below to declare an instance variable for Package
        //private Package instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Package
            //instance = new Package();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Package
        /// </summary>
        [Test]
        public void PackageInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Package
            //Assert.IsInstanceOfType<Package> (instance, "variable 'instance' is a Package");
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
        /// Test the property 'PackageDimensions'
        /// </summary>
        [Test]
        public void PackageDimensionsTest()
        {
            // TODO unit test for the property 'PackageDimensions'
        }
        /// <summary>
        /// Test the property 'PackageWeight'
        /// </summary>
        [Test]
        public void PackageWeightTest()
        {
            // TODO unit test for the property 'PackageWeight'
        }
        /// <summary>
        /// Test the property 'PackageItems'
        /// </summary>
        [Test]
        public void PackageItemsTest()
        {
            // TODO unit test for the property 'PackageItems'
        }
        /// <summary>
        /// Test the property 'PackageTimeSlot'
        /// </summary>
        [Test]
        public void PackageTimeSlotTest()
        {
            // TODO unit test for the property 'PackageTimeSlot'
        }
        /// <summary>
        /// Test the property 'PackageIdentifier'
        /// </summary>
        [Test]
        public void PackageIdentifierTest()
        {
            // TODO unit test for the property 'PackageIdentifier'
        }
        /// <summary>
        /// Test the property 'Invoice'
        /// </summary>
        [Test]
        public void InvoiceTest()
        {
            // TODO unit test for the property 'Invoice'
        }
        /// <summary>
        /// Test the property 'PackageStatus'
        /// </summary>
        [Test]
        public void PackageStatusTest()
        {
            // TODO unit test for the property 'PackageStatus'
        }
        /// <summary>
        /// Test the property 'TrackingDetails'
        /// </summary>
        [Test]
        public void TrackingDetailsTest()
        {
            // TODO unit test for the property 'TrackingDetails'
        }

    }

}
