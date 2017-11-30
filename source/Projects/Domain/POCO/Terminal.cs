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
    /// The Terminal class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Location))]

    public class Terminal : Location, IDomainModelClass
    {
        #region Terminal's Fields
        [DataMember(Name="Code")]
        protected string code;
        #endregion
        #region Terminal's Properties
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
        #endregion
        #region Terminal's Participant Properties
        [DataMember(Name="Airport")]
        protected Airport airport;
        public virtual Airport Airport
        {
            get
            {
                return airport;
            }
            set
            {
                if(Equals(airport, value)) return;
                var __oldValue = airport;
                if (value != null)
                {
                    if(airport != null && !Equals(airport, value))
                        airport.RemoveTerminals(this);
                    airport = value;
                    airport.AddTerminals(this);
                }
                else
                {
                    if(airport != null)
                        airport.RemoveTerminals(this);
                    airport = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Terminal class
/// </summary>
/// <returns>New Terminal object</returns>
/// <remarks></remarks>
        public Terminal(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (Code != null && Code.Length > 100)
            {
                __errors.Add("Length of property 'Code' cannot be greater than 100.");
            }
            if (Airport == null)
            {
                __errors.Add("Association with 'Airport' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Terminal' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Terminal] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Terminal Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Terminal copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Terminal)copiedObjects[this];
            copy = copy ?? new Terminal();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.Code = this.Code;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.airport != null)
            {
                if (!copiedObjects.Contains(this.airport))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Airport = this.Airport;
                    else if (asNew)
                        copy.Airport = this.Airport.Copy(deep, copiedObjects, true);
                    else
                        copy.airport = this.airport.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Airport = (Airport)copiedObjects[this.Airport];
                    else
                        copy.airport = (Airport)copiedObjects[this.Airport];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Terminal;
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
