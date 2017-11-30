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
    /// The UNLocode class
    /// UNLOC 3 character Port
    /// </summary>
    [Serializable]
    [DataContract]
    public class UNLocode : IDomainModelClass
    {
        #region UNLocode's Fields

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
        [DataMember(Name="Code")]
        protected string code;
        [DataMember(Name="Functions")]
        protected string functions;
        [DataMember(Name="SubDivisionCode")]
        protected string subDivisionCode;
        [DataMember(Name="Status")]
        protected string status;
        [DataMember(Name="Remarks")]
        protected string remarks;
        [DataMember(Name="DateUpdated")]
        protected DateTime? dateUpdated;
        #endregion
        #region UNLocode's Properties
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
/// The Code property
///
/// </summary>
///
        public virtual string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
/// <summary>
/// The Functions property
///
/// </summary>
///
        public virtual string Functions
        {
            get
            {
                return functions;
            }
            set
            {
                functions = value;
            }
        }
/// <summary>
/// The SubDivisionCode property
///
/// </summary>
///
        public virtual string SubDivisionCode
        {
            get
            {
                return subDivisionCode;
            }
            set
            {
                subDivisionCode = value;
            }
        }
/// <summary>
/// The Status property
///
/// </summary>
///
        public virtual string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
/// <summary>
/// The Remarks property
///
/// </summary>
///
        public virtual string Remarks
        {
            get
            {
                return remarks;
            }
            set
            {
                remarks = value;
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
        #region UNLocode's Participant Properties
        [DataMember(Name="Location")]
        protected Location location;
        public virtual Location Location
        {
            get
            {
                return location;
            }
            set
            {
                if(Equals(location, value)) return;
                var __oldValue = location;
                if (value != null)
                {
                    if(location != null && !Equals(location, value))
                        location.UNLocode = null;
                    location = value;
                    if(location.UNLocode != this)
                        location.UNLocode = this;
                }
                else
                {
                    if (location != null)
                    {
                        var __obj = location;
                        location = null;
                        __obj.UNLocode = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UNLocode class
/// </summary>
/// <returns>New UNLocode object</returns>
/// <remarks></remarks>
        public UNLocode() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Code != null && Code.Length > 100)
            {
                __errors.Add("Length of property 'Code' cannot be greater than 100.");
            }
            if (Functions != null && Functions.Length > 100)
            {
                __errors.Add("Length of property 'Functions' cannot be greater than 100.");
            }
            if (SubDivisionCode != null && SubDivisionCode.Length > 100)
            {
                __errors.Add("Length of property 'SubDivisionCode' cannot be greater than 100.");
            }
            if (Status != null && Status.Length > 100)
            {
                __errors.Add("Length of property 'Status' cannot be greater than 100.");
            }
            if (Remarks != null && Remarks.Length > 100)
            {
                __errors.Add("Length of property 'Remarks' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UNLocode' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UNLocode] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UNLocode Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UNLocode copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UNLocode)copiedObjects[this];
            copy = copy ?? new UNLocode();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Code = this.Code;
            copy.Functions = this.Functions;
            copy.SubDivisionCode = this.SubDivisionCode;
            copy.Status = this.Status;
            copy.Remarks = this.Remarks;
            copy.DateUpdated = this.DateUpdated;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.location != null)
            {
                if (!copiedObjects.Contains(this.location))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Location = this.Location;
                    else if (asNew)
                        copy.Location = this.Location.Copy(deep, copiedObjects, true);
                    else
                        copy.location = this.location.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Location = (Location)copiedObjects[this.Location];
                    else
                        copy.location = (Location)copiedObjects[this.Location];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UNLocode;
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
        protected bool HasSameNonDefaultIdAs(UNLocode compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
