// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationSessionStartedUpdate : ConversationUpdate
    {
        internal ConversationSessionStartedUpdate(string eventId, InternalRealtimeResponseSession internalSession) : base(eventId, RealtimeConversation.ConversationUpdateKind.SessionStarted)
        {
            _internalSession = internalSession;
        }

        internal ConversationSessionStartedUpdate(string eventId, RealtimeConversation.ConversationUpdateKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, InternalRealtimeResponseSession internalSession) : base(eventId, kind, additionalBinaryDataProperties)
        {
            _internalSession = internalSession;
        }
    }
}
