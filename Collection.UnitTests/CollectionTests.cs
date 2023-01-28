using Collections;

namespace Collection.UnitTests
{
    public class CollectionTests
    {
    

        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            var collection = new Collection<int>();   
            Assert.AreEqual(collection.ToString(), "[]");
            Assert.AreEqual(collection.Count, 0);
            Assert.AreEqual(collection.Capacity, 16);
        }
        [Test]
        public void Test_Collection_ConstructorSingleItem()
         
        {
            var collection = new Collection<int>(5);
            Assert.AreEqual(collection.ToString(), "[5]");
            // var actual = collection.ToString();
            // var expected = "[5]";
            // Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            var collection = new Collection<int>(5, 6);
            Assert.AreEqual(collection.ToString(), "[5, 6]");
        }
        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            var collection = new Collection<int>(5, 6);
            Assert.AreEqual(collection.Count, 2);
            Assert.That(collection.Capacity, Is.GreaterThan(collection.Count));
        }
        [Test]
        public void Test_Collection_Add()
        {
            var collection = new Collection<string>("Ivan", "Peter");
            collection.Add("Filip");
            Assert.AreEqual(collection.ToString(), "[Ivan, Peter, Filip]");
        }
        [Test]
        public void Test_Collection_GetByIndex()
        {
            var collection = new Collection<int>(5, 6, 7);
            var item = collection[1];
            Assert.That(item.ToString, Is.EqualTo("6"));
        }
        [Test]
        public void Test_Collection_SetByIndex()
        {
            var collection = new Collection<int>(5, 6, 7);
            collection[1] = 666;
            Assert.That(collection.ToString(), Is.EqualTo("[5, 666, 7]"));
          }
        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            var collection = new Collection<string>("Ivan", "Peter");
            Assert.That(() => { var item = collection[2]; }, 
                Throws.InstanceOf<ArgumentOutOfRangeException>());
         }
       }
    }