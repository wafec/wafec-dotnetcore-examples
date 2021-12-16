using AutoMapper;
using Example001_MapNestedClasses;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Example001_MapNesteedClasses_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OuterSourceMap_ShouldReturnOuterDest()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<OuterProfile>();
            });

            config.AssertConfigurationIsValid();

            var source = new OuterSource()
            {
                Value = 5,
                Inner = new InnerSource() { OtherValue = 15 }
            };

            var mapper = config.CreateMapper();
            var dest = mapper.Map<OuterSource, OuterDest>(source);

            Assert.AreEqual(5, dest.Value);
            Assert.NotNull(dest.Inner);
            Assert.AreEqual(15, dest.Inner.OtherValue);
        }

        [Test]
        public void OuterSourceEnumerableMap_ShouldReturnOuterDestEnumerable()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<OuterEnumerableProfile>();
            });

            config.AssertConfigurationIsValid();

            var source = new OuterSourceEnumerable[]
            {
                new OuterSourceEnumerable { Value = 5, InnerItems = new InnerSourceEnumerable[] {
                    new InnerSourceEnumerable { OtherValue = 15 }
                } }
            };

            var mapper = config.CreateMapper();
            var dest = mapper.Map<OuterSourceEnumerable[], IEnumerable<OuterDestEnumerable>>(source);

            Assert.AreEqual(1, dest.Count());
            Assert.AreEqual(5, dest.First().Value);
            Assert.AreEqual(1, dest.First().InnerItems.Count());
            Assert.AreEqual(15, dest.First().InnerItems.First().OtherValue);
        }
    }
}