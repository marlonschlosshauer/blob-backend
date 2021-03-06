﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blob_API.Model
{
    [DataContract]
    public partial class OrderedAddress
    {
        public OrderedAddress()
        {
            OrderedCustomer = new HashSet<OrderedCustomer>();
        }

        [DataMember]
        public uint Id { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public string City { get; set; }

        [JsonIgnore]
        public virtual ICollection<OrderedCustomer> OrderedCustomer { get; set; }
    }
}
