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
    /// The UrbanAgency class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(OperatorCompany))]

    public class UrbanAgency : OperatorCompany, IDomainModelClass
    {
        #region UrbanAgency's Fields
        [DataMember(Name="GTFSId")]
        protected string gTFSId;
        #endregion
        #region UrbanAgency's Properties
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
        #endregion
        #region UrbanAgency's Participant Properties
        [DataMember(Name="UrbanLines")]
        protected IList<UrbanRoute> urbanLines = new List<UrbanRoute>();
        public virtual List<UrbanRoute> UrbanLines
        {
            get
            {
                if (urbanLines is UrbanRoute[])
                {
                    urbanLines = urbanLines.ToList();
                }
                if (urbanLines == null)
                {
                    urbanLines = new List<UrbanRoute>();
                }
                return urbanLines.ToList();
            }
            set
            {
                if (urbanLines is UrbanRoute[])
                {
                    urbanLines = urbanLines.ToList();
                }
                if (urbanLines != null)
                {
                    var __itemsToDelete = new List<UrbanRoute>(urbanLines);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUrbanLines(__item);
                    }
                }
                if(value == null)
                {
                    urbanLines = new List<UrbanRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUrbanLines(__item);
                }
            }
        }
        public virtual void AddUrbanLines(IList<UrbanRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddUrbanLines(__item);
            }
        }
        public virtual void AddUrbanLines(UrbanRoute __item)
        {
            if (__item != null && urbanLines!=null && !urbanLines.Contains(__item))
            {
                urbanLines.Add(__item);
                if (__item.UrbanAgency != this)
                    __item.UrbanAgency = this;
            }
        }

        public virtual void RemoveUrbanLines(UrbanRoute __item)
        {
            if (__item != null && urbanLines!=null && urbanLines.Contains(__item))
            {
                urbanLines.Remove(__item);
                __item.UrbanAgency = null;
            }
        }
        public virtual void SetUrbanLinesAt(UrbanRoute __item, int __index)
        {
            if (__item == null)
            {
                urbanLines[__index].UrbanAgency = null;
            }
            else
            {
                urbanLines[__index] = __item;
                if (__item.UrbanAgency != this)
                    __item.UrbanAgency = this;
            }
        }

        public virtual void ClearUrbanLines()
        {
            if (urbanLines!=null)
            {
                var __itemsToRemove = urbanLines.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUrbanLines(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UrbanAgency class
/// </summary>
/// <returns>New UrbanAgency object</returns>
/// <remarks></remarks>
        public UrbanAgency(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (GTFSId != null && GTFSId.Length > 100)
            {
                __errors.Add("Length of property 'GTFSId' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UrbanAgency' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UrbanAgency] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UrbanAgency Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UrbanAgency copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UrbanAgency)copiedObjects[this];
            copy = copy ?? new UrbanAgency();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.GTFSId = this.GTFSId;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.urbanLines = new List<UrbanRoute>();
            if(deep && this.urbanLines != null)
            {
                foreach (var __item in this.urbanLines)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUrbanLines(__item);
                        else
                            copy.AddUrbanLines(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUrbanLines((UrbanRoute)copiedObjects[__item]);
                    }
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UrbanAgency;
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
