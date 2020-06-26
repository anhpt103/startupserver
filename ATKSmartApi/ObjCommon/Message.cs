using System;
using System.Collections.Generic;

namespace ATKSmartApi.ObjCommon
{
    public class Message
    {
        public string Msg { get; protected set; }
        public Dictionary<string, object> Metadata { get; protected set; }

        protected Message()
        {
            Metadata = new Dictionary<string, object>();
        }

        public bool HasMetadataKey(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            return Metadata.ContainsKey(key);
        }

        public bool HasMetadata(string key, Func<object, bool> predicate)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            if (Metadata.TryGetValue(key, out object actualValue))
                return predicate(actualValue);

            return false;
        }

        protected virtual ReasonStringBuilder GetReasonStringBuilder()
        {
            return new ReasonStringBuilder()
                .WithReasonType(GetType())
                .WithInfo(nameof(Message), Msg)
                .WithInfo(nameof(Metadata), string.Join("; ", Metadata)); //todo: correct string
        }

        public override string ToString()
        {
            return GetReasonStringBuilder()
                .Build();
        }
    }
}