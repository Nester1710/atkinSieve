using NUnit.Framework;
using eratProject;
using System.Collections.Generic;

namespace SieveTestProject
{
    public class Tests{
        [SetUp]
        public void Setup(){
        }

        [Test]
        public void Test1(){
            Assert.Pass();
        }

        [Test]
        public void SieveTest()
        {
            // �������� ������
            int n = 8;
            List<int> expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19 };
            List<int> actual = new List<int>();
            List<int> MyList = new List<int>();
            // ��������� �������� � ������� ������������ ������
            Sieve g = new Sieve();
            actual = Sieve.Atkin(MyList, n);
            // ��������� ���������� ���������� � ����������
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}