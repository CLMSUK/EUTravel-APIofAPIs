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
    /// The POIResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class POIResponse : IDomainModelClass
    {
        #region POIResponse's Fields

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
        [DataMember(Name="Message")]
        protected string message;
        [DataMember(Name="Likes")]
        protected int? likes;
        [DataMember(Name="POIResponseKey")]
        protected Guid? pOIResponseKey = Guid.Empty;
        #endregion
        #region POIResponse's Properties
/// <summary>
/// The Message property
///
/// </summary>
///
        public virtual string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
/// <summary>
/// The Likes property
///
/// </summary>
///
        public virtual int? Likes
        {
            get
            {
                return likes;
            }
            set
            {
                likes = value;
            }
        }
/// <summary>
/// The POIResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? POIResponseKey
        {
            get
            {
                return pOIResponseKey;
            }
            set
            {
                pOIResponseKey = value;
            }
        }
        #endregion
        #region POIResponse's Participant Properties
        [DataMember(Name="Error")]
        protected Error error;
        public virtual Error Error
        {
            get
            {
                return error;
            }
            set
            {
                if(Equals(error, value)) return;
                var __oldValue = error;
                if (value != null)
                {
                    error = value;
                }
                else
                {
                    if (error != null)
                    {
                        error = null;
                    }
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
                    pointOfInterest = value;
                }
                else
                {
                    pointOfInterest = null;
                }
            }
        }
        [DataMember(Name="PointsOfInterest")]
        protected IList<PointOfInterest> pointsOfInterest = new List<PointOfInterest>();
        public virtual List<PointOfInterest> PointsOfInterest
        {
            get
            {
                if (pointsOfInterest is PointOfInterest[])
                {
                    pointsOfInterest = pointsOfInterest.ToList();
                }
                if (pointsOfInterest == null)
                {
                    pointsOfInterest = new List<PointOfInterest>();
                }
                return pointsOfInterest.ToList();
            }
            set
            {
                if (pointsOfInterest is PointOfInterest[])
                {
                    pointsOfInterest = pointsOfInterest.ToList();
                }
                if (pointsOfInterest != null)
                {
                    var __itemsToDelete = new List<PointOfInterest>(pointsOfInterest);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePointsOfInterest(__item);
                    }
                }
                if(value == null)
                {
                    pointsOfInterest = new List<PointOfInterest>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPointsOfInterest(__item);
                }
            }
        }
        public virtual void AddPointsOfInterest(IList<PointOfInterest> __items)
        {
            foreach (var __item in __items)
            {
                AddPointsOfInterest(__item);
            }
        }
        public virtual void AddPointsOfInterest(PointOfInterest __item)
        {
            if (__item != null && pointsOfInterest!=null && !pointsOfInterest.Contains(__item))
            {
                pointsOfInterest.Add(__item);
            }
        }

        public virtual void RemovePointsOfInterest(PointOfInterest __item)
        {
            if (__item != null && pointsOfInterest!=null && pointsOfInterest.Contains(__item))
            {
                pointsOfInterest.Remove(__item);
            }
        }
        public virtual void SetPointsOfInterestAt(PointOfInterest __item, int __index)
        {
            if (__item == null)
            {
                pointsOfInterest[__index] = null;
            }
            else
            {
                pointsOfInterest[__index] = __item;
            }
        }

        public virtual void ClearPointsOfInterest()
        {
            if (pointsOfInterest!=null)
            {
                var __itemsToRemove = pointsOfInterest.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePointsOfInterest(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the POIResponse class
/// </summary>
/// <returns>New POIResponse object</returns>
/// <remarks></remarks>
        public POIResponse()
        {
            if (POIResponseKey == null) POIResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Message != null && Message.Length > 100)
            {
                __errors.Add("Length of property 'Message' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'POIResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [POIResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual POIResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, POIResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (POIResponse)copiedObjects[this];
            copy = copy ?? new POIResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.POIResponseKey = this.POIResponseKey;
            }
            copy.Message = this.Message;
            copy.Likes = this.Likes;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.error != null)
            {
                if (!copiedObjects.Contains(this.error))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Error = this.Error;
                    else if (asNew)
                        copy.Error = this.Error.Copy(deep, copiedObjects, true);
                    else
                        copy.error = this.error.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Error = (Error)copiedObjects[this.Error];
                    else
                        copy.error = (Error)copiedObjects[this.Error];
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
            copy.pointsOfInterest = new List<PointOfInterest>();
            if(deep && this.pointsOfInterest != null)
            {
                foreach (var __item in this.pointsOfInterest)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPointsOfInterest(__item);
                        else
                            copy.AddPointsOfInterest(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPointsOfInterest((PointOfInterest)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as POIResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("POIResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.POIResponseKey.GetHashCode();
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
            return this.POIResponseKey == default(Guid) || this.POIResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(POIResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.POIResponseKey.Equals(compareTo.POIResponseKey);
        }

        #endregion
    }
}
