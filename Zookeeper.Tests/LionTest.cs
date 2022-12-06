using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zookeeper.Models;
using Zookeeper;
using FluentAssertions;

namespace Zookeeper.Tests
{
    public class LionTest
    {
        private Lion lion;
        [SetUp]
        public void SetUp ()
        {
            lion = new Lion ();
            //lion.Size.Set(Size.Medium);
        }

        [Test]
        public void IsDangerousTrue()
        {
            var lion = new Lion();
            Assert.IsTrue(lion.IsDangerous());
        }
        [Test]
        public void IsSizeMedium() 
        {
            var lion = new Lion();
            Assert.AreEqual(lion.Size, Size.Medium);
            Assert.That(lion.Size, Is.EqualTo(Size.Medium));
            lion.Size.Should().Be(Size.Medium);

        }

        public void NegativeAge()
        { 
            lion = new Lion();
            //AssertionException()
        }

    }
    public class GiraffeTest
    {
        [Test]

        public void IsDangerousFalse()
        {
            var giraffe = new Giraffe();
            Assert.IsFalse(giraffe.IsDangerous());
        }
    }
}
