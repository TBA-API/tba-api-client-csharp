/* 
 * The Blue Alliance API v3
 *
 * # Overview    Information and statistics about FIRST Robotics Competition teams and events.   # Authentication   All endpoints require an Auth Key to be passed in the header `X-TBA-Auth-Key`. If you do not have an auth key yet, you can obtain one from your [Account Page](/account).    A `User-Agent` header may need to be set to prevent a 403 Unauthorized error.
 *
 * The version of the OpenAPI document: 3.8.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TBAAPI.V3Client.Client;
using TBAAPI.V3Client.Api;
using TBAAPI.V3Client.Model;

namespace TBAAPI.V3Client.Test
{
    /// <summary>
    ///  Class for testing EventApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventApiTests
    {
        private EventApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EventApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' EventApi
            //Assert.IsInstanceOf(typeof(EventApi), instance);
        }

        
        /// <summary>
        /// Test GetDistrictEvents
        /// </summary>
        [Test]
        public void GetDistrictEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEvents(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Event>), response, "response is List<Event>");
        }
        
        /// <summary>
        /// Test GetDistrictEventsKeys
        /// </summary>
        [Test]
        public void GetDistrictEventsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEventsKeys(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetDistrictEventsSimple
        /// </summary>
        [Test]
        public void GetDistrictEventsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string districtKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetDistrictEventsSimple(districtKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<EventSimple>), response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetEvent
        /// </summary>
        [Test]
        public void GetEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEvent(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(Event), response, "response is Event");
        }
        
        /// <summary>
        /// Test GetEventAlliances
        /// </summary>
        [Test]
        public void GetEventAlliancesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventAlliances(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<EliminationAlliance>), response, "response is List<EliminationAlliance>");
        }
        
        /// <summary>
        /// Test GetEventAwards
        /// </summary>
        [Test]
        public void GetEventAwardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventAwards(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Award>), response, "response is List<Award>");
        }
        
        /// <summary>
        /// Test GetEventDistrictPoints
        /// </summary>
        [Test]
        public void GetEventDistrictPointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventDistrictPoints(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(EventDistrictPoints), response, "response is EventDistrictPoints");
        }
        
        /// <summary>
        /// Test GetEventInsights
        /// </summary>
        [Test]
        public void GetEventInsightsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventInsights(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(EventInsights), response, "response is EventInsights");
        }
        
        /// <summary>
        /// Test GetEventMatchTimeseries
        /// </summary>
        [Test]
        public void GetEventMatchTimeseriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventMatchTimeseries(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetEventMatches
        /// </summary>
        [Test]
        public void GetEventMatchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventMatches(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Match>), response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetEventMatchesKeys
        /// </summary>
        [Test]
        public void GetEventMatchesKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventMatchesKeys(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetEventMatchesSimple
        /// </summary>
        [Test]
        public void GetEventMatchesSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventMatchesSimple(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<MatchSimple>), response, "response is List<MatchSimple>");
        }
        
        /// <summary>
        /// Test GetEventOPRs
        /// </summary>
        [Test]
        public void GetEventOPRsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventOPRs(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(EventOPRs), response, "response is EventOPRs");
        }
        
        /// <summary>
        /// Test GetEventPredictions
        /// </summary>
        [Test]
        public void GetEventPredictionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventPredictions(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test GetEventRankings
        /// </summary>
        [Test]
        public void GetEventRankingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventRankings(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(EventRanking), response, "response is EventRanking");
        }
        
        /// <summary>
        /// Test GetEventSimple
        /// </summary>
        [Test]
        public void GetEventSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventSimple(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(EventSimple), response, "response is EventSimple");
        }
        
        /// <summary>
        /// Test GetEventTeams
        /// </summary>
        [Test]
        public void GetEventTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeams(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Team>), response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test GetEventTeamsKeys
        /// </summary>
        [Test]
        public void GetEventTeamsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsKeys(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetEventTeamsSimple
        /// </summary>
        [Test]
        public void GetEventTeamsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsSimple(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<TeamSimple>), response, "response is List<TeamSimple>");
        }
        
        /// <summary>
        /// Test GetEventTeamsStatuses
        /// </summary>
        [Test]
        public void GetEventTeamsStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventTeamsStatuses(eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(Dictionary<string, TeamEventStatus>), response, "response is Dictionary<string, TeamEventStatus>");
        }
        
        /// <summary>
        /// Test GetEventsByYear
        /// </summary>
        [Test]
        public void GetEventsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventsByYear(year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Event>), response, "response is List<Event>");
        }
        
        /// <summary>
        /// Test GetEventsByYearKeys
        /// </summary>
        [Test]
        public void GetEventsByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventsByYearKeys(year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetEventsByYearSimple
        /// </summary>
        [Test]
        public void GetEventsByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetEventsByYearSimple(year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<EventSimple>), response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetTeamEventAwards
        /// </summary>
        [Test]
        public void GetTeamEventAwardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventAwards(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Award>), response, "response is List<Award>");
        }
        
        /// <summary>
        /// Test GetTeamEventMatches
        /// </summary>
        [Test]
        public void GetTeamEventMatchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatches(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Match>), response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamEventMatchesKeys
        /// </summary>
        [Test]
        public void GetTeamEventMatchesKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatchesKeys(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventMatchesSimple
        /// </summary>
        [Test]
        public void GetTeamEventMatchesSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventMatchesSimple(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Match>), response, "response is List<Match>");
        }
        
        /// <summary>
        /// Test GetTeamEventStatus
        /// </summary>
        [Test]
        public void GetTeamEventStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string eventKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventStatus(teamKey, eventKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(TeamEventStatus), response, "response is TeamEventStatus");
        }
        
        /// <summary>
        /// Test GetTeamEvents
        /// </summary>
        [Test]
        public void GetTeamEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEvents(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Event>), response, "response is List<Event>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYear
        /// </summary>
        [Test]
        public void GetTeamEventsByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYear(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<Event>), response, "response is List<Event>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYearKeys
        /// </summary>
        [Test]
        public void GetTeamEventsByYearKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYearKeys(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventsByYearSimple
        /// </summary>
        [Test]
        public void GetTeamEventsByYearSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsByYearSimple(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<EventSimple>), response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetTeamEventsKeys
        /// </summary>
        [Test]
        public void GetTeamEventsKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsKeys(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<string>), response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetTeamEventsSimple
        /// </summary>
        [Test]
        public void GetTeamEventsSimpleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsSimple(teamKey, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(List<EventSimple>), response, "response is List<EventSimple>");
        }
        
        /// <summary>
        /// Test GetTeamEventsStatusesByYear
        /// </summary>
        [Test]
        public void GetTeamEventsStatusesByYearTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamKey = null;
            //int year = null;
            //string ifModifiedSince = null;
            //var response = instance.GetTeamEventsStatusesByYear(teamKey, year, ifModifiedSince);
            //Assert.IsInstanceOf(typeof(Dictionary<string, TeamEventStatus>), response, "response is Dictionary<string, TeamEventStatus>");
        }
        
    }

}
