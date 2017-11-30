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
    /// The Person class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ApplicationUser))]

    [KnownType(typeof(Passenger))]

    public class Person : ApplicationUser, IDomainModelClass
    {
        #region Person's Fields
        [DataMember(Name="Forename")]
        protected string forename;
        [DataMember(Name="Surname")]
        protected string surname;
        [DataMember(Name="DateOfBirth")]
        protected DateTime? dateOfBirth;
        [DataMember(Name="MiddleName")]
        protected string middleName;
        [DataMember(Name="FullName")]
        protected string fullName;
        [DataMember(Name="Guest")]
        protected bool guest;
        [DataMember(Name="IPAddress")]
        protected string iPAddress;
        [DataMember(Name="Gender")]
        protected EuTravel_2.BO.Gender gender;
        [DataMember(Name="Age")]
        protected int? age;
        [DataMember(Name="Title")]
        protected EuTravel_2.BO.TitleEnum title;
        #endregion
        #region Person's Properties
/// <summary>
/// The Forename property
///
/// </summary>
///
        public virtual string Forename
        {
            get
            {
                return forename;
            }
            set
            {
                forename = value;
            }
        }
/// <summary>
/// The Surname property
///
/// </summary>
///
        public virtual string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
/// <summary>
/// The DateOfBirth property
///
/// </summary>
///
        public virtual DateTime? DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }
/// <summary>
/// The MiddleName property
///
/// </summary>
///
        public virtual string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }
/// <summary>
/// The FullName property
///
/// </summary>
///
        public virtual string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
/// <summary>
/// The Guest property
///
/// </summary>
///
        public virtual bool Guest
        {
            get
            {
                return guest;
            }
            set
            {
                guest = value;
            }
        }
/// <summary>
/// The IPAddress property
///
/// </summary>
///
        public virtual string IPAddress
        {
            get
            {
                return iPAddress;
            }
            set
            {
                iPAddress = value;
            }
        }
/// <summary>
/// The Gender property
///
/// </summary>
///
        public virtual EuTravel_2.BO.Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
/// <summary>
/// The Age property
///
/// </summary>
///
        public virtual int? Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
/// <summary>
/// The Title property
///
/// </summary>
///
        public virtual EuTravel_2.BO.TitleEnum Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        #endregion
        #region Person's Participant Properties
        [DataMember(Name="Identification")]
        protected IList<Identification> identification = new List<Identification>();
        public virtual List<Identification> Identification
        {
            get
            {
                if (identification is Identification[])
                {
                    identification = identification.ToList();
                }
                if (identification == null)
                {
                    identification = new List<Identification>();
                }
                return identification.ToList();
            }
            set
            {
                if (identification is Identification[])
                {
                    identification = identification.ToList();
                }
                if (identification != null)
                {
                    var __itemsToDelete = new List<Identification>(identification);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveIdentification(__item);
                    }
                }
                if(value == null)
                {
                    identification = new List<Identification>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddIdentification(__item);
                }
            }
        }
        public virtual void AddIdentification(IList<Identification> __items)
        {
            foreach (var __item in __items)
            {
                AddIdentification(__item);
            }
        }
        public virtual void AddIdentification(Identification __item)
        {
            if (__item != null && identification!=null && !identification.Contains(__item))
            {
                identification.Add(__item);
                if (__item.Person != this)
                    __item.Person = this;
            }
        }

        public virtual void RemoveIdentification(Identification __item)
        {
            if (__item != null && identification!=null && identification.Contains(__item))
            {
                identification.Remove(__item);
                __item.Person = null;
            }
        }
        public virtual void SetIdentificationAt(Identification __item, int __index)
        {
            if (__item == null)
            {
                identification[__index].Person = null;
            }
            else
            {
                identification[__index] = __item;
                if (__item.Person != this)
                    __item.Person = this;
            }
        }

        public virtual void ClearIdentification()
        {
            if (identification!=null)
            {
                var __itemsToRemove = identification.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveIdentification(__item);
                }
            }
        }
        [DataMember(Name="Prefix")]
        protected Prefixes prefix;
        public virtual Prefixes Prefix
        {
            get
            {
                return prefix;
            }
            set
            {
                if(Equals(prefix, value)) return;
                var __oldValue = prefix;
                if (value != null)
                {
                    prefix = value;
                }
                else
                {
                    prefix = null;
                }
            }
        }
        [DataMember(Name="Sufix")]
        protected Suffixes sufix;
        public virtual Suffixes Sufix
        {
            get
            {
                return sufix;
            }
            set
            {
                if(Equals(sufix, value)) return;
                var __oldValue = sufix;
                if (value != null)
                {
                    sufix = value;
                }
                else
                {
                    sufix = null;
                }
            }
        }
        [DataMember(Name="ContactInformation")]
        protected ContactInformation contactInformation;
        public virtual ContactInformation ContactInformation
        {
            get
            {
                return contactInformation;
            }
            set
            {
                if(Equals(contactInformation, value)) return;
                var __oldValue = contactInformation;
                if (value != null)
                {
                    if(contactInformation != null && !Equals(contactInformation, value))
                        contactInformation.Person = null;
                    contactInformation = value;
                    if(contactInformation.Person != this)
                        contactInformation.Person = this;
                }
                else
                {
                    if (contactInformation != null)
                    {
                        var __obj = contactInformation;
                        contactInformation = null;
                        __obj.Person = null;
                    }
                }
            }
        }
        [DataMember(Name="Nationality")]
        protected Country nationality;
        public virtual Country Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                if(Equals(nationality, value)) return;
                var __oldValue = nationality;
                if (value != null)
                {
                    nationality = value;
                }
                else
                {
                    nationality = null;
                }
            }
        }
        [DataMember(Name="ShoppingTransactions")]
        protected IList<Transaction> shoppingTransactions = new List<Transaction>();
        public virtual List<Transaction> ShoppingTransactions
        {
            get
            {
                if (shoppingTransactions is Transaction[])
                {
                    shoppingTransactions = shoppingTransactions.ToList();
                }
                if (shoppingTransactions == null)
                {
                    shoppingTransactions = new List<Transaction>();
                }
                return shoppingTransactions.ToList();
            }
            set
            {
                if (shoppingTransactions is Transaction[])
                {
                    shoppingTransactions = shoppingTransactions.ToList();
                }
                if (shoppingTransactions != null)
                {
                    var __itemsToDelete = new List<Transaction>(shoppingTransactions);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveShoppingTransactions(__item);
                    }
                }
                if(value == null)
                {
                    shoppingTransactions = new List<Transaction>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddShoppingTransactions(__item);
                }
            }
        }
        public virtual void AddShoppingTransactions(IList<Transaction> __items)
        {
            foreach (var __item in __items)
            {
                AddShoppingTransactions(__item);
            }
        }
        public virtual void AddShoppingTransactions(Transaction __item)
        {
            if (__item != null && shoppingTransactions!=null && !shoppingTransactions.Contains(__item))
            {
                shoppingTransactions.Add(__item);
                if (__item.Person != this)
                    __item.Person = this;
            }
        }

        public virtual void RemoveShoppingTransactions(Transaction __item)
        {
            if (__item != null && shoppingTransactions!=null && shoppingTransactions.Contains(__item))
            {
                shoppingTransactions.Remove(__item);
                __item.Person = null;
            }
        }
        public virtual void SetShoppingTransactionsAt(Transaction __item, int __index)
        {
            if (__item == null)
            {
                shoppingTransactions[__index].Person = null;
            }
            else
            {
                shoppingTransactions[__index] = __item;
                if (__item.Person != this)
                    __item.Person = this;
            }
        }

        public virtual void ClearShoppingTransactions()
        {
            if (shoppingTransactions!=null)
            {
                var __itemsToRemove = shoppingTransactions.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveShoppingTransactions(__item);
                }
            }
        }
        [DataMember(Name="TaggedIn")]
        protected IList<Photograph> taggedIn = new List<Photograph>();
        public virtual List<Photograph> TaggedIn
        {
            get
            {
                if (taggedIn is Photograph[])
                {
                    taggedIn = taggedIn.ToList();
                }
                if (taggedIn == null)
                {
                    taggedIn = new List<Photograph>();
                }
                return taggedIn.ToList();
            }
            set
            {
                if (taggedIn is Photograph[])
                {
                    taggedIn = taggedIn.ToList();
                }
                if (taggedIn != null)
                {
                    var __itemsToDelete = new List<Photograph>(taggedIn);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTaggedIn(__item);
                    }
                }
                if(value == null)
                {
                    taggedIn = new List<Photograph>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTaggedIn(__item);
                }
            }
        }
        public virtual void AddTaggedIn(IList<Photograph> __items)
        {
            foreach (var __item in __items)
            {
                AddTaggedIn(__item);
            }
        }
        public virtual void AddTaggedIn(Photograph __item)
        {
            if (__item != null && taggedIn!=null && !taggedIn.Contains(__item))
            {
                taggedIn.Add(__item);
                if (!__item.TaggedPeople.Contains(this))
                    __item.AddTaggedPeople(this);
            }
        }

        public virtual void RemoveTaggedIn(Photograph __item)
        {
            if (__item != null && taggedIn!=null && taggedIn.Contains(__item))
            {
                taggedIn.Remove(__item);
                if(__item.TaggedPeople.Contains(this))
                    __item.RemoveTaggedPeople(this);
            }
        }
        public virtual void SetTaggedInAt(Photograph __item, int __index)
        {
            if (__item == null)
            {
                taggedIn[__index].RemoveTaggedPeople(this);
            }
            else
            {
                taggedIn[__index] = __item;
                if (!__item.TaggedPeople.Contains(this))
                    __item.AddTaggedPeople(this);
            }
        }

        public virtual void ClearTaggedIn()
        {
            if (taggedIn!=null)
            {
                var __itemsToRemove = taggedIn.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTaggedIn(__item);
                }
            }
        }
        [DataMember(Name="MyPhotos")]
        protected IList<Photograph> myPhotos = new List<Photograph>();
        public virtual List<Photograph> MyPhotos
        {
            get
            {
                if (myPhotos is Photograph[])
                {
                    myPhotos = myPhotos.ToList();
                }
                if (myPhotos == null)
                {
                    myPhotos = new List<Photograph>();
                }
                return myPhotos.ToList();
            }
            set
            {
                if (myPhotos is Photograph[])
                {
                    myPhotos = myPhotos.ToList();
                }
                if (myPhotos != null)
                {
                    var __itemsToDelete = new List<Photograph>(myPhotos);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveMyPhotos(__item);
                    }
                }
                if(value == null)
                {
                    myPhotos = new List<Photograph>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddMyPhotos(__item);
                }
            }
        }
        public virtual void AddMyPhotos(IList<Photograph> __items)
        {
            foreach (var __item in __items)
            {
                AddMyPhotos(__item);
            }
        }
        public virtual void AddMyPhotos(Photograph __item)
        {
            if (__item != null && myPhotos!=null && !myPhotos.Contains(__item))
            {
                myPhotos.Add(__item);
                if (__item.TakenBy != this)
                    __item.TakenBy = this;
            }
        }

        public virtual void RemoveMyPhotos(Photograph __item)
        {
            if (__item != null && myPhotos!=null && myPhotos.Contains(__item))
            {
                myPhotos.Remove(__item);
                __item.TakenBy = null;
            }
        }
        public virtual void SetMyPhotosAt(Photograph __item, int __index)
        {
            if (__item == null)
            {
                myPhotos[__index].TakenBy = null;
            }
            else
            {
                myPhotos[__index] = __item;
                if (__item.TakenBy != this)
                    __item.TakenBy = this;
            }
        }

        public virtual void ClearMyPhotos()
        {
            if (myPhotos!=null)
            {
                var __itemsToRemove = myPhotos.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveMyPhotos(__item);
                }
            }
        }
        [DataMember(Name="LikedPointsOfInterest")]
        protected IList<PointOfInterest> likedPointsOfInterest = new List<PointOfInterest>();
        public virtual List<PointOfInterest> LikedPointsOfInterest
        {
            get
            {
                if (likedPointsOfInterest is PointOfInterest[])
                {
                    likedPointsOfInterest = likedPointsOfInterest.ToList();
                }
                if (likedPointsOfInterest == null)
                {
                    likedPointsOfInterest = new List<PointOfInterest>();
                }
                return likedPointsOfInterest.ToList();
            }
            set
            {
                if (likedPointsOfInterest is PointOfInterest[])
                {
                    likedPointsOfInterest = likedPointsOfInterest.ToList();
                }
                if (likedPointsOfInterest != null)
                {
                    var __itemsToDelete = new List<PointOfInterest>(likedPointsOfInterest);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLikedPointsOfInterest(__item);
                    }
                }
                if(value == null)
                {
                    likedPointsOfInterest = new List<PointOfInterest>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLikedPointsOfInterest(__item);
                }
            }
        }
        public virtual void AddLikedPointsOfInterest(IList<PointOfInterest> __items)
        {
            foreach (var __item in __items)
            {
                AddLikedPointsOfInterest(__item);
            }
        }
        public virtual void AddLikedPointsOfInterest(PointOfInterest __item)
        {
            if (__item != null && likedPointsOfInterest!=null && !likedPointsOfInterest.Contains(__item))
            {
                likedPointsOfInterest.Add(__item);
                if (!__item.LikedBy.Contains(this))
                    __item.AddLikedBy(this);
            }
        }

        public virtual void RemoveLikedPointsOfInterest(PointOfInterest __item)
        {
            if (__item != null && likedPointsOfInterest!=null && likedPointsOfInterest.Contains(__item))
            {
                likedPointsOfInterest.Remove(__item);
                if(__item.LikedBy.Contains(this))
                    __item.RemoveLikedBy(this);
            }
        }
        public virtual void SetLikedPointsOfInterestAt(PointOfInterest __item, int __index)
        {
            if (__item == null)
            {
                likedPointsOfInterest[__index].RemoveLikedBy(this);
            }
            else
            {
                likedPointsOfInterest[__index] = __item;
                if (!__item.LikedBy.Contains(this))
                    __item.AddLikedBy(this);
            }
        }

        public virtual void ClearLikedPointsOfInterest()
        {
            if (likedPointsOfInterest!=null)
            {
                var __itemsToRemove = likedPointsOfInterest.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLikedPointsOfInterest(__item);
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
                if (__item.CreatedBy != this)
                    __item.CreatedBy = this;
            }
        }

        public virtual void RemoveNotes(Note __item)
        {
            if (__item != null && notes!=null && notes.Contains(__item))
            {
                notes.Remove(__item);
                __item.CreatedBy = null;
            }
        }
        public virtual void SetNotesAt(Note __item, int __index)
        {
            if (__item == null)
            {
                notes[__index].CreatedBy = null;
            }
            else
            {
                notes[__index] = __item;
                if (__item.CreatedBy != this)
                    __item.CreatedBy = this;
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
        [DataMember(Name="UploadedPointsOfInterest")]
        protected IList<PointOfInterest> uploadedPointsOfInterest = new List<PointOfInterest>();
        public virtual List<PointOfInterest> UploadedPointsOfInterest
        {
            get
            {
                if (uploadedPointsOfInterest is PointOfInterest[])
                {
                    uploadedPointsOfInterest = uploadedPointsOfInterest.ToList();
                }
                if (uploadedPointsOfInterest == null)
                {
                    uploadedPointsOfInterest = new List<PointOfInterest>();
                }
                return uploadedPointsOfInterest.ToList();
            }
            set
            {
                if (uploadedPointsOfInterest is PointOfInterest[])
                {
                    uploadedPointsOfInterest = uploadedPointsOfInterest.ToList();
                }
                if (uploadedPointsOfInterest != null)
                {
                    var __itemsToDelete = new List<PointOfInterest>(uploadedPointsOfInterest);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUploadedPointsOfInterest(__item);
                    }
                }
                if(value == null)
                {
                    uploadedPointsOfInterest = new List<PointOfInterest>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUploadedPointsOfInterest(__item);
                }
            }
        }
        public virtual void AddUploadedPointsOfInterest(IList<PointOfInterest> __items)
        {
            foreach (var __item in __items)
            {
                AddUploadedPointsOfInterest(__item);
            }
        }
        public virtual void AddUploadedPointsOfInterest(PointOfInterest __item)
        {
            if (__item != null && uploadedPointsOfInterest!=null && !uploadedPointsOfInterest.Contains(__item))
            {
                uploadedPointsOfInterest.Add(__item);
                if (__item.UploadedBy != this)
                    __item.UploadedBy = this;
            }
        }

        public virtual void RemoveUploadedPointsOfInterest(PointOfInterest __item)
        {
            if (__item != null && uploadedPointsOfInterest!=null && uploadedPointsOfInterest.Contains(__item))
            {
                uploadedPointsOfInterest.Remove(__item);
                __item.UploadedBy = null;
            }
        }
        public virtual void SetUploadedPointsOfInterestAt(PointOfInterest __item, int __index)
        {
            if (__item == null)
            {
                uploadedPointsOfInterest[__index].UploadedBy = null;
            }
            else
            {
                uploadedPointsOfInterest[__index] = __item;
                if (__item.UploadedBy != this)
                    __item.UploadedBy = this;
            }
        }

        public virtual void ClearUploadedPointsOfInterest()
        {
            if (uploadedPointsOfInterest!=null)
            {
                var __itemsToRemove = uploadedPointsOfInterest.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUploadedPointsOfInterest(__item);
                }
            }
        }
        [DataMember(Name="LikedTrips")]
        protected IList<Trip> likedTrips = new List<Trip>();
        public virtual List<Trip> LikedTrips
        {
            get
            {
                if (likedTrips is Trip[])
                {
                    likedTrips = likedTrips.ToList();
                }
                if (likedTrips == null)
                {
                    likedTrips = new List<Trip>();
                }
                return likedTrips.ToList();
            }
            set
            {
                if (likedTrips is Trip[])
                {
                    likedTrips = likedTrips.ToList();
                }
                if (likedTrips != null)
                {
                    var __itemsToDelete = new List<Trip>(likedTrips);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLikedTrips(__item);
                    }
                }
                if(value == null)
                {
                    likedTrips = new List<Trip>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLikedTrips(__item);
                }
            }
        }
        public virtual void AddLikedTrips(IList<Trip> __items)
        {
            foreach (var __item in __items)
            {
                AddLikedTrips(__item);
            }
        }
        public virtual void AddLikedTrips(Trip __item)
        {
            if (__item != null && likedTrips!=null && !likedTrips.Contains(__item))
            {
                likedTrips.Add(__item);
                if (!__item.LikedBy.Contains(this))
                    __item.AddLikedBy(this);
            }
        }

        public virtual void RemoveLikedTrips(Trip __item)
        {
            if (__item != null && likedTrips!=null && likedTrips.Contains(__item))
            {
                likedTrips.Remove(__item);
                if(__item.LikedBy.Contains(this))
                    __item.RemoveLikedBy(this);
            }
        }
        public virtual void SetLikedTripsAt(Trip __item, int __index)
        {
            if (__item == null)
            {
                likedTrips[__index].RemoveLikedBy(this);
            }
            else
            {
                likedTrips[__index] = __item;
                if (!__item.LikedBy.Contains(this))
                    __item.AddLikedBy(this);
            }
        }

        public virtual void ClearLikedTrips()
        {
            if (likedTrips!=null)
            {
                var __itemsToRemove = likedTrips.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLikedTrips(__item);
                }
            }
        }
        [DataMember(Name="LikedPhotos")]
        protected IList<Photograph> likedPhotos = new List<Photograph>();
        public virtual List<Photograph> LikedPhotos
        {
            get
            {
                if (likedPhotos is Photograph[])
                {
                    likedPhotos = likedPhotos.ToList();
                }
                if (likedPhotos == null)
                {
                    likedPhotos = new List<Photograph>();
                }
                return likedPhotos.ToList();
            }
            set
            {
                if (likedPhotos is Photograph[])
                {
                    likedPhotos = likedPhotos.ToList();
                }
                if (likedPhotos != null)
                {
                    var __itemsToDelete = new List<Photograph>(likedPhotos);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLikedPhotos(__item);
                    }
                }
                if(value == null)
                {
                    likedPhotos = new List<Photograph>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLikedPhotos(__item);
                }
            }
        }
        public virtual void AddLikedPhotos(IList<Photograph> __items)
        {
            foreach (var __item in __items)
            {
                AddLikedPhotos(__item);
            }
        }
        public virtual void AddLikedPhotos(Photograph __item)
        {
            if (__item != null && likedPhotos!=null && !likedPhotos.Contains(__item))
            {
                likedPhotos.Add(__item);
                if (!__item.LikedBy.Contains(this))
                    __item.AddLikedBy(this);
            }
        }

        public virtual void RemoveLikedPhotos(Photograph __item)
        {
            if (__item != null && likedPhotos!=null && likedPhotos.Contains(__item))
            {
                likedPhotos.Remove(__item);
                if(__item.LikedBy.Contains(this))
                    __item.RemoveLikedBy(this);
            }
        }
        public virtual void SetLikedPhotosAt(Photograph __item, int __index)
        {
            if (__item == null)
            {
                likedPhotos[__index].RemoveLikedBy(this);
            }
            else
            {
                likedPhotos[__index] = __item;
                if (!__item.LikedBy.Contains(this))
                    __item.AddLikedBy(this);
            }
        }

        public virtual void ClearLikedPhotos()
        {
            if (likedPhotos!=null)
            {
                var __itemsToRemove = likedPhotos.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLikedPhotos(__item);
                }
            }
        }
        [DataMember(Name="BookedTrips")]
        protected IList<Trip> bookedTrips = new List<Trip>();
        public virtual List<Trip> BookedTrips
        {
            get
            {
                if (bookedTrips is Trip[])
                {
                    bookedTrips = bookedTrips.ToList();
                }
                if (bookedTrips == null)
                {
                    bookedTrips = new List<Trip>();
                }
                return bookedTrips.ToList();
            }
            set
            {
                if (bookedTrips is Trip[])
                {
                    bookedTrips = bookedTrips.ToList();
                }
                if (bookedTrips != null)
                {
                    var __itemsToDelete = new List<Trip>(bookedTrips);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveBookedTrips(__item);
                    }
                }
                if(value == null)
                {
                    bookedTrips = new List<Trip>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddBookedTrips(__item);
                }
            }
        }
        public virtual void AddBookedTrips(IList<Trip> __items)
        {
            foreach (var __item in __items)
            {
                AddBookedTrips(__item);
            }
        }
        public virtual void AddBookedTrips(Trip __item)
        {
            if (__item != null && bookedTrips!=null && !bookedTrips.Contains(__item))
            {
                bookedTrips.Add(__item);
                if (__item.BookedBy != this)
                    __item.BookedBy = this;
            }
        }

        public virtual void RemoveBookedTrips(Trip __item)
        {
            if (__item != null && bookedTrips!=null && bookedTrips.Contains(__item))
            {
                bookedTrips.Remove(__item);
                __item.BookedBy = null;
            }
        }
        public virtual void SetBookedTripsAt(Trip __item, int __index)
        {
            if (__item == null)
            {
                bookedTrips[__index].BookedBy = null;
            }
            else
            {
                bookedTrips[__index] = __item;
                if (__item.BookedBy != this)
                    __item.BookedBy = this;
            }
        }

        public virtual void ClearBookedTrips()
        {
            if (bookedTrips!=null)
            {
                var __itemsToRemove = bookedTrips.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveBookedTrips(__item);
                }
            }
        }
        [DataMember(Name="LogEntities")]
        protected IList<LogEntity> logEntities = new List<LogEntity>();
        public virtual List<LogEntity> LogEntities
        {
            get
            {
                if (logEntities is LogEntity[])
                {
                    logEntities = logEntities.ToList();
                }
                if (logEntities == null)
                {
                    logEntities = new List<LogEntity>();
                }
                return logEntities.ToList();
            }
            set
            {
                if (logEntities is LogEntity[])
                {
                    logEntities = logEntities.ToList();
                }
                if (logEntities != null)
                {
                    var __itemsToDelete = new List<LogEntity>(logEntities);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLogEntities(__item);
                    }
                }
                if(value == null)
                {
                    logEntities = new List<LogEntity>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLogEntities(__item);
                }
            }
        }
        public virtual void AddLogEntities(IList<LogEntity> __items)
        {
            foreach (var __item in __items)
            {
                AddLogEntities(__item);
            }
        }
        public virtual void AddLogEntities(LogEntity __item)
        {
            if (__item != null && logEntities!=null && !logEntities.Contains(__item))
            {
                logEntities.Add(__item);
                if (__item.User != this)
                    __item.User = this;
            }
        }

        public virtual void RemoveLogEntities(LogEntity __item)
        {
            if (__item != null && logEntities!=null && logEntities.Contains(__item))
            {
                logEntities.Remove(__item);
                __item.User = null;
            }
        }
        public virtual void SetLogEntitiesAt(LogEntity __item, int __index)
        {
            if (__item == null)
            {
                logEntities[__index].User = null;
            }
            else
            {
                logEntities[__index] = __item;
                if (__item.User != this)
                    __item.User = this;
            }
        }

        public virtual void ClearLogEntities()
        {
            if (logEntities!=null)
            {
                var __itemsToRemove = logEntities.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLogEntities(__item);
                }
            }
        }
        [DataMember(Name="CreatedServiceMetrics")]
        protected IList<ServiceMetric> createdServiceMetrics = new List<ServiceMetric>();
        public virtual List<ServiceMetric> CreatedServiceMetrics
        {
            get
            {
                if (createdServiceMetrics is ServiceMetric[])
                {
                    createdServiceMetrics = createdServiceMetrics.ToList();
                }
                if (createdServiceMetrics == null)
                {
                    createdServiceMetrics = new List<ServiceMetric>();
                }
                return createdServiceMetrics.ToList();
            }
            set
            {
                if (createdServiceMetrics is ServiceMetric[])
                {
                    createdServiceMetrics = createdServiceMetrics.ToList();
                }
                if (createdServiceMetrics != null)
                {
                    var __itemsToDelete = new List<ServiceMetric>(createdServiceMetrics);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveCreatedServiceMetrics(__item);
                    }
                }
                if(value == null)
                {
                    createdServiceMetrics = new List<ServiceMetric>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddCreatedServiceMetrics(__item);
                }
            }
        }
        public virtual void AddCreatedServiceMetrics(IList<ServiceMetric> __items)
        {
            foreach (var __item in __items)
            {
                AddCreatedServiceMetrics(__item);
            }
        }
        public virtual void AddCreatedServiceMetrics(ServiceMetric __item)
        {
            if (__item != null && createdServiceMetrics!=null && !createdServiceMetrics.Contains(__item))
            {
                createdServiceMetrics.Add(__item);
                if (__item.CreatedBy != this)
                    __item.CreatedBy = this;
            }
        }

        public virtual void RemoveCreatedServiceMetrics(ServiceMetric __item)
        {
            if (__item != null && createdServiceMetrics!=null && createdServiceMetrics.Contains(__item))
            {
                createdServiceMetrics.Remove(__item);
                __item.CreatedBy = null;
            }
        }
        public virtual void SetCreatedServiceMetricsAt(ServiceMetric __item, int __index)
        {
            if (__item == null)
            {
                createdServiceMetrics[__index].CreatedBy = null;
            }
            else
            {
                createdServiceMetrics[__index] = __item;
                if (__item.CreatedBy != this)
                    __item.CreatedBy = this;
            }
        }

        public virtual void ClearCreatedServiceMetrics()
        {
            if (createdServiceMetrics!=null)
            {
                var __itemsToRemove = createdServiceMetrics.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveCreatedServiceMetrics(__item);
                }
            }
        }
        [DataMember(Name="Devices")]
        protected IList<Device> devices = new List<Device>();
        public virtual List<Device> Devices
        {
            get
            {
                if (devices is Device[])
                {
                    devices = devices.ToList();
                }
                if (devices == null)
                {
                    devices = new List<Device>();
                }
                return devices.ToList();
            }
            set
            {
                if (devices is Device[])
                {
                    devices = devices.ToList();
                }
                if (devices != null)
                {
                    var __itemsToDelete = new List<Device>(devices);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveDevices(__item);
                    }
                }
                if(value == null)
                {
                    devices = new List<Device>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddDevices(__item);
                }
            }
        }
        public virtual void AddDevices(IList<Device> __items)
        {
            foreach (var __item in __items)
            {
                AddDevices(__item);
            }
        }
        public virtual void AddDevices(Device __item)
        {
            if (__item != null && devices!=null && !devices.Contains(__item))
            {
                devices.Add(__item);
                if (__item.Person != this)
                    __item.Person = this;
            }
        }

        public virtual void RemoveDevices(Device __item)
        {
            if (__item != null && devices!=null && devices.Contains(__item))
            {
                devices.Remove(__item);
                __item.Person = null;
            }
        }
        public virtual void SetDevicesAt(Device __item, int __index)
        {
            if (__item == null)
            {
                devices[__index].Person = null;
            }
            else
            {
                devices[__index] = __item;
                if (__item.Person != this)
                    __item.Person = this;
            }
        }

        public virtual void ClearDevices()
        {
            if (devices!=null)
            {
                var __itemsToRemove = devices.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveDevices(__item);
                }
            }
        }
        [DataMember(Name="UserBookings")]
        protected IList<UserBookings> userBookings = new List<UserBookings>();
        public virtual List<UserBookings> UserBookings
        {
            get
            {
                if (userBookings is UserBookings[])
                {
                    userBookings = userBookings.ToList();
                }
                if (userBookings == null)
                {
                    userBookings = new List<UserBookings>();
                }
                return userBookings.ToList();
            }
            set
            {
                if (userBookings is UserBookings[])
                {
                    userBookings = userBookings.ToList();
                }
                if (userBookings != null)
                {
                    var __itemsToDelete = new List<UserBookings>(userBookings);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUserBookings(__item);
                    }
                }
                if(value == null)
                {
                    userBookings = new List<UserBookings>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUserBookings(__item);
                }
            }
        }
        public virtual void AddUserBookings(IList<UserBookings> __items)
        {
            foreach (var __item in __items)
            {
                AddUserBookings(__item);
            }
        }
        public virtual void AddUserBookings(UserBookings __item)
        {
            if (__item != null && userBookings!=null && !userBookings.Contains(__item))
            {
                userBookings.Add(__item);
            }
        }

        public virtual void RemoveUserBookings(UserBookings __item)
        {
            if (__item != null && userBookings!=null && userBookings.Contains(__item))
            {
                userBookings.Remove(__item);
            }
        }
        public virtual void SetUserBookingsAt(UserBookings __item, int __index)
        {
            if (__item == null)
            {
                userBookings[__index] = null;
            }
            else
            {
                userBookings[__index] = __item;
            }
        }

        public virtual void ClearUserBookings()
        {
            if (userBookings!=null)
            {
                var __itemsToRemove = userBookings.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUserBookings(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Person class
/// </summary>
/// <returns>New Person object</returns>
/// <remarks></remarks>
        public Person(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (Forename != null && Forename.Length > 100)
            {
                __errors.Add("Length of property 'Forename' cannot be greater than 100.");
            }
            if (Surname != null && Surname.Length > 100)
            {
                __errors.Add("Length of property 'Surname' cannot be greater than 100.");
            }
            if (MiddleName != null && MiddleName.Length > 100)
            {
                __errors.Add("Length of property 'MiddleName' cannot be greater than 100.");
            }
            if (FullName != null && FullName.Length > 100)
            {
                __errors.Add("Length of property 'FullName' cannot be greater than 100.");
            }
            if (IPAddress != null && IPAddress.Length > 100)
            {
                __errors.Add("Length of property 'IPAddress' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Person' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Person] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Person Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Person copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Person)copiedObjects[this];
            copy = copy ?? new Person();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.Forename = this.Forename;
            copy.Surname = this.Surname;
            copy.DateOfBirth = this.DateOfBirth;
            copy.MiddleName = this.MiddleName;
            copy.FullName = this.FullName;
            copy.Guest = this.Guest;
            copy.IPAddress = this.IPAddress;
            copy.Gender = this.Gender;
            copy.Age = this.Age;
            copy.Title = this.Title;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.identification = new List<Identification>();
            if(deep && this.identification != null)
            {
                foreach (var __item in this.identification)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddIdentification(__item);
                        else
                            copy.AddIdentification(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddIdentification((Identification)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.prefix != null)
            {
                if (!copiedObjects.Contains(this.prefix))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Prefix = this.Prefix;
                    else if (asNew)
                        copy.Prefix = this.Prefix.Copy(deep, copiedObjects, true);
                    else
                        copy.prefix = this.prefix.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Prefix = (Prefixes)copiedObjects[this.Prefix];
                    else
                        copy.prefix = (Prefixes)copiedObjects[this.Prefix];
                }
            }
            if(deep && this.sufix != null)
            {
                if (!copiedObjects.Contains(this.sufix))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Sufix = this.Sufix;
                    else if (asNew)
                        copy.Sufix = this.Sufix.Copy(deep, copiedObjects, true);
                    else
                        copy.sufix = this.sufix.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Sufix = (Suffixes)copiedObjects[this.Sufix];
                    else
                        copy.sufix = (Suffixes)copiedObjects[this.Sufix];
                }
            }
            if(deep && this.contactInformation != null)
            {
                if (!copiedObjects.Contains(this.contactInformation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ContactInformation = this.ContactInformation;
                    else if (asNew)
                        copy.ContactInformation = this.ContactInformation.Copy(deep, copiedObjects, true);
                    else
                        copy.contactInformation = this.contactInformation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ContactInformation = (ContactInformation)copiedObjects[this.ContactInformation];
                    else
                        copy.contactInformation = (ContactInformation)copiedObjects[this.ContactInformation];
                }
            }
            if(deep && this.nationality != null)
            {
                if (!copiedObjects.Contains(this.nationality))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Nationality = this.Nationality;
                    else if (asNew)
                        copy.Nationality = this.Nationality.Copy(deep, copiedObjects, true);
                    else
                        copy.nationality = this.nationality.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Nationality = (Country)copiedObjects[this.Nationality];
                    else
                        copy.nationality = (Country)copiedObjects[this.Nationality];
                }
            }
            copy.shoppingTransactions = new List<Transaction>();
            if(deep && this.shoppingTransactions != null)
            {
                foreach (var __item in this.shoppingTransactions)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddShoppingTransactions(__item);
                        else
                            copy.AddShoppingTransactions(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddShoppingTransactions((Transaction)copiedObjects[__item]);
                    }
                }
            }
            copy.taggedIn = new List<Photograph>();
            if(deep && this.taggedIn != null)
            {
                foreach (var __item in this.taggedIn)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTaggedIn(__item);
                        else
                            copy.AddTaggedIn(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTaggedIn((Photograph)copiedObjects[__item]);
                    }
                }
            }
            copy.myPhotos = new List<Photograph>();
            if(deep && this.myPhotos != null)
            {
                foreach (var __item in this.myPhotos)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddMyPhotos(__item);
                        else
                            copy.AddMyPhotos(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddMyPhotos((Photograph)copiedObjects[__item]);
                    }
                }
            }
            copy.likedPointsOfInterest = new List<PointOfInterest>();
            if(deep && this.likedPointsOfInterest != null)
            {
                foreach (var __item in this.likedPointsOfInterest)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLikedPointsOfInterest(__item);
                        else
                            copy.AddLikedPointsOfInterest(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLikedPointsOfInterest((PointOfInterest)copiedObjects[__item]);
                    }
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
            copy.uploadedPointsOfInterest = new List<PointOfInterest>();
            if(deep && this.uploadedPointsOfInterest != null)
            {
                foreach (var __item in this.uploadedPointsOfInterest)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUploadedPointsOfInterest(__item);
                        else
                            copy.AddUploadedPointsOfInterest(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUploadedPointsOfInterest((PointOfInterest)copiedObjects[__item]);
                    }
                }
            }
            copy.likedTrips = new List<Trip>();
            if(deep && this.likedTrips != null)
            {
                foreach (var __item in this.likedTrips)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLikedTrips(__item);
                        else
                            copy.AddLikedTrips(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLikedTrips((Trip)copiedObjects[__item]);
                    }
                }
            }
            copy.likedPhotos = new List<Photograph>();
            if(deep && this.likedPhotos != null)
            {
                foreach (var __item in this.likedPhotos)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLikedPhotos(__item);
                        else
                            copy.AddLikedPhotos(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLikedPhotos((Photograph)copiedObjects[__item]);
                    }
                }
            }
            copy.bookedTrips = new List<Trip>();
            if(deep && this.bookedTrips != null)
            {
                foreach (var __item in this.bookedTrips)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddBookedTrips(__item);
                        else
                            copy.AddBookedTrips(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddBookedTrips((Trip)copiedObjects[__item]);
                    }
                }
            }
            copy.logEntities = new List<LogEntity>();
            if(deep && this.logEntities != null)
            {
                foreach (var __item in this.logEntities)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLogEntities(__item);
                        else
                            copy.AddLogEntities(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLogEntities((LogEntity)copiedObjects[__item]);
                    }
                }
            }
            copy.createdServiceMetrics = new List<ServiceMetric>();
            if(deep && this.createdServiceMetrics != null)
            {
                foreach (var __item in this.createdServiceMetrics)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddCreatedServiceMetrics(__item);
                        else
                            copy.AddCreatedServiceMetrics(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddCreatedServiceMetrics((ServiceMetric)copiedObjects[__item]);
                    }
                }
            }
            copy.devices = new List<Device>();
            if(deep && this.devices != null)
            {
                foreach (var __item in this.devices)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddDevices(__item);
                        else
                            copy.AddDevices(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddDevices((Device)copiedObjects[__item]);
                    }
                }
            }
            copy.userBookings = new List<UserBookings>();
            if(deep && this.userBookings != null)
            {
                foreach (var __item in this.userBookings)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUserBookings(__item);
                        else
                            copy.AddUserBookings(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUserBookings((UserBookings)copiedObjects[__item]);
                    }
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Person;
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
