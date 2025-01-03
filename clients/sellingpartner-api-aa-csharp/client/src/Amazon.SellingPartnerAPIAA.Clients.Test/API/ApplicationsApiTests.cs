/* 
 * Selling Partner API for Application Management
 *
 * The Selling Partner API for Application Management lets you programmatically update the client secret on registered applications.
 *
 * OpenAPI spec version: 2023-11-30
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
using Amazon.SellingPartnerAPIAA.Clients.Models.Application;

namespace Amazon.SellingPartnerAPIAA.Clients.Application.Test
{
    /// <summary>
    ///  Class for testing ApplicationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ApplicationsApiTests
    {
        private ApplicationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new ApplicationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApplicationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ApplicationsApi
            //Assert.IsInstanceOfType(typeof(ApplicationsApi), instance, "instance is a ApplicationsApi");
        }

        
        /// <summary>
        /// Test RotateApplicationClientSecret
        /// </summary>
        [Test]
        public void RotateApplicationClientSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.RotateApplicationClientSecret();
            
        }
        
    }

}