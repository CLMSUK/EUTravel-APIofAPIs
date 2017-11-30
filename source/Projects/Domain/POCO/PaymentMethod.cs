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
    /// The PaymentMethod class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum PaymentMethod
    {
        [DataMember(Name="OnBoard")]
        OnBoard,
        [DataMember(Name="BeforeBoarding")]
        BeforeBoarding,
    }
}