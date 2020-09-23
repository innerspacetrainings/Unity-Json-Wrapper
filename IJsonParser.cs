using System.Collections.Generic;

namespace Blue.Json
{
    public interface IJsonParser
    {
        /// <summary>Serialize Dictionary to a json</summary>
        /// <returns>Serialized JSON</returns>
        string Serialize(IDictionary<string, object> dictionary, bool prettyPrint = false);
        /// <summary>Serializes a object which supports serialization</summary>
        /// <returns>Serialized JSON</returns>
        string Serialize(object obj, bool prettyPrint = false);

        /// <summary>Parse a json to a Dictionary of type string/object</summary>
        /// <seealso cref="JsonDictionary"/>
        /// <returns>Nested dictionary with some extra features</returns>
        JsonDictionary Parse(string json);
        /// <summary>Parse a Json to the desired type.</summary>
        /// <para>Works only for serializable types</para>
        /// <param name="json"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Parse<T>(string json);
    }
}