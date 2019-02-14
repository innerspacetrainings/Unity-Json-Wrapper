using System.Collections.Generic;

namespace Blue.Json
{
    /// <summary>Extension of Dictionary which allows modification of inner classes</summary>
    public class JsonDictionary : Dictionary<string, object>
    {
        /// <summary>Get the value casted to the desired type</summary>
        public T Get<T>(string key)
        {
            return (T) base[key];
        }
    }
}