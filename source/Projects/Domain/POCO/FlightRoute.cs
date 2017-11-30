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
    /// The FlightRoute class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ItineraryRoute))]

    public class FlightRoute : ItineraryRoute, IDomainModelClass
    {
        #region FlightRoute's Fields
        [DataMember(Name="FlightNumber")]
        protected string flightNumber;
        [DataMember(Name="OperatingFlightNumber")]
        protected string operatingFlightNumber;
        [DataMember(Name="StopCount")]
        protected int? stopCount;
        [DataMember(Name="DisplayOption")]
        protected bool displayOption;
        [DataMember(Name="FlightDuration")]
        protected int? flightDuration;
        [DataMember(Name="SecureSell")]
        protected string secureSell;
        [DataMember(Name="InsideAvailability")]
        protected string insideAvailability;
        [DataMember(Name="Group")]
        protected int? group;
        [DataMember(Name="ProviderCode")]
        protected string providerCode;
        #endregion
        #region FlightRoute's Properties
/// <summary>
/// The FlightNumber property
///
/// </summary>
///
        public virtual string FlightNumber
        {
            get
            {
                return flightNumber;
            }
            set
            {
                flightNumber = value;
            }
        }
/// <summary>
/// The OperatingFlightNumber property
///
/// </summary>
///
        public virtual string OperatingFlightNumber
        {
            get
            {
                return operatingFlightNumber;
            }
            set
            {
                operatingFlightNumber = value;
            }
        }
/// <summary>
/// The StopCount property
///
/// </summary>
///
        public virtual int? StopCount
        {
            get
            {
                return stopCount;
            }
            set
            {
                stopCount = value;
            }
        }
/// <summary>
/// The DisplayOption property
///
/// </summary>
///
        public virtual bool DisplayOption
        {
            get
            {
                return displayOption;
            }
            set
            {
                displayOption = value;
            }
        }
/// <summary>
/// The FlightDuration property
///
/// </summary>
///
        public virtual int? FlightDuration
        {
            get
            {
                return flightDuration;
            }
            set
            {
                flightDuration = value;
            }
        }
/// <summary>
/// The SecureSell property
///
/// </summary>
///
        public virtual string SecureSell
        {
            get
            {
                return secureSell;
            }
            set
            {
                secureSell = value;
            }
        }
/// <summary>
/// The InsideAvailability property
///
/// </summary>
///
        public virtual string InsideAvailability
        {
            get
            {
                return insideAvailability;
            }
            set
            {
                insideAvailability = value;
            }
        }
/// <summary>
/// The Group property
///
/// </summary>
///
        public virtual int? Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }
/// <summary>
/// The ProviderCode property
///
/// </summary>
///
        public virtual string ProviderCode
        {
            get
            {
                return providerCode;
            }
            set
            {
                providerCode = value;
            }
        }
        #endregion
        #region FlightRoute's Participant Properties
        [DataMember(Name="ClassesOfService")]
        protected IList<ClassOfService> classesOfService = new List<ClassOfService>();
        public virtual List<ClassOfService> ClassesOfService
        {
            get
            {
                if (classesOfService is ClassOfService[])
                {
                    classesOfService = classesOfService.ToList();
                }
                if (classesOfService == null)
                {
                    classesOfService = new List<ClassOfService>();
                }
                return classesOfService.ToList();
            }
            set
            {
                if (classesOfService is ClassOfService[])
                {
                    classesOfService = classesOfService.ToList();
                }
                if (classesOfService != null)
                {
                    var __itemsToDelete = new List<ClassOfService>(classesOfService);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveClassesOfService(__item);
                    }
                }
                if(value == null)
                {
                    classesOfService = new List<ClassOfService>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddClassesOfService(__item);
                }
            }
        }
        public virtual void AddClassesOfService(IList<ClassOfService> __items)
        {
            foreach (var __item in __items)
            {
                AddClassesOfService(__item);
            }
        }
        public virtual void AddClassesOfService(ClassOfService __item)
        {
            if (__item != null && classesOfService!=null && !classesOfService.Contains(__item))
            {
                classesOfService.Add(__item);
            }
        }

        public virtual void RemoveClassesOfService(ClassOfService __item)
        {
            if (__item != null && classesOfService!=null && classesOfService.Contains(__item))
            {
                classesOfService.Remove(__item);
            }
        }
        public virtual void SetClassesOfServiceAt(ClassOfService __item, int __index)
        {
            if (__item == null)
            {
                classesOfService[__index] = null;
            }
            else
            {
                classesOfService[__index] = __item;
            }
        }

        public virtual void ClearClassesOfService()
        {
            if (classesOfService!=null)
            {
                var __itemsToRemove = classesOfService.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveClassesOfService(__item);
                }
            }
        }
        [DataMember(Name="OriginTerminal")]
        protected Terminal originTerminal;
        public virtual Terminal OriginTerminal
        {
            get
            {
                return originTerminal;
            }
            set
            {
                if(Equals(originTerminal, value)) return;
                var __oldValue = originTerminal;
                if (value != null)
                {
                    originTerminal = value;
                }
                else
                {
                    if (originTerminal != null)
                    {
                        originTerminal = null;
                    }
                }
            }
        }
        [DataMember(Name="DestinationTerminal")]
        protected Terminal destinationTerminal;
        public virtual Terminal DestinationTerminal
        {
            get
            {
                return destinationTerminal;
            }
            set
            {
                if(Equals(destinationTerminal, value)) return;
                var __oldValue = destinationTerminal;
                if (value != null)
                {
                    destinationTerminal = value;
                }
                else
                {
                    if (destinationTerminal != null)
                    {
                        destinationTerminal = null;
                    }
                }
            }
        }
        [DataMember(Name="Origin")]
        protected Airport origin;
        public virtual Airport Origin
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
        protected Airport destination;
        public virtual Airport Destination
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
        [DataMember(Name="OperatingAirline")]
        protected Airline operatingAirline;
        public virtual Airline OperatingAirline
        {
            get
            {
                return operatingAirline;
            }
            set
            {
                if(Equals(operatingAirline, value)) return;
                var __oldValue = operatingAirline;
                if (value != null)
                {
                    if(operatingAirline != null && !Equals(operatingAirline, value))
                        operatingAirline.RemoveOperatingRoutes(this);
                    operatingAirline = value;
                    operatingAirline.AddOperatingRoutes(this);
                }
                else
                {
                    if(operatingAirline != null)
                        operatingAirline.RemoveOperatingRoutes(this);
                    operatingAirline = null;
                }
            }
        }
        [DataMember(Name="MarketingAirline")]
        protected Airline marketingAirline;
        public virtual Airline MarketingAirline
        {
            get
            {
                return marketingAirline;
            }
            set
            {
                if(Equals(marketingAirline, value)) return;
                var __oldValue = marketingAirline;
                if (value != null)
                {
                    if(marketingAirline != null && !Equals(marketingAirline, value))
                        marketingAirline.RemoveMarketingRoutes(this);
                    marketingAirline = value;
                    marketingAirline.AddMarketingRoutes(this);
                }
                else
                {
                    if(marketingAirline != null)
                        marketingAirline.RemoveMarketingRoutes(this);
                    marketingAirline = null;
                }
            }
        }
        [DataMember(Name="OutgoingConnections")]
        protected IList<Connection> outgoingConnections = new List<Connection>();
        public virtual List<Connection> OutgoingConnections
        {
            get
            {
                if (outgoingConnections is Connection[])
                {
                    outgoingConnections = outgoingConnections.ToList();
                }
                if (outgoingConnections == null)
                {
                    outgoingConnections = new List<Connection>();
                }
                return outgoingConnections.ToList();
            }
            set
            {
                if (outgoingConnections is Connection[])
                {
                    outgoingConnections = outgoingConnections.ToList();
                }
                if (outgoingConnections != null)
                {
                    var __itemsToDelete = new List<Connection>(outgoingConnections);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveOutgoingConnections(__item);
                    }
                }
                if(value == null)
                {
                    outgoingConnections = new List<Connection>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddOutgoingConnections(__item);
                }
            }
        }
        public virtual void AddOutgoingConnections(IList<Connection> __items)
        {
            foreach (var __item in __items)
            {
                AddOutgoingConnections(__item);
            }
        }
        public virtual void AddOutgoingConnections(Connection __item)
        {
            if (__item != null && outgoingConnections!=null && !outgoingConnections.Contains(__item))
            {
                outgoingConnections.Add(__item);
                if (__item.IncomingFlightRoute != this)
                    __item.IncomingFlightRoute = this;
            }
        }

        public virtual void RemoveOutgoingConnections(Connection __item)
        {
            if (__item != null && outgoingConnections!=null && outgoingConnections.Contains(__item))
            {
                outgoingConnections.Remove(__item);
                __item.IncomingFlightRoute = null;
            }
        }
        public virtual void SetOutgoingConnectionsAt(Connection __item, int __index)
        {
            if (__item == null)
            {
                outgoingConnections[__index].IncomingFlightRoute = null;
            }
            else
            {
                outgoingConnections[__index] = __item;
                if (__item.IncomingFlightRoute != this)
                    __item.IncomingFlightRoute = this;
            }
        }

        public virtual void ClearOutgoingConnections()
        {
            if (outgoingConnections!=null)
            {
                var __itemsToRemove = outgoingConnections.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveOutgoingConnections(__item);
                }
            }
        }
        [DataMember(Name="IncomingConnections")]
        protected IList<Connection> incomingConnections = new List<Connection>();
        public virtual List<Connection> IncomingConnections
        {
            get
            {
                if (incomingConnections is Connection[])
                {
                    incomingConnections = incomingConnections.ToList();
                }
                if (incomingConnections == null)
                {
                    incomingConnections = new List<Connection>();
                }
                return incomingConnections.ToList();
            }
            set
            {
                if (incomingConnections is Connection[])
                {
                    incomingConnections = incomingConnections.ToList();
                }
                if (incomingConnections != null)
                {
                    var __itemsToDelete = new List<Connection>(incomingConnections);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveIncomingConnections(__item);
                    }
                }
                if(value == null)
                {
                    incomingConnections = new List<Connection>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddIncomingConnections(__item);
                }
            }
        }
        public virtual void AddIncomingConnections(IList<Connection> __items)
        {
            foreach (var __item in __items)
            {
                AddIncomingConnections(__item);
            }
        }
        public virtual void AddIncomingConnections(Connection __item)
        {
            if (__item != null && incomingConnections!=null && !incomingConnections.Contains(__item))
            {
                incomingConnections.Add(__item);
                if (__item.OutgoingFlightRoute != this)
                    __item.OutgoingFlightRoute = this;
            }
        }

        public virtual void RemoveIncomingConnections(Connection __item)
        {
            if (__item != null && incomingConnections!=null && incomingConnections.Contains(__item))
            {
                incomingConnections.Remove(__item);
                __item.OutgoingFlightRoute = null;
            }
        }
        public virtual void SetIncomingConnectionsAt(Connection __item, int __index)
        {
            if (__item == null)
            {
                incomingConnections[__index].OutgoingFlightRoute = null;
            }
            else
            {
                incomingConnections[__index] = __item;
                if (__item.OutgoingFlightRoute != this)
                    __item.OutgoingFlightRoute = this;
            }
        }

        public virtual void ClearIncomingConnections()
        {
            if (incomingConnections!=null)
            {
                var __itemsToRemove = incomingConnections.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveIncomingConnections(__item);
                }
            }
        }
        [DataMember(Name="InFlightServices")]
        protected IList<InFlightService> inFlightServices = new List<InFlightService>();
        public virtual List<InFlightService> InFlightServices
        {
            get
            {
                if (inFlightServices is InFlightService[])
                {
                    inFlightServices = inFlightServices.ToList();
                }
                if (inFlightServices == null)
                {
                    inFlightServices = new List<InFlightService>();
                }
                return inFlightServices.ToList();
            }
            set
            {
                if (inFlightServices is InFlightService[])
                {
                    inFlightServices = inFlightServices.ToList();
                }
                if (inFlightServices != null)
                {
                    var __itemsToDelete = new List<InFlightService>(inFlightServices);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveInFlightServices(__item);
                    }
                }
                if(value == null)
                {
                    inFlightServices = new List<InFlightService>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddInFlightServices(__item);
                }
            }
        }
        public virtual void AddInFlightServices(IList<InFlightService> __items)
        {
            foreach (var __item in __items)
            {
                AddInFlightServices(__item);
            }
        }
        public virtual void AddInFlightServices(InFlightService __item)
        {
            if (__item != null && inFlightServices!=null && !inFlightServices.Contains(__item))
            {
                inFlightServices.Add(__item);
            }
        }

        public virtual void RemoveInFlightServices(InFlightService __item)
        {
            if (__item != null && inFlightServices!=null && inFlightServices.Contains(__item))
            {
                inFlightServices.Remove(__item);
            }
        }
        public virtual void SetInFlightServicesAt(InFlightService __item, int __index)
        {
            if (__item == null)
            {
                inFlightServices[__index] = null;
            }
            else
            {
                inFlightServices[__index] = __item;
            }
        }

        public virtual void ClearInFlightServices()
        {
            if (inFlightServices!=null)
            {
                var __itemsToRemove = inFlightServices.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveInFlightServices(__item);
                }
            }
        }
        [DataMember(Name="Aircraft")]
        protected Aircraft aircraft;
        public virtual Aircraft Aircraft
        {
            get
            {
                return aircraft;
            }
            set
            {
                if(Equals(aircraft, value)) return;
                var __oldValue = aircraft;
                if (value != null)
                {
                    aircraft = value;
                }
                else
                {
                    aircraft = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the FlightRoute class
/// </summary>
/// <returns>New FlightRoute object</returns>
/// <remarks></remarks>
        public FlightRoute(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (FlightNumber != null && FlightNumber.Length > 100)
            {
                __errors.Add("Length of property 'FlightNumber' cannot be greater than 100.");
            }
            if (OperatingFlightNumber != null && OperatingFlightNumber.Length > 100)
            {
                __errors.Add("Length of property 'OperatingFlightNumber' cannot be greater than 100.");
            }
            if (SecureSell != null && SecureSell.Length > 100)
            {
                __errors.Add("Length of property 'SecureSell' cannot be greater than 100.");
            }
            if (InsideAvailability != null && InsideAvailability.Length > 100)
            {
                __errors.Add("Length of property 'InsideAvailability' cannot be greater than 100.");
            }
            if (ProviderCode != null && ProviderCode.Length > 100)
            {
                __errors.Add("Length of property 'ProviderCode' cannot be greater than 100.");
            }
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
                throw new BusinessException("An instance of TypeClass 'FlightRoute' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [FlightRoute] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual FlightRoute Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, FlightRoute copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (FlightRoute)copiedObjects[this];
            copy = copy ?? new FlightRoute();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.FlightNumber = this.FlightNumber;
            copy.OperatingFlightNumber = this.OperatingFlightNumber;
            copy.StopCount = this.StopCount;
            copy.DisplayOption = this.DisplayOption;
            copy.FlightDuration = this.FlightDuration;
            copy.SecureSell = this.SecureSell;
            copy.InsideAvailability = this.InsideAvailability;
            copy.Group = this.Group;
            copy.ProviderCode = this.ProviderCode;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.classesOfService = new List<ClassOfService>();
            if(deep && this.classesOfService != null)
            {
                foreach (var __item in this.classesOfService)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddClassesOfService(__item);
                        else
                            copy.AddClassesOfService(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddClassesOfService((ClassOfService)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.originTerminal != null)
            {
                if (!copiedObjects.Contains(this.originTerminal))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OriginTerminal = this.OriginTerminal;
                    else if (asNew)
                        copy.OriginTerminal = this.OriginTerminal.Copy(deep, copiedObjects, true);
                    else
                        copy.originTerminal = this.originTerminal.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OriginTerminal = (Terminal)copiedObjects[this.OriginTerminal];
                    else
                        copy.originTerminal = (Terminal)copiedObjects[this.OriginTerminal];
                }
            }
            if(deep && this.destinationTerminal != null)
            {
                if (!copiedObjects.Contains(this.destinationTerminal))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DestinationTerminal = this.DestinationTerminal;
                    else if (asNew)
                        copy.DestinationTerminal = this.DestinationTerminal.Copy(deep, copiedObjects, true);
                    else
                        copy.destinationTerminal = this.destinationTerminal.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DestinationTerminal = (Terminal)copiedObjects[this.DestinationTerminal];
                    else
                        copy.destinationTerminal = (Terminal)copiedObjects[this.DestinationTerminal];
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
                        copy.Origin = (Airport)copiedObjects[this.Origin];
                    else
                        copy.origin = (Airport)copiedObjects[this.Origin];
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
                        copy.Destination = (Airport)copiedObjects[this.Destination];
                    else
                        copy.destination = (Airport)copiedObjects[this.Destination];
                }
            }
            if(deep && this.operatingAirline != null)
            {
                if (!copiedObjects.Contains(this.operatingAirline))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OperatingAirline = this.OperatingAirline;
                    else if (asNew)
                        copy.OperatingAirline = this.OperatingAirline.Copy(deep, copiedObjects, true);
                    else
                        copy.operatingAirline = this.operatingAirline.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OperatingAirline = (Airline)copiedObjects[this.OperatingAirline];
                    else
                        copy.operatingAirline = (Airline)copiedObjects[this.OperatingAirline];
                }
            }
            if(deep && this.marketingAirline != null)
            {
                if (!copiedObjects.Contains(this.marketingAirline))
                {
                    if (asNew && reuseNestedObjects)
                        copy.MarketingAirline = this.MarketingAirline;
                    else if (asNew)
                        copy.MarketingAirline = this.MarketingAirline.Copy(deep, copiedObjects, true);
                    else
                        copy.marketingAirline = this.marketingAirline.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.MarketingAirline = (Airline)copiedObjects[this.MarketingAirline];
                    else
                        copy.marketingAirline = (Airline)copiedObjects[this.MarketingAirline];
                }
            }
            copy.outgoingConnections = new List<Connection>();
            if(deep && this.outgoingConnections != null)
            {
                foreach (var __item in this.outgoingConnections)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddOutgoingConnections(__item);
                        else
                            copy.AddOutgoingConnections(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddOutgoingConnections((Connection)copiedObjects[__item]);
                    }
                }
            }
            copy.incomingConnections = new List<Connection>();
            if(deep && this.incomingConnections != null)
            {
                foreach (var __item in this.incomingConnections)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddIncomingConnections(__item);
                        else
                            copy.AddIncomingConnections(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddIncomingConnections((Connection)copiedObjects[__item]);
                    }
                }
            }
            copy.inFlightServices = new List<InFlightService>();
            if(deep && this.inFlightServices != null)
            {
                foreach (var __item in this.inFlightServices)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddInFlightServices(__item);
                        else
                            copy.AddInFlightServices(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddInFlightServices((InFlightService)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.aircraft != null)
            {
                if (!copiedObjects.Contains(this.aircraft))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Aircraft = this.Aircraft;
                    else if (asNew)
                        copy.Aircraft = this.Aircraft.Copy(deep, copiedObjects, true);
                    else
                        copy.aircraft = this.aircraft.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Aircraft = (Aircraft)copiedObjects[this.Aircraft];
                    else
                        copy.aircraft = (Aircraft)copiedObjects[this.Aircraft];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as FlightRoute;
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
