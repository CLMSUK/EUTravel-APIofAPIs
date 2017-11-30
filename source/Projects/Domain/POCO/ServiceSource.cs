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
    /// The ServiceSource class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum ServiceSource
    {
        [DataMember(Name="API")]
        API,
        [DataMember(Name="Feed")]
        Feed,
        [DataMember(Name="File")]
        File,
    }
}