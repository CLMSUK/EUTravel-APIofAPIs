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
    /// The GraphResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class GraphResponse : IDomainModelClass
    {
        #region GraphResponse's Fields

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
        [DataMember(Name="MultiElementMode")]
        protected bool multiElementMode;
        [DataMember(Name="ElementType")]
        protected int? elementType;
        [DataMember(Name="ID")]
        protected int? iD;
        [DataMember(Name="KindEnumerator")]
        protected int? kindEnumerator;
        [DataMember(Name="IndexId")]
        protected int? indexId;
        [DataMember(Name="Label")]
        protected string label;
        [DataMember(Name="WasVisited")]
        protected bool wasVisited;
        [DataMember(Name="GraphResponseKey")]
        protected Guid? graphResponseKey = Guid.Empty;
        #endregion
        #region GraphResponse's Properties
/// <summary>
/// The MultiElementMode property
///
/// </summary>
///
        public virtual bool MultiElementMode
        {
            get
            {
                return multiElementMode;
            }
            set
            {
                multiElementMode = value;
            }
        }
/// <summary>
/// The ElementType property
///
/// </summary>
///
        public virtual int? ElementType
        {
            get
            {
                return elementType;
            }
            set
            {
                elementType = value;
            }
        }
/// <summary>
/// The ID property
///
/// </summary>
///
        public virtual int? ID
        {
            get
            {
                return iD;
            }
            set
            {
                iD = value;
            }
        }
/// <summary>
/// The KindEnumerator property
///
/// </summary>
///
        public virtual int? KindEnumerator
        {
            get
            {
                return kindEnumerator;
            }
            set
            {
                kindEnumerator = value;
            }
        }
/// <summary>
/// The IndexId property
///
/// </summary>
///
        public virtual int? IndexId
        {
            get
            {
                return indexId;
            }
            set
            {
                indexId = value;
            }
        }
/// <summary>
/// The Label property
///
/// </summary>
///
        public virtual string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }
/// <summary>
/// The WasVisited property
///
/// </summary>
///
        public virtual bool WasVisited
        {
            get
            {
                return wasVisited;
            }
            set
            {
                wasVisited = value;
            }
        }
/// <summary>
/// The GraphResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? GraphResponseKey
        {
            get
            {
                return graphResponseKey;
            }
            set
            {
                graphResponseKey = value;
            }
        }
        #endregion
        #region GraphResponse's Participant Properties
        [DataMember(Name="ElementData")]
        protected ElementData elementData;
        public virtual ElementData ElementData
        {
            get
            {
                return elementData;
            }
            set
            {
                if(Equals(elementData, value)) return;
                var __oldValue = elementData;
                if (value != null)
                {
                    elementData = value;
                }
                else
                {
                    if (elementData != null)
                    {
                        elementData = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the GraphResponse class
/// </summary>
/// <returns>New GraphResponse object</returns>
/// <remarks></remarks>
        public GraphResponse()
        {
            if (GraphResponseKey == null) GraphResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Label != null && Label.Length > 100)
            {
                __errors.Add("Length of property 'Label' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'GraphResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [GraphResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual GraphResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, GraphResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (GraphResponse)copiedObjects[this];
            copy = copy ?? new GraphResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.GraphResponseKey = this.GraphResponseKey;
            }
            copy.MultiElementMode = this.MultiElementMode;
            copy.ElementType = this.ElementType;
            copy.ID = this.ID;
            copy.KindEnumerator = this.KindEnumerator;
            copy.IndexId = this.IndexId;
            copy.Label = this.Label;
            copy.WasVisited = this.WasVisited;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.elementData != null)
            {
                if (!copiedObjects.Contains(this.elementData))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ElementData = this.ElementData;
                    else if (asNew)
                        copy.ElementData = this.ElementData.Copy(deep, copiedObjects, true);
                    else
                        copy.elementData = this.elementData.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ElementData = (ElementData)copiedObjects[this.ElementData];
                    else
                        copy.elementData = (ElementData)copiedObjects[this.ElementData];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as GraphResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("GraphResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.GraphResponseKey.GetHashCode();
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
            return this.GraphResponseKey == default(Guid) || this.GraphResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(GraphResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.GraphResponseKey.Equals(compareTo.GraphResponseKey);
        }

        #endregion
    }
}
