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
    /// The Ferry class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Vehicle))]

    public class Ferry : Vehicle, IDomainModelClass
    {
        #region Ferry's Fields
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="FastCraft")]
        protected bool fastCraft;
        [DataMember(Name="ForthCRSId")]
        protected string forthCRSId;
        #endregion
        #region Ferry's Properties
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
/// The FastCraft property
///
/// </summary>
///
        public virtual bool FastCraft
        {
            get
            {
                return fastCraft;
            }
            set
            {
                fastCraft = value;
            }
        }
/// <summary>
/// The ForthCRSId property
///
/// </summary>
///
        public virtual string ForthCRSId
        {
            get
            {
                return forthCRSId;
            }
            set
            {
                forthCRSId = value;
            }
        }
        #endregion
        #region Ferry's Participant Properties
        [DataMember(Name="MarineAgency")]
        protected MarineAgency marineAgency;
        public virtual MarineAgency MarineAgency
        {
            get
            {
                return marineAgency;
            }
            set
            {
                if(Equals(marineAgency, value)) return;
                var __oldValue = marineAgency;
                if (value != null)
                {
                    if(marineAgency != null && !Equals(marineAgency, value))
                        marineAgency.RemoveOwnedFerries(this);
                    marineAgency = value;
                    marineAgency.AddOwnedFerries(this);
                }
                else
                {
                    if(marineAgency != null)
                        marineAgency.RemoveOwnedFerries(this);
                    marineAgency = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Ferry class
/// </summary>
/// <returns>New Ferry object</returns>
/// <remarks></remarks>
        public Ferry(): base() {}
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
            if (ForthCRSId != null && ForthCRSId.Length > 100)
            {
                __errors.Add("Length of property 'ForthCRSId' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Ferry' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Ferry] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Ferry Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Ferry copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Ferry)copiedObjects[this];
            copy = copy ?? new Ferry();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.Name = this.Name;
            copy.FastCraft = this.FastCraft;
            copy.ForthCRSId = this.ForthCRSId;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.marineAgency != null)
            {
                if (!copiedObjects.Contains(this.marineAgency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.MarineAgency = this.MarineAgency;
                    else if (asNew)
                        copy.MarineAgency = this.MarineAgency.Copy(deep, copiedObjects, true);
                    else
                        copy.marineAgency = this.marineAgency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.MarineAgency = (MarineAgency)copiedObjects[this.MarineAgency];
                    else
                        copy.marineAgency = (MarineAgency)copiedObjects[this.MarineAgency];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Ferry;
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
