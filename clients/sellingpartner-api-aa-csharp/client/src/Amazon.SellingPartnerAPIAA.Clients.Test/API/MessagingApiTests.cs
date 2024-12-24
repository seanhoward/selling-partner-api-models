/* 
 * Selling Partner API for Messaging
 *
 * With the Messaging API you can build applications that send messages to buyers. You can get a list of message types that are available for an order that you specify, then call an operation that sends a message to the buyer for that order. The Messaging API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
 *
 * OpenAPI spec version: v1
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
using Amazon.SellingPartnerAPIAA.Clients.Models.Messaging;

namespace Amazon.SellingPartnerAPIAA.Clients.Messaging.Test
{
    /// <summary>
    ///  Class for testing MessagingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MessagingApiTests
    {
        private MessagingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new MessagingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MessagingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MessagingApi
            //Assert.IsInstanceOfType(typeof(MessagingApi), instance, "instance is a MessagingApi");
        }

        
        /// <summary>
        /// Test ConfirmCustomizationDetails
        /// </summary>
        [Test]
        public void ConfirmCustomizationDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateConfirmCustomizationDetailsRequest body = null;
            //var response = instance.ConfirmCustomizationDetails(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateConfirmCustomizationDetailsResponse> (response, "response is CreateConfirmCustomizationDetailsResponse");
        }
        
        /// <summary>
        /// Test CreateAmazonMotors
        /// </summary>
        [Test]
        public void CreateAmazonMotorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateAmazonMotorsRequest body = null;
            //var response = instance.CreateAmazonMotors(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateAmazonMotorsResponse> (response, "response is CreateAmazonMotorsResponse");
        }
        
        /// <summary>
        /// Test CreateConfirmDeliveryDetails
        /// </summary>
        [Test]
        public void CreateConfirmDeliveryDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateConfirmDeliveryDetailsRequest body = null;
            //var response = instance.CreateConfirmDeliveryDetails(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateConfirmDeliveryDetailsResponse> (response, "response is CreateConfirmDeliveryDetailsResponse");
        }
        
        /// <summary>
        /// Test CreateConfirmOrderDetails
        /// </summary>
        [Test]
        public void CreateConfirmOrderDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateConfirmOrderDetailsRequest body = null;
            //var response = instance.CreateConfirmOrderDetails(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateConfirmOrderDetailsResponse> (response, "response is CreateConfirmOrderDetailsResponse");
        }
        
        /// <summary>
        /// Test CreateConfirmServiceDetails
        /// </summary>
        [Test]
        public void CreateConfirmServiceDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateConfirmServiceDetailsRequest body = null;
            //var response = instance.CreateConfirmServiceDetails(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateConfirmServiceDetailsResponse> (response, "response is CreateConfirmServiceDetailsResponse");
        }
        
        /// <summary>
        /// Test CreateDigitalAccessKey
        /// </summary>
        [Test]
        public void CreateDigitalAccessKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateDigitalAccessKeyRequest body = null;
            //var response = instance.CreateDigitalAccessKey(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateDigitalAccessKeyResponse> (response, "response is CreateDigitalAccessKeyResponse");
        }
        
        /// <summary>
        /// Test CreateLegalDisclosure
        /// </summary>
        [Test]
        public void CreateLegalDisclosureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateLegalDisclosureRequest body = null;
            //var response = instance.CreateLegalDisclosure(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateLegalDisclosureResponse> (response, "response is CreateLegalDisclosureResponse");
        }
        
        /// <summary>
        /// Test CreateNegativeFeedbackRemoval
        /// </summary>
        [Test]
        public void CreateNegativeFeedbackRemovalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //var response = instance.CreateNegativeFeedbackRemoval(amazonOrderId, marketplaceIds);
            //Assert.IsInstanceOf<CreateNegativeFeedbackRemovalResponse> (response, "response is CreateNegativeFeedbackRemovalResponse");
        }
        
        /// <summary>
        /// Test CreateUnexpectedProblem
        /// </summary>
        [Test]
        public void CreateUnexpectedProblemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateUnexpectedProblemRequest body = null;
            //var response = instance.CreateUnexpectedProblem(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateUnexpectedProblemResponse> (response, "response is CreateUnexpectedProblemResponse");
        }
        
        /// <summary>
        /// Test CreateWarranty
        /// </summary>
        [Test]
        public void CreateWarrantyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //CreateWarrantyRequest body = null;
            //var response = instance.CreateWarranty(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<CreateWarrantyResponse> (response, "response is CreateWarrantyResponse");
        }
        
        /// <summary>
        /// Test GetAttributes
        /// </summary>
        [Test]
        public void GetAttributesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //var response = instance.GetAttributes(amazonOrderId, marketplaceIds);
            //Assert.IsInstanceOf<GetAttributesResponse> (response, "response is GetAttributesResponse");
        }
        
        /// <summary>
        /// Test GetMessagingActionsForOrder
        /// </summary>
        [Test]
        public void GetMessagingActionsForOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //var response = instance.GetMessagingActionsForOrder(amazonOrderId, marketplaceIds);
            //Assert.IsInstanceOf<GetMessagingActionsForOrderResponse> (response, "response is GetMessagingActionsForOrderResponse");
        }
        
        /// <summary>
        /// Test SendInvoice
        /// </summary>
        [Test]
        public void SendInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string amazonOrderId = null;
            //List<string> marketplaceIds = null;
            //InvoiceRequest body = null;
            //var response = instance.SendInvoice(amazonOrderId, marketplaceIds, body);
            //Assert.IsInstanceOf<InvoiceResponse> (response, "response is InvoiceResponse");
        }
        
    }

}