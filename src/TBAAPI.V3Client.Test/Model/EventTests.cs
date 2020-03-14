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
    ///  Class for testing Event
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EventTests
    {
        // TODO uncomment below to declare an instance variable for Event
        //private Event instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Event
            //instance = new Event();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Event
        /// </summary>
        [Test]
        public void EventInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Event
            //Assert.IsInstanceOf(typeof(Event), instance);
        }


        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'EventCode'
        /// </summary>
        [Test]
        public void EventCodeTest()
        {
            // TODO unit test for the property 'EventCode'
        }
        /// <summary>
        /// Test the property 'EventType'
        /// </summary>
        [Test]
        public void EventTypeTest()
        {
            // TODO unit test for the property 'EventType'
        }
        /// <summary>
        /// Test the property 'District'
        /// </summary>
        [Test]
        public void DistrictTest()
        {
            // TODO unit test for the property 'District'
        }
        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [Test]
        public void CityTest()
        {
            // TODO unit test for the property 'City'
        }
        /// <summary>
        /// Test the property 'StateProv'
        /// </summary>
        [Test]
        public void StateProvTest()
        {
            // TODO unit test for the property 'StateProv'
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Test]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'Year'
        /// </summary>
        [Test]
        public void YearTest()
        {
            // TODO unit test for the property 'Year'
        }
        /// <summary>
        /// Test the property 'ShortName'
        /// </summary>
        [Test]
        public void ShortNameTest()
        {
            // TODO unit test for the property 'ShortName'
        }
        /// <summary>
        /// Test the property 'EventTypeString'
        /// </summary>
        [Test]
        public void EventTypeStringTest()
        {
            // TODO unit test for the property 'EventTypeString'
        }
        /// <summary>
        /// Test the property 'Week'
        /// </summary>
        [Test]
        public void WeekTest()
        {
            // TODO unit test for the property 'Week'
        }
        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Test]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }
        /// <summary>
        /// Test the property 'GmapsPlaceId'
        /// </summary>
        [Test]
        public void GmapsPlaceIdTest()
        {
            // TODO unit test for the property 'GmapsPlaceId'
        }
        /// <summary>
        /// Test the property 'GmapsUrl'
        /// </summary>
        [Test]
        public void GmapsUrlTest()
        {
            // TODO unit test for the property 'GmapsUrl'
        }
        /// <summary>
        /// Test the property 'Lat'
        /// </summary>
        [Test]
        public void LatTest()
        {
            // TODO unit test for the property 'Lat'
        }
        /// <summary>
        /// Test the property 'Lng'
        /// </summary>
        [Test]
        public void LngTest()
        {
            // TODO unit test for the property 'Lng'
        }
        /// <summary>
        /// Test the property 'LocationName'
        /// </summary>
        [Test]
        public void LocationNameTest()
        {
            // TODO unit test for the property 'LocationName'
        }
        /// <summary>
        /// Test the property 'Timezone'
        /// </summary>
        [Test]
        public void TimezoneTest()
        {
            // TODO unit test for the property 'Timezone'
        }
        /// <summary>
        /// Test the property 'Website'
        /// </summary>
        [Test]
        public void WebsiteTest()
        {
            // TODO unit test for the property 'Website'
        }
        /// <summary>
        /// Test the property 'FirstEventId'
        /// </summary>
        [Test]
        public void FirstEventIdTest()
        {
            // TODO unit test for the property 'FirstEventId'
        }
        /// <summary>
        /// Test the property 'FirstEventCode'
        /// </summary>
        [Test]
        public void FirstEventCodeTest()
        {
            // TODO unit test for the property 'FirstEventCode'
        }
        /// <summary>
        /// Test the property 'Webcasts'
        /// </summary>
        [Test]
        public void WebcastsTest()
        {
            // TODO unit test for the property 'Webcasts'
        }
        /// <summary>
        /// Test the property 'DivisionKeys'
        /// </summary>
        [Test]
        public void DivisionKeysTest()
        {
            // TODO unit test for the property 'DivisionKeys'
        }
        /// <summary>
        /// Test the property 'ParentEventKey'
        /// </summary>
        [Test]
        public void ParentEventKeyTest()
        {
            // TODO unit test for the property 'ParentEventKey'
        }
        /// <summary>
        /// Test the property 'PlayoffType'
        /// </summary>
        [Test]
        public void PlayoffTypeTest()
        {
            // TODO unit test for the property 'PlayoffType'
        }
        /// <summary>
        /// Test the property 'PlayoffTypeString'
        /// </summary>
        [Test]
        public void PlayoffTypeStringTest()
        {
            // TODO unit test for the property 'PlayoffTypeString'
        }

    }

}
