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
    /// The UrbanSegment class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ItinerarySegment))]

    public class UrbanSegment : ItinerarySegment, IDomainModelClass
    {
        #region UrbanSegment's Fields
        #endregion
        #region UrbanSegment's Participant Properties
        [DataMember(Name="Origin")]
        protected Station origin;
        public virtual Station Origin
        {
            get
            {
                return origin;
            }
            set
            {
                if(Equals(origin, value)) return;
                var __oldValue = origin;
                if (value != null)
                {
                    origin = value;
                }
                else
                {
                    origin = null;
                }
            }
        }
        [DataMember(Name="Destination")]
        protected Station destination;
        public virtual Station Destination
        {
            get
            {
                return destination;
            }
            set
            {
                if(Equals(destination, value)) return;
                var __oldValue = destination;
                if (value != null)
                {
                    destination = value;
                }
                else
                {
                    destination = null;
                }
            }
        }
        [DataMember(Name="UrbanTrip")]
        protected UrbanTrip urbanTrip;
        public virtual UrbanTrip UrbanTrip
        {
            get
            {
                return urbanTrip;
            }
            set
            {
                if(Equals(urbanTrip, value)) return;
                var __oldValue = urbanTrip;
                if (value != null)
                {
                    urbanTrip = value;
                }
                else
                {
                    urbanTrip = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UrbanSegment class
/// </summary>
/// <returns>New UrbanSegment object</returns>
/// <remarks></remarks>
        public UrbanSegment(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (UrbanTrip == null)
            {
                __errors.Add("Association with 'UrbanTrip' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UrbanSegment' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UrbanSegment] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UrbanSegment Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UrbanSegment copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UrbanSegment)copiedObjects[this];
            copy = copy ?? new UrbanSegment();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.origin != null)
            {
                if (!copiedObjects.Contains(this.origin))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Origin = this.Origin;
                    else if (asNew)
                        copy.Origin = this.Origin.Copy(deep, copiedObjects, true);
                    else
                        copy.origin = this.origin.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Origin = (Station)copiedObjects[this.Origin];
                    else
                        copy.origin = (Station)copiedObjects[this.Origin];
                }
            }
            if(deep && this.destination != null)
            {
                if (!copiedObjects.Contains(this.destination))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Destination = this.Destination;
                    else if (asNew)
                        copy.Destination = this.Destination.Copy(deep, copiedObjects, true);
                    else
                        copy.destination = this.destination.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Destination = (Station)copiedObjects[this.Destination];
                    else
                        copy.destination = (Station)copiedObjects[this.Destination];
                }
            }
            if(deep && this.urbanTrip != null)
            {
                if (!copiedObjects.Contains(this.urbanTrip))
                {
                    if (asNew && reuseNestedObjects)
                        copy.UrbanTrip = this.UrbanTrip;
                    else if (asNew)
                        copy.UrbanTrip = this.UrbanTrip.Copy(deep, copiedObjects, true);
                    else
                        copy.urbanTrip = this.urbanTrip.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.UrbanTrip = (UrbanTrip)copiedObjects[this.UrbanTrip];
                    else
                        copy.urbanTrip = (UrbanTrip)copiedObjects[this.UrbanTrip];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UrbanSegment;
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
