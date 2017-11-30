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
    /// The CoachAgency class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(OperatorCompany))]

    public class CoachAgency : OperatorCompany, IDomainModelClass
    {
        #region CoachAgency's Fields
        [DataMember(Name="DistribusionCode")]
        protected string distribusionCode;
        #endregion
        #region CoachAgency's Properties
/// <summary>
/// The DistribusionCode property
///
/// </summary>
///
        public virtual string DistribusionCode
        {
            get
            {
                return distribusionCode;
            }
            set
            {
                distribusionCode = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the CoachAgency class
/// </summary>
/// <returns>New CoachAgency object</returns>
/// <remarks></remarks>
        public CoachAgency(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (DistribusionCode != null && DistribusionCode.Length > 100)
            {
                __errors.Add("Length of property 'DistribusionCode' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'CoachAgency' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [CoachAgency] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual CoachAgency Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, CoachAgency copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (CoachAgency)copiedObjects[this];
            copy = copy ?? new CoachAgency();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.DistribusionCode = this.DistribusionCode;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as CoachAgency;
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
