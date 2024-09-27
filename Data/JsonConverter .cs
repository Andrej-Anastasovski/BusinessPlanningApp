using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class TransactionJsonConverter : JsonConverter<Transaction>
{
    public override Transaction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Deserialize the base type
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var json = doc.RootElement;
            if (json.TryGetProperty("Source", out _))
            {
                return JsonSerializer.Deserialize<Income>(json.GetRawText(), options);
            }
            else if (json.TryGetProperty("Category", out _))
            {
                return JsonSerializer.Deserialize<Expense>(json.GetRawText(), options);
            }
            throw new JsonException("Unknown transaction type.");
        }
    }

    public override void Write(Utf8JsonWriter writer, Transaction value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
