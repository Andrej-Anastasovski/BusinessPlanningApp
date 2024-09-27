using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Expense_Tracking_App.Data
{
    // Custom JsonConverter for Transaction polymorphism
    public class TransactionJsonConverter : JsonConverter<Transaction>
    {
        public override Transaction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
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

    public class DataSerializer
    {
        private readonly JsonSerializerOptions _options;

        public DataSerializer()
        {
            _options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters =
                {
                    new JsonStringEnumConverter(), // To handle enums as strings, if used
                    new TransactionJsonConverter() // Register the custom converter
                }
            };
        }

        // Serialize the transactions to a JSON file
        public void SerializeToFile(string filePath, IEnumerable<Transaction> transactions)
        {
            var allTransactions = transactions.ToList(); // Ensure it's a list to avoid deferred execution
            string json = JsonSerializer.Serialize(allTransactions, _options);
            Console.WriteLine($"Serialized Data: {json}"); // Debugging line
            File.WriteAllText(filePath, json);
        }

        // Deserialize transactions from a JSON file
        public IEnumerable<Transaction> DeserializeFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var transactions = JsonSerializer.Deserialize<List<Transaction>>(json, _options) ?? new List<Transaction>();
                Console.WriteLine($"Loaded Data: {json}"); // Debugging line
                return transactions;
            }
            return new List<Transaction>();
        }
    }
}
