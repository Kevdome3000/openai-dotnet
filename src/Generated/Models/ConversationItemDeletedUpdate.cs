// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationItemDeletedUpdate : ConversationUpdate
    {
        internal ConversationItemDeletedUpdate(string eventId, string itemId) : base(eventId, RealtimeConversation.ConversationUpdateKind.ItemDeleted)
        {
            ItemId = itemId;
        }

        internal ConversationItemDeletedUpdate(string eventId, RealtimeConversation.ConversationUpdateKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string itemId) : base(eventId, kind, additionalBinaryDataProperties)
        {
            ItemId = itemId;
        }

        public string ItemId { get; }
    }
}
