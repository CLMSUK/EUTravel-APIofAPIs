using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;

namespace EuTravel_2.BO
{
    /// <summary>
    /// The TransferType class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum TransferType
    {
        [DataMember(Name="Recommended")]
        Recommended,
        [DataMember(Name="TimedTransfer")]
        TimedTransfer,
        [DataMember(Name="MinTransferTimeRequired")]
        MinTransferTimeRequired,
        [DataMember(Name="NotAvailable")]
        NotAvailable,
    }
}