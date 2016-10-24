﻿using System;
using System.Windows;
using NUnit.Framework;

namespace RobotChallenge
{
	[TestFixture]
	public class NUnitTestClass
	{
		Robot myRobot;

		[SetUp]
		public void Setup()
		{
			myRobot = new Robot ();
		}

		[Test]
		public void RobotDefault()
		{
			Assert.IsNotNull (myRobot);
		}

		[Test]
		public void RobotPositionField()
		{
			Assert.AreEqual (-1,myRobot.Position.X);
			Assert.AreEqual (-1,myRobot.Position.Y);
		}

		[Test]
		public void RobotMaxFieldsConstructor()
		{
			Assert.AreEqual (5, myRobot._maxX);
			Assert.AreEqual (5, myRobot._maxY);
		}

		[Test]
		public void RobotPositionProperty()
		{
			myRobot.Position = new Point (5, 5);
			Assert.AreEqual (5, myRobot.Position.X);
			Assert.AreEqual (5,myRobot.Position.Y);
			myRobot.Position = new Point (0, 0);
			Assert.AreEqual (0, myRobot.Position.X);
			Assert.AreEqual (0, myRobot.Position.Y);
			myRobot.Position = new Point (-1, -1);
			Assert.AreEqual (0, myRobot.Position.X);
			Assert.AreEqual (0, myRobot.Position.Y);
		}

		[Test]
		public void RobotPlace()
		{
			Assert.False (myRobot.IsPlaced);
			myRobot.PlaceRobot (new Point(6, 6), Direction.NORTH);
			Assert.False (myRobot.IsPlaced);
			myRobot.PlaceRobot (new Point (5, 5), Direction.NORTH);
			Assert.True (myRobot.IsPlaced);
		}

		[Test]
		public void RobotFace()
		{
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
		}

		[Test]
		public void RobotLeft()
		{
			myRobot.Left ();
			Assert.AreEqual (Direction.WEST, myRobot.Faced);
			myRobot.Left ();
			Assert.AreEqual (Direction.SOUTH, myRobot.Faced);
		}

		[Test]
		public void RobotRight()
		{
			myRobot.Right ();
			Assert.AreEqual (Direction.EAST, myRobot.Faced);
			myRobot.Right ();
			Assert.AreEqual (Direction.SOUTH, myRobot.Faced);
		}
	}
}
