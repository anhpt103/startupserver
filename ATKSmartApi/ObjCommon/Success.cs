using System.Collections.Generic;

namespace ATKSmartApi.ObjCommon
{
    public class Success : Message
    {
        public Success(string message)
        {
            Message = message;
        }

        public Success WithMetadata(string metadataName, object metadataValue)
        {
            Metadata.Add(metadataName, metadataValue);
            return this;
        }

        public Success WithMetadata(Dictionary<string, object> metadata)
        {
            foreach (var metadataItem in metadata)
            {
                Metadata.Add(metadataItem.Key, metadataItem.Value);
            }
            
            return this;
        }
    }
}