/* 
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.FbaInventory;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing ReservedQuantity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReservedQuantityTests
    {
        // TODO uncomment below to declare an instance variable for ReservedQuantity
        //private ReservedQuantity instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ReservedQuantity
            //instance = new ReservedQuantity();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReservedQuantity
        /// </summary>
        [Test]
        public void ReservedQuantityInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ReservedQuantity
            //Assert.IsInstanceOfType<ReservedQuantity> (instance, "variable 'instance' is a ReservedQuantity");
        }


        /// <summary>
        /// Test the property 'TotalReservedQuantity'
        /// </summary>
        [Test]
        public void TotalReservedQuantityTest()
        {
            // TODO unit test for the property 'TotalReservedQuantity'
        }
        /// <summary>
        /// Test the property 'PendingCustomerOrderQuantity'
        /// </summary>
        [Test]
        public void PendingCustomerOrderQuantityTest()
        {
            // TODO unit test for the property 'PendingCustomerOrderQuantity'
        }
        /// <summary>
        /// Test the property 'PendingTransshipmentQuantity'
        /// </summary>
        [Test]
        public void PendingTransshipmentQuantityTest()
        {
            // TODO unit test for the property 'PendingTransshipmentQuantity'
        }
        /// <summary>
        /// Test the property 'FcProcessingQuantity'
        /// </summary>
        [Test]
        public void FcProcessingQuantityTest()
        {
            // TODO unit test for the property 'FcProcessingQuantity'
        }

    }

}