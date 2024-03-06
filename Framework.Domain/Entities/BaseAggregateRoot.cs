using Framework.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain.Entities
{


    public abstract class BaseAggregateRoot<TId>
    {
        public TId Id { get; set; }

        private readonly List<IEvent> _events;
        protected BaseAggregateRoot()
        {
                _events = new List<IEvent>();
        }
        public void HandleEvent(IEvent @event)
        {
            SetStateByEvent(@event);
            ValidateInvariants();
            _events.Add(@event);
        }
        protected abstract void ValidateInvariants();
        protected abstract void SetStateByEvent(IEvent @event);
    }
}
