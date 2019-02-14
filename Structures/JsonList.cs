using System.Collections.Generic;

namespace Blue.Json
{
    /// <summary>Extended List which brings a inner get with type casting</summary>
    public class JsonList : List<object>
    {
        /// <summary>Get the index of the list casted to the desired type</summary>
        public T Get<T>(int index)
        {
            return (T) base[index];
        }
    }
}