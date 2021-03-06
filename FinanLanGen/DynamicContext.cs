﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FinanLanGen
{
    [Serializable]
    public class DynamicContext : DynamicObject, ISerializable
    {
        private Dictionary<string, object> dynamicContext = new Dictionary<string, object>();

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return (dynamicContext.TryGetValue(binder.Name, out result));
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            dynamicContext.Add(binder.Name, value);
            return true;
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            foreach (KeyValuePair<string, object> kvp in dynamicContext)
            {
                info.AddValue(kvp.Key, kvp.Value);
            }
        }

        public DynamicContext()
        {
        }

        protected DynamicContext(SerializationInfo info, StreamingContext context)
        {
            // TODO: validate inputs before deserializing. See http://msdn.microsoft.com/en-us/library/ty01x675(VS.80).aspx
            foreach (SerializationEntry entry in info)
            {
                dynamicContext.Add(entry.Name, entry.Value);
            }
        }

    }
}
