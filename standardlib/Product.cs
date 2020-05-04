using System;
using System.Runtime.Serialization;

namespace standardlib
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String Brand { get; set; }
    }

}
