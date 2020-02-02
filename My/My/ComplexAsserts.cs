using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using NUnit.Framework;

namespace My
{
    class ComplexAsserts
    {
        [Test]
        public void StringAssertsTest() 
        {
            string s = "The best way to explain it is to do it";
            StringAssert.Contains("explain", s, "No match found");
            StringAssert.DoesNotContain("Alice", s);
            StringAssert.StartsWith("The", s, "No {0} found in {1}", new string[2] { "this", "that" });
            StringAssert.DoesNotStartWith("An", s);
            StringAssert.EndsWith("do it", s, "Incorrect ending");
            StringAssert.DoesNotEndWith("do that", s);
            string x = "ThE bEst WaY to eXplaiN iT iS tO dO iT";
            StringAssert.AreEqualIgnoringCase(x, s, "No match found");
        }
        [Test]
        public void CollectionAssertsTest()
        {
            List<int> list1 = new List<int> { 5, 10, 15, 20, 25, 30, 35 };
            List<int> list2 = new List<int> { 10, 15, 20, 25, 30 };
            CollectionAssert.AllItemsAreInstancesOfType(list1, typeof(int));
            CollectionAssert.AllItemsAreNotNull(list1);
            CollectionAssert.AllItemsAreUnique(list1);
            CollectionAssert.AreNotEqual(list1, list2);
            CollectionAssert.AreNotEquivalent(list1, list2);
            CollectionAssert.Contains(list1, 10);
            CollectionAssert.IsSubsetOf(list2, list1);
            CollectionAssert.IsSupersetOf(list1, list2);
            CollectionAssert.IsNotEmpty(list1);
            CollectionAssert.IsOrdered(list1);
        }
        [Test]
        public void FileAssertsTest()
        {
            FileInfo fileInfo1 = new FileInfo(@"D:\development\Text1.txt");
            FileInfo fileInfo2 = new FileInfo(@"D:\development\Text2.txt");
            FileAssert.AreEqual(fileInfo1, fileInfo2);
            FileAssert.AreNotEqual(fileInfo1, new FileInfo(@"D:\Recovery.txt"));
            FileAssert.Exists(fileInfo1);
            FileAssert.DoesNotExist(new FileInfo(@"D:\development\Text3.txt"));
        }
        [Test]
        public void DirectoryAssertsTest()
        {
            DirectoryInfo dirInfo1 = new DirectoryInfo(@"D:\development\Folder1");
            DirectoryInfo dirInfo2 = new DirectoryInfo(@"D:\development\Folder2");
            DirectoryAssert.AreNotEqual(dirInfo1, dirInfo2);
            DirectoryAssert.Exists(dirInfo1);
        }
    }
}
