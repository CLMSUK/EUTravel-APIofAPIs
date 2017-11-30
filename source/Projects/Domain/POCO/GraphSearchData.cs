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
    /// The GraphSearchData class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class GraphSearchData : IDomainModelClass
    {
        #region GraphSearchData's Fields

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
        [DataMember(Name="AlgorithmName")]
        protected string algorithmName;
        [DataMember(Name="GraphSearchDataKey")]
        protected Guid? graphSearchDataKey = Guid.Empty;
        #endregion
        #region GraphSearchData's Properties
/// <summary>
/// The AlgorithmName property
///
/// </summary>
///
        public virtual string AlgorithmName
        {
            get
            {
                return algorithmName;
            }
            set
            {
                algorithmName = value;
            }
        }
/// <summary>
/// The GraphSearchDataKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? GraphSearchDataKey
        {
            get
            {
                return graphSearchDataKey;
            }
            set
            {
                graphSearchDataKey = value;
            }
        }
        #endregion
        #region GraphSearchData's Participant Properties
        [DataMember(Name="AlgorithmOptimalPathParameters")]
        protected IList<GeoCoordinates> algorithmOptimalPathParameters = new List<GeoCoordinates>();
        public virtual List<GeoCoordinates> AlgorithmOptimalPathParameters
        {
            get
            {
                if (algorithmOptimalPathParameters is GeoCoordinates[])
                {
                    algorithmOptimalPathParameters = algorithmOptimalPathParameters.ToList();
                }
                if (algorithmOptimalPathParameters == null)
                {
                    algorithmOptimalPathParameters = new List<GeoCoordinates>();
                }
                return algorithmOptimalPathParameters.ToList();
            }
            set
            {
                if (algorithmOptimalPathParameters is GeoCoordinates[])
                {
                    algorithmOptimalPathParameters = algorithmOptimalPathParameters.ToList();
                }
                if (algorithmOptimalPathParameters != null)
                {
                    var __itemsToDelete = new List<GeoCoordinates>(algorithmOptimalPathParameters);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveAlgorithmOptimalPathParameters(__item);
                    }
                }
                if(value == null)
                {
                    algorithmOptimalPathParameters = new List<GeoCoordinates>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddAlgorithmOptimalPathParameters(__item);
                }
            }
        }
        public virtual void AddAlgorithmOptimalPathParameters(IList<GeoCoordinates> __items)
        {
            foreach (var __item in __items)
            {
                AddAlgorithmOptimalPathParameters(__item);
            }
        }
        public virtual void AddAlgorithmOptimalPathParameters(GeoCoordinates __item)
        {
            if (__item != null && algorithmOptimalPathParameters!=null && !algorithmOptimalPathParameters.Contains(__item))
            {
                algorithmOptimalPathParameters.Add(__item);
            }
        }

        public virtual void RemoveAlgorithmOptimalPathParameters(GeoCoordinates __item)
        {
            if (__item != null && algorithmOptimalPathParameters!=null && algorithmOptimalPathParameters.Contains(__item))
            {
                algorithmOptimalPathParameters.Remove(__item);
            }
        }
        public virtual void SetAlgorithmOptimalPathParametersAt(GeoCoordinates __item, int __index)
        {
            if (__item == null)
            {
                algorithmOptimalPathParameters[__index] = null;
            }
            else
            {
                algorithmOptimalPathParameters[__index] = __item;
            }
        }

        public virtual void ClearAlgorithmOptimalPathParameters()
        {
            if (algorithmOptimalPathParameters!=null)
            {
                var __itemsToRemove = algorithmOptimalPathParameters.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveAlgorithmOptimalPathParameters(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the GraphSearchData class
/// </summary>
/// <returns>New GraphSearchData object</returns>
/// <remarks></remarks>
        public GraphSearchData()
        {
            if (GraphSearchDataKey == null) GraphSearchDataKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (AlgorithmName != null && AlgorithmName.Length > 100)
            {
                __errors.Add("Length of property 'AlgorithmName' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'GraphSearchData' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [GraphSearchData] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual GraphSearchData Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, GraphSearchData copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (GraphSearchData)copiedObjects[this];
            copy = copy ?? new GraphSearchData();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.GraphSearchDataKey = this.GraphSearchDataKey;
            }
            copy.AlgorithmName = this.AlgorithmName;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.algorithmOptimalPathParameters = new List<GeoCoordinates>();
            if(deep && this.algorithmOptimalPathParameters != null)
            {
                foreach (var __item in this.algorithmOptimalPathParameters)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddAlgorithmOptimalPathParameters(__item);
                        else
                            copy.AddAlgorithmOptimalPathParameters(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddAlgorithmOptimalPathParameters((GeoCoordinates)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as GraphSearchData;
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
                __propertyKeyCache = this.GetType().GetProperty("GraphSearchDataKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.GraphSearchDataKey.GetHashCode();
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
            return this.GraphSearchDataKey == default(Guid) || this.GraphSearchDataKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(GraphSearchData compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.GraphSearchDataKey.Equals(compareTo.GraphSearchDataKey);
        }

        #endregion
    }
}
