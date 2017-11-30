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
    /// The RouteType class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum RouteType
    {
        [DataMember(Name="Tram")]
        Tram,
        [DataMember(Name="Subway")]
        Subway,
        [DataMember(Name="Rail")]
        Rail,
        [DataMember(Name="Bus")]
        Bus,
        [DataMember(Name="Ferry")]
        Ferry,
        [DataMember(Name="CableCar")]
        CableCar,
        [DataMember(Name="Gondola")]
        Gondola,
        [DataMember(Name="Funicular")]
        Funicular,
    }
}