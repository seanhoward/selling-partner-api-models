/* 
 * Listings Items v2021-08-01
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/listings-items-api-v2021-08-01-use-case-guide).
 *
 * OpenAPI spec version: 2021-08-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.ListingsItems;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing Pagination
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PaginationTests
    {
        // TODO uncomment below to declare an instance variable for Pagination
        //private Pagination instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Pagination
            //instance = new Pagination();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Pagination
        /// </summary>
        [Test]
        public void PaginationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Pagination
            //Assert.IsInstanceOfType<Pagination> (instance, "variable 'instance' is a Pagination");
        }


        /// <summary>
        /// Test the property 'NextToken'
        /// </summary>
        [Test]
        public void NextTokenTest()
        {
            // TODO unit test for the property 'NextToken'
        }
        /// <summary>
        /// Test the property 'PreviousToken'
        /// </summary>
        [Test]
        public void PreviousTokenTest()
        {
            // TODO unit test for the property 'PreviousToken'
        }

    }

}