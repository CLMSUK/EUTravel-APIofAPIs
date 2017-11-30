using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace EuTravel_2.BO
{
    /// <summary>
    /// The StationResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class StationResponse : IDomainModelClass
    {
        #region StationResponse's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="StationResponseKey")]
        protected Guid? stationResponseKey = Guid.Empty;
        #endregion
        #region StationResponse's Properties
/// <summary>
/// The StationResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? StationResponseKey
        {
            get
            {
                return stationResponseKey;
            }
            set
            {
                stationResponseKey = value;
            }
        }
        #endregion
        #region StationResponse's Participant Properties
        [DataMember(Name="Airports")]
        protected IList<Airport> airports = new List<Airport>();
        public virtual List<Airport> Airports
        {
            get
            {
                if (airports is Airport[])
                {
                    airports = airports.ToList();
                }
                if (airports == null)
                {
                    airports = new List<Airport>();
                }
                return airports.ToList();
            }
            set
            {
                if (airports is Airport[])
                {
                    airports = airports.ToList();
                }
                if (airports != null)
                {
                    var __itemsToDelete = new List<Airport>(airports);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveAirports(__item);
                    }
                }
                if(value == null)
                {
                    airports = new List<Airport>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddAirports(__item);
                }
            }
        }
        public virtual void AddAirports(IList<Airport> __items)
        {
            foreach (var __item in __items)
            {
                AddAirports(__item);
            }
        }
        public virtual void AddAirports(Airport __item)
        {
            if (__item != null && airports!=null && !airports.Contains(__item))
            {
                airports.Add(__item);
            }
        }

        public virtual void RemoveAirports(Airport __item)
        {
            if (__item != null && airports!=null && airports.Contains(__item))
            {
                airports.Remove(__item);
            }
        }
        public virtual void SetAirportsAt(Airport __item, int __index)
        {
            if (__item == null)
            {
                airports[__index] = null;
            }
            else
            {
                airports[__index] = __item;
            }
        }

        public virtual void ClearAirports()
        {
            if (airports!=null)
            {
                var __itemsToRemove = airports.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveAirports(__item);
                }
            }
        }
        [DataMember(Name="Ports")]
        protected IList<Port> ports = new List<Port>();
        public virtual List<Port> Ports
        {
            get
            {
                if (ports is Port[])
                {
                    ports = ports.ToList();
                }
                if (ports == null)
                {
                    ports = new List<Port>();
                }
                return ports.ToList();
            }
            set
            {
                if (ports is Port[])
                {
                    ports = ports.ToList();
                }
                if (ports != null)
                {
                    var __itemsToDelete = new List<Port>(ports);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePorts(__item);
                    }
                }
                if(value == null)
                {
                    ports = new List<Port>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPorts(__item);
                }
            }
        }
        public virtual void AddPorts(IList<Port> __items)
        {
            foreach (var __item in __items)
            {
                AddPorts(__item);
            }
        }
        public virtual void AddPorts(Port __item)
        {
            if (__item != null && ports!=null && !ports.Contains(__item))
            {
                ports.Add(__item);
            }
        }

        public virtual void RemovePorts(Port __item)
        {
            if (__item != null && ports!=null && ports.Contains(__item))
            {
                ports.Remove(__item);
            }
        }
        public virtual void SetPortsAt(Port __item, int __index)
        {
            if (__item == null)
            {
                ports[__index] = null;
            }
            else
            {
                ports[__index] = __item;
            }
        }

        public virtual void ClearPorts()
        {
            if (ports!=null)
            {
                var __itemsToRemove = ports.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePorts(__item);
                }
            }
        }
        [DataMember(Name="TrainStations")]
        protected IList<TrainStation> trainStations = new List<TrainStation>();
        public virtual List<TrainStation> TrainStations
        {
            get
            {
                if (trainStations is TrainStation[])
                {
                    trainStations = trainStations.ToList();
                }
                if (trainStations == null)
                {
                    trainStations = new List<TrainStation>();
                }
                return trainStations.ToList();
            }
            set
            {
                if (trainStations is TrainStation[])
                {
                    trainStations = trainStations.ToList();
                }
                if (trainStations != null)
                {
                    var __itemsToDelete = new List<TrainStation>(trainStations);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTrainStations(__item);
                    }
                }
                if(value == null)
                {
                    trainStations = new List<TrainStation>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTrainStations(__item);
                }
            }
        }
        public virtual void AddTrainStations(IList<TrainStation> __items)
        {
            foreach (var __item in __items)
            {
                AddTrainStations(__item);
            }
        }
        public virtual void AddTrainStations(TrainStation __item)
        {
            if (__item != null && trainStations!=null && !trainStations.Contains(__item))
            {
                trainStations.Add(__item);
            }
        }

        public virtual void RemoveTrainStations(TrainStation __item)
        {
            if (__item != null && trainStations!=null && trainStations.Contains(__item))
            {
                trainStations.Remove(__item);
            }
        }
        public virtual void SetTrainStationsAt(TrainStation __item, int __index)
        {
            if (__item == null)
            {
                trainStations[__index] = null;
            }
            else
            {
                trainStations[__index] = __item;
            }
        }

        public virtual void ClearTrainStations()
        {
            if (trainStations!=null)
            {
                var __itemsToRemove = trainStations.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTrainStations(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the StationResponse class
/// </summary>
/// <returns>New StationResponse object</returns>
/// <remarks></remarks>
        public StationResponse()
        {
            if (StationResponseKey == null) StationResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'StationResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [StationResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual StationResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, StationResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (StationResponse)copiedObjects[this];
            copy = copy ?? new StationResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.StationResponseKey = this.StationResponseKey;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.airports = new List<Airport>();
            if(deep && this.airports != null)
            {
                foreach (var __item in this.airports)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddAirports(__item);
                        else
                            copy.AddAirports(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddAirports((Airport)copiedObjects[__item]);
                    }
                }
            }
            copy.ports = new List<Port>();
            if(deep && this.ports != null)
            {
                foreach (var __item in this.ports)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPorts(__item);
                        else
                            copy.AddPorts(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPorts((Port)copiedObjects[__item]);
                    }
                }
            }
            copy.trainStations = new List<TrainStation>();
            if(deep && this.trainStations != null)
            {
                foreach (var __item in this.trainStations)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTrainStations(__item);
                        else
                            copy.AddTrainStations(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTrainStations((TrainStation)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as StationResponse;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("StationResponseKey");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.StationResponseKey.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.StationResponseKey == default(Guid) || this.StationResponseKey.Equals(default(Guid));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(StationResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.StationResponseKey.Equals(compareTo.StationResponseKey);
        }

        #endregion
    }
}
