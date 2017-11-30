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
    /// The TreeNode class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class TreeNode : IDomainModelClass
    {
        #region TreeNode's Fields

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
        [DataMember(Name="responseLevel")]
        protected int? _responseLevel;
        [DataMember(Name="TreeNodeKey")]
        protected Guid? treeNodeKey = Guid.Empty;
        #endregion
        #region TreeNode's Properties
/// <summary>
/// The responseLevel property
///
/// </summary>
///
        public virtual int? responseLevel
        {
            get
            {
                return _responseLevel;
            }
            set
            {
                _responseLevel = value;
            }
        }
/// <summary>
/// The TreeNodeKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? TreeNodeKey
        {
            get
            {
                return treeNodeKey;
            }
            set
            {
                treeNodeKey = value;
            }
        }
        #endregion
        #region TreeNode's Participant Properties
        [DataMember(Name="parentNode")]
        protected TreeNode _parentNode;
        public virtual TreeNode parentNode
        {
            get
            {
                return _parentNode;
            }
            set
            {
                if(Equals(_parentNode, value)) return;
                var __oldValue = _parentNode;
                if (value != null)
                {
                    if(_parentNode != null && !Equals(_parentNode, value))
                        _parentNode.RemovechildrenNodes(this);
                    _parentNode = value;
                    _parentNode.AddchildrenNodes(this);
                }
                else
                {
                    if(_parentNode != null)
                        _parentNode.RemovechildrenNodes(this);
                    _parentNode = null;
                }
            }
        }
        [DataMember(Name="childrenNodes")]
        protected IList<TreeNode> _childrenNodes = new List<TreeNode>();
        public virtual List<TreeNode> childrenNodes
        {
            get
            {
                if (_childrenNodes is TreeNode[])
                {
                    _childrenNodes = _childrenNodes.ToList();
                }
                if (_childrenNodes == null)
                {
                    _childrenNodes = new List<TreeNode>();
                }
                return _childrenNodes.ToList();
            }
            set
            {
                if (_childrenNodes is TreeNode[])
                {
                    _childrenNodes = _childrenNodes.ToList();
                }
                if (_childrenNodes != null)
                {
                    var __itemsToDelete = new List<TreeNode>(_childrenNodes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovechildrenNodes(__item);
                    }
                }
                if(value == null)
                {
                    _childrenNodes = new List<TreeNode>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddchildrenNodes(__item);
                }
            }
        }
        public virtual void AddchildrenNodes(IList<TreeNode> __items)
        {
            foreach (var __item in __items)
            {
                AddchildrenNodes(__item);
            }
        }
        public virtual void AddchildrenNodes(TreeNode __item)
        {
            if (__item != null && _childrenNodes!=null && !_childrenNodes.Contains(__item))
            {
                _childrenNodes.Add(__item);
                if (__item.parentNode != this)
                    __item.parentNode = this;
            }
        }

        public virtual void RemovechildrenNodes(TreeNode __item)
        {
            if (__item != null && _childrenNodes!=null && _childrenNodes.Contains(__item))
            {
                _childrenNodes.Remove(__item);
                __item.parentNode = null;
            }
        }
        public virtual void SetchildrenNodesAt(TreeNode __item, int __index)
        {
            if (__item == null)
            {
                _childrenNodes[__index].parentNode = null;
            }
            else
            {
                _childrenNodes[__index] = __item;
                if (__item.parentNode != this)
                    __item.parentNode = this;
            }
        }

        public virtual void ClearchildrenNodes()
        {
            if (_childrenNodes!=null)
            {
                var __itemsToRemove = _childrenNodes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovechildrenNodes(__item);
                }
            }
        }
        [DataMember(Name="marineSegment")]
        protected MarineSegment _marineSegment;
        public virtual MarineSegment marineSegment
        {
            get
            {
                return _marineSegment;
            }
            set
            {
                if(Equals(_marineSegment, value)) return;
                var __oldValue = _marineSegment;
                if (value != null)
                {
                    _marineSegment = value;
                }
                else
                {
                    if (_marineSegment != null)
                    {
                        _marineSegment = null;
                    }
                }
            }
        }
        [DataMember(Name="railSegment")]
        protected RailSegment _railSegment;
        public virtual RailSegment railSegment
        {
            get
            {
                return _railSegment;
            }
            set
            {
                if(Equals(_railSegment, value)) return;
                var __oldValue = _railSegment;
                if (value != null)
                {
                    _railSegment = value;
                }
                else
                {
                    if (_railSegment != null)
                    {
                        _railSegment = null;
                    }
                }
            }
        }
        [DataMember(Name="flightSegment")]
        protected FlightSegment _flightSegment;
        public virtual FlightSegment flightSegment
        {
            get
            {
                return _flightSegment;
            }
            set
            {
                if(Equals(_flightSegment, value)) return;
                var __oldValue = _flightSegment;
                if (value != null)
                {
                    _flightSegment = value;
                }
                else
                {
                    if (_flightSegment != null)
                    {
                        _flightSegment = null;
                    }
                }
            }
        }
        [DataMember(Name="urbanSegment")]
        protected UrbanSegment _urbanSegment;
        public virtual UrbanSegment urbanSegment
        {
            get
            {
                return _urbanSegment;
            }
            set
            {
                if(Equals(_urbanSegment, value)) return;
                var __oldValue = _urbanSegment;
                if (value != null)
                {
                    _urbanSegment = value;
                }
                else
                {
                    if (_urbanSegment != null)
                    {
                        _urbanSegment = null;
                    }
                }
            }
        }
        [DataMember(Name="solution")]
        protected Solution _solution;
        public virtual Solution solution
        {
            get
            {
                return _solution;
            }
            set
            {
                if(Equals(_solution, value)) return;
                var __oldValue = _solution;
                if (value != null)
                {
                    _solution = value;
                }
                else
                {
                    if (_solution != null)
                    {
                        _solution = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the TreeNode class
/// </summary>
/// <returns>New TreeNode object</returns>
/// <remarks></remarks>
        public TreeNode()
        {
            _responseLevel = -1;
            if (TreeNodeKey == null) TreeNodeKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'TreeNode' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [TreeNode] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual TreeNode Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, TreeNode copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (TreeNode)copiedObjects[this];
            copy = copy ?? new TreeNode();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.TreeNodeKey = this.TreeNodeKey;
            }
            copy.responseLevel = this.responseLevel;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this._parentNode != null)
            {
                if (!copiedObjects.Contains(this._parentNode))
                {
                    if (asNew && reuseNestedObjects)
                        copy.parentNode = this.parentNode;
                    else if (asNew)
                        copy.parentNode = this.parentNode.Copy(deep, copiedObjects, true);
                    else
                        copy._parentNode = this._parentNode.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.parentNode = (TreeNode)copiedObjects[this.parentNode];
                    else
                        copy._parentNode = (TreeNode)copiedObjects[this.parentNode];
                }
            }
            copy._childrenNodes = new List<TreeNode>();
            if(deep && this._childrenNodes != null)
            {
                foreach (var __item in this._childrenNodes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddchildrenNodes(__item);
                        else
                            copy.AddchildrenNodes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddchildrenNodes((TreeNode)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this._marineSegment != null)
            {
                if (!copiedObjects.Contains(this._marineSegment))
                {
                    if (asNew && reuseNestedObjects)
                        copy.marineSegment = this.marineSegment;
                    else if (asNew)
                        copy.marineSegment = this.marineSegment.Copy(deep, copiedObjects, true);
                    else
                        copy._marineSegment = this._marineSegment.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.marineSegment = (MarineSegment)copiedObjects[this.marineSegment];
                    else
                        copy._marineSegment = (MarineSegment)copiedObjects[this.marineSegment];
                }
            }
            if(deep && this._railSegment != null)
            {
                if (!copiedObjects.Contains(this._railSegment))
                {
                    if (asNew && reuseNestedObjects)
                        copy.railSegment = this.railSegment;
                    else if (asNew)
                        copy.railSegment = this.railSegment.Copy(deep, copiedObjects, true);
                    else
                        copy._railSegment = this._railSegment.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.railSegment = (RailSegment)copiedObjects[this.railSegment];
                    else
                        copy._railSegment = (RailSegment)copiedObjects[this.railSegment];
                }
            }
            if(deep && this._flightSegment != null)
            {
                if (!copiedObjects.Contains(this._flightSegment))
                {
                    if (asNew && reuseNestedObjects)
                        copy.flightSegment = this.flightSegment;
                    else if (asNew)
                        copy.flightSegment = this.flightSegment.Copy(deep, copiedObjects, true);
                    else
                        copy._flightSegment = this._flightSegment.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.flightSegment = (FlightSegment)copiedObjects[this.flightSegment];
                    else
                        copy._flightSegment = (FlightSegment)copiedObjects[this.flightSegment];
                }
            }
            if(deep && this._urbanSegment != null)
            {
                if (!copiedObjects.Contains(this._urbanSegment))
                {
                    if (asNew && reuseNestedObjects)
                        copy.urbanSegment = this.urbanSegment;
                    else if (asNew)
                        copy.urbanSegment = this.urbanSegment.Copy(deep, copiedObjects, true);
                    else
                        copy._urbanSegment = this._urbanSegment.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.urbanSegment = (UrbanSegment)copiedObjects[this.urbanSegment];
                    else
                        copy._urbanSegment = (UrbanSegment)copiedObjects[this.urbanSegment];
                }
            }
            if(deep && this._solution != null)
            {
                if (!copiedObjects.Contains(this._solution))
                {
                    if (asNew && reuseNestedObjects)
                        copy.solution = this.solution;
                    else if (asNew)
                        copy.solution = this.solution.Copy(deep, copiedObjects, true);
                    else
                        copy._solution = this._solution.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.solution = (Solution)copiedObjects[this.solution];
                    else
                        copy._solution = (Solution)copiedObjects[this.solution];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as TreeNode;
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
                __propertyKeyCache = this.GetType().GetProperty("TreeNodeKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.TreeNodeKey.GetHashCode();
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
            return this.TreeNodeKey == default(Guid) || this.TreeNodeKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(TreeNode compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.TreeNodeKey.Equals(compareTo.TreeNodeKey);
        }

        #endregion
    }
}
