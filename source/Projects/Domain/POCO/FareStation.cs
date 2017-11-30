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
    /// The FareStation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum FareStation
    {
        [DataMember(Name="OutputOnly")]
        OutputOnly,
        [DataMember(Name="No")]
        No,
        [DataMember(Name="Yes")]
        Yes,
    }
}