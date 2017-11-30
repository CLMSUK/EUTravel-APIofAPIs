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
    /// The StationType class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum StationType
    {
        [DataMember(Name="Stop")]
        Stop,
        [DataMember(Name="Station")]
        Station,
    }
}