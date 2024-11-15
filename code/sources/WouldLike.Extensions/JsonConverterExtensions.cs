using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WouldLike.Extensions
{
    internal static class JsonConverterExtensions
    {
        public static bool TryDeserialize<T>(this JsonConverter<T> jsonConverter, Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, out T value)
        {
            try
            {
                value = jsonConverter.Read(ref reader, typeToConvert, options);
            }
            catch (Exception)
            {
                value = default;
                return false;
            }

            return true;
        }
    }
}
