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
    /// The SilverrailStationType class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum SilverrailStationType
    {
        [DataMember(Name="Station")]
        Station,
        [DataMember(Name="Group")]
        Group,
    }
}