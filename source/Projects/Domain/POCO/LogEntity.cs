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
    /// The LogEntity class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class LogEntity : IDomainModelClass
    {
        #region LogEntity's Fields

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
        [DataMember(Name="Action")]
        protected string action;
        [DataMember(Name="Method")]
        protected string method;
        [DataMember(Name="Successful")]
        protected bool successful;
        [DataMember(Name="Reason")]
        protected string reason;
        [DataMember(Name="RequestHash")]
        protected string requestHash;
        [DataMember(Name="ResponseHash")]
        protected string responseHash;
        [DataMember(Name="ProcessingTime")]
        protected int? processingTime;
        #endregion
        #region LogEntity's Properties
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
/// The Action property
///
/// </summary>
///
        public virtual string Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
            }
        }
/// <summary>
/// The Method property
///
/// </summary>
///
        public virtual string Method
        {
            get
            {
                return method;
            }
            set
            {
                method = value;
            }
        }
/// <summary>
/// The Successful property
///
/// </summary>
///
        public virtual bool Successful
        {
            get
            {
                return successful;
            }
            set
            {
                successful = value;
            }
        }
/// <summary>
/// The Reason property
///
/// </summary>
///
        public virtual string Reason
        {
            get
            {
                return reason;
            }
            set
            {
                reason = value;
            }
        }
/// <summary>
/// The RequestHash property
///
/// </summary>
///
        public virtual string RequestHash
        {
            get
            {
                return requestHash;
            }
            set
            {
                requestHash = value;
            }
        }
/// <summary>
/// The ResponseHash property
///
/// </summary>
///
        public virtual string ResponseHash
        {
            get
            {
                return responseHash;
            }
            set
            {
                responseHash = value;
            }
        }
/// <summary>
/// The ProcessingTime property
///
/// </summary>
///
        public virtual int? ProcessingTime
        {
            get
            {
                return processingTime;
            }
            set
            {
                processingTime = value;
            }
        }
        #endregion
        #region LogEntity's Participant Properties
        [DataMember(Name="User")]
        protected Person user;
        public virtual Person User
        {
            get
            {
                return user;
            }
            set
            {
                if(Equals(user, value)) return;
                var __oldValue = user;
                if (value != null)
                {
                    if(user != null && !Equals(user, value))
                        user.RemoveLogEntities(this);
                    user = value;
                    user.AddLogEntities(this);
                }
                else
                {
                    if(user != null)
                        user.RemoveLogEntities(this);
                    user = null;
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
                        serviceLog.RemoveLogEntity(this);
                    serviceLog = value;
                    serviceLog.AddLogEntity(this);
                }
                else
                {
                    if(serviceLog != null)
                        serviceLog.RemoveLogEntity(this);
                    serviceLog = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the LogEntity class
/// </summary>
/// <returns>New LogEntity object</returns>
/// <remarks></remarks>
        public LogEntity() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Action != null && Action.Length > 100)
            {
                __errors.Add("Length of property 'Action' cannot be greater than 100.");
            }
            if (Method != null && Method.Length > 100)
            {
                __errors.Add("Length of property 'Method' cannot be greater than 100.");
            }
            if (Reason != null && Reason.Length > 100)
            {
                __errors.Add("Length of property 'Reason' cannot be greater than 100.");
            }
            if (RequestHash != null && RequestHash.Length > 100)
            {
                __errors.Add("Length of property 'RequestHash' cannot be greater than 100.");
            }
            if (ResponseHash != null && ResponseHash.Length > 100)
            {
                __errors.Add("Length of property 'ResponseHash' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'LogEntity' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [LogEntity] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual LogEntity Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, LogEntity copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (LogEntity)copiedObjects[this];
            copy = copy ?? new LogEntity();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Action = this.Action;
            copy.Method = this.Method;
            copy.Successful = this.Successful;
            copy.Reason = this.Reason;
            copy.RequestHash = this.RequestHash;
            copy.ResponseHash = this.ResponseHash;
            copy.ProcessingTime = this.ProcessingTime;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.user != null)
            {
                if (!copiedObjects.Contains(this.user))
                {
                    if (asNew && reuseNestedObjects)
                        copy.User = this.User;
                    else if (asNew)
                        copy.User = this.User.Copy(deep, copiedObjects, true);
                    else
                        copy.user = this.user.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.User = (Person)copiedObjects[this.User];
                    else
                        copy.user = (Person)copiedObjects[this.User];
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
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as LogEntity;
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
        protected bool HasSameNonDefaultIdAs(LogEntity compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
