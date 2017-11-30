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
    /// The NCSRDDoorToDoorRoot class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class NCSRDDoorToDoorRoot : IDomainModelClass
    {
        #region NCSRDDoorToDoorRoot's Fields

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
        [DataMember(Name="NCSRDDoorToDoorRootKey")]
        protected Guid? nCSRDDoorToDoorRootKey = Guid.Empty;
        #endregion
        #region NCSRDDoorToDoorRoot's Properties
/// <summary>
/// The NCSRDDoorToDoorRootKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? NCSRDDoorToDoorRootKey
        {
            get
            {
                return nCSRDDoorToDoorRootKey;
            }
            set
            {
                nCSRDDoorToDoorRootKey = value;
            }
        }
        #endregion
        #region NCSRDDoorToDoorRoot's Participant Properties
        [DataMember(Name="plan")]
        protected plan _plan;
        public virtual plan plan
        {
            get
            {
                return _plan;
            }
            set
            {
                if(Equals(_plan, value)) return;
                var __oldValue = _plan;
                if (value != null)
                {
                    _plan = value;
                }
                else
                {
                    if (_plan != null)
                    {
                        _plan = null;
                    }
                }
            }
        }
        [DataMember(Name="requestParameters")]
        protected requestParameters _requestParameters;
        public virtual requestParameters requestParameters
        {
            get
            {
                return _requestParameters;
            }
            set
            {
                if(Equals(_requestParameters, value)) return;
                var __oldValue = _requestParameters;
                if (value != null)
                {
                    _requestParameters = value;
                }
                else
                {
                    if (_requestParameters != null)
                    {
                        _requestParameters = null;
                    }
                }
            }
        }
        [DataMember(Name="error")]
        protected D2DError _error;
        public virtual D2DError error
        {
            get
            {
                return _error;
            }
            set
            {
                if(Equals(_error, value)) return;
                var __oldValue = _error;
                if (value != null)
                {
                    _error = value;
                }
                else
                {
                    if (_error != null)
                    {
                        _error = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the NCSRDDoorToDoorRoot class
/// </summary>
/// <returns>New NCSRDDoorToDoorRoot object</returns>
/// <remarks></remarks>
        public NCSRDDoorToDoorRoot()
        {
            if (NCSRDDoorToDoorRootKey == null) NCSRDDoorToDoorRootKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'NCSRDDoorToDoorRoot' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [NCSRDDoorToDoorRoot] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual NCSRDDoorToDoorRoot Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, NCSRDDoorToDoorRoot copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (NCSRDDoorToDoorRoot)copiedObjects[this];
            copy = copy ?? new NCSRDDoorToDoorRoot();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.NCSRDDoorToDoorRootKey = this.NCSRDDoorToDoorRootKey;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this._plan != null)
            {
                if (!copiedObjects.Contains(this._plan))
                {
                    if (asNew && reuseNestedObjects)
                        copy.plan = this.plan;
                    else if (asNew)
                        copy.plan = this.plan.Copy(deep, copiedObjects, true);
                    else
                        copy._plan = this._plan.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.plan = (plan)copiedObjects[this.plan];
                    else
                        copy._plan = (plan)copiedObjects[this.plan];
                }
            }
            if(deep && this._requestParameters != null)
            {
                if (!copiedObjects.Contains(this._requestParameters))
                {
                    if (asNew && reuseNestedObjects)
                        copy.requestParameters = this.requestParameters;
                    else if (asNew)
                        copy.requestParameters = this.requestParameters.Copy(deep, copiedObjects, true);
                    else
                        copy._requestParameters = this._requestParameters.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.requestParameters = (requestParameters)copiedObjects[this.requestParameters];
                    else
                        copy._requestParameters = (requestParameters)copiedObjects[this.requestParameters];
                }
            }
            if(deep && this._error != null)
            {
                if (!copiedObjects.Contains(this._error))
                {
                    if (asNew && reuseNestedObjects)
                        copy.error = this.error;
                    else if (asNew)
                        copy.error = this.error.Copy(deep, copiedObjects, true);
                    else
                        copy._error = this._error.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.error = (D2DError)copiedObjects[this.error];
                    else
                        copy._error = (D2DError)copiedObjects[this.error];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as NCSRDDoorToDoorRoot;
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
                __propertyKeyCache = this.GetType().GetProperty("NCSRDDoorToDoorRootKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.NCSRDDoorToDoorRootKey.GetHashCode();
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
            return this.NCSRDDoorToDoorRootKey == default(Guid) || this.NCSRDDoorToDoorRootKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(NCSRDDoorToDoorRoot compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.NCSRDDoorToDoorRootKey.Equals(compareTo.NCSRDDoorToDoorRootKey);
        }

        #endregion
    }
}
