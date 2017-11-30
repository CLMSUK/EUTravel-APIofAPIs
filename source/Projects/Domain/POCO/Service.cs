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
    /// The Service class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Service : IDomainModelClass
    {
        #region Service's Fields

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
        [DataMember(Name="ServiceType")]
        protected EuTravel_2.BO.ServiceSource serviceType;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="DateStarted")]
        protected DateTime? dateStarted;
        [DataMember(Name="DateUpdated")]
        protected DateTime? dateUpdated;
        #endregion
        #region Service's Properties
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
/// The ServiceType property
///
/// </summary>
///
        public virtual EuTravel_2.BO.ServiceSource ServiceType
        {
            get
            {
                return serviceType;
            }
            set
            {
                serviceType = value;
            }
        }
/// <summary>
/// The Name property
///
/// </summary>
///
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
/// <summary>
/// The Description property
///
/// </summary>
///
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
/// <summary>
/// The DateStarted property
///
/// </summary>
///
        public virtual DateTime? DateStarted
        {
            get
            {
                return dateStarted;
            }
            set
            {
                dateStarted = value;
            }
        }
/// <summary>
/// The DateUpdated property
///
/// </summary>
///
        public virtual DateTime? DateUpdated
        {
            get
            {
                return dateUpdated;
            }
            set
            {
                dateUpdated = value;
            }
        }
        #endregion
        #region Service's Participant Properties
        [DataMember(Name="Organization")]
        protected Organization organization;
        public virtual Organization Organization
        {
            get
            {
                return organization;
            }
            set
            {
                if(Equals(organization, value)) return;
                var __oldValue = organization;
                if (value != null)
                {
                    if(organization != null && !Equals(organization, value))
                        organization.RemoveServices(this);
                    organization = value;
                    organization.AddServices(this);
                }
                else
                {
                    if(organization != null)
                        organization.RemoveServices(this);
                    organization = null;
                }
            }
        }
        [DataMember(Name="ServiceLog")]
        protected ServiceLog serviceLog;
        public virtual ServiceLog ServiceLog
        {
            get
            {
                return serviceLog;
            }
            set
            {
                if(Equals(serviceLog, value)) return;
                var __oldValue = serviceLog;
                if (value != null)
                {
                    if(serviceLog != null && !Equals(serviceLog, value))
                        serviceLog.Service = null;
                    serviceLog = value;
                    if(serviceLog.Service != this)
                        serviceLog.Service = this;
                }
                else
                {
                    if (serviceLog != null)
                    {
                        var __obj = serviceLog;
                        serviceLog = null;
                        __obj.Service = null;
                    }
                }
            }
        }
        [DataMember(Name="ServiceMetrics")]
        protected IList<ServiceMetric> serviceMetrics = new List<ServiceMetric>();
        public virtual List<ServiceMetric> ServiceMetrics
        {
            get
            {
                if (serviceMetrics is ServiceMetric[])
                {
                    serviceMetrics = serviceMetrics.ToList();
                }
                if (serviceMetrics == null)
                {
                    serviceMetrics = new List<ServiceMetric>();
                }
                return serviceMetrics.ToList();
            }
            set
            {
                if (serviceMetrics is ServiceMetric[])
                {
                    serviceMetrics = serviceMetrics.ToList();
                }
                if (serviceMetrics != null)
                {
                    var __itemsToDelete = new List<ServiceMetric>(serviceMetrics);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveServiceMetrics(__item);
                    }
                }
                if(value == null)
                {
                    serviceMetrics = new List<ServiceMetric>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddServiceMetrics(__item);
                }
            }
        }
        public virtual void AddServiceMetrics(IList<ServiceMetric> __items)
        {
            foreach (var __item in __items)
            {
                AddServiceMetrics(__item);
            }
        }
        public virtual void AddServiceMetrics(ServiceMetric __item)
        {
            if (__item != null && serviceMetrics!=null && !serviceMetrics.Contains(__item))
            {
                serviceMetrics.Add(__item);
                if (__item.Service != this)
                    __item.Service = this;
            }
        }

        public virtual void RemoveServiceMetrics(ServiceMetric __item)
        {
            if (__item != null && serviceMetrics!=null && serviceMetrics.Contains(__item))
            {
                serviceMetrics.Remove(__item);
                __item.Service = null;
            }
        }
        public virtual void SetServiceMetricsAt(ServiceMetric __item, int __index)
        {
            if (__item == null)
            {
                serviceMetrics[__index].Service = null;
            }
            else
            {
                serviceMetrics[__index] = __item;
                if (__item.Service != this)
                    __item.Service = this;
            }
        }

        public virtual void ClearServiceMetrics()
        {
            if (serviceMetrics!=null)
            {
                var __itemsToRemove = serviceMetrics.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveServiceMetrics(__item);
                }
            }
        }
        [DataMember(Name="ServiceStatistics")]
        protected ServiceStatistics serviceStatistics;
        public virtual ServiceStatistics ServiceStatistics
        {
            get
            {
                return serviceStatistics;
            }
            set
            {
                if(Equals(serviceStatistics, value)) return;
                var __oldValue = serviceStatistics;
                if (value != null)
                {
                    if(serviceStatistics != null && !Equals(serviceStatistics, value))
                        serviceStatistics.Service = null;
                    serviceStatistics = value;
                    if(serviceStatistics.Service != this)
                        serviceStatistics.Service = this;
                }
                else
                {
                    if (serviceStatistics != null)
                    {
                        var __obj = serviceStatistics;
                        serviceStatistics = null;
                        __obj.Service = null;
                    }
                }
            }
        }
        [DataMember(Name="UserPreferences")]
        protected IList<UserPreference> userPreferences = new List<UserPreference>();
        public virtual List<UserPreference> UserPreferences
        {
            get
            {
                if (userPreferences is UserPreference[])
                {
                    userPreferences = userPreferences.ToList();
                }
                if (userPreferences == null)
                {
                    userPreferences = new List<UserPreference>();
                }
                return userPreferences.ToList();
            }
            set
            {
                if (userPreferences is UserPreference[])
                {
                    userPreferences = userPreferences.ToList();
                }
                if (userPreferences != null)
                {
                    var __itemsToDelete = new List<UserPreference>(userPreferences);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUserPreferences(__item);
                    }
                }
                if(value == null)
                {
                    userPreferences = new List<UserPreference>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUserPreferences(__item);
                }
            }
        }
        public virtual void AddUserPreferences(IList<UserPreference> __items)
        {
            foreach (var __item in __items)
            {
                AddUserPreferences(__item);
            }
        }
        public virtual void AddUserPreferences(UserPreference __item)
        {
            if (__item != null && userPreferences!=null && !userPreferences.Contains(__item))
            {
                userPreferences.Add(__item);
                if (__item.Service != this)
                    __item.Service = this;
            }
        }

        public virtual void RemoveUserPreferences(UserPreference __item)
        {
            if (__item != null && userPreferences!=null && userPreferences.Contains(__item))
            {
                userPreferences.Remove(__item);
                __item.Service = null;
            }
        }
        public virtual void SetUserPreferencesAt(UserPreference __item, int __index)
        {
            if (__item == null)
            {
                userPreferences[__index].Service = null;
            }
            else
            {
                userPreferences[__index] = __item;
                if (__item.Service != this)
                    __item.Service = this;
            }
        }

        public virtual void ClearUserPreferences()
        {
            if (userPreferences!=null)
            {
                var __itemsToRemove = userPreferences.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUserPreferences(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Service class
/// </summary>
/// <returns>New Service object</returns>
/// <remarks></remarks>
        public Service() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (Organization == null)
            {
                __errors.Add("Association with 'Organization' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Service' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Service] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Service Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Service copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Service)copiedObjects[this];
            copy = copy ?? new Service();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.ServiceType = this.ServiceType;
            copy.Name = this.Name;
            copy.Description = this.Description;
            copy.DateStarted = this.DateStarted;
            copy.DateUpdated = this.DateUpdated;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.organization != null)
            {
                if (!copiedObjects.Contains(this.organization))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Organization = this.Organization;
                    else if (asNew)
                        copy.Organization = this.Organization.Copy(deep, copiedObjects, true);
                    else
                        copy.organization = this.organization.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Organization = (Organization)copiedObjects[this.Organization];
                    else
                        copy.organization = (Organization)copiedObjects[this.Organization];
                }
            }
            if(deep && this.serviceLog != null)
            {
                if (!copiedObjects.Contains(this.serviceLog))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ServiceLog = this.ServiceLog;
                    else if (asNew)
                        copy.ServiceLog = this.ServiceLog.Copy(deep, copiedObjects, true);
                    else
                        copy.serviceLog = this.serviceLog.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ServiceLog = (ServiceLog)copiedObjects[this.ServiceLog];
                    else
                        copy.serviceLog = (ServiceLog)copiedObjects[this.ServiceLog];
                }
            }
            copy.serviceMetrics = new List<ServiceMetric>();
            if(deep && this.serviceMetrics != null)
            {
                foreach (var __item in this.serviceMetrics)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddServiceMetrics(__item);
                        else
                            copy.AddServiceMetrics(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddServiceMetrics((ServiceMetric)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.serviceStatistics != null)
            {
                if (!copiedObjects.Contains(this.serviceStatistics))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ServiceStatistics = this.ServiceStatistics;
                    else if (asNew)
                        copy.ServiceStatistics = this.ServiceStatistics.Copy(deep, copiedObjects, true);
                    else
                        copy.serviceStatistics = this.serviceStatistics.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ServiceStatistics = (ServiceStatistics)copiedObjects[this.ServiceStatistics];
                    else
                        copy.serviceStatistics = (ServiceStatistics)copiedObjects[this.ServiceStatistics];
                }
            }
            copy.userPreferences = new List<UserPreference>();
            if(deep && this.userPreferences != null)
            {
                foreach (var __item in this.userPreferences)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUserPreferences(__item);
                        else
                            copy.AddUserPreferences(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUserPreferences((UserPreference)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Service;
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
        protected bool HasSameNonDefaultIdAs(Service compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
