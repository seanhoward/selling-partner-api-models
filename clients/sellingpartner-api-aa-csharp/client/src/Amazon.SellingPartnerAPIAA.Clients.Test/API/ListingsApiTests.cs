/* 
 * Selling Partner API for Listings Restrictions
 *
 * The Selling Partner API for Listings Restrictions provides programmatic access to restrictions on Amazon catalog listings.  For more information, see the [Listings Restrictions API Use Case Guide](doc:listings-restrictions-api-v2021-08-01-use-case-guide).
 *
 * OpenAPI spec version: 2021-08-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Amazon.SellingPartnerAPIAA.Clients.Client;
using Amazon.SellingPartnerAPIAA.Clients.API;
using Amazon.SellingPartnerAPIAA.Clients.Models.ListingsRestrictions;

namespace Amazon.SellingPartnerAPIAA.Clients.ListingsRestrictions.Test
{
    /// <summary>
    ///  Class for testing ListingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ListingsApiTests
    {
        private ListingsRestrictionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new ListingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ListingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ListingsApi
            //Assert.IsInstanceOfType(typeof(ListingsApi), instance, "instance is a ListingsApi");
        }

        
        /// <summary>
        /// Test GetListingsRestrictions
        /// </summary>
        [Test]
        public void GetListingsRestrictionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string asin = null;
            //string sellerId = null;
            //List<string> marketplaceIds = null;
            //string conditionType = null;
            //string reasonLocale = null;
            //var response = instance.GetListingsRestrictions(asin, sellerId, marketplaceIds, conditionType, reasonLocale);
            //Assert.IsInstanceOf<RestrictionList> (response, "response is RestrictionList");
        }
        
    }

}