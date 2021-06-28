using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace DataStructure.Tests
{
    public class LRUCacheTest
    {
        public LRUCacheTest()
        {
        }

        [Fact]
        public void Get_ShouldReturnNull_WhenKeyIsNotFound()
        {
            LRUCache cache = new LRUCache(10);

            String data = cache.Get("name");

            Assert.Null(data);
        }

        [Fact]
        public void Get_ShouldReturnValue_WhenKeyIsFound()
        {

            LRUCache cache = new LRUCache(10);
            cache.Put("test", "Hello here!");
            String value = cache.Get("test");
            Assert.NotNull(value);
        }

        [Fact]
        public void Size_ShouldEqualLengthOfCache()
        {
            LRUCache cache = new LRUCache(10);
            cache.Put("name", "Tosin Akinnagbe");
            cache.Put("username", "2XNGneer");
            Assert.Equal(2, 10-cache.CurrentCacheCapacity);
        }

        [Fact]
        public void Put_ShouldMoveValueToTheHeadOfTheList_WhenKeyIsFound()
        {
            LRUCache cache = new LRUCache(10);
            cache.Put("name", "Tosin Akinnagbe");
            cache.Put("username", "2XNGneer");

            Assert.Equal("username" ,cache.Nodes.First.Value.Key);
        }

        [Fact]
        public void Put_ShouldRemoveOldCache_WhenCacheIsFull()
        {
            LRUCache cache = new LRUCache(2);

            cache.Put("name", "Tosin Akinnagbe");
            cache.Put("username", "2XNGneer");

            cache.Put("van", "tosin");

            String c = cache.Get("name");

            Assert.Null(c);
        }
    }
}
