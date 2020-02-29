﻿using System;
using DojoTemplateConsoleApp.MonitoringStation;
using DojoTemplateConsoleApp.SpaceImage;
using DojoTemplateConsoleApp.UniveralOrbit;
using DojoTemplateConsoleApp.CrossedWires;

namespace DojoTemplateConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SpaceImage
            //var inputParser = new InputParser();
            //var spaceImageFormat = new SpaceImageFormat();

            //inputParser.ParseSpaceImageArray(spaceImageFormat);
            //spaceImageFormat.IsolateLayersList(25, 6);
            //var layerWithFewestZeros = spaceImageFormat.FindLayerWithFewestInstancesOfDigit('0');
            //var numberOfOnes = spaceImageFormat.CountInstancesOfDigit(layerWithFewestZeros, '1');
            //var numberOfTwos = spaceImageFormat.CountInstancesOfDigit(layerWithFewestZeros, '2');

            //Console.WriteLine($"Layer {layerWithFewestZeros.LayerID} has the fewest zeros.");
            //Console.WriteLine($"Layer {layerWithFewestZeros.LayerID} has {numberOfOnes} instances of '1' and {numberOfTwos} instances of '2'.");
            //Console.WriteLine($"The final result is {numberOfOnes * numberOfTwos}");

            #endregion

            #region SecureContainer

            //var secureContainer = new SecureContainer();
            //var result = secureContainer.FindNumberOfMatches(156218, 652527);
            //Console.WriteLine($"The number of eligible passwords is {result}.");

            #endregion

            #region UniversalOrbit

            var galaxy = new Galaxy();
            galaxy.LoadInput();
            galaxy.LoadSpaceBodies();
            var COM = galaxy.FindBody("COM");
            var YOU = galaxy.FindBody("YOU");
            var SAN = galaxy.FindBody("SAN");
            var resultDayOne = galaxy.CalculateTotalOrbits(COM);
            var resultDayTwo = galaxy.CountShortestDistance(YOU, SAN);
            Console.WriteLine($"Day 6 part 1 result is {resultDayOne} orbits");
            Console.WriteLine($"Day 6 part 2 result is {resultDayTwo} orbits");

            #endregion

            #region MonitoringStation

            //var asteroidFinder = new AsteroidFinder();
            //var parser = new MonitoringStationInputParser(asteroidFinder);
            //parser.ParseInput();
            //parser.LoadInputToMap();
            //asteroidFinder.LoadAsteroids();
            //foreach (var asteroid in asteroidFinder.Asteroids)
            //{
            //    asteroidFinder.CountVisibleAsteroids(asteroid);
            //}
            //var result = asteroidFinder.FindMonitoringStationPosition();

            //Console.WriteLine($"The monitoring station can see {result} asteroids.");
            #endregion

            #region CrossedWires

            //var crossedWires = new IntersectionFinder();
            //var segmentFactory = new SegmentFactory(crossedWires);
            //segmentFactory.ParseInput();
            //segmentFactory.LoadSegments();
            //crossedWires.FindAllIntersections();
            //crossedWires.CalculateStepsToAllIntersections();
            //var partOneResult = crossedWires.FindClosestIntersection();
            //var partTwoResult = crossedWires.FindShortestDistanceToIntersection();

            //Console.WriteLine($"The closest intersection is {partOneResult} distance from origin.");
            //Console.WriteLine($"The fastest intersection to get to is {partTwoResult} steps from origin.");

            #endregion
        }
    }
}
