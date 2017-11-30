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
    /// The OperatingSystemEnum class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum OperatingSystemEnum
    {
        [DataMember(Name="Windows")]
        Windows,
        [DataMember(Name="MacOS")]
        MacOS,
        [DataMember(Name="Android")]
        Android,
        [DataMember(Name="Linux")]
        Linux,
        [DataMember(Name="iOS")]
        iOS,
    }
}