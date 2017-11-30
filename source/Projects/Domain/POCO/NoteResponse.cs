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
    /// The NoteResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class NoteResponse : IDomainModelClass
    {
        #region NoteResponse's Fields

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
        [DataMember(Name="Message")]
        protected string message;
        [DataMember(Name="NoteResponseKey")]
        protected Guid? noteResponseKey = Guid.Empty;
        #endregion
        #region NoteResponse's Properties
/// <summary>
/// The Message property
///
/// </summary>
///
        public virtual string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
/// <summary>
/// The NoteResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? NoteResponseKey
        {
            get
            {
                return noteResponseKey;
            }
            set
            {
                noteResponseKey = value;
            }
        }
        #endregion
        #region NoteResponse's Participant Properties
        [DataMember(Name="Note")]
        protected Note note;
        public virtual Note Note
        {
            get
            {
                return note;
            }
            set
            {
                if(Equals(note, value)) return;
                var __oldValue = note;
                if (value != null)
                {
                    note = value;
                }
                else
                {
                    if (note != null)
                    {
                        note = null;
                    }
                }
            }
        }
        [DataMember(Name="Notes")]
        protected IList<Note> notes = new List<Note>();
        public virtual List<Note> Notes
        {
            get
            {
                if (notes is Note[])
                {
                    notes = notes.ToList();
                }
                if (notes == null)
                {
                    notes = new List<Note>();
                }
                return notes.ToList();
            }
            set
            {
                if (notes is Note[])
                {
                    notes = notes.ToList();
                }
                if (notes != null)
                {
                    var __itemsToDelete = new List<Note>(notes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveNotes(__item);
                    }
                }
                if(value == null)
                {
                    notes = new List<Note>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddNotes(__item);
                }
            }
        }
        public virtual void AddNotes(IList<Note> __items)
        {
            foreach (var __item in __items)
            {
                AddNotes(__item);
            }
        }
        public virtual void AddNotes(Note __item)
        {
            if (__item != null && notes!=null && !notes.Contains(__item))
            {
                notes.Add(__item);
            }
        }

        public virtual void RemoveNotes(Note __item)
        {
            if (__item != null && notes!=null && notes.Contains(__item))
            {
                notes.Remove(__item);
            }
        }
        public virtual void SetNotesAt(Note __item, int __index)
        {
            if (__item == null)
            {
                notes[__index] = null;
            }
            else
            {
                notes[__index] = __item;
            }
        }

        public virtual void ClearNotes()
        {
            if (notes!=null)
            {
                var __itemsToRemove = notes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveNotes(__item);
                }
            }
        }
        [DataMember(Name="Error")]
        protected Error error;
        public virtual Error Error
        {
            get
            {
                return error;
            }
            set
            {
                if(Equals(error, value)) return;
                var __oldValue = error;
                if (value != null)
                {
                    error = value;
                }
                else
                {
                    if (error != null)
                    {
                        error = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the NoteResponse class
/// </summary>
/// <returns>New NoteResponse object</returns>
/// <remarks></remarks>
        public NoteResponse()
        {
            if (NoteResponseKey == null) NoteResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Message != null && Message.Length > 100)
            {
                __errors.Add("Length of property 'Message' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'NoteResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [NoteResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual NoteResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, NoteResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (NoteResponse)copiedObjects[this];
            copy = copy ?? new NoteResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.NoteResponseKey = this.NoteResponseKey;
            }
            copy.Message = this.Message;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.note != null)
            {
                if (!copiedObjects.Contains(this.note))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Note = this.Note;
                    else if (asNew)
                        copy.Note = this.Note.Copy(deep, copiedObjects, true);
                    else
                        copy.note = this.note.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Note = (Note)copiedObjects[this.Note];
                    else
                        copy.note = (Note)copiedObjects[this.Note];
                }
            }
            copy.notes = new List<Note>();
            if(deep && this.notes != null)
            {
                foreach (var __item in this.notes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddNotes(__item);
                        else
                            copy.AddNotes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddNotes((Note)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.error != null)
            {
                if (!copiedObjects.Contains(this.error))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Error = this.Error;
                    else if (asNew)
                        copy.Error = this.Error.Copy(deep, copiedObjects, true);
                    else
                        copy.error = this.error.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Error = (Error)copiedObjects[this.Error];
                    else
                        copy.error = (Error)copiedObjects[this.Error];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as NoteResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("NoteResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.NoteResponseKey.GetHashCode();
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
            return this.NoteResponseKey == default(Guid) || this.NoteResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(NoteResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.NoteResponseKey.Equals(compareTo.NoteResponseKey);
        }

        #endregion
    }
}
