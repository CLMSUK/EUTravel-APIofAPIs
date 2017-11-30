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
    /// The TransportMode class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public enum TransportMode
    {
        [DataMember(Name="Aircraft")]
        Aircraft,
        [DataMember(Name="Ferry")]
        Ferry,
        [DataMember(Name="Coach")]
        Coach,
        [DataMember(Name="Bus")]
        Bus,
        [DataMember(Name="Trolley")]
        Trolley,
        [DataMember(Name="Tram")]
        Tram,
        [DataMember(Name="Rail")]
        Rail,
        [DataMember(Name="Subway")]
        Subway,
        [DataMember(Name="Car")]
        Car,
        [DataMember(Name="Walking")]
        Walking,
        [DataMember(Name="Van")]
        Van,
    }
}