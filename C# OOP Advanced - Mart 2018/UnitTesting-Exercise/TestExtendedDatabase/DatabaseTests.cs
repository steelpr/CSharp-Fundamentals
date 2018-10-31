using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using Problem2;
using System.Collections.Generic;

namespace TestDatabase
{
    public class DatabaseTests
    {
        private const long id = 22323232323;
        private const string username = "drink";
        private const string nullUsername = null;
        private Person person;
        private Person usernameIsNull;
       
        [SetUp]
        public void CreateValidPerson()
        {
            person = new Person(id, username);
        }

        [SetUp]
        public void CreateInvalidPerson()
        {
            usernameIsNull = new Person(id, null);
        }

        [Test]

        public void TestValidConstructor()
        { 
            Database database = new Database(person);

            FieldInfo databaseField = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(p => p.FieldType == typeof(Person[]));

            FieldInfo indexFiels = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(i => i.FieldType == typeof(int));

            IEnumerable<Person> fieldValue = ((Person[])databaseField.GetValue(database)).Take(1);
            
            int value = (int)indexFiels.GetValue(database);

            
            Assert.That(fieldValue, Is.EqualTo(person));
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        [TestCase(17)]

        public void TestInvalidConstructor(int count)
        {
            Person[] person = new Person[17];
            Assert.That(() => new Database(person), Throws.InvalidOperationException);
        }

        //[Test]
        //[TestCase(10)]
        //[TestCase(-10)]
        //public void TestAddMethod(int value)
        //{
        //    int currentIndex = 1;

        //    Database database = new Database();
        //    database.Add(value);

        //    int[] newDatabase = database.StoreIntegers.Take(currentIndex).ToArray();

        //    FieldInfo fieldInfo = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
        //                                          .First(f => f.FieldType == typeof(int));
        //    int index = (int)fieldInfo.GetValue(database);

        //    Assert.That(newDatabase[0], Is.EqualTo(value));
        //    Assert.That(index, Is.EqualTo(1));

        //}

        //[Test]
        //public void TestInvalidAddMethod()
        //{
        //    int[] testValues = new int[17];

        //    Assert.That(() => new Database(testValues), Throws.InvalidOperationException);
        //}

        //[Test]
        //[TestCase(new int[] { 1, 2, 3 })]
        //[TestCase(new int[] { 1, 2, 3, 4 })]

        //public void TestRemoveMethod(int[] testValues)
        //{
        //    int count = testValues.Length;
        //    int[] result = testValues.Take(count - 1).ToArray();

        //    Database database = new Database(testValues);
        //    database.Remove();
        //    var refreshDatabase = database.StoreIntegers.Take(count - 1).ToArray();

        //    FieldInfo fieldInfo = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(f => f.FieldType == typeof(int));

        //    int field = (int)fieldInfo.GetValue(database);


        //    Assert.That(field, Is.EqualTo(count - 1));
        //    Assert.That(refreshDatabase, Is.EqualTo(result));
        //}

        //[Test]
        //public void TestInvalidRemoveMethod()
        //{
        //    Database database = new Database();

        //    Assert.That(() => database.Remove(), Throws.InvalidOperationException);
        //}

        //[Test]
        //public void TestFatchMethod()
        //{
        //    int[] data = new int[] { 1, 2 };

        //    Database database = new Database(data);

        //    Assert.That(database.Fetch(), Is.EqualTo(data));
        //}
    }
}
