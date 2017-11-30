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
    /// The UrbanTrip class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ItineraryRoute))]

    public class UrbanTrip : ItineraryRoute, IDomainModelClass
    {
        #region UrbanTrip's Fields
        [DataMember(Name="GTFSId")]
        protected string gTFSId;
        [DataMember(Name="Headsign")]
        protected string headsign;
        [DataMember(Name="ShortName")]
        protected string shortName;
        [DataMember(Name="Direction")]
        protected EuTravel_2.BO.DirectionType direction;
        [DataMember(Name="isRail")]
        protected bool _isRail;
        #endregion
        #region UrbanTrip's Properties
/// <summary>
/// The GTFSId property
///
/// </summary>
///
        public virtual string GTFSId
        {
            get
            {
                return gTFSId;
            }
            set
            {
                gTFSId = value;
            }
        }
/// <summary>
/// The Headsign property
///
/// </summary>
///
        public virtual string Headsign
        {
            get
            {
                return headsign;
            }
            set
            {
                headsign = value;
            }
        }
/// <summary>
/// The ShortName property
///
/// </summary>
///
        public virtual string ShortName
        {
            get
            {
                return shortName;
            }
            set
            {
                shortName = value;
            }
        }
/// <summary>
/// The Direction property
///
/// </summary>
///
        public virtual EuTravel_2.BO.DirectionType Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }
/// <summary>
/// The isRail property
///
/// </summary>
///
        public virtual bool isRail
        {
            get
            {
                return _isRail;
            }
            set
            {
                _isRail = value;
            }
        }
        #endregion
        #region UrbanTrip's Participant Properties
        [DataMember(Name="UrbanRoute")]
        protected UrbanRoute urbanRoute;
        public virtual UrbanRoute UrbanRoute
        {
            get
            {
                return urbanRoute;
            }
            set
            {
                if(Equals(urbanRoute, value)) return;
                var __oldValue = urbanRoute;
                if (value != null)
                {
                    if(urbanRoute != null && !Equals(urbanRoute, value))
                        urbanRoute.RemoveUrbanTrips(this);
                    urbanRoute = value;
                    urbanRoute.AddUrbanTrips(this);
                }
                else
                {
                    if(urbanRoute != null)
                        urbanRoute.RemoveUrbanTrips(this);
                    urbanRoute = null;
                }
            }
        }
        [DataMember(Name="StopTimeDetails")]
        protected IList<StopTimeDetails> stopTimeDetails = new List<StopTimeDetails>();
        public virtual List<StopTimeDetails> StopTimeDetails
        {
            get
            {
                if (stopTimeDetails is StopTimeDetails[])
                {
                    stopTimeDetails = stopTimeDetails.ToList();
                }
                if (stopTimeDetails == null)
                {
                    stopTimeDetails = new List<StopTimeDetails>();
                }
                return stopTimeDetails.ToList();
            }
            set
            {
                if (stopTimeDetails is StopTimeDetails[])
                {
                    stopTimeDetails = stopTimeDetails.ToList();
                }
                if (stopTimeDetails != null)
                {
                    var __itemsToDelete = new List<StopTimeDetails>(stopTimeDetails);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveStopTimeDetails(__item);
                    }
                }
                if(value == null)
                {
                    stopTimeDetails = new List<StopTimeDetails>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddStopTimeDetails(__item);
                }
            }
        }
        public virtual void AddStopTimeDetails(IList<StopTimeDetails> __items)
        {
            foreach (var __item in __items)
            {
                AddStopTimeDetails(__item);
            }
        }
        public virtual void AddStopTimeDetails(StopTimeDetails __item)
        {
            if (__item != null && stopTimeDetails!=null && !stopTimeDetails.Contains(__item))
            {
                stopTimeDetails.Add(__item);
            }
        }

        public virtual void RemoveStopTimeDetails(StopTimeDetails __item)
        {
            if (__item != null && stopTimeDetails!=null && stopTimeDetails.Contains(__item))
            {
                stopTimeDetails.Remove(__item);
            }
        }
        public virtual void SetStopTimeDetailsAt(StopTimeDetails __item, int __index)
        {
            if (__item == null)
            {
                stopTimeDetails[__index] = null;
            }
            else
            {
                stopTimeDetails[__index] = __item;
            }
        }

        public virtual void ClearStopTimeDetails()
        {
            if (stopTimeDetails!=null)
            {
                var __itemsToRemove = stopTimeDetails.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveStopTimeDetails(__item);
                }
            }
        }
        [DataMember(Name="Shapes")]
        protected IList<Waypoint> shapes = new List<Waypoint>();
        public virtual List<Waypoint> Shapes
        {
            get
            {
                if (shapes is Waypoint[])
                {
                    shapes = shapes.ToList();
                }
                if (shapes == null)
                {
                    shapes = new List<Waypoint>();
                }
                return shapes.ToList();
            }
            set
            {
                if (shapes is Waypoint[])
                {
                    shapes = shapes.ToList();
                }
                if (shapes != null)
                {
                    var __itemsToDelete = new List<Waypoint>(shapes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveShapes(__item);
                    }
                }
                if(value == null)
                {
                    shapes = new List<Waypoint>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddShapes(__item);
                }
            }
        }
        public virtual void AddShapes(IList<Waypoint> __items)
        {
            foreach (var __item in __items)
            {
                AddShapes(__item);
            }
        }
        public virtual void AddShapes(Waypoint __item)
        {
            if (__item != null && shapes!=null && !shapes.Contains(__item))
            {
                shapes.Add(__item);
            }
        }

        public virtual void RemoveShapes(Waypoint __item)
        {
            if (__item != null && shapes!=null && shapes.Contains(__item))
            {
                shapes.Remove(__item);
            }
        }
        public virtual void SetShapesAt(Waypoint __item, int __index)
        {
            if (__item == null)
            {
                shapes[__index] = null;
            }
            else
            {
                shapes[__index] = __item;
            }
        }

        public virtual void ClearShapes()
        {
            if (shapes!=null)
            {
                var __itemsToRemove = shapes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveShapes(__item);
                }
            }
        }
        [DataMember(Name="Frequency")]
        protected Frequency frequency;
        public virtual Frequency Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if(Equals(frequency, value)) return;
                var __oldValue = frequency;
                if (value != null)
                {
                    frequency = value;
                }
                else
                {
                    frequency = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UrbanTrip class
/// </summary>
/// <returns>New UrbanTrip object</returns>
/// <remarks></remarks>
        public UrbanTrip(): base()
        {
            _isRail = false;
        }
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (GTFSId != null && GTFSId.Length > 100)
            {
                __errors.Add("Length of property 'GTFSId' cannot be greater than 100.");
            }
            if (Headsign != null && Headsign.Length > 100)
            {
                __errors.Add("Length of property 'Headsign' cannot be greater than 100.");
            }
            if (ShortName != null && ShortName.Length > 100)
            {
                __errors.Add("Length of property 'ShortName' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UrbanTrip' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UrbanTrip] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UrbanTrip Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UrbanTrip copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UrbanTrip)copiedObjects[this];
            copy = copy ?? new UrbanTrip();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.GTFSId = this.GTFSId;
            copy.Headsign = this.Headsign;
            copy.ShortName = this.ShortName;
            copy.Direction = this.Direction;
            copy.isRail = this.isRail;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.urbanRoute != null)
            {
                if (!copiedObjects.Contains(this.urbanRoute))
                {
                    if (asNew && reuseNestedObjects)
                        copy.UrbanRoute = this.UrbanRoute;
                    else if (asNew)
                        copy.UrbanRoute = this.UrbanRoute.Copy(deep, copiedObjects, true);
                    else
                        copy.urbanRoute = this.urbanRoute.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.UrbanRoute = (UrbanRoute)copiedObjects[this.UrbanRoute];
                    else
                        copy.urbanRoute = (UrbanRoute)copiedObjects[this.UrbanRoute];
                }
            }
            copy.stopTimeDetails = new List<StopTimeDetails>();
            if(deep && this.stopTimeDetails != null)
            {
                foreach (var __item in this.stopTimeDetails)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddStopTimeDetails(__item);
                        else
                            copy.AddStopTimeDetails(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddStopTimeDetails((StopTimeDetails)copiedObjects[__item]);
                    }
                }
            }
            copy.shapes = new List<Waypoint>();
            if(deep && this.shapes != null)
            {
                foreach (var __item in this.shapes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddShapes(__item);
                        else
                            copy.AddShapes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddShapes((Waypoint)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.frequency != null)
            {
                if (!copiedObjects.Contains(this.frequency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Frequency = this.Frequency;
                    else if (asNew)
                        copy.Frequency = this.Frequency.Copy(deep, copiedObjects, true);
                    else
                        copy.frequency = this.frequency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Frequency = (Frequency)copiedObjects[this.Frequency];
                    else
                        copy.frequency = (Frequency)copiedObjects[this.Frequency];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UrbanTrip;
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
