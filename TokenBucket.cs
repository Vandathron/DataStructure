using System;
namespace DataStructure
{
    public class TokenBucket
    {
        private  double MaxBucketSize;
        private  double bucketRefillRate;

        private double currentBucketSize;
        private DateTime lastRefillDate;

        public TokenBucket(double maxBucketSize, double bucketFillRate)
        {
            this.MaxBucketSize = maxBucketSize;
            this.bucketRefillRate = bucketFillRate;

            currentBucketSize = maxBucketSize;
            lastRefillDate = DateTime.Now;
        }

        private bool allowRequest(int requestToken)
        {
            fillBucket();

            if(requestToken <= currentBucketSize)
            {
                currentBucketSize -= requestToken;
                return true;
            }
            return false;
        }

        private void  fillBucket()
        {
            DateTime now = GetDate();
            double tokenToAdd = now.Subtract(lastRefillDate).TotalSeconds * bucketRefillRate;
            currentBucketSize = Math.Min(currentBucketSize+tokenToAdd, MaxBucketSize);
            lastRefillDate = DateTime.Now;
        }

        private DateTime GetDate() => DateTime.Now;
    }
}
