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
    /// The Connection class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Connection : IDomainModelClass
    {
        #region Connection's Fields

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
        [DataMember(Name="ChangeOfPlane")]
        protected bool changeOfPlane;
        [DataMember(Name="ChangeOfTerminal")]
        protected bool changeOfTerminal;
        [DataMember(Name="ChangeOfAirport")]
        protected bool changeOfAirport;
        [DataMember(Name="StopOver")]
        protected bool stopOver;
        [DataMember(Name="Duration")]
        protected int? duration;
        [DataMember(Name="GroundTime")]
        protected int? groundTime;
        [DataMember(Name="MinConnectionTime")]
        protected int? minConnectionTime;
        #endregion
        #region Connection's Properties
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
/// The ChangeOfPlane property
///
/// </summary>
///
        public virtual bool ChangeOfPlane
        {
            get
            {
                return changeOfPlane;
            }
            set
            {
                changeOfPlane = value;
            }
        }
/// <summary>
/// The ChangeOfTerminal property
///
/// </summary>
///
        public virtual bool ChangeOfTerminal
        {
            get
            {
                return changeOfTerminal;
            }
            set
            {
                changeOfTerminal = value;
            }
        }
/// <summary>
/// The ChangeOfAirport property
///
/// </summary>
///
        public virtual bool ChangeOfAirport
        {
            get
            {
                return changeOfAirport;
            }
            set
            {
                changeOfAirport = value;
            }
        }
/// <summary>
/// The StopOver property
///
/// </summary>
///
        public virtual bool StopOver
        {
            get
            {
                return stopOver;
            }
            set
            {
                stopOver = value;
            }
        }
/// <summary>
/// The Duration property
///
/// </summary>
///
        public virtual int? Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
/// <summary>
/// The GroundTime property
///
/// </summary>
///
        public virtual int? GroundTime
        {
            get
            {
                return groundTime;
            }
            set
            {
                groundTime = value;
            }
        }
/// <summary>
/// The MinConnectionTime property
///
/// </summary>
///
        public virtual int? MinConnectionTime
        {
            get
            {
                return minConnectionTime;
            }
            set
            {
                minConnectionTime = value;
            }
        }
        #endregion
        #region Connection's Participant Properties
        [DataMember(Name="IncomingFlightRoute")]
        protected FlightRoute incomingFlightRoute;
        public virtual FlightRoute IncomingFlightRoute
        {
            get
            {
                return incomingFlightRoute;
            }
            set
            {
                if(Equals(incomingFlightRoute, value)) return;
                var __oldValue = incomingFlightRoute;
                if (value != null)
                {
                    if(incomingFlightRoute != null && !Equals(incomingFlightRoute, value))
                        incomingFlightRoute.RemoveOutgoingConnections(this);
                    incomingFlightRoute = value;
                    incomingFlightRoute.AddOutgoingConnections(this);
                }
                else
                {
                    if(incomingFlightRoute != null)
                        incomingFlightRoute.RemoveOutgoingConnections(this);
                    incomingFlightRoute = null;
                }
            }
        }
        [DataMember(Name="OutgoingFlightRoute")]
        protected FlightRoute outgoingFlightRoute;
        public virtual FlightRoute OutgoingFlightRoute
        {
            get
            {
                return outgoingFlightRoute;
            }
            set
            {
                if(Equals(outgoingFlightRoute, value)) return;
                var __oldValue = outgoingFlightRoute;
                if (value != null)
                {
                    if(outgoingFlightRoute != null && !Equals(outgoingFlightRoute, value))
                        outgoingFlightRoute.RemoveIncomingConnections(this);
                    outgoingFlightRoute = value;
                    outgoingFlightRoute.AddIncomingConnections(this);
                }
                else
                {
                    if(outgoingFlightRoute != null)
                        outgoingFlightRoute.RemoveIncomingConnections(this);
                    outgoingFlightRoute = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Connection class
/// </summary>
/// <returns>New Connection object</returns>
/// <remarks></remarks>
        public Connection() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (IncomingFlightRoute == null)
            {
                __errors.Add("Association with 'IncomingFlightRoute' is required.");
            }
            if (OutgoingFlightRoute == null)
            {
                __errors.Add("Association with 'OutgoingFlightRoute' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Connection' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Connection] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Connection Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Connection copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Connection)copiedObjects[this];
            copy = copy ?? new Connection();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.ChangeOfPlane = this.ChangeOfPlane;
            copy.ChangeOfTerminal = this.ChangeOfTerminal;
            copy.ChangeOfAirport = this.ChangeOfAirport;
            copy.StopOver = this.StopOver;
            copy.Duration = this.Duration;
            copy.GroundTime = this.GroundTime;
            copy.MinConnectionTime = this.MinConnectionTime;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.incomingFlightRoute != null)
            {
                if (!copiedObjects.Contains(this.incomingFlightRoute))
                {
                    if (asNew && reuseNestedObjects)
                        copy.IncomingFlightRoute = this.IncomingFlightRoute;
                    else if (asNew)
                        copy.IncomingFlightRoute = this.IncomingFlightRoute.Copy(deep, copiedObjects, true);
                    else
                        copy.incomingFlightRoute = this.incomingFlightRoute.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.IncomingFlightRoute = (FlightRoute)copiedObjects[this.IncomingFlightRoute];
                    else
                        copy.incomingFlightRoute = (FlightRoute)copiedObjects[this.IncomingFlightRoute];
                }
            }
            if(deep && this.outgoingFlightRoute != null)
            {
                if (!copiedObjects.Contains(this.outgoingFlightRoute))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OutgoingFlightRoute = this.OutgoingFlightRoute;
                    else if (asNew)
                        copy.OutgoingFlightRoute = this.OutgoingFlightRoute.Copy(deep, copiedObjects, true);
                    else
                        copy.outgoingFlightRoute = this.outgoingFlightRoute.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OutgoingFlightRoute = (FlightRoute)copiedObjects[this.OutgoingFlightRoute];
                    else
                        copy.outgoingFlightRoute = (FlightRoute)copiedObjects[this.OutgoingFlightRoute];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Connection;
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
        protected bool HasSameNonDefaultIdAs(Connection compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
