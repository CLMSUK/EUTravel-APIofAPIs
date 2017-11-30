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
    /// The RailSegment class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ItinerarySegment))]

    public class RailSegment : ItinerarySegment, IDomainModelClass
    {
        #region RailSegment's Fields
        [DataMember(Name="TrainNumber")]
        protected string trainNumber;
        [DataMember(Name="RequiresCrossBorderDocuments")]
        protected bool requiresCrossBorderDocuments;
        #endregion
        #region RailSegment's Properties
/// <summary>
/// The TrainNumber property
///
/// </summary>
///
        public virtual string TrainNumber
        {
            get
            {
                return trainNumber;
            }
            set
            {
                trainNumber = value;
            }
        }
/// <summary>
/// The RequiresCrossBorderDocuments property
///
/// </summary>
///
        public virtual bool RequiresCrossBorderDocuments
        {
            get
            {
                return requiresCrossBorderDocuments;
            }
            set
            {
                requiresCrossBorderDocuments = value;
            }
        }
        #endregion
        #region RailSegment's Participant Properties
        [DataMember(Name="RailRoute")]
        protected RailRoute railRoute;
        public virtual RailRoute RailRoute
        {
            get
            {
                return railRoute;
            }
            set
            {
                if(Equals(railRoute, value)) return;
                var __oldValue = railRoute;
                if (value != null)
                {
                    railRoute = value;
                }
                else
                {
                    railRoute = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the RailSegment class
/// </summary>
/// <returns>New RailSegment object</returns>
/// <remarks></remarks>
        public RailSegment(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (TrainNumber != null && TrainNumber.Length > 100)
            {
                __errors.Add("Length of property 'TrainNumber' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'RailSegment' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [RailSegment] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual RailSegment Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, RailSegment copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (RailSegment)copiedObjects[this];
            copy = copy ?? new RailSegment();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.TrainNumber = this.TrainNumber;
            copy.RequiresCrossBorderDocuments = this.RequiresCrossBorderDocuments;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.railRoute != null)
            {
                if (!copiedObjects.Contains(this.railRoute))
                {
                    if (asNew && reuseNestedObjects)
                        copy.RailRoute = this.RailRoute;
                    else if (asNew)
                        copy.RailRoute = this.RailRoute.Copy(deep, copiedObjects, true);
                    else
                        copy.railRoute = this.railRoute.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.RailRoute = (RailRoute)copiedObjects[this.RailRoute];
                    else
                        copy.railRoute = (RailRoute)copiedObjects[this.RailRoute];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as RailSegment;
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
