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
    /// The Note class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Note : IDomainModelClass
    {
        #region Note's Fields

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
        [DataMember(Name="Title")]
        protected string title;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="IsPublic")]
        protected bool isPublic;
        #endregion
        #region Note's Properties
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
/// The Title property
///
/// </summary>
///
        public virtual string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
/// <summary>
/// The Description property
///
/// </summary>
///
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
/// <summary>
/// The IsPublic property
///
/// </summary>
///
        public virtual bool IsPublic
        {
            get
            {
                return isPublic;
            }
            set
            {
                isPublic = value;
            }
        }
        #endregion
        #region Note's Participant Properties
        [DataMember(Name="CreatedBy")]
        protected Person createdBy;
        public virtual Person CreatedBy
        {
            get
            {
                return createdBy;
            }
            set
            {
                if(Equals(createdBy, value)) return;
                var __oldValue = createdBy;
                if (value != null)
                {
                    if(createdBy != null && !Equals(createdBy, value))
                        createdBy.RemoveNotes(this);
                    createdBy = value;
                    createdBy.AddNotes(this);
                }
                else
                {
                    if(createdBy != null)
                        createdBy.RemoveNotes(this);
                    createdBy = null;
                }
            }
        }
        [DataMember(Name="PointOfInterest")]
        protected PointOfInterest pointOfInterest;
        public virtual PointOfInterest PointOfInterest
        {
            get
            {
                return pointOfInterest;
            }
            set
            {
                if(Equals(pointOfInterest, value)) return;
                var __oldValue = pointOfInterest;
                if (value != null)
                {
                    if(pointOfInterest != null && !Equals(pointOfInterest, value))
                        pointOfInterest.RemoveNotes(this);
                    pointOfInterest = value;
                    pointOfInterest.AddNotes(this);
                }
                else
                {
                    if(pointOfInterest != null)
                        pointOfInterest.RemoveNotes(this);
                    pointOfInterest = null;
                }
            }
        }
        [DataMember(Name="Leg")]
        protected Leg leg;
        public virtual Leg Leg
        {
            get
            {
                return leg;
            }
            set
            {
                if(Equals(leg, value)) return;
                var __oldValue = leg;
                if (value != null)
                {
                    if(leg != null && !Equals(leg, value))
                        leg.RemoveNotes(this);
                    leg = value;
                    leg.AddNotes(this);
                }
                else
                {
                    if(leg != null)
                        leg.RemoveNotes(this);
                    leg = null;
                }
            }
        }
        [DataMember(Name="Trip")]
        protected Trip trip;
        public virtual Trip Trip
        {
            get
            {
                return trip;
            }
            set
            {
                if(Equals(trip, value)) return;
                var __oldValue = trip;
                if (value != null)
                {
                    if(trip != null && !Equals(trip, value))
                        trip.RemoveNotes(this);
                    trip = value;
                    trip.AddNotes(this);
                }
                else
                {
                    if(trip != null)
                        trip.RemoveNotes(this);
                    trip = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Note class
/// </summary>
/// <returns>New Note object</returns>
/// <remarks></remarks>
        public Note() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Title != null && Title.Length > 100)
            {
                __errors.Add("Length of property 'Title' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 1000)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 1000.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Note' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Note] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Note Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Note copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Note)copiedObjects[this];
            copy = copy ?? new Note();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Title = this.Title;
            copy.Description = this.Description;
            copy.IsPublic = this.IsPublic;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.createdBy != null)
            {
                if (!copiedObjects.Contains(this.createdBy))
                {
                    if (asNew && reuseNestedObjects)
                        copy.CreatedBy = this.CreatedBy;
                    else if (asNew)
                        copy.CreatedBy = this.CreatedBy.Copy(deep, copiedObjects, true);
                    else
                        copy.createdBy = this.createdBy.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.CreatedBy = (Person)copiedObjects[this.CreatedBy];
                    else
                        copy.createdBy = (Person)copiedObjects[this.CreatedBy];
                }
            }
            if(deep && this.pointOfInterest != null)
            {
                if (!copiedObjects.Contains(this.pointOfInterest))
                {
                    if (asNew && reuseNestedObjects)
                        copy.PointOfInterest = this.PointOfInterest;
                    else if (asNew)
                        copy.PointOfInterest = this.PointOfInterest.Copy(deep, copiedObjects, true);
                    else
                        copy.pointOfInterest = this.pointOfInterest.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.PointOfInterest = (PointOfInterest)copiedObjects[this.PointOfInterest];
                    else
                        copy.pointOfInterest = (PointOfInterest)copiedObjects[this.PointOfInterest];
                }
            }
            if(deep && this.leg != null)
            {
                if (!copiedObjects.Contains(this.leg))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Leg = this.Leg;
                    else if (asNew)
                        copy.Leg = this.Leg.Copy(deep, copiedObjects, true);
                    else
                        copy.leg = this.leg.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Leg = (Leg)copiedObjects[this.Leg];
                    else
                        copy.leg = (Leg)copiedObjects[this.Leg];
                }
            }
            if(deep && this.trip != null)
            {
                if (!copiedObjects.Contains(this.trip))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Trip = this.Trip;
                    else if (asNew)
                        copy.Trip = this.Trip.Copy(deep, copiedObjects, true);
                    else
                        copy.trip = this.trip.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Trip = (Trip)copiedObjects[this.Trip];
                    else
                        copy.trip = (Trip)copiedObjects[this.Trip];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Note;
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
        protected bool HasSameNonDefaultIdAs(Note compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
