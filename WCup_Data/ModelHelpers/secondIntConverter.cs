using System.Text.Json;
using System.Text.Json.Serialization;

namespace WCup_Data.ModelHelpers;

internal class secondIntConverter : JsonConverter<int>
{
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if(reader.TokenType == JsonTokenType.Null)
        {
            return 0;
        }
        if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out int number))
        {
            return number;
        }

        if (reader.TokenType == JsonTokenType.String && int.TryParse(reader.GetString(), out int numberFromString))
        {
            return numberFromString;
        }

        throw new JsonException("Cannot convert to integer");
    }

    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value);
    }
}