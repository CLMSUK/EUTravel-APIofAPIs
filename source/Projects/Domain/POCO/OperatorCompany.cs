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
    /// The OperatorCompany class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Organization))]

    [KnownType(typeof(MarineAgency))]

    [KnownType(typeof(UrbanAgency))]

    [KnownType(typeof(Airline))]

    [KnownType(typeof(CoachAgency))]

    public class OperatorCompany : Organization, IDomainModelClass
    {
        #region OperatorCompany's Fields
        [DataMember(Name="BlackListed")]
        protected bool blackListed;
        [DataMember(Name="FareUrl")]
        protected string fareUrl;
        #endregion
        #region OperatorCompany's Properties
/// <summary>
/// The BlackListed property
///Indicates blacklisted carriers which are banned from servicing points to, from and within the European Community.
/// </summary>
///
        public virtual bool BlackListed
        {
            get
            {
                return blackListed;
            }
            set
            {
                blackListed = value;
            }
        }
/// <summary>
/// The FareUrl property
///
/// </summary>
///
        public virtual string FareUrl
        {
            get
            {
                return fareUrl;
            }
            set
            {
                fareUrl = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the OperatorCompany class
/// </summary>
/// <returns>New OperatorCompany object</returns>
/// <remarks></remarks>
        public OperatorCompany(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (FareUrl != null && FareUrl.Length > 200)
            {
                __errors.Add("Length of property 'FareUrl' cannot be greater than 200.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'OperatorCompany' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [OperatorCompany] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual OperatorCompany Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, OperatorCompany copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (OperatorCompany)copiedObjects[this];
            copy = copy ?? new OperatorCompany();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.BlackListed = this.BlackListed;
            copy.FareUrl = this.FareUrl;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as OperatorCompany;
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
