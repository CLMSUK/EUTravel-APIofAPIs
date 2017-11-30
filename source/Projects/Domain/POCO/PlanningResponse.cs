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
    /// The PlanningResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class PlanningResponse : IDomainModelClass
    {
        #region PlanningResponse's Fields

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
        [DataMember(Name="SessionIdentifier")]
        protected Guid? sessionIdentifier;
        [DataMember(Name="PlanningResponseKey")]
        protected Guid? planningResponseKey = Guid.Empty;
        #endregion
        #region PlanningResponse's Properties
/// <summary>
/// The SessionIdentifier property
///
/// </summary>
///
        public virtual Guid? SessionIdentifier
        {
            get
            {
                return sessionIdentifier;
            }
            set
            {
                sessionIdentifier = value;
            }
        }
/// <summary>
/// The PlanningResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? PlanningResponseKey
        {
            get
            {
                return planningResponseKey;
            }
            set
            {
                planningResponseKey = value;
            }
        }
        #endregion
        #region PlanningResponse's Participant Properties
        [DataMember(Name="Solutions")]
        protected IList<GetSolutionDetailsResponse> solutions = new List<GetSolutionDetailsResponse>();
        public virtual List<GetSolutionDetailsResponse> Solutions
        {
            get
            {
                if (solutions is GetSolutionDetailsResponse[])
                {
                    solutions = solutions.ToList();
                }
                if (solutions == null)
                {
                    solutions = new List<GetSolutionDetailsResponse>();
                }
                return solutions.ToList();
            }
            set
            {
                if (solutions is GetSolutionDetailsResponse[])
                {
                    solutions = solutions.ToList();
                }
                if (solutions != null)
                {
                    var __itemsToDelete = new List<GetSolutionDetailsResponse>(solutions);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveSolutions(__item);
                    }
                }
                if(value == null)
                {
                    solutions = new List<GetSolutionDetailsResponse>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddSolutions(__item);
                }
            }
        }
        public virtual void AddSolutions(IList<GetSolutionDetailsResponse> __items)
        {
            foreach (var __item in __items)
            {
                AddSolutions(__item);
            }
        }
        public virtual void AddSolutions(GetSolutionDetailsResponse __item)
        {
            if (__item != null && solutions!=null && !solutions.Contains(__item))
            {
                solutions.Add(__item);
            }
        }

        public virtual void RemoveSolutions(GetSolutionDetailsResponse __item)
        {
            if (__item != null && solutions!=null && solutions.Contains(__item))
            {
                solutions.Remove(__item);
            }
        }
        public virtual void SetSolutionsAt(GetSolutionDetailsResponse __item, int __index)
        {
            if (__item == null)
            {
                solutions[__index] = null;
            }
            else
            {
                solutions[__index] = __item;
            }
        }

        public virtual void ClearSolutions()
        {
            if (solutions!=null)
            {
                var __itemsToRemove = solutions.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveSolutions(__item);
                }
            }
        }
        [DataMember(Name="Errors")]
        protected IList<Error> errors = new List<Error>();
        public virtual List<Error> Errors
        {
            get
            {
                if (errors is Error[])
                {
                    errors = errors.ToList();
                }
                if (errors == null)
                {
                    errors = new List<Error>();
                }
                return errors.ToList();
            }
            set
            {
                if (errors is Error[])
                {
                    errors = errors.ToList();
                }
                if (errors != null)
                {
                    var __itemsToDelete = new List<Error>(errors);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveErrors(__item);
                    }
                }
                if(value == null)
                {
                    errors = new List<Error>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddErrors(__item);
                }
            }
        }
        public virtual void AddErrors(IList<Error> __items)
        {
            foreach (var __item in __items)
            {
                AddErrors(__item);
            }
        }
        public virtual void AddErrors(Error __item)
        {
            if (__item != null && errors!=null && !errors.Contains(__item))
            {
                errors.Add(__item);
            }
        }

        public virtual void RemoveErrors(Error __item)
        {
            if (__item != null && errors!=null && errors.Contains(__item))
            {
                errors.Remove(__item);
            }
        }
        public virtual void SetErrorsAt(Error __item, int __index)
        {
            if (__item == null)
            {
                errors[__index] = null;
            }
            else
            {
                errors[__index] = __item;
            }
        }

        public virtual void ClearErrors()
        {
            if (errors!=null)
            {
                var __itemsToRemove = errors.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveErrors(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the PlanningResponse class
/// </summary>
/// <returns>New PlanningResponse object</returns>
/// <remarks></remarks>
        public PlanningResponse()
        {
            if (PlanningResponseKey == null) PlanningResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'PlanningResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [PlanningResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual PlanningResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, PlanningResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (PlanningResponse)copiedObjects[this];
            copy = copy ?? new PlanningResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.PlanningResponseKey = this.PlanningResponseKey;
            }
            copy.SessionIdentifier = this.SessionIdentifier;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.solutions = new List<GetSolutionDetailsResponse>();
            if(deep && this.solutions != null)
            {
                foreach (var __item in this.solutions)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddSolutions(__item);
                        else
                            copy.AddSolutions(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddSolutions((GetSolutionDetailsResponse)copiedObjects[__item]);
                    }
                }
            }
            copy.errors = new List<Error>();
            if(deep && this.errors != null)
            {
                foreach (var __item in this.errors)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddErrors(__item);
                        else
                            copy.AddErrors(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddErrors((Error)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as PlanningResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("PlanningResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.PlanningResponseKey.GetHashCode();
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
            return this.PlanningResponseKey == default(Guid) || this.PlanningResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(PlanningResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.PlanningResponseKey.Equals(compareTo.PlanningResponseKey);
        }

        #endregion
    }
}
