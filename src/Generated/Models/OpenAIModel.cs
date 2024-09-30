// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Models
{
    public partial class OpenAIModel
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal OpenAIModel(string id, DateTimeOffset createdAt, string ownedBy)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(ownedBy, nameof(ownedBy));

            Id = id;
            CreatedAt = createdAt;
            OwnedBy = ownedBy;
        }

        internal OpenAIModel(string id, DateTimeOffset createdAt, InternalModelObject @object, string ownedBy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CreatedAt = createdAt;
            Object = @object;
            OwnedBy = ownedBy;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal OpenAIModel()
        {
        }

        public string Id { get; }

        public string OwnedBy { get; }
    }
}