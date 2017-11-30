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
    /// The GetSolutionsForLegResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(LocationPair))]

    public class GetSolutionsForLegResponse : LocationPair, IDomainModelClass
    {
        #region GetSolutionsForLegResponse's Fields
        #endregion
        #region GetSolutionsForLegResponse's Participant Properties
        [DataMember(Name="Solutions")]
        protected IList<SolutionWrapper> solutions = new List<SolutionWrapper>();
        public virtual List<SolutionWrapper> Solutions
        {
            get
            {
                if (solutions is SolutionWrapper[])
                {
                    solutions = solutions.ToList();
                }
                if (solutions == null)
                {
                    solutions = new List<SolutionWrapper>();
                }
                return solutions.ToList();
            }
            set
            {
                if (solutions is SolutionWrapper[])
                {
                    solutions = solutions.ToList();
                }
                if (solutions != null)
                {
                    var __itemsToDelete = new List<SolutionWrapper>(solutions);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveSolutions(__item);
                    }
                }
                if(value == null)
                {
                    solutions = new List<SolutionWrapper>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddSolutions(__item);
                }
            }
        }
        public virtual void AddSolutions(IList<SolutionWrapper> __items)
        {
            foreach (var __item in __items)
            {
                AddSolutions(__item);
            }
        }
        public virtual void AddSolutions(SolutionWrapper __item)
        {
            if (__item != null && solutions!=null && !solutions.Contains(__item))
            {
                solutions.Add(__item);
            }
        }

        public virtual void RemoveSolutions(SolutionWrapper __item)
        {
            if (__item != null && solutions!=null && solutions.Contains(__item))
            {
                solutions.Remove(__item);
            }
        }
        public virtual void SetSolutionsAt(SolutionWrapper __item, int __index)
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
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the GetSolutionsForLegResponse class
/// </summary>
/// <returns>New GetSolutionsForLegResponse object</returns>
/// <remarks></remarks>
        public GetSolutionsForLegResponse(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'GetSolutionsForLegResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [GetSolutionsForLegResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual GetSolutionsForLegResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, GetSolutionsForLegResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (GetSolutionsForLegResponse)copiedObjects[this];
            copy = copy ?? new GetSolutionsForLegResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.solutions = new List<SolutionWrapper>();
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
                        copy.AddSolutions((SolutionWrapper)copiedObjects[__item]);
                    }
                }
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
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as GetSolutionsForLegResponse;
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
