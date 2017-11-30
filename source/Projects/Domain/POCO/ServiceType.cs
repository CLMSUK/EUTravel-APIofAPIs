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
    /// The ServiceType class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum ServiceType
    {
        [DataMember(Name="ManuallyInsertedValue")]
        ManuallyInsertedValue,
        [DataMember(Name="DataFile")]
        DataFile,
        [DataMember(Name="API")]
        API,
    }
}