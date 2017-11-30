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
    /// The RailAgency class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Organization))]

    public class RailAgency : Organization, IDomainModelClass
    {
        #region RailAgency's Fields
        [DataMember(Name="ConditionsOfCarriage")]
        protected string conditionsOfCarriage;
        [DataMember(Name="AcceptedMeansOfPayment")]
        protected string acceptedMeansOfPayment;
        [DataMember(Name="SalesConditions")]
        protected string salesConditions;
        [DataMember(Name="AftersalesConditions")]
        protected string aftersalesConditions;
        [DataMember(Name="ComplaintSubmissionProcedures")]
        protected string complaintSubmissionProcedures;
        [DataMember(Name="SilverRailCode")]
        protected string silverRailCode;
        [DataMember(Name="IsSupplier")]
        protected bool isSupplier;
        #endregion
        #region RailAgency's Properties
/// <summary>
/// The ConditionsOfCarriage property
///
/// </summary>
///
        public virtual string ConditionsOfCarriage
        {
            get
            {
                return conditionsOfCarriage;
            }
            set
            {
                conditionsOfCarriage = value;
            }
        }
/// <summary>
/// The AcceptedMeansOfPayment property
///
/// </summary>
///
        public virtual string AcceptedMeansOfPayment
        {
            get
            {
                return acceptedMeansOfPayment;
            }
            set
            {
                acceptedMeansOfPayment = value;
            }
        }
/// <summary>
/// The SalesConditions property
///
/// </summary>
///
        public virtual string SalesConditions
        {
            get
            {
                return salesConditions;
            }
            set
            {
                salesConditions = value;
            }
        }
/// <summary>
/// The AftersalesConditions property
///
/// </summary>
///
        public virtual string AftersalesConditions
        {
            get
            {
                return aftersalesConditions;
            }
            set
            {
                aftersalesConditions = value;
            }
        }
/// <summary>
/// The ComplaintSubmissionProcedures property
///
/// </summary>
///
        public virtual string ComplaintSubmissionProcedures
        {
            get
            {
                return complaintSubmissionProcedures;
            }
            set
            {
                complaintSubmissionProcedures = value;
            }
        }
/// <summary>
/// The SilverRailCode property
///
/// </summary>
///
        public virtual string SilverRailCode
        {
            get
            {
                return silverRailCode;
            }
            set
            {
                silverRailCode = value;
            }
        }
/// <summary>
/// The IsSupplier property
///
/// </summary>
///
        public virtual bool IsSupplier
        {
            get
            {
                return isSupplier;
            }
            set
            {
                isSupplier = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the RailAgency class
/// </summary>
/// <returns>New RailAgency object</returns>
/// <remarks></remarks>
        public RailAgency(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (ConditionsOfCarriage != null && ConditionsOfCarriage.Length > 2147483647)
            {
                __errors.Add("Length of property 'ConditionsOfCarriage' cannot be greater than 2147483647.");
            }
            if (AcceptedMeansOfPayment != null && AcceptedMeansOfPayment.Length > 2147483647)
            {
                __errors.Add("Length of property 'AcceptedMeansOfPayment' cannot be greater than 2147483647.");
            }
            if (SalesConditions != null && SalesConditions.Length > 2147483647)
            {
                __errors.Add("Length of property 'SalesConditions' cannot be greater than 2147483647.");
            }
            if (AftersalesConditions != null && AftersalesConditions.Length > 2147483647)
            {
                __errors.Add("Length of property 'AftersalesConditions' cannot be greater than 2147483647.");
            }
            if (ComplaintSubmissionProcedures != null && ComplaintSubmissionProcedures.Length > 2147483647)
            {
                __errors.Add("Length of property 'ComplaintSubmissionProcedures' cannot be greater than 2147483647.");
            }
            if (SilverRailCode != null && SilverRailCode.Length > 100)
            {
                __errors.Add("Length of property 'SilverRailCode' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'RailAgency' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [RailAgency] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual RailAgency Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, RailAgency copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (RailAgency)copiedObjects[this];
            copy = copy ?? new RailAgency();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.ConditionsOfCarriage = this.ConditionsOfCarriage;
            copy.AcceptedMeansOfPayment = this.AcceptedMeansOfPayment;
            copy.SalesConditions = this.SalesConditions;
            copy.AftersalesConditions = this.AftersalesConditions;
            copy.ComplaintSubmissionProcedures = this.ComplaintSubmissionProcedures;
            copy.SilverRailCode = this.SilverRailCode;
            copy.IsSupplier = this.IsSupplier;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as RailAgency;
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
