using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ProductService
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
