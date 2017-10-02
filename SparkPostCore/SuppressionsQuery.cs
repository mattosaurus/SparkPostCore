using System;

namespace SparkPostCore
{
    public class SuppressionsQuery
    {
        public DateTime? To { get; set; }
        public DateTime? From { get; set; }
        public int? Limit { get; set; }
    }
}