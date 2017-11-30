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
    /// The FlightSegment class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ItinerarySegment))]

    public class FlightSegment : ItinerarySegment, IDomainModelClass
    {
        #region FlightSegment's Fields
        [DataMember(Name="FlightTime")]
        protected int? flightTime;
        [DataMember(Name="DepartureDateTimeString")]
        protected string departureDateTimeString;
        [DataMember(Name="ArrivalDateTimeString")]
        protected string arrivalDateTimeString;
        #endregion
        #region FlightSegment's Properties
/// <summary>
/// The FlightTime property
///
/// </summary>
///
        public virtual int? FlightTime
        {
            get
            {
                return flightTime;
            }
            set
            {
                flightTime = value;
            }
        }
/// <summary>
/// The DepartureDateTimeString property
///
/// </summary>
///
        public virtual string DepartureDateTimeString
        {
            get
            {
                return departureDateTimeString;
            }
            set
            {
                departureDateTimeString = value;
            }
        }
/// <summary>
/// The ArrivalDateTimeString property
///
/// </summary>
///
        public virtual string ArrivalDateTimeString
        {
            get
            {
                return arrivalDateTimeString;
            }
            set
            {
                arrivalDateTimeString = value;
            }
        }
        #endregion
        #region FlightSegment's Participant Properties
        [DataMember(Name="FlightRoute")]
        protected FlightRoute flightRoute;
        public virtual FlightRoute FlightRoute
        {
            get
            {
                return flightRoute;
            }
            set
            {
                if(Equals(flightRoute, value)) return;
                var __oldValue = flightRoute;
                if (value != null)
                {
                    flightRoute = value;
                }
                else
                {
                    flightRoute = null;
                }
            }
        }
        [DataMember(Name="ClassOfService")]
        protected IList<ClassOfService> classOfService = new List<ClassOfService>();
        public virtual List<ClassOfService> ClassOfService
        {
            get
            {
                if (classOfService is ClassOfService[])
                {
                    classOfService = classOfService.ToList();
                }
                if (classOfService == null)
                {
                    classOfService = new List<ClassOfService>();
                }
                return classOfService.ToList();
            }
            set
            {
                if (classOfService is ClassOfService[])
                {
                    classOfService = classOfService.ToList();
                }
                if (classOfService != null)
                {
                    var __itemsToDelete = new List<ClassOfService>(classOfService);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveClassOfService(__item);
                    }
                }
                if(value == null)
                {
                    classOfService = new List<ClassOfService>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddClassOfService(__item);
                }
            }
        }
        public virtual void AddClassOfService(IList<ClassOfService> __items)
        {
            foreach (var __item in __items)
            {
                AddClassOfService(__item);
            }
        }
        public virtual void AddClassOfService(ClassOfService __item)
        {
            if (__item != null && classOfService!=null && !classOfService.Contains(__item))
            {
                classOfService.Add(__item);
            }
        }

        public virtual void RemoveClassOfService(ClassOfService __item)
        {
            if (__item != null && classOfService!=null && classOfService.Contains(__item))
            {
                classOfService.Remove(__item);
            }
        }
        public virtual void SetClassOfServiceAt(ClassOfService __item, int __index)
        {
            if (__item == null)
            {
                classOfService[__index] = null;
            }
            else
            {
                classOfService[__index] = __item;
            }
        }

        public virtual void ClearClassOfService()
        {
            if (classOfService!=null)
            {
                var __itemsToRemove = classOfService.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveClassOfService(__item);
                }
            }
        }
        [DataMember(Name="ChosenClassOfService")]
        protected ClassOfService chosenClassOfService;
        public virtual ClassOfService ChosenClassOfService
        {
            get
            {
                return chosenClassOfService;
            }
            set
            {
                if(Equals(chosenClassOfService, value)) return;
                var __oldValue = chosenClassOfService;
                if (value != null)
                {
                    chosenClassOfService = value;
                }
                else
                {
                    if (chosenClassOfService != null)
                    {
                        chosenClassOfService = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the FlightSegment class
/// </summary>
/// <returns>New FlightSegment object</returns>
/// <remarks></remarks>
        public FlightSegment(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (DepartureDateTimeString != null && DepartureDateTimeString.Length > 100)
            {
                __errors.Add("Length of property 'DepartureDateTimeString' cannot be greater than 100.");
            }
            if (ArrivalDateTimeString != null && ArrivalDateTimeString.Length > 100)
            {
                __errors.Add("Length of property 'ArrivalDateTimeString' cannot be greater than 100.");
            }
            if (FlightRoute == null)
            {
                __errors.Add("Association with 'FlightRoute' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'FlightSegment' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [FlightSegment] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual FlightSegment Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, FlightSegment copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (FlightSegment)copiedObjects[this];
            copy = copy ?? new FlightSegment();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.FlightTime = this.FlightTime;
            copy.DepartureDateTimeString = this.DepartureDateTimeString;
            copy.ArrivalDateTimeString = this.ArrivalDateTimeString;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.flightRoute != null)
            {
                if (!copiedObjects.Contains(this.flightRoute))
                {
                    if (asNew && reuseNestedObjects)
                        copy.FlightRoute = this.FlightRoute;
                    else if (asNew)
                        copy.FlightRoute = this.FlightRoute.Copy(deep, copiedObjects, true);
                    else
                        copy.flightRoute = this.flightRoute.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.FlightRoute = (FlightRoute)copiedObjects[this.FlightRoute];
                    else
                        copy.flightRoute = (FlightRoute)copiedObjects[this.FlightRoute];
                }
            }
            copy.classOfService = new List<ClassOfService>();
            if(deep && this.classOfService != null)
            {
                foreach (var __item in this.classOfService)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddClassOfService(__item);
                        else
                            copy.AddClassOfService(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddClassOfService((ClassOfService)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.chosenClassOfService != null)
            {
                if (!copiedObjects.Contains(this.chosenClassOfService))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ChosenClassOfService = this.ChosenClassOfService;
                    else if (asNew)
                        copy.ChosenClassOfService = this.ChosenClassOfService.Copy(deep, copiedObjects, true);
                    else
                        copy.chosenClassOfService = this.chosenClassOfService.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ChosenClassOfService = (ClassOfService)copiedObjects[this.ChosenClassOfService];
                    else
                        copy.chosenClassOfService = (ClassOfService)copiedObjects[this.ChosenClassOfService];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as FlightSegment;
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
