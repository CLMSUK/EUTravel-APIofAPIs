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
    /// The RailRoute class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ItineraryRoute))]

    public class RailRoute : ItineraryRoute, IDomainModelClass
    {
        #region RailRoute's Fields
        #endregion
        #region RailRoute's Participant Properties
        [DataMember(Name="OriginStation")]
        protected TrainStation originStation;
        public virtual TrainStation OriginStation
        {
            get
            {
                return originStation;
            }
            set
            {
                if(Equals(originStation, value)) return;
                var __oldValue = originStation;
                if (value != null)
                {
                    originStation = value;
                }
                else
                {
                    originStation = null;
                }
            }
        }
        [DataMember(Name="DestinationStation")]
        protected TrainStation destinationStation;
        public virtual TrainStation DestinationStation
        {
            get
            {
                return destinationStation;
            }
            set
            {
                if(Equals(destinationStation, value)) return;
                var __oldValue = destinationStation;
                if (value != null)
                {
                    destinationStation = value;
                }
                else
                {
                    destinationStation = null;
                }
            }
        }
        [DataMember(Name="MarketingAgency")]
        protected RailAgency marketingAgency;
        public virtual RailAgency MarketingAgency
        {
            get
            {
                return marketingAgency;
            }
            set
            {
                if(Equals(marketingAgency, value)) return;
                var __oldValue = marketingAgency;
                if (value != null)
                {
                    marketingAgency = value;
                }
                else
                {
                    marketingAgency = null;
                }
            }
        }
        [DataMember(Name="Train")]
        protected Train train;
        public virtual Train Train
        {
            get
            {
                return train;
            }
            set
            {
                if(Equals(train, value)) return;
                var __oldValue = train;
                if (value != null)
                {
                    if(train != null && !Equals(train, value))
                        train.RemoveRailRoute(this);
                    train = value;
                    train.AddRailRoute(this);
                }
                else
                {
                    if(train != null)
                        train.RemoveRailRoute(this);
                    train = null;
                }
            }
        }
        [DataMember(Name="TrainStations")]
        protected IList<TrainStation> trainStations = new List<TrainStation>();
        public virtual List<TrainStation> TrainStations
        {
            get
            {
                if (trainStations is TrainStation[])
                {
                    trainStations = trainStations.ToList();
                }
                if (trainStations == null)
                {
                    trainStations = new List<TrainStation>();
                }
                return trainStations.ToList();
            }
            set
            {
                if (trainStations is TrainStation[])
                {
                    trainStations = trainStations.ToList();
                }
                if (trainStations != null)
                {
                    var __itemsToDelete = new List<TrainStation>(trainStations);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTrainStations(__item);
                    }
                }
                if(value == null)
                {
                    trainStations = new List<TrainStation>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTrainStations(__item);
                }
            }
        }
        public virtual void AddTrainStations(IList<TrainStation> __items)
        {
            foreach (var __item in __items)
            {
                AddTrainStations(__item);
            }
        }
        public virtual void AddTrainStations(TrainStation __item)
        {
            if (__item != null && trainStations!=null && !trainStations.Contains(__item))
            {
                trainStations.Add(__item);
            }
        }

        public virtual void RemoveTrainStations(TrainStation __item)
        {
            if (__item != null && trainStations!=null && trainStations.Contains(__item))
            {
                trainStations.Remove(__item);
            }
        }
        public virtual void SetTrainStationsAt(TrainStation __item, int __index)
        {
            if (__item == null)
            {
                trainStations[__index] = null;
            }
            else
            {
                trainStations[__index] = __item;
            }
        }

        public virtual void ClearTrainStations()
        {
            if (trainStations!=null)
            {
                var __itemsToRemove = trainStations.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTrainStations(__item);
                }
            }
        }
        [DataMember(Name="OperatingAgency")]
        protected RailAgency operatingAgency;
        public virtual RailAgency OperatingAgency
        {
            get
            {
                return operatingAgency;
            }
            set
            {
                if(Equals(operatingAgency, value)) return;
                var __oldValue = operatingAgency;
                if (value != null)
                {
                    operatingAgency = value;
                }
                else
                {
                    operatingAgency = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the RailRoute class
/// </summary>
/// <returns>New RailRoute object</returns>
/// <remarks></remarks>
        public RailRoute(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'RailRoute' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [RailRoute] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual RailRoute Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, RailRoute copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (RailRoute)copiedObjects[this];
            copy = copy ?? new RailRoute();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.originStation != null)
            {
                if (!copiedObjects.Contains(this.originStation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OriginStation = this.OriginStation;
                    else if (asNew)
                        copy.OriginStation = this.OriginStation.Copy(deep, copiedObjects, true);
                    else
                        copy.originStation = this.originStation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OriginStation = (TrainStation)copiedObjects[this.OriginStation];
                    else
                        copy.originStation = (TrainStation)copiedObjects[this.OriginStation];
                }
            }
            if(deep && this.destinationStation != null)
            {
                if (!copiedObjects.Contains(this.destinationStation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DestinationStation = this.DestinationStation;
                    else if (asNew)
                        copy.DestinationStation = this.DestinationStation.Copy(deep, copiedObjects, true);
                    else
                        copy.destinationStation = this.destinationStation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DestinationStation = (TrainStation)copiedObjects[this.DestinationStation];
                    else
                        copy.destinationStation = (TrainStation)copiedObjects[this.DestinationStation];
                }
            }
            if(deep && this.marketingAgency != null)
            {
                if (!copiedObjects.Contains(this.marketingAgency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.MarketingAgency = this.MarketingAgency;
                    else if (asNew)
                        copy.MarketingAgency = this.MarketingAgency.Copy(deep, copiedObjects, true);
                    else
                        copy.marketingAgency = this.marketingAgency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.MarketingAgency = (RailAgency)copiedObjects[this.MarketingAgency];
                    else
                        copy.marketingAgency = (RailAgency)copiedObjects[this.MarketingAgency];
                }
            }
            if(deep && this.train != null)
            {
                if (!copiedObjects.Contains(this.train))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Train = this.Train;
                    else if (asNew)
                        copy.Train = this.Train.Copy(deep, copiedObjects, true);
                    else
                        copy.train = this.train.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Train = (Train)copiedObjects[this.Train];
                    else
                        copy.train = (Train)copiedObjects[this.Train];
                }
            }
            copy.trainStations = new List<TrainStation>();
            if(deep && this.trainStations != null)
            {
                foreach (var __item in this.trainStations)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTrainStations(__item);
                        else
                            copy.AddTrainStations(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTrainStations((TrainStation)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.operatingAgency != null)
            {
                if (!copiedObjects.Contains(this.operatingAgency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OperatingAgency = this.OperatingAgency;
                    else if (asNew)
                        copy.OperatingAgency = this.OperatingAgency.Copy(deep, copiedObjects, true);
                    else
                        copy.operatingAgency = this.operatingAgency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OperatingAgency = (RailAgency)copiedObjects[this.OperatingAgency];
                    else
                        copy.operatingAgency = (RailAgency)copiedObjects[this.OperatingAgency];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as RailRoute;
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
