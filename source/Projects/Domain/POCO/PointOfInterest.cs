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
    /// The PointOfInterest class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Location))]

    public class PointOfInterest : Location, IDomainModelClass
    {
        #region PointOfInterest's Fields
        [DataMember(Name="IsPublic")]
        protected bool isPublic;
        #endregion
        #region PointOfInterest's Properties
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
        #region PointOfInterest's Participant Properties
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
                if (!__item.LikedPointsOfInterest.Contains(this))
                    __item.AddLikedPointsOfInterest(this);
            }
        }

        public virtual void RemoveLikedBy(Person __item)
        {
            if (__item != null && likedBy!=null && likedBy.Contains(__item))
            {
                likedBy.Remove(__item);
                if(__item.LikedPointsOfInterest.Contains(this))
                    __item.RemoveLikedPointsOfInterest(this);
            }
        }
        public virtual void SetLikedByAt(Person __item, int __index)
        {
            if (__item == null)
            {
                likedBy[__index].RemoveLikedPointsOfInterest(this);
            }
            else
            {
                likedBy[__index] = __item;
                if (!__item.LikedPointsOfInterest.Contains(this))
                    __item.AddLikedPointsOfInterest(this);
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
        [DataMember(Name="Photographs")]
        protected IList<Photograph> photographs = new List<Photograph>();
        public virtual List<Photograph> Photographs
        {
            get
            {
                if (photographs is Photograph[])
                {
                    photographs = photographs.ToList();
                }
                if (photographs == null)
                {
                    photographs = new List<Photograph>();
                }
                return photographs.ToList();
            }
            set
            {
                if (photographs is Photograph[])
                {
                    photographs = photographs.ToList();
                }
                if (photographs != null)
                {
                    var __itemsToDelete = new List<Photograph>(photographs);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePhotographs(__item);
                    }
                }
                if(value == null)
                {
                    photographs = new List<Photograph>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPhotographs(__item);
                }
            }
        }
        public virtual void AddPhotographs(IList<Photograph> __items)
        {
            foreach (var __item in __items)
            {
                AddPhotographs(__item);
            }
        }
        public virtual void AddPhotographs(Photograph __item)
        {
            if (__item != null && photographs!=null && !photographs.Contains(__item))
            {
                photographs.Add(__item);
                if (__item.PointOfInterest != this)
                    __item.PointOfInterest = this;
            }
        }

        public virtual void RemovePhotographs(Photograph __item)
        {
            if (__item != null && photographs!=null && photographs.Contains(__item))
            {
                photographs.Remove(__item);
                __item.PointOfInterest = null;
            }
        }
        public virtual void SetPhotographsAt(Photograph __item, int __index)
        {
            if (__item == null)
            {
                photographs[__index].PointOfInterest = null;
            }
            else
            {
                photographs[__index] = __item;
                if (__item.PointOfInterest != this)
                    __item.PointOfInterest = this;
            }
        }

        public virtual void ClearPhotographs()
        {
            if (photographs!=null)
            {
                var __itemsToRemove = photographs.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePhotographs(__item);
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
                        leg.RemovePointOfInterest(this);
                    leg = value;
                    leg.AddPointOfInterest(this);
                }
                else
                {
                    if(leg != null)
                        leg.RemovePointOfInterest(this);
                    leg = null;
                }
            }
        }
        [DataMember(Name="Notes")]
        protected IList<Note> notes = new List<Note>();
        public virtual List<Note> Notes
        {
            get
            {
                if (notes is Note[])
                {
                    notes = notes.ToList();
                }
                if (notes == null)
                {
                    notes = new List<Note>();
                }
                return notes.ToList();
            }
            set
            {
                if (notes is Note[])
                {
                    notes = notes.ToList();
                }
                if (notes != null)
                {
                    var __itemsToDelete = new List<Note>(notes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveNotes(__item);
                    }
                }
                if(value == null)
                {
                    notes = new List<Note>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddNotes(__item);
                }
            }
        }
        public virtual void AddNotes(IList<Note> __items)
        {
            foreach (var __item in __items)
            {
                AddNotes(__item);
            }
        }
        public virtual void AddNotes(Note __item)
        {
            if (__item != null && notes!=null && !notes.Contains(__item))
            {
                notes.Add(__item);
                if (__item.PointOfInterest != this)
                    __item.PointOfInterest = this;
            }
        }

        public virtual void RemoveNotes(Note __item)
        {
            if (__item != null && notes!=null && notes.Contains(__item))
            {
                notes.Remove(__item);
                __item.PointOfInterest = null;
            }
        }
        public virtual void SetNotesAt(Note __item, int __index)
        {
            if (__item == null)
            {
                notes[__index].PointOfInterest = null;
            }
            else
            {
                notes[__index] = __item;
                if (__item.PointOfInterest != this)
                    __item.PointOfInterest = this;
            }
        }

        public virtual void ClearNotes()
        {
            if (notes!=null)
            {
                var __itemsToRemove = notes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveNotes(__item);
                }
            }
        }
        [DataMember(Name="UploadedBy")]
        protected Person uploadedBy;
        public virtual Person UploadedBy
        {
            get
            {
                return uploadedBy;
            }
            set
            {
                if(Equals(uploadedBy, value)) return;
                var __oldValue = uploadedBy;
                if (value != null)
                {
                    if(uploadedBy != null && !Equals(uploadedBy, value))
                        uploadedBy.RemoveUploadedPointsOfInterest(this);
                    uploadedBy = value;
                    uploadedBy.AddUploadedPointsOfInterest(this);
                }
                else
                {
                    if(uploadedBy != null)
                        uploadedBy.RemoveUploadedPointsOfInterest(this);
                    uploadedBy = null;
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
                        trip.RemovePointsOfInterest(this);
                    trip = value;
                    trip.AddPointsOfInterest(this);
                }
                else
                {
                    if(trip != null)
                        trip.RemovePointsOfInterest(this);
                    trip = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the PointOfInterest class
/// </summary>
/// <returns>New PointOfInterest object</returns>
/// <remarks></remarks>
        public PointOfInterest(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'PointOfInterest' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [PointOfInterest] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual PointOfInterest Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, PointOfInterest copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (PointOfInterest)copiedObjects[this];
            copy = copy ?? new PointOfInterest();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.IsPublic = this.IsPublic;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
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
            copy.photographs = new List<Photograph>();
            if(deep && this.photographs != null)
            {
                foreach (var __item in this.photographs)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPhotographs(__item);
                        else
                            copy.AddPhotographs(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPhotographs((Photograph)copiedObjects[__item]);
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
            copy.notes = new List<Note>();
            if(deep && this.notes != null)
            {
                foreach (var __item in this.notes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddNotes(__item);
                        else
                            copy.AddNotes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddNotes((Note)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.uploadedBy != null)
            {
                if (!copiedObjects.Contains(this.uploadedBy))
                {
                    if (asNew && reuseNestedObjects)
                        copy.UploadedBy = this.UploadedBy;
                    else if (asNew)
                        copy.UploadedBy = this.UploadedBy.Copy(deep, copiedObjects, true);
                    else
                        copy.uploadedBy = this.uploadedBy.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.UploadedBy = (Person)copiedObjects[this.UploadedBy];
                    else
                        copy.uploadedBy = (Person)copiedObjects[this.UploadedBy];
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
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as PointOfInterest;
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
