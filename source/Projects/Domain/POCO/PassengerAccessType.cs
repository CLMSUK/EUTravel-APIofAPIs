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
    /// The PassengerAccessType class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum PassengerAccessType
    {
        [DataMember(Name="Regular")]
        Regular,
        [DataMember(Name="NoPickupAvailable")]
        NoPickupAvailable,
        [DataMember(Name="ContactAgency")]
        ContactAgency,
        [DataMember(Name="ContactDriver")]
        ContactDriver,
    }
}