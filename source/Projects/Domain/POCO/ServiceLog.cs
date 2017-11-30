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
    /// The ServiceLog class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class ServiceLog : IDomainModelClass
    {
        #region ServiceLog's Fields

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
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="NumberOfFailedActions")]
        protected int? numberOfFailedActions;
        [DataMember(Name="NumberOfSuccessfulActions")]
        protected int? numberOfSuccessfulActions;
        #endregion
        #region ServiceLog's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The NumberOfFailedActions property
///
/// </summary>
///
        public virtual int? NumberOfFailedActions
        {
            get
            {
                return numberOfFailedActions;
            }
            set
            {
                numberOfFailedActions = value;
            }
        }
/// <summary>
/// The NumberOfSuccessfulActions property
///
/// </summary>
///
        public virtual int? NumberOfSuccessfulActions
        {
            get
            {
                return numberOfSuccessfulActions;
            }
            set
            {
                numberOfSuccessfulActions = value;
            }
        }
        #endregion
        #region ServiceLog's Participant Properties
        [DataMember(Name="Service")]
        protected Service service;
        public virtual Service Service
        {
            get
            {
                return service;
            }
            set
            {
                if(Equals(service, value)) return;
                var __oldValue = service;
                if (value != null)
                {
                    if(service != null && !Equals(service, value))
                        service.ServiceLog = null;
                    service = value;
                    if(service.ServiceLog != this)
                        service.ServiceLog = this;
                }
                else
                {
                    if (service != null)
                    {
                        var __obj = service;
                        service = null;
                        __obj.ServiceLog = null;
                    }
                }
            }
        }
        [DataMember(Name="LogEntity")]
        protected IList<LogEntity> logEntity = new List<LogEntity>();
        public virtual List<LogEntity> LogEntity
        {
            get
            {
                if (logEntity is LogEntity[])
                {
                    logEntity = logEntity.ToList();
                }
                if (logEntity == null)
                {
                    logEntity = new List<LogEntity>();
                }
                return logEntity.ToList();
            }
            set
            {
                if (logEntity is LogEntity[])
                {
                    logEntity = logEntity.ToList();
                }
                if (logEntity != null)
                {
                    var __itemsToDelete = new List<LogEntity>(logEntity);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLogEntity(__item);
                    }
                }
                if(value == null)
                {
                    logEntity = new List<LogEntity>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLogEntity(__item);
                }
            }
        }
        public virtual void AddLogEntity(IList<LogEntity> __items)
        {
            foreach (var __item in __items)
            {
                AddLogEntity(__item);
            }
        }
        public virtual void AddLogEntity(LogEntity __item)
        {
            if (__item != null && logEntity!=null && !logEntity.Contains(__item))
            {
                logEntity.Add(__item);
                if (__item.ServiceLog != this)
                    __item.ServiceLog = this;
            }
        }

        public virtual void RemoveLogEntity(LogEntity __item)
        {
            if (__item != null && logEntity!=null && logEntity.Contains(__item))
            {
                logEntity.Remove(__item);
                __item.ServiceLog = null;
            }
        }
        public virtual void SetLogEntityAt(LogEntity __item, int __index)
        {
            if (__item == null)
            {
                logEntity[__index].ServiceLog = null;
            }
            else
            {
                logEntity[__index] = __item;
                if (__item.ServiceLog != this)
                    __item.ServiceLog = this;
            }
        }

        public virtual void ClearLogEntity()
        {
            if (logEntity!=null)
            {
                var __itemsToRemove = logEntity.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLogEntity(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the ServiceLog class
/// </summary>
/// <returns>New ServiceLog object</returns>
/// <remarks></remarks>
        public ServiceLog() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Service == null)
            {
                __errors.Add("Association with 'Service' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'ServiceLog' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [ServiceLog] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual ServiceLog Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, ServiceLog copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (ServiceLog)copiedObjects[this];
            copy = copy ?? new ServiceLog();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.NumberOfFailedActions = this.NumberOfFailedActions;
            copy.NumberOfSuccessfulActions = this.NumberOfSuccessfulActions;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.service != null)
            {
                if (!copiedObjects.Contains(this.service))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Service = this.Service;
                    else if (asNew)
                        copy.Service = this.Service.Copy(deep, copiedObjects, true);
                    else
                        copy.service = this.service.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Service = (Service)copiedObjects[this.Service];
                    else
                        copy.service = (Service)copiedObjects[this.Service];
                }
            }
            copy.logEntity = new List<LogEntity>();
            if(deep && this.logEntity != null)
            {
                foreach (var __item in this.logEntity)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLogEntity(__item);
                        else
                            copy.AddLogEntity(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLogEntity((LogEntity)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as ServiceLog;
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
                __propertyKeyCache = this.GetType().GetProperty("Id");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
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
            return this.Id == default(int) || this.Id.Equals(default(int));
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
        protected bool HasSameNonDefaultIdAs(ServiceLog compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
