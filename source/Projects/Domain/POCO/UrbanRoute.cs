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
    /// The UrbanRoute class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class UrbanRoute : IDomainModelClass
    {
        #region UrbanRoute's Fields

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
        [DataMember(Name="GTFSId")]
        protected string gTFSId;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="ShortName")]
        protected string shortName;
        [DataMember(Name="RouteType")]
        protected EuTravel_2.BO.RouteType routeType;
        [DataMember(Name="TextColor")]
        protected string textColor;
        #endregion
        #region UrbanRoute's Properties
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
/// The GTFSId property
///
/// </summary>
///
        public virtual string GTFSId
        {
            get
            {
                return gTFSId;
            }
            set
            {
                gTFSId = value;
            }
        }
/// <summary>
/// The Name property
///
/// </summary>
///
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
/// <summary>
/// The ShortName property
///
/// </summary>
///
        public virtual string ShortName
        {
            get
            {
                return shortName;
            }
            set
            {
                shortName = value;
            }
        }
/// <summary>
/// The RouteType property
///
/// </summary>
///
        public virtual EuTravel_2.BO.RouteType RouteType
        {
            get
            {
                return routeType;
            }
            set
            {
                routeType = value;
            }
        }
/// <summary>
/// The TextColor property
///
/// </summary>
///
        public virtual string TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
            }
        }
        #endregion
        #region UrbanRoute's Participant Properties
        [DataMember(Name="TransportMeans")]
        protected UrbanTransportMeans transportMeans;
        public virtual UrbanTransportMeans TransportMeans
        {
            get
            {
                return transportMeans;
            }
            set
            {
                if(Equals(transportMeans, value)) return;
                var __oldValue = transportMeans;
                if (value != null)
                {
                    transportMeans = value;
                }
                else
                {
                    transportMeans = null;
                }
            }
        }
        [DataMember(Name="UrbanAgency")]
        protected UrbanAgency urbanAgency;
        public virtual UrbanAgency UrbanAgency
        {
            get
            {
                return urbanAgency;
            }
            set
            {
                if(Equals(urbanAgency, value)) return;
                var __oldValue = urbanAgency;
                if (value != null)
                {
                    if(urbanAgency != null && !Equals(urbanAgency, value))
                        urbanAgency.RemoveUrbanLines(this);
                    urbanAgency = value;
                    urbanAgency.AddUrbanLines(this);
                }
                else
                {
                    if(urbanAgency != null)
                        urbanAgency.RemoveUrbanLines(this);
                    urbanAgency = null;
                }
            }
        }
        [DataMember(Name="UrbanTrips")]
        protected IList<UrbanTrip> urbanTrips = new List<UrbanTrip>();
        public virtual List<UrbanTrip> UrbanTrips
        {
            get
            {
                if (urbanTrips is UrbanTrip[])
                {
                    urbanTrips = urbanTrips.ToList();
                }
                if (urbanTrips == null)
                {
                    urbanTrips = new List<UrbanTrip>();
                }
                return urbanTrips.ToList();
            }
            set
            {
                if (urbanTrips is UrbanTrip[])
                {
                    urbanTrips = urbanTrips.ToList();
                }
                if (urbanTrips != null)
                {
                    var __itemsToDelete = new List<UrbanTrip>(urbanTrips);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUrbanTrips(__item);
                    }
                }
                if(value == null)
                {
                    urbanTrips = new List<UrbanTrip>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUrbanTrips(__item);
                }
            }
        }
        public virtual void AddUrbanTrips(IList<UrbanTrip> __items)
        {
            foreach (var __item in __items)
            {
                AddUrbanTrips(__item);
            }
        }
        public virtual void AddUrbanTrips(UrbanTrip __item)
        {
            if (__item != null && urbanTrips!=null && !urbanTrips.Contains(__item))
            {
                urbanTrips.Add(__item);
                if (__item.UrbanRoute != this)
                    __item.UrbanRoute = this;
            }
        }

        public virtual void RemoveUrbanTrips(UrbanTrip __item)
        {
            if (__item != null && urbanTrips!=null && urbanTrips.Contains(__item))
            {
                urbanTrips.Remove(__item);
                __item.UrbanRoute = null;
            }
        }
        public virtual void SetUrbanTripsAt(UrbanTrip __item, int __index)
        {
            if (__item == null)
            {
                urbanTrips[__index].UrbanRoute = null;
            }
            else
            {
                urbanTrips[__index] = __item;
                if (__item.UrbanRoute != this)
                    __item.UrbanRoute = this;
            }
        }

        public virtual void ClearUrbanTrips()
        {
            if (urbanTrips!=null)
            {
                var __itemsToRemove = urbanTrips.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUrbanTrips(__item);
                }
            }
        }
        [DataMember(Name="RouteColor")]
        protected Color routeColor;
        public virtual Color RouteColor
        {
            get
            {
                return routeColor;
            }
            set
            {
                if(Equals(routeColor, value)) return;
                var __oldValue = routeColor;
                if (value != null)
                {
                    routeColor = value;
                }
                else
                {
                    routeColor = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UrbanRoute class
/// </summary>
/// <returns>New UrbanRoute object</returns>
/// <remarks></remarks>
        public UrbanRoute() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (GTFSId != null && GTFSId.Length > 100)
            {
                __errors.Add("Length of property 'GTFSId' cannot be greater than 100.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (ShortName != null && ShortName.Length > 100)
            {
                __errors.Add("Length of property 'ShortName' cannot be greater than 100.");
            }
            if (TextColor != null && TextColor.Length > 100)
            {
                __errors.Add("Length of property 'TextColor' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UrbanRoute' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UrbanRoute] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UrbanRoute Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UrbanRoute copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UrbanRoute)copiedObjects[this];
            copy = copy ?? new UrbanRoute();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.GTFSId = this.GTFSId;
            copy.Name = this.Name;
            copy.ShortName = this.ShortName;
            copy.RouteType = this.RouteType;
            copy.TextColor = this.TextColor;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.transportMeans != null)
            {
                if (!copiedObjects.Contains(this.transportMeans))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TransportMeans = this.TransportMeans;
                    else if (asNew)
                        copy.TransportMeans = this.TransportMeans.Copy(deep, copiedObjects, true);
                    else
                        copy.transportMeans = this.transportMeans.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TransportMeans = (UrbanTransportMeans)copiedObjects[this.TransportMeans];
                    else
                        copy.transportMeans = (UrbanTransportMeans)copiedObjects[this.TransportMeans];
                }
            }
            if(deep && this.urbanAgency != null)
            {
                if (!copiedObjects.Contains(this.urbanAgency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.UrbanAgency = this.UrbanAgency;
                    else if (asNew)
                        copy.UrbanAgency = this.UrbanAgency.Copy(deep, copiedObjects, true);
                    else
                        copy.urbanAgency = this.urbanAgency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.UrbanAgency = (UrbanAgency)copiedObjects[this.UrbanAgency];
                    else
                        copy.urbanAgency = (UrbanAgency)copiedObjects[this.UrbanAgency];
                }
            }
            copy.urbanTrips = new List<UrbanTrip>();
            if(deep && this.urbanTrips != null)
            {
                foreach (var __item in this.urbanTrips)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUrbanTrips(__item);
                        else
                            copy.AddUrbanTrips(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUrbanTrips((UrbanTrip)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.routeColor != null)
            {
                if (!copiedObjects.Contains(this.routeColor))
                {
                    if (asNew && reuseNestedObjects)
                        copy.RouteColor = this.RouteColor;
                    else if (asNew)
                        copy.RouteColor = this.RouteColor.Copy(deep, copiedObjects, true);
                    else
                        copy.routeColor = this.routeColor.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.RouteColor = (Color)copiedObjects[this.RouteColor];
                    else
                        copy.routeColor = (Color)copiedObjects[this.RouteColor];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UrbanRoute;
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
        protected bool HasSameNonDefaultIdAs(UrbanRoute compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
