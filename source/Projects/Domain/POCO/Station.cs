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
    /// The Station class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Location))]

    [KnownType(typeof(DistributionStation))]

    public class Station : Location, IDomainModelClass
    {
        #region Station's Fields
        [DataMember(Name="StationCode")]
        protected string stationCode;
        [DataMember(Name="StationUrl")]
        protected string stationUrl;
        [DataMember(Name="GTFSId")]
        protected string gTFSId;
        [DataMember(Name="StationType")]
        protected EuTravel_2.BO.StationType stationType;
        [DataMember(Name="WheelchairAccess")]
        protected EuTravel_2.BO.WheelchairAccess wheelchairAccess;
        [DataMember(Name="StopHeadsign")]
        protected string stopHeadsign;
        [DataMember(Name="DistTravelled")]
        protected float? distTravelled;
        [DataMember(Name="DistributionId")]
        protected string distributionId;
        #endregion
        #region Station's Properties
/// <summary>
/// The StationCode property
///
/// </summary>
///
        public virtual string StationCode
        {
            get
            {
                return stationCode;
            }
            set
            {
                stationCode = value;
            }
        }
/// <summary>
/// The StationUrl property
///
/// </summary>
///
        public virtual string StationUrl
        {
            get
            {
                return stationUrl;
            }
            set
            {
                stationUrl = value;
            }
        }
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
/// The StationType property
///
/// </summary>
///
        public virtual EuTravel_2.BO.StationType StationType
        {
            get
            {
                return stationType;
            }
            set
            {
                stationType = value;
            }
        }
/// <summary>
/// The WheelchairAccess property
///
/// </summary>
///
        public virtual EuTravel_2.BO.WheelchairAccess WheelchairAccess
        {
            get
            {
                return wheelchairAccess;
            }
            set
            {
                wheelchairAccess = value;
            }
        }
/// <summary>
/// The StopHeadsign property
///
/// </summary>
///
        public virtual string StopHeadsign
        {
            get
            {
                return stopHeadsign;
            }
            set
            {
                stopHeadsign = value;
            }
        }
/// <summary>
/// The DistTravelled property
///
/// </summary>
///
        public virtual float? DistTravelled
        {
            get
            {
                return distTravelled;
            }
            set
            {
                distTravelled = value;
            }
        }
/// <summary>
/// The DistributionId property
///
/// </summary>
///
        public virtual string DistributionId
        {
            get
            {
                return distributionId;
            }
            set
            {
                distributionId = value;
            }
        }
        #endregion
        #region Station's Participant Properties
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
                if (__item.Station != this)
                    __item.Station = this;
            }
        }

        public virtual void RemoveStopTimeDetails(StopTimeDetails __item)
        {
            if (__item != null && stopTimeDetails!=null && stopTimeDetails.Contains(__item))
            {
                stopTimeDetails.Remove(__item);
                __item.Station = null;
            }
        }
        public virtual void SetStopTimeDetailsAt(StopTimeDetails __item, int __index)
        {
            if (__item == null)
            {
                stopTimeDetails[__index].Station = null;
            }
            else
            {
                stopTimeDetails[__index] = __item;
                if (__item.Station != this)
                    __item.Station = this;
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
        [DataMember(Name="ParentStation")]
        protected Station parentStation;
        public virtual Station ParentStation
        {
            get
            {
                return parentStation;
            }
            set
            {
                if(Equals(parentStation, value)) return;
                var __oldValue = parentStation;
                if (value != null)
                {
                    if(parentStation != null && !Equals(parentStation, value))
                        parentStation.RemoveChildrenStations(this);
                    parentStation = value;
                    parentStation.AddChildrenStations(this);
                }
                else
                {
                    if(parentStation != null)
                        parentStation.RemoveChildrenStations(this);
                    parentStation = null;
                }
            }
        }
        [DataMember(Name="ChildrenStations")]
        protected IList<Station> childrenStations = new List<Station>();
        public virtual List<Station> ChildrenStations
        {
            get
            {
                if (childrenStations is Station[])
                {
                    childrenStations = childrenStations.ToList();
                }
                if (childrenStations == null)
                {
                    childrenStations = new List<Station>();
                }
                return childrenStations.ToList();
            }
            set
            {
                if (childrenStations is Station[])
                {
                    childrenStations = childrenStations.ToList();
                }
                if (childrenStations != null)
                {
                    var __itemsToDelete = new List<Station>(childrenStations);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveChildrenStations(__item);
                    }
                }
                if(value == null)
                {
                    childrenStations = new List<Station>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddChildrenStations(__item);
                }
            }
        }
        public virtual void AddChildrenStations(IList<Station> __items)
        {
            foreach (var __item in __items)
            {
                AddChildrenStations(__item);
            }
        }
        public virtual void AddChildrenStations(Station __item)
        {
            if (__item != null && childrenStations!=null && !childrenStations.Contains(__item))
            {
                childrenStations.Add(__item);
                if (__item.ParentStation != this)
                    __item.ParentStation = this;
            }
        }

        public virtual void RemoveChildrenStations(Station __item)
        {
            if (__item != null && childrenStations!=null && childrenStations.Contains(__item))
            {
                childrenStations.Remove(__item);
                __item.ParentStation = null;
            }
        }
        public virtual void SetChildrenStationsAt(Station __item, int __index)
        {
            if (__item == null)
            {
                childrenStations[__index].ParentStation = null;
            }
            else
            {
                childrenStations[__index] = __item;
                if (__item.ParentStation != this)
                    __item.ParentStation = this;
            }
        }

        public virtual void ClearChildrenStations()
        {
            if (childrenStations!=null)
            {
                var __itemsToRemove = childrenStations.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveChildrenStations(__item);
                }
            }
        }
        [DataMember(Name="Timezone")]
        protected Timezone timezone;
        public virtual Timezone Timezone
        {
            get
            {
                return timezone;
            }
            set
            {
                if(Equals(timezone, value)) return;
                var __oldValue = timezone;
                if (value != null)
                {
                    timezone = value;
                }
                else
                {
                    timezone = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Station class
/// </summary>
/// <returns>New Station object</returns>
/// <remarks></remarks>
        public Station(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (StationCode != null && StationCode.Length > 100)
            {
                __errors.Add("Length of property 'StationCode' cannot be greater than 100.");
            }
            if (StationUrl != null && StationUrl.Length > 100)
            {
                __errors.Add("Length of property 'StationUrl' cannot be greater than 100.");
            }
            if (GTFSId != null && GTFSId.Length > 100)
            {
                __errors.Add("Length of property 'GTFSId' cannot be greater than 100.");
            }
            if (StopHeadsign != null && StopHeadsign.Length > 100)
            {
                __errors.Add("Length of property 'StopHeadsign' cannot be greater than 100.");
            }
            if (DistributionId != null && DistributionId.Length > 100)
            {
                __errors.Add("Length of property 'DistributionId' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Station' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Station] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Station Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Station copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Station)copiedObjects[this];
            copy = copy ?? new Station();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.StationCode = this.StationCode;
            copy.StationUrl = this.StationUrl;
            copy.GTFSId = this.GTFSId;
            copy.StationType = this.StationType;
            copy.WheelchairAccess = this.WheelchairAccess;
            copy.StopHeadsign = this.StopHeadsign;
            copy.DistTravelled = this.DistTravelled;
            copy.DistributionId = this.DistributionId;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
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
            if(deep && this.parentStation != null)
            {
                if (!copiedObjects.Contains(this.parentStation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ParentStation = this.ParentStation;
                    else if (asNew)
                        copy.ParentStation = this.ParentStation.Copy(deep, copiedObjects, true);
                    else
                        copy.parentStation = this.parentStation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ParentStation = (Station)copiedObjects[this.ParentStation];
                    else
                        copy.parentStation = (Station)copiedObjects[this.ParentStation];
                }
            }
            copy.childrenStations = new List<Station>();
            if(deep && this.childrenStations != null)
            {
                foreach (var __item in this.childrenStations)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddChildrenStations(__item);
                        else
                            copy.AddChildrenStations(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddChildrenStations((Station)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.timezone != null)
            {
                if (!copiedObjects.Contains(this.timezone))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Timezone = this.Timezone;
                    else if (asNew)
                        copy.Timezone = this.Timezone.Copy(deep, copiedObjects, true);
                    else
                        copy.timezone = this.timezone.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Timezone = (Timezone)copiedObjects[this.Timezone];
                    else
                        copy.timezone = (Timezone)copiedObjects[this.Timezone];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Station;
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
