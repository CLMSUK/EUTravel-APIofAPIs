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
    /// The TitleEnum class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum TitleEnum
    {
        [DataMember(Name="Mr")]
        Mr,
        [DataMember(Name="Mrs")]
        Mrs,
        [DataMember(Name="Ms")]
        Ms,
        [DataMember(Name="Dr")]
        Dr,
    }
}