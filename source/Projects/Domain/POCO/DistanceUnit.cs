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
    /// The DistanceUnit class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum DistanceUnit
    {
        [DataMember(Name="KILOMETERS")]
        KILOMETERS,
        [DataMember(Name="YARDS")]
        YARDS,
        [DataMember(Name="MILES")]
        MILES,
        [DataMember(Name="NAUTICAL_MILES")]
        NAUTICAL_MILES,
        [DataMember(Name="METERS")]
        METERS,
    }
}