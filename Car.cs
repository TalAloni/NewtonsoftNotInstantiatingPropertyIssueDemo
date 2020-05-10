using System;
using System.Runtime.Serialization;

namespace ConsoleApp4
{
    [DataContract]
    public class Car
    {
        [DataMember]
        public CarIdentifier Identifier
        {
            get; private set;
        }

        public Car()
        {
            Identifier = CarIdentifier.None;
        }

        public Car(CarIdentifier identifier)
        {
            Identifier = identifier;
        }
    }
}
