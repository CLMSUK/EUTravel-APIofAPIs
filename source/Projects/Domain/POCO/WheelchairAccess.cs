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
    /// The WheelchairAccess class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum WheelchairAccess
    {
        [DataMember(Name="None")]
        None,
        [DataMember(Name="Partial")]
        Partial,
        [DataMember(Name="Full")]
        Full,
    }
}