using System.Collections.Generic;

namespace SparkPostCore
{
    public class ListSuppressionResponse : Response
    {
        public IEnumerable<Suppression> Suppressions { get; set; }
    }
}