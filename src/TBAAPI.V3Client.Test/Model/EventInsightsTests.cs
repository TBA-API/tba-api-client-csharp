/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TBAAPI.V3Client.Api;
using TBAAPI.V3Client.Model;
using TBAAPI.V3Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TBAAPI.V3Client.Test
{
    /// <summary>
    ///  Class for testing EventInsights
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EventInsightsTests
    {
        // TODO uncomment below to declare an instance variable for EventInsights
        //private EventInsights instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EventInsights
            //instance = new EventInsights();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventInsights
        /// </summary>
        [Test]
        public void EventInsightsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" EventInsights
            //Assert.IsInstanceOf(typeof(EventInsights), instance);
        }


        /// <summary>
        /// Test the property 'Qual'
        /// </summary>
        [Test]
        public void QualTest()
        {
            // TODO unit test for the property 'Qual'
        }
        /// <summary>
        /// Test the property 'Playoff'
        /// </summary>
        [Test]
        public void PlayoffTest()
        {
            // TODO unit test for the property 'Playoff'
        }

    }

}
