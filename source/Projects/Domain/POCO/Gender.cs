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
    /// The Gender class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum Gender
    {
        [DataMember(Name="Male")]
        Male,
        [DataMember(Name="Female")]
        Female,
    }
}