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
    /// The ItineraryStatus class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum ItineraryStatus
    {
        [DataMember(Name="Active")]
        Active,
        [DataMember(Name="Cancelled")]
        Cancelled,
        [DataMember(Name="Edited")]
        Edited,
        [DataMember(Name="Booked")]
        Booked,
    }
}