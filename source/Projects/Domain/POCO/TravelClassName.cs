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
    /// The TravelClassName class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum TravelClassName
    {
        [DataMember(Name="Economy")]
        Economy,
        [DataMember(Name="EconomyPremium")]
        EconomyPremium,
        [DataMember(Name="Business")]
        Business,
    }
}