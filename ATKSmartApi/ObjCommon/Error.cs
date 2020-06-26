using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace ATKSmartApi.ObjCommon
{
    public class Error : Message
    {
        public List<Error> Messages { get; }

        public Error()
        {
            Messages = new List<Error>();
        }

        public Error(string message)
            : this()
        {
            Msg = message;
        }

        public Error(string message, Error causedBy)
            : this(message)
        {
            Messages.Add(causedBy);
        }

        public Error CausedBy(Error error)
        {
            Messages.Add(error);
            return this;
        }
        
        public Error CausedBy(Exception exception)
        {
            Messages.Add(new ExceptionalError(exception));
            return this;
        }

        public Error WithMessage(string message)
        {
            Message = message;
            return this;
        }

        public Error WithMetadata(string metadataName, object metadataValue)
        {
            Metadata.Add(metadataName, metadataValue);
            return this;
        }

        public Error WithMetadata(Dictionary<string, object> metadata)
        {
            foreach (var metadataItem in metadata)
            {
                Metadata.Add(metadataItem.Key, metadataItem.Value);
            }

            return this;
        }

        public Error CausedBy(string message, Exception exception)
        {
            Messages.Add(new ExceptionalError(message, exception));
            return this;
        }

        public Error CausedBy(string message)
        {
            Messages.Add(new Error(message));
            return this;
        }

        protected override MessagestringBuilder GetMessagestringBuilder()
        {
            return base.GetMessagestringBuilder()
                .WithInfo(nameof(Messages), ReasonFormat.ErrorMessagesToString(Messages));
        }
    }

    internal class ReasonFormat
    {
        public static string ErrorMessagesToString(List<Error> errorMessages)
        {
            return string.Join("; ", errorMessages);
        }

        public static string MessagesToString(List<Message> errorMessages)
        {
            return string.Join("; ", errorMessages);
        }
    }
}