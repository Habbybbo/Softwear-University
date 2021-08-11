using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase extendedDb;
        [SetUp]
        public void Setup()
        {
            extendedDb = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void Ctor_AddInitialPeopleToTheDb()
        {
            var people = new Person[5];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Name:{i}");
            }

            extendedDb = new ExtendedDatabase.ExtendedDatabase(people);
            Assert.That(extendedDb.Count, Is.EqualTo(people.Length));

            foreach (var person in people)
            {
                Person dbPerson = extendedDb.FindById(person.Id);
                Assert.That(person, Is.EqualTo(dbPerson));
            }
        }

        [Test]
        public void Ctor_ThrowsExeptionWhenCapacityIsExceeded()
        {
            var people = new Person[17];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, $"Pesho{i}");
            }

            Assert.Throws<ArgumentException>(() => extendedDb = new ExtendedDatabase.ExtendedDatabase(people));
        }

        [Test]
        public void Add_ThrowsExceptionWhenCountIsExceeded()
        {
            var n = 16;
            for (int i = 0; i < n; i++)
            {
                extendedDb.Add(new Person(i, $"Name{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => extendedDb.Add(new Person(16, "BaiKolio")));
        }

        [Test]
        public void Add_ThrowsExceptionWhenUsernameExistsAlready()
        {
            var name = "Pesho";
            extendedDb.Add(new Person(1, name));

            Assert.Throws<InvalidOperationException>(() => extendedDb.Add(new Person(16, name)));
        }

        [Test]
        public void Add_ThrowsExceptionWhenIdIsAlreadyUsed()
        {
            var id = 1;
            extendedDb.Add(new Person(id, "name"));

            Assert.Throws<InvalidOperationException>(() => extendedDb.Add(new Person(id, "name")));
        }

        [Test]
        public void Add_IncrementCountWhenAllIsValid()
        {
            var expectedCount = 2;
            extendedDb.Add(new Person(1, "Pesho"));
            extendedDb.Add(new Person(2, "Gosho"));
            Assert.That(extendedDb.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Remove_ThrowsExceptionWhenDbIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => extendedDb.Remove());
        }

        [Test]
        public void Remove_RemoveElementFromDb()
        {
            var n = 3;
            for (int i = 0; i < n; i++)
            {
                extendedDb.Add(new Person(i, $"Fresh{i}"));
            }
            extendedDb.Remove();
            Assert.That(extendedDb.Count, Is.EqualTo(n - 1));
            Assert.Throws<InvalidOperationException>(() => extendedDb.FindById(n - 1));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsername_ThrowsExceptionWhenUsernameIsInvalid(string username)
        {
            Assert.Throws<ArgumentNullException>(() => extendedDb.FindByUsername(username));
        }

        [Test]
        public void FindByUsername_ThrowsExceptionWhenUsernameDoesNotExists()
        {
            Assert.Throws<InvalidOperationException>(() => extendedDb.FindByUsername("Skido"));
        }

        [Test]
        public void FindByUsername_ReturnsTheCorrectResult()
        {
            var person = new Person(1, "Pesho");
            extendedDb.Add(person);
            var dbPerson = extendedDb.FindByUsername(person.UserName);
            Assert.That(person, Is.EqualTo(dbPerson));
        }

        [Test]
        public void FindById_ThrowExceptionForInvalidId()
        {
            Assert.Throws<InvalidOperationException>(() => extendedDb.FindById(123));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-21)]
        public void FindById_ThrowExceptionWhenIdIsNegativeValue(int id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDb.FindById(id));
        }

        [Test]
        public void FindById_ReturnsTheCorrectResult()
        {
            var person = new Person(1, "Pesho");
            extendedDb.Add(person);
            var dbPerson = extendedDb.FindById(person.Id);
            Assert.That(person, Is.EqualTo(dbPerson));
        }
    }
}