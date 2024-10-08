// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Batch
{
    internal partial class InternalListBatchesResponse : IJsonModel<InternalListBatchesResponse>
    {
        void IJsonModel<InternalListBatchesResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalListBatchesResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListBatchesResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("data") != true)
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("first_id") != true && Optional.IsDefined(FirstId))
            {
                writer.WritePropertyName("first_id"u8);
                writer.WriteStringValue(FirstId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("last_id") != true && Optional.IsDefined(LastId))
            {
                writer.WritePropertyName("last_id"u8);
                writer.WriteStringValue(LastId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("has_more") != true)
            {
                writer.WritePropertyName("has_more"u8);
                writer.WriteBooleanValue(HasMore);
            }
            if (SerializedAdditionalRawData?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object.ToString());
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalListBatchesResponse IJsonModel<InternalListBatchesResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalListBatchesResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListBatchesResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalListBatchesResponse(document.RootElement, options);
        }

        internal static InternalListBatchesResponse DeserializeInternalListBatchesResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<InternalBatchJob> data = default;
            string firstId = default;
            string lastId = default;
            bool hasMore = default;
            InternalListBatchesResponseObject @object = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"u8))
                {
                    List<InternalBatchJob> array = new List<InternalBatchJob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InternalBatchJob.DeserializeInternalBatchJob(item, options));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("first_id"u8))
                {
                    firstId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("last_id"u8))
                {
                    lastId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("has_more"u8))
                {
                    hasMore = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = new InternalListBatchesResponseObject(property.Value.GetString());
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalListBatchesResponse(
                data,
                firstId,
                lastId,
                hasMore,
                @object,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalListBatchesResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalListBatchesResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalListBatchesResponse)} does not support writing '{options.Format}' format.");
            }
        }

        InternalListBatchesResponse IPersistableModel<InternalListBatchesResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalListBatchesResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalListBatchesResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalListBatchesResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalListBatchesResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalListBatchesResponse FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalListBatchesResponse(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
