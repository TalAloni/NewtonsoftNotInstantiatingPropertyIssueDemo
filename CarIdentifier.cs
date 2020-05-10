using System;
using System.Runtime.Serialization;

namespace ConsoleApp4
{
    [DataContract]
    public class CarIdentifier
    {
        [DataMember]
        public virtual ulong Identifier
        {
            get;
            private set;
        }

        protected CarIdentifier()
        {
        }

        public CarIdentifier(ulong identifier)
        {
            Identifier = identifier;
        }

        public static readonly CarIdentifier None = new CarIdentifier(0);
    }
}
