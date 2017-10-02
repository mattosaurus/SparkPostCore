using System;

namespace SparkPostCore
{
    public interface IValueMapper
    {
        bool CanMap(Type propertyType, object value);
        object Map(Type propertyType, object value);
    }
}