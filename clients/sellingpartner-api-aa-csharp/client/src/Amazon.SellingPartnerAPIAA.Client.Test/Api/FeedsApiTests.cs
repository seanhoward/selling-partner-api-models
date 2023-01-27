/* 
 * Selling Partner API for Feeds
 *
 * The Selling Partner API for Feeds lets you upload data to Amazon on behalf of a selling partner.
 *
 * OpenAPI spec version: 2021-06-30
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

using Amazon.SellingPartnerAPIAA.Client.Client;
using Amazon.SellingPartnerAPIAA.Client.Api;
using Amazon.SellingPartnerAPIAA.Client.Model;

namespace Amazon.SellingPartnerAPIAA.Client.Test
{
    /// <summary>
    ///  Class for testing FeedsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FeedsApiTests
    {
        private FeedsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new FeedsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeedsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FeedsApi
            //Assert.IsInstanceOfType(typeof(FeedsApi), instance, "instance is a FeedsApi");
        }

        
        /// <summary>
        /// Test CancelFeed
        /// </summary>
        [Test]
        public void CancelFeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string feedId = null;
            //instance.CancelFeed(feedId);
            
        }
        
        /// <summary>
        /// Test CreateFeed
        /// </summary>
        [Test]
        public void CreateFeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFeedSpecification body = null;
            //var response = instance.CreateFeed(body);
            //Assert.IsInstanceOf<CreateFeedResponse> (response, "response is CreateFeedResponse");
        }
        
        /// <summary>
        /// Test CreateFeedDocument
        /// </summary>
        [Test]
        public void CreateFeedDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFeedDocumentSpecification body = null;
            //var response = instance.CreateFeedDocument(body);
            //Assert.IsInstanceOf<CreateFeedDocumentResponse> (response, "response is CreateFeedDocumentResponse");
        }
        
        /// <summary>
        /// Test GetFeed
        /// </summary>
        [Test]
        public void GetFeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string feedId = null;
            //var response = instance.GetFeed(feedId);
            //Assert.IsInstanceOf<Feed> (response, "response is Feed");
        }
        
        /// <summary>
        /// Test GetFeedDocument
        /// </summary>
        [Test]
        public void GetFeedDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string feedDocumentId = null;
            //var response = instance.GetFeedDocument(feedDocumentId);
            //Assert.IsInstanceOf<FeedDocument> (response, "response is FeedDocument");
        }
        
        /// <summary>
        /// Test GetFeeds
        /// </summary>
        [Test]
        public void GetFeedsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> feedTypes = null;
            //List<string> marketplaceIds = null;
            //int? pageSize = null;
            //List<string> processingStatuses = null;
            //DateTime? createdSince = null;
            //DateTime? createdUntil = null;
            //string nextToken = null;
            //var response = instance.GetFeeds(feedTypes, marketplaceIds, pageSize, processingStatuses, createdSince, createdUntil, nextToken);
            //Assert.IsInstanceOf<GetFeedsResponse> (response, "response is GetFeedsResponse");
        }
        
    }

}
