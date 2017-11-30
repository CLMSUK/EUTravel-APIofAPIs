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
    /// The Photograph class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Photograph : IDomainModelClass
    {
        #region Photograph's Fields

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
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="Url")]
        protected string url;
        [DataMember(Name="File")]
        protected string file;
        [DataMember(Name="IsPublic")]
        protected bool isPublic;
        #endregion
        #region Photograph's Properties
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
/// The Url property
///
/// </summary>
///
        public virtual string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }
/// <summary>
/// The File property
///
/// </summary>
///
        public virtual string File
        {
            get
            {
                return file;
            }
            set
            {
                file = value;
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
        #region Photograph's Participant Properties
        [DataMember(Name="GeoCoordinates")]
        protected GeoCoordinates geoCoordinates;
        public virtual GeoCoordinates GeoCoordinates
        {
            get
            {
                return geoCoordinates;
            }
            set
            {
                if(Equals(geoCoordinates, value)) return;
                var __oldValue = geoCoordinates;
                if (value != null)
                {
                    geoCoordinates = value;
                }
                else
                {
                    geoCoordinates = null;
                }
            }
        }
        [DataMember(Name="TaggedPeople")]
        protected IList<Person> taggedPeople = new List<Person>();
        public virtual List<Person> TaggedPeople
        {
            get
            {
                if (taggedPeople is Person[])
                {
                    taggedPeople = taggedPeople.ToList();
                }
                if (taggedPeople == null)
                {
                    taggedPeople = new List<Person>();
                }
                return taggedPeople.ToList();
            }
            set
            {
                if (taggedPeople is Person[])
                {
                    taggedPeople = taggedPeople.ToList();
                }
                if (taggedPeople != null)
                {
                    var __itemsToDelete = new List<Person>(taggedPeople);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTaggedPeople(__item);
                    }
                }
                if(value == null)
                {
                    taggedPeople = new List<Person>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTaggedPeople(__item);
                }
            }
        }
        public virtual void AddTaggedPeople(IList<Person> __items)
        {
            foreach (var __item in __items)
            {
                AddTaggedPeople(__item);
            }
        }
        public virtual void AddTaggedPeople(Person __item)
        {
            if (__item != null && taggedPeople!=null && !taggedPeople.Contains(__item))
            {
                taggedPeople.Add(__item);
                if (!__item.TaggedIn.Contains(this))
                    __item.AddTaggedIn(this);
            }
        }

        public virtual void RemoveTaggedPeople(Person __item)
        {
            if (__item != null && taggedPeople!=null && taggedPeople.Contains(__item))
            {
                taggedPeople.Remove(__item);
                if(__item.TaggedIn.Contains(this))
                    __item.RemoveTaggedIn(this);
            }
        }
        public virtual void SetTaggedPeopleAt(Person __item, int __index)
        {
            if (__item == null)
            {
                taggedPeople[__index].RemoveTaggedIn(this);
            }
            else
            {
                taggedPeople[__index] = __item;
                if (!__item.TaggedIn.Contains(this))
                    __item.AddTaggedIn(this);
            }
        }

        public virtual void ClearTaggedPeople()
        {
            if (taggedPeople!=null)
            {
                var __itemsToRemove = taggedPeople.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTaggedPeople(__item);
                }
            }
        }
        [DataMember(Name="TakenBy")]
        protected Person takenBy;
        public virtual Person TakenBy
        {
            get
            {
                return takenBy;
            }
            set
            {
                if(Equals(takenBy, value)) return;
                var __oldValue = takenBy;
                if (value != null)
                {
                    if(takenBy != null && !Equals(takenBy, value))
                        takenBy.RemoveMyPhotos(this);
                    takenBy = value;
                    takenBy.AddMyPhotos(this);
                }
                else
                {
                    if(takenBy != null)
                        takenBy.RemoveMyPhotos(this);
                    takenBy = null;
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
                        pointOfInterest.RemovePhotographs(this);
                    pointOfInterest = value;
                    pointOfInterest.AddPhotographs(this);
                }
                else
                {
                    if(pointOfInterest != null)
                        pointOfInterest.RemovePhotographs(this);
                    pointOfInterest = null;
                }
            }
        }
        [DataMember(Name="LikedBy")]
        protected IList<Person> likedBy = new List<Person>();
        public virtual List<Person> LikedBy
        {
            get
            {
                if (likedBy is Person[])
                {
                    likedBy = likedBy.ToList();
                }
                if (likedBy == null)
                {
                    likedBy = new List<Person>();
                }
                return likedBy.ToList();
            }
            set
            {
                if (likedBy is Person[])
                {
                    likedBy = likedBy.ToList();
                }
                if (likedBy != null)
                {
                    var __itemsToDelete = new List<Person>(likedBy);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLikedBy(__item);
                    }
                }
                if(value == null)
                {
                    likedBy = new List<Person>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLikedBy(__item);
                }
            }
        }
        public virtual void AddLikedBy(IList<Person> __items)
        {
            foreach (var __item in __items)
            {
                AddLikedBy(__item);
            }
        }
        public virtual void AddLikedBy(Person __item)
        {
            if (__item != null && likedBy!=null && !likedBy.Contains(__item))
            {
                likedBy.Add(__item);
                if (!__item.LikedPhotos.Contains(this))
                    __item.AddLikedPhotos(this);
            }
        }

        public virtual void RemoveLikedBy(Person __item)
        {
            if (__item != null && likedBy!=null && likedBy.Contains(__item))
            {
                likedBy.Remove(__item);
                if(__item.LikedPhotos.Contains(this))
                    __item.RemoveLikedPhotos(this);
            }
        }
        public virtual void SetLikedByAt(Person __item, int __index)
        {
            if (__item == null)
            {
                likedBy[__index].RemoveLikedPhotos(this);
            }
            else
            {
                likedBy[__index] = __item;
                if (!__item.LikedPhotos.Contains(this))
                    __item.AddLikedPhotos(this);
            }
        }

        public virtual void ClearLikedBy()
        {
            if (likedBy!=null)
            {
                var __itemsToRemove = likedBy.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLikedBy(__item);
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
                        leg.RemovePhotographs(this);
                    leg = value;
                    leg.AddPhotographs(this);
                }
                else
                {
                    if(leg != null)
                        leg.RemovePhotographs(this);
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
                        trip.RemovePhotographs(this);
                    trip = value;
                    trip.AddPhotographs(this);
                }
                else
                {
                    if(trip != null)
                        trip.RemovePhotographs(this);
                    trip = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Photograph class
/// </summary>
/// <returns>New Photograph object</returns>
/// <remarks></remarks>
        public Photograph() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 3000)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 3000.");
            }
            if (Url != null && Url.Length > 100)
            {
                __errors.Add("Length of property 'Url' cannot be greater than 100.");
            }
            if (File != null && File.Length > 1000)
            {
                __errors.Add("Length of property 'File' cannot be greater than 1000.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Photograph' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Photograph] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Photograph Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Photograph copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Photograph)copiedObjects[this];
            copy = copy ?? new Photograph();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Name = this.Name;
            copy.Description = this.Description;
            copy.Url = this.Url;
            copy.File = this.File;
            copy.IsPublic = this.IsPublic;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.geoCoordinates != null)
            {
                if (!copiedObjects.Contains(this.geoCoordinates))
                {
                    if (asNew && reuseNestedObjects)
                        copy.GeoCoordinates = this.GeoCoordinates;
                    else if (asNew)
                        copy.GeoCoordinates = this.GeoCoordinates.Copy(deep, copiedObjects, true);
                    else
                        copy.geoCoordinates = this.geoCoordinates.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.GeoCoordinates = (GeoCoordinates)copiedObjects[this.GeoCoordinates];
                    else
                        copy.geoCoordinates = (GeoCoordinates)copiedObjects[this.GeoCoordinates];
                }
            }
            copy.taggedPeople = new List<Person>();
            if(deep && this.taggedPeople != null)
            {
                foreach (var __item in this.taggedPeople)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTaggedPeople(__item);
                        else
                            copy.AddTaggedPeople(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTaggedPeople((Person)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.takenBy != null)
            {
                if (!copiedObjects.Contains(this.takenBy))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TakenBy = this.TakenBy;
                    else if (asNew)
                        copy.TakenBy = this.TakenBy.Copy(deep, copiedObjects, true);
                    else
                        copy.takenBy = this.takenBy.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TakenBy = (Person)copiedObjects[this.TakenBy];
                    else
                        copy.takenBy = (Person)copiedObjects[this.TakenBy];
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
            copy.likedBy = new List<Person>();
            if(deep && this.likedBy != null)
            {
                foreach (var __item in this.likedBy)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLikedBy(__item);
                        else
                            copy.AddLikedBy(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLikedBy((Person)copiedObjects[__item]);
                    }
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
            var compareTo = obj as Photograph;
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
        protected bool HasSameNonDefaultIdAs(Photograph compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
