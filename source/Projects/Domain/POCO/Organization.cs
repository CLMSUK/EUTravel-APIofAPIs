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
    /// The Organization class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(OperatorCompany))]

    [KnownType(typeof(RailAgency))]

    public class Organization : IDomainModelClass
    {
        #region Organization's Fields

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
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="Url")]
        protected string url;
        #endregion
        #region Organization's Properties
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
/// The Url property
///
/// </summary>
///
        public virtual string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }
        #endregion
        #region Organization's Participant Properties
        [DataMember(Name="Contact")]
        protected ContactInformation contact;
        public virtual ContactInformation Contact
        {
            get
            {
                return contact;
            }
            set
            {
                if(Equals(contact, value)) return;
                var __oldValue = contact;
                if (value != null)
                {
                    contact = value;
                }
                else
                {
                    if (contact != null)
                    {
                        contact = null;
                    }
                }
            }
        }
        [DataMember(Name="Departments")]
        protected IList<Organization> departments = new List<Organization>();
        public virtual List<Organization> Departments
        {
            get
            {
                if (departments is Organization[])
                {
                    departments = departments.ToList();
                }
                if (departments == null)
                {
                    departments = new List<Organization>();
                }
                return departments.ToList();
            }
            set
            {
                if (departments is Organization[])
                {
                    departments = departments.ToList();
                }
                if (departments != null)
                {
                    var __itemsToDelete = new List<Organization>(departments);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveDepartments(__item);
                    }
                }
                if(value == null)
                {
                    departments = new List<Organization>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddDepartments(__item);
                }
            }
        }
        public virtual void AddDepartments(IList<Organization> __items)
        {
            foreach (var __item in __items)
            {
                AddDepartments(__item);
            }
        }
        public virtual void AddDepartments(Organization __item)
        {
            if (__item != null && departments!=null && !departments.Contains(__item))
            {
                departments.Add(__item);
                if (__item.DepartmentOf != this)
                    __item.DepartmentOf = this;
            }
        }

        public virtual void RemoveDepartments(Organization __item)
        {
            if (__item != null && departments!=null && departments.Contains(__item))
            {
                departments.Remove(__item);
                __item.DepartmentOf = null;
            }
        }
        public virtual void SetDepartmentsAt(Organization __item, int __index)
        {
            if (__item == null)
            {
                departments[__index].DepartmentOf = null;
            }
            else
            {
                departments[__index] = __item;
                if (__item.DepartmentOf != this)
                    __item.DepartmentOf = this;
            }
        }

        public virtual void ClearDepartments()
        {
            if (departments!=null)
            {
                var __itemsToRemove = departments.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveDepartments(__item);
                }
            }
        }
        [DataMember(Name="DepartmentOf")]
        protected Organization departmentOf;
        public virtual Organization DepartmentOf
        {
            get
            {
                return departmentOf;
            }
            set
            {
                if(Equals(departmentOf, value)) return;
                var __oldValue = departmentOf;
                if (value != null)
                {
                    if(departmentOf != null && !Equals(departmentOf, value))
                        departmentOf.RemoveDepartments(this);
                    departmentOf = value;
                    departmentOf.AddDepartments(this);
                }
                else
                {
                    if(departmentOf != null)
                        departmentOf.RemoveDepartments(this);
                    departmentOf = null;
                }
            }
        }
        [DataMember(Name="OperatingTimezone")]
        protected Timezone operatingTimezone;
        public virtual Timezone OperatingTimezone
        {
            get
            {
                return operatingTimezone;
            }
            set
            {
                if(Equals(operatingTimezone, value)) return;
                var __oldValue = operatingTimezone;
                if (value != null)
                {
                    operatingTimezone = value;
                }
                else
                {
                    operatingTimezone = null;
                }
            }
        }
        [DataMember(Name="OperatingLanguages")]
        protected IList<Language> operatingLanguages = new List<Language>();
        public virtual List<Language> OperatingLanguages
        {
            get
            {
                if (operatingLanguages is Language[])
                {
                    operatingLanguages = operatingLanguages.ToList();
                }
                if (operatingLanguages == null)
                {
                    operatingLanguages = new List<Language>();
                }
                return operatingLanguages.ToList();
            }
            set
            {
                if (operatingLanguages is Language[])
                {
                    operatingLanguages = operatingLanguages.ToList();
                }
                if (operatingLanguages != null)
                {
                    var __itemsToDelete = new List<Language>(operatingLanguages);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveOperatingLanguages(__item);
                    }
                }
                if(value == null)
                {
                    operatingLanguages = new List<Language>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddOperatingLanguages(__item);
                }
            }
        }
        public virtual void AddOperatingLanguages(IList<Language> __items)
        {
            foreach (var __item in __items)
            {
                AddOperatingLanguages(__item);
            }
        }
        public virtual void AddOperatingLanguages(Language __item)
        {
            if (__item != null && operatingLanguages!=null && !operatingLanguages.Contains(__item))
            {
                operatingLanguages.Add(__item);
            }
        }

        public virtual void RemoveOperatingLanguages(Language __item)
        {
            if (__item != null && operatingLanguages!=null && operatingLanguages.Contains(__item))
            {
                operatingLanguages.Remove(__item);
            }
        }
        public virtual void SetOperatingLanguagesAt(Language __item, int __index)
        {
            if (__item == null)
            {
                operatingLanguages[__index] = null;
            }
            else
            {
                operatingLanguages[__index] = __item;
            }
        }

        public virtual void ClearOperatingLanguages()
        {
            if (operatingLanguages!=null)
            {
                var __itemsToRemove = operatingLanguages.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveOperatingLanguages(__item);
                }
            }
        }
        [DataMember(Name="Datasources")]
        protected IList<Datasource> datasources = new List<Datasource>();
        public virtual List<Datasource> Datasources
        {
            get
            {
                if (datasources is Datasource[])
                {
                    datasources = datasources.ToList();
                }
                if (datasources == null)
                {
                    datasources = new List<Datasource>();
                }
                return datasources.ToList();
            }
            set
            {
                if (datasources is Datasource[])
                {
                    datasources = datasources.ToList();
                }
                if (datasources != null)
                {
                    var __itemsToDelete = new List<Datasource>(datasources);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveDatasources(__item);
                    }
                }
                if(value == null)
                {
                    datasources = new List<Datasource>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddDatasources(__item);
                }
            }
        }
        public virtual void AddDatasources(IList<Datasource> __items)
        {
            foreach (var __item in __items)
            {
                AddDatasources(__item);
            }
        }
        public virtual void AddDatasources(Datasource __item)
        {
            if (__item != null && datasources!=null && !datasources.Contains(__item))
            {
                datasources.Add(__item);
            }
        }

        public virtual void RemoveDatasources(Datasource __item)
        {
            if (__item != null && datasources!=null && datasources.Contains(__item))
            {
                datasources.Remove(__item);
            }
        }
        public virtual void SetDatasourcesAt(Datasource __item, int __index)
        {
            if (__item == null)
            {
                datasources[__index] = null;
            }
            else
            {
                datasources[__index] = __item;
            }
        }

        public virtual void ClearDatasources()
        {
            if (datasources!=null)
            {
                var __itemsToRemove = datasources.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveDatasources(__item);
                }
            }
        }
        [DataMember(Name="Services")]
        protected IList<Service> services = new List<Service>();
        public virtual List<Service> Services
        {
            get
            {
                if (services is Service[])
                {
                    services = services.ToList();
                }
                if (services == null)
                {
                    services = new List<Service>();
                }
                return services.ToList();
            }
            set
            {
                if (services is Service[])
                {
                    services = services.ToList();
                }
                if (services != null)
                {
                    var __itemsToDelete = new List<Service>(services);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveServices(__item);
                    }
                }
                if(value == null)
                {
                    services = new List<Service>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddServices(__item);
                }
            }
        }
        public virtual void AddServices(IList<Service> __items)
        {
            foreach (var __item in __items)
            {
                AddServices(__item);
            }
        }
        public virtual void AddServices(Service __item)
        {
            if (__item != null && services!=null && !services.Contains(__item))
            {
                services.Add(__item);
                if (__item.Organization != this)
                    __item.Organization = this;
            }
        }

        public virtual void RemoveServices(Service __item)
        {
            if (__item != null && services!=null && services.Contains(__item))
            {
                services.Remove(__item);
                __item.Organization = null;
            }
        }
        public virtual void SetServicesAt(Service __item, int __index)
        {
            if (__item == null)
            {
                services[__index].Organization = null;
            }
            else
            {
                services[__index] = __item;
                if (__item.Organization != this)
                    __item.Organization = this;
            }
        }

        public virtual void ClearServices()
        {
            if (services!=null)
            {
                var __itemsToRemove = services.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveServices(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Organization class
/// </summary>
/// <returns>New Organization object</returns>
/// <remarks></remarks>
        public Organization() {}
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
            if (Url != null && Url.Length > 100)
            {
                __errors.Add("Length of property 'Url' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Organization' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Organization] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Organization Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Organization copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Organization)copiedObjects[this];
            copy = copy ?? new Organization();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Name = this.Name;
            copy.Description = this.Description;
            copy.Url = this.Url;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.contact != null)
            {
                if (!copiedObjects.Contains(this.contact))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Contact = this.Contact;
                    else if (asNew)
                        copy.Contact = this.Contact.Copy(deep, copiedObjects, true);
                    else
                        copy.contact = this.contact.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Contact = (ContactInformation)copiedObjects[this.Contact];
                    else
                        copy.contact = (ContactInformation)copiedObjects[this.Contact];
                }
            }
            copy.departments = new List<Organization>();
            if(deep && this.departments != null)
            {
                foreach (var __item in this.departments)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddDepartments(__item);
                        else
                            copy.AddDepartments(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddDepartments((Organization)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.departmentOf != null)
            {
                if (!copiedObjects.Contains(this.departmentOf))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DepartmentOf = this.DepartmentOf;
                    else if (asNew)
                        copy.DepartmentOf = this.DepartmentOf.Copy(deep, copiedObjects, true);
                    else
                        copy.departmentOf = this.departmentOf.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DepartmentOf = (Organization)copiedObjects[this.DepartmentOf];
                    else
                        copy.departmentOf = (Organization)copiedObjects[this.DepartmentOf];
                }
            }
            if(deep && this.operatingTimezone != null)
            {
                if (!copiedObjects.Contains(this.operatingTimezone))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OperatingTimezone = this.OperatingTimezone;
                    else if (asNew)
                        copy.OperatingTimezone = this.OperatingTimezone.Copy(deep, copiedObjects, true);
                    else
                        copy.operatingTimezone = this.operatingTimezone.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OperatingTimezone = (Timezone)copiedObjects[this.OperatingTimezone];
                    else
                        copy.operatingTimezone = (Timezone)copiedObjects[this.OperatingTimezone];
                }
            }
            copy.operatingLanguages = new List<Language>();
            if(deep && this.operatingLanguages != null)
            {
                foreach (var __item in this.operatingLanguages)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddOperatingLanguages(__item);
                        else
                            copy.AddOperatingLanguages(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddOperatingLanguages((Language)copiedObjects[__item]);
                    }
                }
            }
            copy.datasources = new List<Datasource>();
            if(deep && this.datasources != null)
            {
                foreach (var __item in this.datasources)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddDatasources(__item);
                        else
                            copy.AddDatasources(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddDatasources((Datasource)copiedObjects[__item]);
                    }
                }
            }
            copy.services = new List<Service>();
            if(deep && this.services != null)
            {
                foreach (var __item in this.services)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddServices(__item);
                        else
                            copy.AddServices(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddServices((Service)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Organization;
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
        protected bool HasSameNonDefaultIdAs(Organization compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
