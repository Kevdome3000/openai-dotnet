// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace OpenAI.RealtimeConversation
{
    [PersistableModelProxy(typeof(UnknownRealtimeRequestItem))]
    public partial class ConversationItem : IJsonModel<ConversationItem>
    {
        void IJsonModel<ConversationItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("id") != true && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        ConversationItem IJsonModel<ConversationItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationItem(document.RootElement, options);
        }

        internal static ConversationItem DeserializeConversationItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "assistant": return InternalRealtimeRequestAssistantMessageItem.DeserializeInternalRealtimeRequestAssistantMessageItem(element, options);
                    case "function_call": return InternalRealtimeRequestFunctionCallItem.DeserializeInternalRealtimeRequestFunctionCallItem(element, options);
                    case "function_call_output": return InternalRealtimeRequestFunctionCallOutputItem.DeserializeInternalRealtimeRequestFunctionCallOutputItem(element, options);
                    case "message": return InternalRealtimeRequestMessageItem.DeserializeInternalRealtimeRequestMessageItem(element, options);
                    case "system": return InternalRealtimeRequestSystemMessageItem.DeserializeInternalRealtimeRequestSystemMessageItem(element, options);
                    case "user": return InternalRealtimeRequestUserMessageItem.DeserializeInternalRealtimeRequestUserMessageItem(element, options);
                }
            }
            return UnknownRealtimeRequestItem.DeserializeUnknownRealtimeRequestItem(element, options);
        }

        BinaryData IPersistableModel<ConversationItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationItem)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationItem IPersistableModel<ConversationItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConversationItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static ConversationItem FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConversationItem(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
