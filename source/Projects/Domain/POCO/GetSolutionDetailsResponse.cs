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
    /// The GetSolutionDetailsResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class GetSolutionDetailsResponse : IDomainModelClass
    {
        #region GetSolutionDetailsResponse's Fields

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
        [DataMember(Name="SolutionId")]
        protected long? solutionId;
        [DataMember(Name="TotalDuration")]
        protected int? totalDuration;
        [DataMember(Name="Currency")]
        protected string currency;
        [DataMember(Name="NetPrice")]
        protected decimal? netPrice;
        [DataMember(Name="Tax")]
        protected decimal? tax;
        [DataMember(Name="StartPoint")]
        protected string startPoint;
        [DataMember(Name="EndPoint")]
        protected string endPoint;
        [DataMember(Name="TotalPrice")]
        protected decimal? totalPrice;
        [DataMember(Name="TotalCO2")]
        protected decimal? totalCO2;
        [DataMember(Name="Departure")]
        protected DateTime? departure;
        [DataMember(Name="Arrival")]
        protected DateTime? arrival;
        [DataMember(Name="GetSolutionDetailsResponseKey")]
        protected Guid? getSolutionDetailsResponseKey = Guid.Empty;
        #endregion
        #region GetSolutionDetailsResponse's Properties
/// <summary>
/// The SolutionId property
///
/// </summary>
///
        public virtual long? SolutionId
        {
            get
            {
                return solutionId;
            }
            set
            {
                solutionId = value;
            }
        }
/// <summary>
/// The TotalDuration property
///
/// </summary>
///
        public virtual int? TotalDuration
        {
            get
            {
                return totalDuration;
            }
            set
            {
                totalDuration = value;
            }
        }
/// <summary>
/// The Currency property
///
/// </summary>
///
        public virtual string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
            }
        }
/// <summary>
/// The NetPrice property
///
/// </summary>
///
        public virtual decimal? NetPrice
        {
            get
            {
                return netPrice;
            }
            set
            {
                netPrice = value;
            }
        }
/// <summary>
/// The Tax property
///
/// </summary>
///
        public virtual decimal? Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }
/// <summary>
/// The StartPoint property
///
/// </summary>
///
        public virtual string StartPoint
        {
            get
            {
                return startPoint;
            }
            set
            {
                startPoint = value;
            }
        }
/// <summary>
/// The EndPoint property
///
/// </summary>
///
        public virtual string EndPoint
        {
            get
            {
                return endPoint;
            }
            set
            {
                endPoint = value;
            }
        }
/// <summary>
/// The TotalPrice property
///
/// </summary>
///
        public virtual decimal? TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
            }
        }
/// <summary>
/// The TotalCO2 property
///
/// </summary>
///
        public virtual decimal? TotalCO2
        {
            get
            {
                return totalCO2;
            }
            set
            {
                totalCO2 = value;
            }
        }
/// <summary>
/// The Departure property
///
/// </summary>
///
        public virtual DateTime? Departure
        {
            get
            {
                return departure;
            }
            set
            {
                departure = value;
            }
        }
/// <summary>
/// The Arrival property
///
/// </summary>
///
        public virtual DateTime? Arrival
        {
            get
            {
                return arrival;
            }
            set
            {
                arrival = value;
            }
        }
/// <summary>
/// The GetSolutionDetailsResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? GetSolutionDetailsResponseKey
        {
            get
            {
                return getSolutionDetailsResponseKey;
            }
            set
            {
                getSolutionDetailsResponseKey = value;
            }
        }
        #endregion
        #region GetSolutionDetailsResponse's Participant Properties
        [DataMember(Name="Error")]
        protected Error error;
        public virtual Error Error
        {
            get
            {
                return error;
            }
            set
            {
                if(Equals(error, value)) return;
                var __oldValue = error;
                if (value != null)
                {
                    error = value;
                }
                else
                {
                    error = null;
                }
            }
        }
        [DataMember(Name="Solution")]
        protected Solution solution;
        public virtual Solution Solution
        {
            get
            {
                return solution;
            }
            set
            {
                if(Equals(solution, value)) return;
                var __oldValue = solution;
                if (value != null)
                {
                    solution = value;
                }
                else
                {
                    solution = null;
                }
            }
        }
        [DataMember(Name="Transports")]
        protected Transports transports;
        public virtual Transports Transports
        {
            get
            {
                return transports;
            }
            set
            {
                if(Equals(transports, value)) return;
                var __oldValue = transports;
                if (value != null)
                {
                    transports = value;
                }
                else
                {
                    if (transports != null)
                    {
                        transports = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the GetSolutionDetailsResponse class
/// </summary>
/// <returns>New GetSolutionDetailsResponse object</returns>
/// <remarks></remarks>
        public GetSolutionDetailsResponse()
        {
            totalPrice = 0M;
            totalCO2 = 0M;
            if (GetSolutionDetailsResponseKey == null) GetSolutionDetailsResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Currency != null && Currency.Length > 100)
            {
                __errors.Add("Length of property 'Currency' cannot be greater than 100.");
            }
            if (StartPoint != null && StartPoint.Length > 100)
            {
                __errors.Add("Length of property 'StartPoint' cannot be greater than 100.");
            }
            if (EndPoint != null && EndPoint.Length > 100)
            {
                __errors.Add("Length of property 'EndPoint' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'GetSolutionDetailsResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [GetSolutionDetailsResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual GetSolutionDetailsResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, GetSolutionDetailsResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (GetSolutionDetailsResponse)copiedObjects[this];
            copy = copy ?? new GetSolutionDetailsResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.GetSolutionDetailsResponseKey = this.GetSolutionDetailsResponseKey;
            }
            copy.SolutionId = this.SolutionId;
            copy.TotalDuration = this.TotalDuration;
            copy.Currency = this.Currency;
            copy.NetPrice = this.NetPrice;
            copy.Tax = this.Tax;
            copy.StartPoint = this.StartPoint;
            copy.EndPoint = this.EndPoint;
            copy.TotalPrice = this.TotalPrice;
            copy.TotalCO2 = this.TotalCO2;
            copy.Departure = this.Departure;
            copy.Arrival = this.Arrival;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.error != null)
            {
                if (!copiedObjects.Contains(this.error))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Error = this.Error;
                    else if (asNew)
                        copy.Error = this.Error.Copy(deep, copiedObjects, true);
                    else
                        copy.error = this.error.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Error = (Error)copiedObjects[this.Error];
                    else
                        copy.error = (Error)copiedObjects[this.Error];
                }
            }
            if(deep && this.solution != null)
            {
                if (!copiedObjects.Contains(this.solution))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Solution = this.Solution;
                    else if (asNew)
                        copy.Solution = this.Solution.Copy(deep, copiedObjects, true);
                    else
                        copy.solution = this.solution.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Solution = (Solution)copiedObjects[this.Solution];
                    else
                        copy.solution = (Solution)copiedObjects[this.Solution];
                }
            }
            
            if(deep && this.transports != null)
            {
                if (!copiedObjects.Contains(this.transports))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Transports = this.Transports;
                    else if (asNew)
                        copy.Transports = this.Transports.Copy(deep, copiedObjects, true);
                    else
                        copy.transports = this.transports.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Transports = (Transports)copiedObjects[this.Transports];
                    else
                        copy.transports = (Transports)copiedObjects[this.Transports];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as GetSolutionDetailsResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("GetSolutionDetailsResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.GetSolutionDetailsResponseKey.GetHashCode();
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
            return this.GetSolutionDetailsResponseKey == default(Guid) || this.GetSolutionDetailsResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(GetSolutionDetailsResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.GetSolutionDetailsResponseKey.Equals(compareTo.GetSolutionDetailsResponseKey);
        }

        #endregion
    }
}
