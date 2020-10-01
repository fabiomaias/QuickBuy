using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _messageValidation { get; set; }

        private List<string> messageValidation
        {
            get { return _messageValidation ?? (_messageValidation = new List<string>()); }
        }

        protected void CleanMessagesValidation()
        {
            messageValidation.Clear();
        }

        protected void AddMessageValidation(string message)
        {
            messageValidation.Add(message);
        }

        public abstract void Validate();

        protected bool IsValid {
            get { return !messageValidation.Any(); }
        }

    }
}
