using Problem2;
using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace TestDatabase
{
    public class DatabaseTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 6, 7, 8 })]
        [TestCase(new int[] { })]

        public void TestValidConstructor(int[] array)
        {
            int length = array.Length;
            Database database = new Database(array);
            int[] createDatabase = database.StoreIntegers.Take(length).ToArray();




            Assert.That(createDatabase, Is.EquivalentTo(array));
        }

        [Test]
        [TestCase(17)]

        public void TestInvalidConstructor(int count)
        {
            int[] values = new int[count];

            Assert.That(() => new Database(values), Throws.InvalidOperationException);
        }

        [Test]
        [TestCase(10)]
        [TestCase(-10)]
        public void TestAddMethod(int value)
        {
            int currentIndex = 1;

            Database database = new Database();
            database.Add(value);

            int[] newDatabase = database.StoreIntegers.Take(currentIndex).ToArray();

            FieldInfo fieldInfo = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                                  .First(f => f.FieldType == typeof(int));
            int index = (int)fieldInfo.GetValue(database);

            Assert.That(newDatabase[0], Is.EqualTo(value));
            Assert.That(index, Is.EqualTo(1));

        }

        [Test]
        public void TestInvalidAddMethod()
        {
            int[] testValues = new int[17];

            Assert.That(() => new Database(testValues), Throws.InvalidOperationException);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 })]

        public void TestRemoveMethod(int[] testValues)
        {
            int count = testValues.Length;
            int[] result = testValues.Take(count - 1).ToArray();

            Database database = new Database(testValues);
            database.Remove();
            var refreshDatabase = database.StoreIntegers.Take(count - 1).ToArray();

            FieldInfo fieldInfo = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(f => f.FieldType == typeof(int));

            int field = (int)fieldInfo.GetValue(database);


            Assert.That(field, Is.EqualTo(count - 1));
            Assert.That(refreshDatabase, Is.EqualTo(result));
        }

        [Test]
        public void TestInvalidRemoveMethod()
        {
            Database database = new Database();

            Assert.That(() => database.Remove(), Throws.InvalidOperationException);
        }

        [Test]
        public void TestFatchMethod()
        {
            int[] data = new int[] { 1, 2 };

            Database database = new Database(data);

            Assert.That(database.Fetch(), Is.EqualTo(data));
        }
    }
}
