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
    /// The PermittedTransfers class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum PermittedTransfers
    {
        [DataMember(Name="None")]
        None,
        [DataMember(Name="One")]
        One,
        [DataMember(Name="Two")]
        Two,
        [DataMember(Name="Unlimited")]
        Unlimited,
    }
}