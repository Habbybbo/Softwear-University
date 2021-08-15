namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        private RobotManager robotManager;

        [SetUp]
        public void Setup()
        {
            robotManager = new RobotManager(5);
        }

        [Test]
        public void Ctor_ImputValuesAreCorrect()
        {
            Assert.That(robotManager.Capacity, Is.EqualTo(5));
        }

        [Test]
        public void Ctor_ImputValuesAreIncorrect()
        {
            Assert.Throws<ArgumentException>(() => robotManager = new RobotManager(-1));
        }

        [Test]
        public void Add_AddRobotToTheRobotManager()
        {
            Robot robot = new Robot("Spences", 40);
            robotManager.Add(robot);
            Assert.That(robotManager.Count, Is.EqualTo(1));
        }

        [Test]
        public void Add_ThrowsExceptionForARobotWithTheSameName()
        {
            Robot robot = new Robot("Spencer", 40);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot = new Robot("Spencer", 40)));
        }

        [Test]
        public void Add_ThrowsExceptionForExceedingCapacity()
        {
            Robot robot = new Robot("Spences", 40);
            Robot robot2 = new Robot("Gosho", 40);
            Robot robot3 = new Robot("Pesho", 40);
            Robot robot4 = new Robot("Maina", 40);
            Robot robot5 = new Robot("HubaBuba", 40);
            robotManager.Add(robot);
            robotManager.Add(robot2);
            robotManager.Add(robot3);
            robotManager.Add(robot4);
            robotManager.Add(robot5);
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot = new Robot("Munga", 40)));
        }

        [Test]
        public void Remove_RemovesRobotFromTheRobotManager()
        {
            Robot robot = new Robot("Spencer", 40);
            robotManager.Add(robot);
            robotManager.Remove("Spencer");
            Assert.That(robotManager.Count, Is.EqualTo(0));
        }

        [Test]
        public void Remove_ThrowsExceptionForANullInput()
        {
            Robot robot = new Robot("Spencer", 40);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Remove(null));
        }

        [Test]
        public void Work_ChecksIfItWorksWithValidInput()
        {
            Robot robot = new Robot("Spencer", 40);
            robotManager.Add(robot);
            int bateryUsage = 5;
            robotManager.Work("Spencer", "Digging", bateryUsage);
            Assert.That(robot.Battery, Is.LessThan(40));
        }

        [Test]
        public void Work_ThrowsExceptionForANonExistingRobot()
        {
            Robot robot = new Robot("Spencer", 40);
            robotManager.Add(robot);
            int bateryUsage = 5;
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Gosho", "Digging", bateryUsage));
        }

        [Test]
        public void Work_ThrowsExceptionForASmallBattery()
        {
            Robot robot = new Robot("Spencer", 40);
            robotManager.Add(robot);
            int bateryUsage = 45;
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Spencer", "Digging", bateryUsage));
        }

        [Test]
        public void Charge_ChecksIfItWorksWithValidInput()
        {
            Robot robot = new Robot("Spencer", 40);
            robotManager.Add(robot);
            int bateryUsage = 5;
            robotManager.Work("Spencer", "Digging", bateryUsage);
            robotManager.Charge("Spencer");
            Assert.That(robot.Battery, Is.EqualTo(robot.MaximumBattery));
        }

        [Test]
        public void Charge_ThrowsExceptionForNullInput()
        {
            Robot robot = new Robot("Spencer", 40);
            robotManager.Add(robot);
            int bateryUsage = 5;
            robotManager.Work("Spencer", "Digging", bateryUsage);
            Assert.Throws<InvalidOperationException>(() => robotManager.Charge(null));
        }
    }
}
