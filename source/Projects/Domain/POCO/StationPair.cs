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
    /// The StationPair class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class StationPair : IDomainModelClass
    {
        #region StationPair's Fields

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
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region StationPair's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region StationPair's Participant Properties
        [DataMember(Name="OriginStation")]
        protected TrainStation originStation;
        public virtual TrainStation OriginStation
        {
            get
            {
                return originStation;
            }
            set
            {
                if(Equals(originStation, value)) return;
                var __oldValue = originStation;
                if (value != null)
                {
                    originStation = value;
                }
                else
                {
                    originStation = null;
                }
            }
        }
        [DataMember(Name="DestinationStation")]
        protected TrainStation destinationStation;
        public virtual TrainStation DestinationStation
        {
            get
            {
                return destinationStation;
            }
            set
            {
                if(Equals(destinationStation, value)) return;
                var __oldValue = destinationStation;
                if (value != null)
                {
                    destinationStation = value;
                }
                else
                {
                    destinationStation = null;
                }
            }
        }
        [DataMember(Name="RailAgency")]
        protected RailAgency railAgency;
        public virtual RailAgency RailAgency
        {
            get
            {
                return railAgency;
            }
            set
            {
                if(Equals(railAgency, value)) return;
                var __oldValue = railAgency;
                if (value != null)
                {
                    railAgency = value;
                }
                else
                {
                    railAgency = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the StationPair class
/// </summary>
/// <returns>New StationPair object</returns>
/// <remarks></remarks>
        public StationPair() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (OriginStation == null)
            {
                __errors.Add("Association with 'OriginStation' is required.");
            }
            if (DestinationStation == null)
            {
                __errors.Add("Association with 'DestinationStation' is required.");
            }
            if (RailAgency == null)
            {
                __errors.Add("Association with 'RailAgency' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'StationPair' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [StationPair] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual StationPair Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, StationPair copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (StationPair)copiedObjects[this];
            copy = copy ?? new StationPair();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.originStation != null)
            {
                if (!copiedObjects.Contains(this.originStation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OriginStation = this.OriginStation;
                    else if (asNew)
                        copy.OriginStation = this.OriginStation.Copy(deep, copiedObjects, true);
                    else
                        copy.originStation = this.originStation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OriginStation = (TrainStation)copiedObjects[this.OriginStation];
                    else
                        copy.originStation = (TrainStation)copiedObjects[this.OriginStation];
                }
            }
            if(deep && this.destinationStation != null)
            {
                if (!copiedObjects.Contains(this.destinationStation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DestinationStation = this.DestinationStation;
                    else if (asNew)
                        copy.DestinationStation = this.DestinationStation.Copy(deep, copiedObjects, true);
                    else
                        copy.destinationStation = this.destinationStation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DestinationStation = (TrainStation)copiedObjects[this.DestinationStation];
                    else
                        copy.destinationStation = (TrainStation)copiedObjects[this.DestinationStation];
                }
            }
            if(deep && this.railAgency != null)
            {
                if (!copiedObjects.Contains(this.railAgency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.RailAgency = this.RailAgency;
                    else if (asNew)
                        copy.RailAgency = this.RailAgency.Copy(deep, copiedObjects, true);
                    else
                        copy.railAgency = this.railAgency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.RailAgency = (RailAgency)copiedObjects[this.RailAgency];
                    else
                        copy.railAgency = (RailAgency)copiedObjects[this.RailAgency];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as StationPair;
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
                __propertyKeyCache = this.GetType().GetProperty("Id");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
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
            return this.Id == default(int) || this.Id.Equals(default(int));
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
        protected bool HasSameNonDefaultIdAs(StationPair compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
