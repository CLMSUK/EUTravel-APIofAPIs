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
    /// The DirectionType class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum DirectionType
    {
        [DataMember(Name="Outbound")]
        Outbound,
        [DataMember(Name="Inbound")]
        Inbound,
    }
}