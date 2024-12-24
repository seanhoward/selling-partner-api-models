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
    ///  Class for testing AddressExtendedFields
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AddressExtendedFieldsTests
    {
        // TODO uncomment below to declare an instance variable for AddressExtendedFields
        //private AddressExtendedFields instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AddressExtendedFields
            //instance = new AddressExtendedFields();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddressExtendedFields
        /// </summary>
        [Test]
        public void AddressExtendedFieldsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AddressExtendedFields
            //Assert.IsInstanceOfType<AddressExtendedFields> (instance, "variable 'instance' is a AddressExtendedFields");
        }


        /// <summary>
        /// Test the property 'StreetName'
        /// </summary>
        [Test]
        public void StreetNameTest()
        {
            // TODO unit test for the property 'StreetName'
        }
        /// <summary>
        /// Test the property 'StreetNumber'
        /// </summary>
        [Test]
        public void StreetNumberTest()
        {
            // TODO unit test for the property 'StreetNumber'
        }
        /// <summary>
        /// Test the property 'Complement'
        /// </summary>
        [Test]
        public void ComplementTest()
        {
            // TODO unit test for the property 'Complement'
        }
        /// <summary>
        /// Test the property 'Neighborhood'
        /// </summary>
        [Test]
        public void NeighborhoodTest()
        {
            // TODO unit test for the property 'Neighborhood'
        }

    }

}
