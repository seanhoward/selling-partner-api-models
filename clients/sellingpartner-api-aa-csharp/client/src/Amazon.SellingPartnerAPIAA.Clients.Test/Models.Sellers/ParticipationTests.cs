/* 
 * Selling Partner API for Sellers
 *
 * The [Selling Partner API for Sellers](https://developer-docs.amazon.com/sp-api/docs/sellers-api-v1-reference) (Sellers API) provides essential information about seller accounts, such as:  - The marketplaces a seller can list in - The default language and currency of a marketplace - Whether the seller has suspended listings  Refer to the [Sellers API reference](https://developer-docs.amazon.com/sp-api/docs/sellers-api-v1-reference) for details about this API's operations, data types, and schemas.
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
using Amazon.SellingPartnerAPIAA.Clients.Models.Sellers;
using Amazon.SellingPartnerAPIAA.Clients.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPIAA.Clients.Test
{
    /// <summary>
    ///  Class for testing Participation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ParticipationTests
    {
        // TODO uncomment below to declare an instance variable for Participation
        //private Participation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Participation
            //instance = new Participation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Participation
        /// </summary>
        [Test]
        public void ParticipationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Participation
            //Assert.IsInstanceOfType<Participation> (instance, "variable 'instance' is a Participation");
        }


        /// <summary>
        /// Test the property 'IsParticipating'
        /// </summary>
        [Test]
        public void IsParticipatingTest()
        {
            // TODO unit test for the property 'IsParticipating'
        }
        /// <summary>
        /// Test the property 'HasSuspendedListings'
        /// </summary>
        [Test]
        public void HasSuspendedListingsTest()
        {
            // TODO unit test for the property 'HasSuspendedListings'
        }

    }

}