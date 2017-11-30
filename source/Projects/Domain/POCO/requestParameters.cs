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
    /// The requestParameters class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class requestParameters : IDomainModelClass
    {
        #region requestParameters's Fields

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
        [DataMember(Name="body")]
        protected string _body;
        [DataMember(Name="date")]
        protected string _date;
        [DataMember(Name="fromPlace")]
        protected string _fromPlace;
        [DataMember(Name="maxWalkDistance")]
        protected string _maxWalkDistance;
        [DataMember(Name="mode")]
        protected string _mode;
        [DataMember(Name="optimize")]
        protected string _optimize;
        [DataMember(Name="showIntermediateStops")]
        protected string _showIntermediateStops;
        [DataMember(Name="time")]
        protected string _time;
        [DataMember(Name="toPlace")]
        protected string _toPlace;
        [DataMember(Name="requestParametersKey")]
        protected Guid? _requestParametersKey = Guid.Empty;
        #endregion
        #region requestParameters's Properties
/// <summary>
/// The body property
///
/// </summary>
///
        public virtual string body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
            }
        }
/// <summary>
/// The date property
///
/// </summary>
///
        public virtual string date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
/// <summary>
/// The fromPlace property
///
/// </summary>
///
        public virtual string fromPlace
        {
            get
            {
                return _fromPlace;
            }
            set
            {
                _fromPlace = value;
            }
        }
/// <summary>
/// The maxWalkDistance property
///
/// </summary>
///
        public virtual string maxWalkDistance
        {
            get
            {
                return _maxWalkDistance;
            }
            set
            {
                _maxWalkDistance = value;
            }
        }
/// <summary>
/// The mode property
///
/// </summary>
///
        public virtual string mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
            }
        }
/// <summary>
/// The optimize property
///
/// </summary>
///
        public virtual string optimize
        {
            get
            {
                return _optimize;
            }
            set
            {
                _optimize = value;
            }
        }
/// <summary>
/// The showIntermediateStops property
///
/// </summary>
///
        public virtual string showIntermediateStops
        {
            get
            {
                return _showIntermediateStops;
            }
            set
            {
                _showIntermediateStops = value;
            }
        }
/// <summary>
/// The time property
///
/// </summary>
///
        public virtual string time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }
/// <summary>
/// The toPlace property
///
/// </summary>
///
        public virtual string toPlace
        {
            get
            {
                return _toPlace;
            }
            set
            {
                _toPlace = value;
            }
        }
/// <summary>
/// The requestParametersKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? requestParametersKey
        {
            get
            {
                return _requestParametersKey;
            }
            set
            {
                _requestParametersKey = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the requestParameters class
/// </summary>
/// <returns>New requestParameters object</returns>
/// <remarks></remarks>
        public requestParameters()
        {
            if (requestParametersKey == null) requestParametersKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (body != null && body.Length > 100)
            {
                __errors.Add("Length of property 'body' cannot be greater than 100.");
            }
            if (date != null && date.Length > 100)
            {
                __errors.Add("Length of property 'date' cannot be greater than 100.");
            }
            if (fromPlace != null && fromPlace.Length > 100)
            {
                __errors.Add("Length of property 'fromPlace' cannot be greater than 100.");
            }
            if (maxWalkDistance != null && maxWalkDistance.Length > 100)
            {
                __errors.Add("Length of property 'maxWalkDistance' cannot be greater than 100.");
            }
            if (mode != null && mode.Length > 100)
            {
                __errors.Add("Length of property 'mode' cannot be greater than 100.");
            }
            if (optimize != null && optimize.Length > 100)
            {
                __errors.Add("Length of property 'optimize' cannot be greater than 100.");
            }
            if (showIntermediateStops != null && showIntermediateStops.Length > 100)
            {
                __errors.Add("Length of property 'showIntermediateStops' cannot be greater than 100.");
            }
            if (time != null && time.Length > 100)
            {
                __errors.Add("Length of property 'time' cannot be greater than 100.");
            }
            if (toPlace != null && toPlace.Length > 100)
            {
                __errors.Add("Length of property 'toPlace' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'requestParameters' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [requestParameters] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual requestParameters Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, requestParameters copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (requestParameters)copiedObjects[this];
            copy = copy ?? new requestParameters();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.requestParametersKey = this.requestParametersKey;
            }
            copy.body = this.body;
            copy.date = this.date;
            copy.fromPlace = this.fromPlace;
            copy.maxWalkDistance = this.maxWalkDistance;
            copy.mode = this.mode;
            copy.optimize = this.optimize;
            copy.showIntermediateStops = this.showIntermediateStops;
            copy.time = this.time;
            copy.toPlace = this.toPlace;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as requestParameters;
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
                __propertyKeyCache = this.GetType().GetProperty("requestParametersKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.requestParametersKey.GetHashCode();
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
            return this.requestParametersKey == default(Guid) || this.requestParametersKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(requestParameters compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.requestParametersKey.Equals(compareTo.requestParametersKey);
        }

        #endregion
    }
}
