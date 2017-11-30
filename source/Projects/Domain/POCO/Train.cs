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
    /// The Train class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Vehicle))]

    public class Train : Vehicle, IDomainModelClass
    {
        #region Train's Fields
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="BikesAllowed")]
        protected bool bikesAllowed;
        [DataMember(Name="CarsAllowed")]
        protected bool carsAllowed;
        #endregion
        #region Train's Properties
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
/// The BikesAllowed property
///
/// </summary>
///
        public virtual bool BikesAllowed
        {
            get
            {
                return bikesAllowed;
            }
            set
            {
                bikesAllowed = value;
            }
        }
/// <summary>
/// The CarsAllowed property
///
/// </summary>
///
        public virtual bool CarsAllowed
        {
            get
            {
                return carsAllowed;
            }
            set
            {
                carsAllowed = value;
            }
        }
        #endregion
        #region Train's Participant Properties
        [DataMember(Name="RailRoute")]
        protected IList<RailRoute> railRoute = new List<RailRoute>();
        public virtual List<RailRoute> RailRoute
        {
            get
            {
                if (railRoute is RailRoute[])
                {
                    railRoute = railRoute.ToList();
                }
                if (railRoute == null)
                {
                    railRoute = new List<RailRoute>();
                }
                return railRoute.ToList();
            }
            set
            {
                if (railRoute is RailRoute[])
                {
                    railRoute = railRoute.ToList();
                }
                if (railRoute != null)
                {
                    var __itemsToDelete = new List<RailRoute>(railRoute);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveRailRoute(__item);
                    }
                }
                if(value == null)
                {
                    railRoute = new List<RailRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddRailRoute(__item);
                }
            }
        }
        public virtual void AddRailRoute(IList<RailRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddRailRoute(__item);
            }
        }
        public virtual void AddRailRoute(RailRoute __item)
        {
            if (__item != null && railRoute!=null && !railRoute.Contains(__item))
            {
                railRoute.Add(__item);
                if (__item.Train != this)
                    __item.Train = this;
            }
        }

        public virtual void RemoveRailRoute(RailRoute __item)
        {
            if (__item != null && railRoute!=null && railRoute.Contains(__item))
            {
                railRoute.Remove(__item);
                __item.Train = null;
            }
        }
        public virtual void SetRailRouteAt(RailRoute __item, int __index)
        {
            if (__item == null)
            {
                railRoute[__index].Train = null;
            }
            else
            {
                railRoute[__index] = __item;
                if (__item.Train != this)
                    __item.Train = this;
            }
        }

        public virtual void ClearRailRoute()
        {
            if (railRoute!=null)
            {
                var __itemsToRemove = railRoute.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveRailRoute(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Train class
/// </summary>
/// <returns>New Train object</returns>
/// <remarks></remarks>
        public Train(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Train' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Train] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Train Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Train copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Train)copiedObjects[this];
            copy = copy ?? new Train();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.Name = this.Name;
            copy.BikesAllowed = this.BikesAllowed;
            copy.CarsAllowed = this.CarsAllowed;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.railRoute = new List<RailRoute>();
            if(deep && this.railRoute != null)
            {
                foreach (var __item in this.railRoute)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddRailRoute(__item);
                        else
                            copy.AddRailRoute(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddRailRoute((RailRoute)copiedObjects[__item]);
                    }
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Train;
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
