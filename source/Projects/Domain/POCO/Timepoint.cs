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
    /// The Timepoint class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum Timepoint
    {
        [DataMember(Name="Approximate")]
        Approximate,
        [DataMember(Name="Exact")]
        Exact,
    }
}