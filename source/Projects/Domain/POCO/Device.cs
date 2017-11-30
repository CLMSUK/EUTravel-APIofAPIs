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
    /// The Device class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Device : IDomainModelClass
    {
        #region Device's Fields

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
        [DataMember(Name="Mobile")]
        protected bool mobile;
        [DataMember(Name="OperatingSystem")]
        protected EuTravel_2.BO.OperatingSystemEnum operatingSystem;
        [DataMember(Name="OSVersion")]
        protected string oSVersion;
        [DataMember(Name="DeviceModel")]
        protected string deviceModel;
        #endregion
        #region Device's Properties
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
/// The Mobile property
///
/// </summary>
///
        public virtual bool Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
/// <summary>
/// The OperatingSystem property
///
/// </summary>
///
        public virtual EuTravel_2.BO.OperatingSystemEnum OperatingSystem
        {
            get
            {
                return operatingSystem;
            }
            set
            {
                operatingSystem = value;
            }
        }
/// <summary>
/// The OSVersion property
///
/// </summary>
///
        public virtual string OSVersion
        {
            get
            {
                return oSVersion;
            }
            set
            {
                oSVersion = value;
            }
        }
/// <summary>
/// The DeviceModel property
///
/// </summary>
///
        public virtual string DeviceModel
        {
            get
            {
                return deviceModel;
            }
            set
            {
                deviceModel = value;
            }
        }
        #endregion
        #region Device's Participant Properties
        [DataMember(Name="Person")]
        protected Person person;
        public virtual Person Person
        {
            get
            {
                return person;
            }
            set
            {
                if(Equals(person, value)) return;
                var __oldValue = person;
                if (value != null)
                {
                    if(person != null && !Equals(person, value))
                        person.RemoveDevices(this);
                    person = value;
                    person.AddDevices(this);
                }
                else
                {
                    if(person != null)
                        person.RemoveDevices(this);
                    person = null;
                }
            }
        }
        [DataMember(Name="DiaryApplication")]
        protected DiaryApplication diaryApplication;
        public virtual DiaryApplication DiaryApplication
        {
            get
            {
                return diaryApplication;
            }
            set
            {
                if(Equals(diaryApplication, value)) return;
                var __oldValue = diaryApplication;
                if (value != null)
                {
                    if(diaryApplication != null && !Equals(diaryApplication, value))
                        diaryApplication.Device = null;
                    diaryApplication = value;
                    if(diaryApplication.Device != this)
                        diaryApplication.Device = this;
                }
                else
                {
                    if (diaryApplication != null)
                    {
                        var __obj = diaryApplication;
                        diaryApplication = null;
                        __obj.Device = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Device class
/// </summary>
/// <returns>New Device object</returns>
/// <remarks></remarks>
        public Device() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (OSVersion != null && OSVersion.Length > 100)
            {
                __errors.Add("Length of property 'OSVersion' cannot be greater than 100.");
            }
            if (DeviceModel != null && DeviceModel.Length > 100)
            {
                __errors.Add("Length of property 'DeviceModel' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Device' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Device] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Device Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Device copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Device)copiedObjects[this];
            copy = copy ?? new Device();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Mobile = this.Mobile;
            copy.OperatingSystem = this.OperatingSystem;
            copy.OSVersion = this.OSVersion;
            copy.DeviceModel = this.DeviceModel;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.person != null)
            {
                if (!copiedObjects.Contains(this.person))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Person = this.Person;
                    else if (asNew)
                        copy.Person = this.Person.Copy(deep, copiedObjects, true);
                    else
                        copy.person = this.person.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Person = (Person)copiedObjects[this.Person];
                    else
                        copy.person = (Person)copiedObjects[this.Person];
                }
            }
            if(deep && this.diaryApplication != null)
            {
                if (!copiedObjects.Contains(this.diaryApplication))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DiaryApplication = this.DiaryApplication;
                    else if (asNew)
                        copy.DiaryApplication = this.DiaryApplication.Copy(deep, copiedObjects, true);
                    else
                        copy.diaryApplication = this.diaryApplication.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DiaryApplication = (DiaryApplication)copiedObjects[this.DiaryApplication];
                    else
                        copy.diaryApplication = (DiaryApplication)copiedObjects[this.DiaryApplication];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Device;
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
        protected bool HasSameNonDefaultIdAs(Device compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
