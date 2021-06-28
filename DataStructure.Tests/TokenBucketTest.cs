using System;
using Xunit;

namespace DataStructure.Tests
{
    public class TokenBucketTest
    {
        public TokenBucketTest()
        {

        }

        [Fact]
        public void AllowRequest_ShouldReturnTrue_WhenTokenIsLesserOrSameAsCurrentBucketSize()
        {
            TokenBucket tokenBucket = new TokenBucket(30, 15);

            var result = tokenBucket.allowRequest(10);
            Assert.True(result);
        }
    }
}
