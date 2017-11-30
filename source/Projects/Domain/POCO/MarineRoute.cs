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
    /// The MarineRoute class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ItineraryRoute))]

    public class MarineRoute : ItineraryRoute, IDomainModelClass
    {
        #region MarineRoute's Fields
        #endregion
        #region MarineRoute's Participant Properties
        [DataMember(Name="Agency")]
        protected MarineAgency agency;
        public virtual MarineAgency Agency
        {
            get
            {
                return agency;
            }
            set
            {
                if(Equals(agency, value)) return;
                var __oldValue = agency;
                if (value != null)
                {
                    if(agency != null && !Equals(agency, value))
                        agency.RemoveShippingLines(this);
                    agency = value;
                    agency.AddShippingLines(this);
                }
                else
                {
                    if(agency != null)
                        agency.RemoveShippingLines(this);
                    agency = null;
                }
            }
        }
        [DataMember(Name="IntermediatePorts")]
        protected IList<Port> intermediatePorts = new List<Port>();
        public virtual List<Port> IntermediatePorts
        {
            get
            {
                if (intermediatePorts is Port[])
                {
                    intermediatePorts = intermediatePorts.ToList();
                }
                if (intermediatePorts == null)
                {
                    intermediatePorts = new List<Port>();
                }
                return intermediatePorts.ToList();
            }
            set
            {
                if (intermediatePorts is Port[])
                {
                    intermediatePorts = intermediatePorts.ToList();
                }
                if (intermediatePorts != null)
                {
                    var __itemsToDelete = new List<Port>(intermediatePorts);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveIntermediatePorts(__item);
                    }
                }
                if(value == null)
                {
                    intermediatePorts = new List<Port>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddIntermediatePorts(__item);
                }
            }
        }
        public virtual void AddIntermediatePorts(IList<Port> __items)
        {
            foreach (var __item in __items)
            {
                AddIntermediatePorts(__item);
            }
        }
        public virtual void AddIntermediatePorts(Port __item)
        {
            if (__item != null && intermediatePorts!=null && !intermediatePorts.Contains(__item))
            {
                intermediatePorts.Add(__item);
                if (!__item.ShippingLines.Contains(this))
                    __item.AddShippingLines(this);
            }
        }

        public virtual void RemoveIntermediatePorts(Port __item)
        {
            if (__item != null && intermediatePorts!=null && intermediatePorts.Contains(__item))
            {
                intermediatePorts.Remove(__item);
                if(__item.ShippingLines.Contains(this))
                    __item.RemoveShippingLines(this);
            }
        }
        public virtual void SetIntermediatePortsAt(Port __item, int __index)
        {
            if (__item == null)
            {
                intermediatePorts[__index].RemoveShippingLines(this);
            }
            else
            {
                intermediatePorts[__index] = __item;
                if (!__item.ShippingLines.Contains(this))
                    __item.AddShippingLines(this);
            }
        }

        public virtual void ClearIntermediatePorts()
        {
            if (intermediatePorts!=null)
            {
                var __itemsToRemove = intermediatePorts.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveIntermediatePorts(__item);
                }
            }
        }
        [DataMember(Name="Ship")]
        protected Ferry ship;
        public virtual Ferry Ship
        {
            get
            {
                return ship;
            }
            set
            {
                if(Equals(ship, value)) return;
                var __oldValue = ship;
                if (value != null)
                {
                    ship = value;
                }
                else
                {
                    ship = null;
                }
            }
        }
        [DataMember(Name="Origin")]
        protected Port origin;
        public virtual Port Origin
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
                    if(origin != null && !Equals(origin, value))
                        origin.RemoveOutgoingMarineRoutes(this);
                    origin = value;
                    origin.AddOutgoingMarineRoutes(this);
                }
                else
                {
                    if(origin != null)
                        origin.RemoveOutgoingMarineRoutes(this);
                    origin = null;
                }
            }
        }
        [DataMember(Name="Destination")]
        protected Port destination;
        public virtual Port Destination
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
                    if(destination != null && !Equals(destination, value))
                        destination.RemoveIncomingMarineRoutes(this);
                    destination = value;
                    destination.AddIncomingMarineRoutes(this);
                }
                else
                {
                    if(destination != null)
                        destination.RemoveIncomingMarineRoutes(this);
                    destination = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the MarineRoute class
/// </summary>
/// <returns>New MarineRoute object</returns>
/// <remarks></remarks>
        public MarineRoute(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (Origin == null)
            {
                __errors.Add("Association with 'Origin' is required.");
            }
            if (Destination == null)
            {
                __errors.Add("Association with 'Destination' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'MarineRoute' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [MarineRoute] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual MarineRoute Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, MarineRoute copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (MarineRoute)copiedObjects[this];
            copy = copy ?? new MarineRoute();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.agency != null)
            {
                if (!copiedObjects.Contains(this.agency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Agency = this.Agency;
                    else if (asNew)
                        copy.Agency = this.Agency.Copy(deep, copiedObjects, true);
                    else
                        copy.agency = this.agency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Agency = (MarineAgency)copiedObjects[this.Agency];
                    else
                        copy.agency = (MarineAgency)copiedObjects[this.Agency];
                }
            }
            copy.intermediatePorts = new List<Port>();
            if(deep && this.intermediatePorts != null)
            {
                foreach (var __item in this.intermediatePorts)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddIntermediatePorts(__item);
                        else
                            copy.AddIntermediatePorts(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddIntermediatePorts((Port)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.ship != null)
            {
                if (!copiedObjects.Contains(this.ship))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Ship = this.Ship;
                    else if (asNew)
                        copy.Ship = this.Ship.Copy(deep, copiedObjects, true);
                    else
                        copy.ship = this.ship.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Ship = (Ferry)copiedObjects[this.Ship];
                    else
                        copy.ship = (Ferry)copiedObjects[this.Ship];
                }
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
                        copy.Origin = (Port)copiedObjects[this.Origin];
                    else
                        copy.origin = (Port)copiedObjects[this.Origin];
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
                        copy.Destination = (Port)copiedObjects[this.Destination];
                    else
                        copy.destination = (Port)copiedObjects[this.Destination];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as MarineRoute;
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
