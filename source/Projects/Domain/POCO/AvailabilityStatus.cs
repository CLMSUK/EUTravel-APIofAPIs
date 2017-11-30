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
    /// The AvailabilityStatus class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum AvailabilityStatus
    {
        [DataMember(Name="Available")]
        Available,
        [DataMember(Name="Limited")]
        Limited,
        [DataMember(Name="SoldOut")]
        SoldOut,
    }
}