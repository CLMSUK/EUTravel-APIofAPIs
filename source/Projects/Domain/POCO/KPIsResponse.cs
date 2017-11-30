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
    /// The KPIsResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class KPIsResponse : IDomainModelClass
    {
        #region KPIsResponse's Fields

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
        [DataMember(Name="KPIsResponseKey")]
        protected Guid? kPIsResponseKey = Guid.Empty;
        #endregion
        #region KPIsResponse's Properties
/// <summary>
/// The KPIsResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? KPIsResponseKey
        {
            get
            {
                return kPIsResponseKey;
            }
            set
            {
                kPIsResponseKey = value;
            }
        }
        #endregion
        #region KPIsResponse's Participant Properties
        [DataMember(Name="SOLCOV")]
        protected SOLCOV sOLCOV;
        public virtual SOLCOV SOLCOV
        {
            get
            {
                return sOLCOV;
            }
            set
            {
                if(Equals(sOLCOV, value)) return;
                var __oldValue = sOLCOV;
                if (value != null)
                {
                    sOLCOV = value;
                }
                else
                {
                    if (sOLCOV != null)
                    {
                        sOLCOV = null;
                    }
                }
            }
        }
        [DataMember(Name="FBSCO")]
        protected FBSCO fBSCO;
        public virtual FBSCO FBSCO
        {
            get
            {
                return fBSCO;
            }
            set
            {
                if(Equals(fBSCO, value)) return;
                var __oldValue = fBSCO;
                if (value != null)
                {
                    fBSCO = value;
                }
                else
                {
                    if (fBSCO != null)
                    {
                        fBSCO = null;
                    }
                }
            }
        }
        [DataMember(Name="DATUR")]
        protected DATUR dATUR;
        public virtual DATUR DATUR
        {
            get
            {
                return dATUR;
            }
            set
            {
                if(Equals(dATUR, value)) return;
                var __oldValue = dATUR;
                if (value != null)
                {
                    dATUR = value;
                }
                else
                {
                    if (dATUR != null)
                    {
                        dATUR = null;
                    }
                }
            }
        }
        [DataMember(Name="TIMBO")]
        protected TIMBO tIMBO;
        public virtual TIMBO TIMBO
        {
            get
            {
                return tIMBO;
            }
            set
            {
                if(Equals(tIMBO, value)) return;
                var __oldValue = tIMBO;
                if (value != null)
                {
                    tIMBO = value;
                }
                else
                {
                    if (tIMBO != null)
                    {
                        tIMBO = null;
                    }
                }
            }
        }
        [DataMember(Name="COMCP")]
        protected COMCP cOMCP;
        public virtual COMCP COMCP
        {
            get
            {
                return cOMCP;
            }
            set
            {
                if(Equals(cOMCP, value)) return;
                var __oldValue = cOMCP;
                if (value != null)
                {
                    cOMCP = value;
                }
                else
                {
                    if (cOMCP != null)
                    {
                        cOMCP = null;
                    }
                }
            }
        }
        [DataMember(Name="TIMUC")]
        protected TIMUC tIMUC;
        public virtual TIMUC TIMUC
        {
            get
            {
                return tIMUC;
            }
            set
            {
                if(Equals(tIMUC, value)) return;
                var __oldValue = tIMUC;
                if (value != null)
                {
                    tIMUC = value;
                }
                else
                {
                    if (tIMUC != null)
                    {
                        tIMUC = null;
                    }
                }
            }
        }
        [DataMember(Name="STEPA")]
        protected STEPA sTEPA;
        public virtual STEPA STEPA
        {
            get
            {
                return sTEPA;
            }
            set
            {
                if(Equals(sTEPA, value)) return;
                var __oldValue = sTEPA;
                if (value != null)
                {
                    sTEPA = value;
                }
                else
                {
                    if (sTEPA != null)
                    {
                        sTEPA = null;
                    }
                }
            }
        }
        [DataMember(Name="MONEP")]
        protected MONEP mONEP;
        public virtual MONEP MONEP
        {
            get
            {
                return mONEP;
            }
            set
            {
                if(Equals(mONEP, value)) return;
                var __oldValue = mONEP;
                if (value != null)
                {
                    mONEP = value;
                }
                else
                {
                    if (mONEP != null)
                    {
                        mONEP = null;
                    }
                }
            }
        }
        [DataMember(Name="FBPEN")]
        protected FBPEN fBPEN;
        public virtual FBPEN FBPEN
        {
            get
            {
                return fBPEN;
            }
            set
            {
                if(Equals(fBPEN, value)) return;
                var __oldValue = fBPEN;
                if (value != null)
                {
                    fBPEN = value;
                }
                else
                {
                    if (fBPEN != null)
                    {
                        fBPEN = null;
                    }
                }
            }
        }
        [DataMember(Name="STEAU")]
        protected STEAU sTEAU;
        public virtual STEAU STEAU
        {
            get
            {
                return sTEAU;
            }
            set
            {
                if(Equals(sTEAU, value)) return;
                var __oldValue = sTEAU;
                if (value != null)
                {
                    sTEAU = value;
                }
                else
                {
                    if (sTEAU != null)
                    {
                        sTEAU = null;
                    }
                }
            }
        }
        [DataMember(Name="SRTHR")]
        protected SRTHR sRTHR;
        public virtual SRTHR SRTHR
        {
            get
            {
                return sRTHR;
            }
            set
            {
                if(Equals(sRTHR, value)) return;
                var __oldValue = sRTHR;
                if (value != null)
                {
                    sRTHR = value;
                }
                else
                {
                    if (sRTHR != null)
                    {
                        sRTHR = null;
                    }
                }
            }
        }
        [DataMember(Name="EXTEVG")]
        protected EXTEVG eXTEVG;
        public virtual EXTEVG EXTEVG
        {
            get
            {
                return eXTEVG;
            }
            set
            {
                if(Equals(eXTEVG, value)) return;
                var __oldValue = eXTEVG;
                if (value != null)
                {
                    eXTEVG = value;
                }
                else
                {
                    if (eXTEVG != null)
                    {
                        eXTEVG = null;
                    }
                }
            }
        }
        [DataMember(Name="TIMPL")]
        protected TIMPL tIMPL;
        public virtual TIMPL TIMPL
        {
            get
            {
                return tIMPL;
            }
            set
            {
                if(Equals(tIMPL, value)) return;
                var __oldValue = tIMPL;
                if (value != null)
                {
                    tIMPL = value;
                }
                else
                {
                    if (tIMPL != null)
                    {
                        tIMPL = null;
                    }
                }
            }
        }
        [DataMember(Name="TIMPA")]
        protected TIMPA tIMPA;
        public virtual TIMPA TIMPA
        {
            get
            {
                return tIMPA;
            }
            set
            {
                if(Equals(tIMPA, value)) return;
                var __oldValue = tIMPA;
                if (value != null)
                {
                    tIMPA = value;
                }
                else
                {
                    if (tIMPA != null)
                    {
                        tIMPA = null;
                    }
                }
            }
        }
        [DataMember(Name="CLINF")]
        protected CLINF cLINF;
        public virtual CLINF CLINF
        {
            get
            {
                return cLINF;
            }
            set
            {
                if(Equals(cLINF, value)) return;
                var __oldValue = cLINF;
                if (value != null)
                {
                    cLINF = value;
                }
                else
                {
                    if (cLINF != null)
                    {
                        cLINF = null;
                    }
                }
            }
        }
        [DataMember(Name="COMIS")]
        protected COMIS cOMIS;
        public virtual COMIS COMIS
        {
            get
            {
                return cOMIS;
            }
            set
            {
                if(Equals(cOMIS, value)) return;
                var __oldValue = cOMIS;
                if (value != null)
                {
                    cOMIS = value;
                }
                else
                {
                    if (cOMIS != null)
                    {
                        cOMIS = null;
                    }
                }
            }
        }
        [DataMember(Name="LTBRA")]
        protected LTBRA lTBRA;
        public virtual LTBRA LTBRA
        {
            get
            {
                return lTBRA;
            }
            set
            {
                if(Equals(lTBRA, value)) return;
                var __oldValue = lTBRA;
                if (value != null)
                {
                    lTBRA = value;
                }
                else
                {
                    if (lTBRA != null)
                    {
                        lTBRA = null;
                    }
                }
            }
        }
        [DataMember(Name="SOLCOM")]
        protected SOLCOM sOLCOM;
        public virtual SOLCOM SOLCOM
        {
            get
            {
                return sOLCOM;
            }
            set
            {
                if(Equals(sOLCOM, value)) return;
                var __oldValue = sOLCOM;
                if (value != null)
                {
                    sOLCOM = value;
                }
                else
                {
                    if (sOLCOM != null)
                    {
                        sOLCOM = null;
                    }
                }
            }
        }
        [DataMember(Name="SRINT")]
        protected SRINT sRINT;
        public virtual SRINT SRINT
        {
            get
            {
                return sRINT;
            }
            set
            {
                if(Equals(sRINT, value)) return;
                var __oldValue = sRINT;
                if (value != null)
                {
                    sRINT = value;
                }
                else
                {
                    if (sRINT != null)
                    {
                        sRINT = null;
                    }
                }
            }
        }
        [DataMember(Name="TIMTI")]
        protected TIMTI tIMTI;
        public virtual TIMTI TIMTI
        {
            get
            {
                return tIMTI;
            }
            set
            {
                if(Equals(tIMTI, value)) return;
                var __oldValue = tIMTI;
                if (value != null)
                {
                    tIMTI = value;
                }
                else
                {
                    if (tIMTI != null)
                    {
                        tIMTI = null;
                    }
                }
            }
        }
        [DataMember(Name="AVGAT")]
        protected AVGAT aVGAT;
        public virtual AVGAT AVGAT
        {
            get
            {
                return aVGAT;
            }
            set
            {
                if(Equals(aVGAT, value)) return;
                var __oldValue = aVGAT;
                if (value != null)
                {
                    aVGAT = value;
                }
                else
                {
                    if (aVGAT != null)
                    {
                        aVGAT = null;
                    }
                }
            }
        }
        [DataMember(Name="FOCIM")]
        protected FOCIM fOCIM;
        public virtual FOCIM FOCIM
        {
            get
            {
                return fOCIM;
            }
            set
            {
                if(Equals(fOCIM, value)) return;
                var __oldValue = fOCIM;
                if (value != null)
                {
                    fOCIM = value;
                }
                else
                {
                    if (fOCIM != null)
                    {
                        fOCIM = null;
                    }
                }
            }
        }
        [DataMember(Name="SRAVG")]
        protected SRAVG sRAVG;
        public virtual SRAVG SRAVG
        {
            get
            {
                return sRAVG;
            }
            set
            {
                if(Equals(sRAVG, value)) return;
                var __oldValue = sRAVG;
                if (value != null)
                {
                    sRAVG = value;
                }
                else
                {
                    if (sRAVG != null)
                    {
                        sRAVG = null;
                    }
                }
            }
        }
        [DataMember(Name="COMBS")]
        protected COMBS cOMBS;
        public virtual COMBS COMBS
        {
            get
            {
                return cOMBS;
            }
            set
            {
                if(Equals(cOMBS, value)) return;
                var __oldValue = cOMBS;
                if (value != null)
                {
                    cOMBS = value;
                }
                else
                {
                    if (cOMBS != null)
                    {
                        cOMBS = null;
                    }
                }
            }
        }
        [DataMember(Name="SOLPO")]
        protected SOLPO sOLPO;
        public virtual SOLPO SOLPO
        {
            get
            {
                return sOLPO;
            }
            set
            {
                if(Equals(sOLPO, value)) return;
                var __oldValue = sOLPO;
                if (value != null)
                {
                    sOLPO = value;
                }
                else
                {
                    if (sOLPO != null)
                    {
                        sOLPO = null;
                    }
                }
            }
        }
        [DataMember(Name="DATEF")]
        protected DATEF dATEF;
        public virtual DATEF DATEF
        {
            get
            {
                return dATEF;
            }
            set
            {
                if(Equals(dATEF, value)) return;
                var __oldValue = dATEF;
                if (value != null)
                {
                    dATEF = value;
                }
                else
                {
                    if (dATEF != null)
                    {
                        dATEF = null;
                    }
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
        [DataMember(Name="TIMSH")]
        protected TIMSH tIMSH;
        public virtual TIMSH TIMSH
        {
            get
            {
                return tIMSH;
            }
            set
            {
                if(Equals(tIMSH, value)) return;
                var __oldValue = tIMSH;
                if (value != null)
                {
                    tIMSH = value;
                }
                else
                {
                    if (tIMSH != null)
                    {
                        tIMSH = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the KPIsResponse class
/// </summary>
/// <returns>New KPIsResponse object</returns>
/// <remarks></remarks>
        public KPIsResponse()
        {
            if (KPIsResponseKey == null) KPIsResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'KPIsResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [KPIsResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual KPIsResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, KPIsResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (KPIsResponse)copiedObjects[this];
            copy = copy ?? new KPIsResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.KPIsResponseKey = this.KPIsResponseKey;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.sOLCOV != null)
            {
                if (!copiedObjects.Contains(this.sOLCOV))
                {
                    if (asNew && reuseNestedObjects)
                        copy.SOLCOV = this.SOLCOV;
                    else if (asNew)
                        copy.SOLCOV = this.SOLCOV.Copy(deep, copiedObjects, true);
                    else
                        copy.sOLCOV = this.sOLCOV.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.SOLCOV = (SOLCOV)copiedObjects[this.SOLCOV];
                    else
                        copy.sOLCOV = (SOLCOV)copiedObjects[this.SOLCOV];
                }
            }
            if(deep && this.fBSCO != null)
            {
                if (!copiedObjects.Contains(this.fBSCO))
                {
                    if (asNew && reuseNestedObjects)
                        copy.FBSCO = this.FBSCO;
                    else if (asNew)
                        copy.FBSCO = this.FBSCO.Copy(deep, copiedObjects, true);
                    else
                        copy.fBSCO = this.fBSCO.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.FBSCO = (FBSCO)copiedObjects[this.FBSCO];
                    else
                        copy.fBSCO = (FBSCO)copiedObjects[this.FBSCO];
                }
            }
            if(deep && this.dATUR != null)
            {
                if (!copiedObjects.Contains(this.dATUR))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DATUR = this.DATUR;
                    else if (asNew)
                        copy.DATUR = this.DATUR.Copy(deep, copiedObjects, true);
                    else
                        copy.dATUR = this.dATUR.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DATUR = (DATUR)copiedObjects[this.DATUR];
                    else
                        copy.dATUR = (DATUR)copiedObjects[this.DATUR];
                }
            }
            if(deep && this.tIMBO != null)
            {
                if (!copiedObjects.Contains(this.tIMBO))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TIMBO = this.TIMBO;
                    else if (asNew)
                        copy.TIMBO = this.TIMBO.Copy(deep, copiedObjects, true);
                    else
                        copy.tIMBO = this.tIMBO.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TIMBO = (TIMBO)copiedObjects[this.TIMBO];
                    else
                        copy.tIMBO = (TIMBO)copiedObjects[this.TIMBO];
                }
            }
            if(deep && this.cOMCP != null)
            {
                if (!copiedObjects.Contains(this.cOMCP))
                {
                    if (asNew && reuseNestedObjects)
                        copy.COMCP = this.COMCP;
                    else if (asNew)
                        copy.COMCP = this.COMCP.Copy(deep, copiedObjects, true);
                    else
                        copy.cOMCP = this.cOMCP.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.COMCP = (COMCP)copiedObjects[this.COMCP];
                    else
                        copy.cOMCP = (COMCP)copiedObjects[this.COMCP];
                }
            }
            if(deep && this.tIMUC != null)
            {
                if (!copiedObjects.Contains(this.tIMUC))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TIMUC = this.TIMUC;
                    else if (asNew)
                        copy.TIMUC = this.TIMUC.Copy(deep, copiedObjects, true);
                    else
                        copy.tIMUC = this.tIMUC.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TIMUC = (TIMUC)copiedObjects[this.TIMUC];
                    else
                        copy.tIMUC = (TIMUC)copiedObjects[this.TIMUC];
                }
            }
            if(deep && this.sTEPA != null)
            {
                if (!copiedObjects.Contains(this.sTEPA))
                {
                    if (asNew && reuseNestedObjects)
                        copy.STEPA = this.STEPA;
                    else if (asNew)
                        copy.STEPA = this.STEPA.Copy(deep, copiedObjects, true);
                    else
                        copy.sTEPA = this.sTEPA.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.STEPA = (STEPA)copiedObjects[this.STEPA];
                    else
                        copy.sTEPA = (STEPA)copiedObjects[this.STEPA];
                }
            }
            if(deep && this.mONEP != null)
            {
                if (!copiedObjects.Contains(this.mONEP))
                {
                    if (asNew && reuseNestedObjects)
                        copy.MONEP = this.MONEP;
                    else if (asNew)
                        copy.MONEP = this.MONEP.Copy(deep, copiedObjects, true);
                    else
                        copy.mONEP = this.mONEP.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.MONEP = (MONEP)copiedObjects[this.MONEP];
                    else
                        copy.mONEP = (MONEP)copiedObjects[this.MONEP];
                }
            }
            if(deep && this.fBPEN != null)
            {
                if (!copiedObjects.Contains(this.fBPEN))
                {
                    if (asNew && reuseNestedObjects)
                        copy.FBPEN = this.FBPEN;
                    else if (asNew)
                        copy.FBPEN = this.FBPEN.Copy(deep, copiedObjects, true);
                    else
                        copy.fBPEN = this.fBPEN.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.FBPEN = (FBPEN)copiedObjects[this.FBPEN];
                    else
                        copy.fBPEN = (FBPEN)copiedObjects[this.FBPEN];
                }
            }
            if(deep && this.sTEAU != null)
            {
                if (!copiedObjects.Contains(this.sTEAU))
                {
                    if (asNew && reuseNestedObjects)
                        copy.STEAU = this.STEAU;
                    else if (asNew)
                        copy.STEAU = this.STEAU.Copy(deep, copiedObjects, true);
                    else
                        copy.sTEAU = this.sTEAU.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.STEAU = (STEAU)copiedObjects[this.STEAU];
                    else
                        copy.sTEAU = (STEAU)copiedObjects[this.STEAU];
                }
            }
            if(deep && this.sRTHR != null)
            {
                if (!copiedObjects.Contains(this.sRTHR))
                {
                    if (asNew && reuseNestedObjects)
                        copy.SRTHR = this.SRTHR;
                    else if (asNew)
                        copy.SRTHR = this.SRTHR.Copy(deep, copiedObjects, true);
                    else
                        copy.sRTHR = this.sRTHR.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.SRTHR = (SRTHR)copiedObjects[this.SRTHR];
                    else
                        copy.sRTHR = (SRTHR)copiedObjects[this.SRTHR];
                }
            }
            if(deep && this.eXTEVG != null)
            {
                if (!copiedObjects.Contains(this.eXTEVG))
                {
                    if (asNew && reuseNestedObjects)
                        copy.EXTEVG = this.EXTEVG;
                    else if (asNew)
                        copy.EXTEVG = this.EXTEVG.Copy(deep, copiedObjects, true);
                    else
                        copy.eXTEVG = this.eXTEVG.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.EXTEVG = (EXTEVG)copiedObjects[this.EXTEVG];
                    else
                        copy.eXTEVG = (EXTEVG)copiedObjects[this.EXTEVG];
                }
            }
            if(deep && this.tIMPL != null)
            {
                if (!copiedObjects.Contains(this.tIMPL))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TIMPL = this.TIMPL;
                    else if (asNew)
                        copy.TIMPL = this.TIMPL.Copy(deep, copiedObjects, true);
                    else
                        copy.tIMPL = this.tIMPL.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TIMPL = (TIMPL)copiedObjects[this.TIMPL];
                    else
                        copy.tIMPL = (TIMPL)copiedObjects[this.TIMPL];
                }
            }
            if(deep && this.tIMPA != null)
            {
                if (!copiedObjects.Contains(this.tIMPA))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TIMPA = this.TIMPA;
                    else if (asNew)
                        copy.TIMPA = this.TIMPA.Copy(deep, copiedObjects, true);
                    else
                        copy.tIMPA = this.tIMPA.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TIMPA = (TIMPA)copiedObjects[this.TIMPA];
                    else
                        copy.tIMPA = (TIMPA)copiedObjects[this.TIMPA];
                }
            }
            if(deep && this.cLINF != null)
            {
                if (!copiedObjects.Contains(this.cLINF))
                {
                    if (asNew && reuseNestedObjects)
                        copy.CLINF = this.CLINF;
                    else if (asNew)
                        copy.CLINF = this.CLINF.Copy(deep, copiedObjects, true);
                    else
                        copy.cLINF = this.cLINF.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.CLINF = (CLINF)copiedObjects[this.CLINF];
                    else
                        copy.cLINF = (CLINF)copiedObjects[this.CLINF];
                }
            }
            if(deep && this.cOMIS != null)
            {
                if (!copiedObjects.Contains(this.cOMIS))
                {
                    if (asNew && reuseNestedObjects)
                        copy.COMIS = this.COMIS;
                    else if (asNew)
                        copy.COMIS = this.COMIS.Copy(deep, copiedObjects, true);
                    else
                        copy.cOMIS = this.cOMIS.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.COMIS = (COMIS)copiedObjects[this.COMIS];
                    else
                        copy.cOMIS = (COMIS)copiedObjects[this.COMIS];
                }
            }
            if(deep && this.lTBRA != null)
            {
                if (!copiedObjects.Contains(this.lTBRA))
                {
                    if (asNew && reuseNestedObjects)
                        copy.LTBRA = this.LTBRA;
                    else if (asNew)
                        copy.LTBRA = this.LTBRA.Copy(deep, copiedObjects, true);
                    else
                        copy.lTBRA = this.lTBRA.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.LTBRA = (LTBRA)copiedObjects[this.LTBRA];
                    else
                        copy.lTBRA = (LTBRA)copiedObjects[this.LTBRA];
                }
            }
            if(deep && this.sOLCOM != null)
            {
                if (!copiedObjects.Contains(this.sOLCOM))
                {
                    if (asNew && reuseNestedObjects)
                        copy.SOLCOM = this.SOLCOM;
                    else if (asNew)
                        copy.SOLCOM = this.SOLCOM.Copy(deep, copiedObjects, true);
                    else
                        copy.sOLCOM = this.sOLCOM.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.SOLCOM = (SOLCOM)copiedObjects[this.SOLCOM];
                    else
                        copy.sOLCOM = (SOLCOM)copiedObjects[this.SOLCOM];
                }
            }
            if(deep && this.sRINT != null)
            {
                if (!copiedObjects.Contains(this.sRINT))
                {
                    if (asNew && reuseNestedObjects)
                        copy.SRINT = this.SRINT;
                    else if (asNew)
                        copy.SRINT = this.SRINT.Copy(deep, copiedObjects, true);
                    else
                        copy.sRINT = this.sRINT.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.SRINT = (SRINT)copiedObjects[this.SRINT];
                    else
                        copy.sRINT = (SRINT)copiedObjects[this.SRINT];
                }
            }
            if(deep && this.tIMTI != null)
            {
                if (!copiedObjects.Contains(this.tIMTI))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TIMTI = this.TIMTI;
                    else if (asNew)
                        copy.TIMTI = this.TIMTI.Copy(deep, copiedObjects, true);
                    else
                        copy.tIMTI = this.tIMTI.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TIMTI = (TIMTI)copiedObjects[this.TIMTI];
                    else
                        copy.tIMTI = (TIMTI)copiedObjects[this.TIMTI];
                }
            }
            if(deep && this.aVGAT != null)
            {
                if (!copiedObjects.Contains(this.aVGAT))
                {
                    if (asNew && reuseNestedObjects)
                        copy.AVGAT = this.AVGAT;
                    else if (asNew)
                        copy.AVGAT = this.AVGAT.Copy(deep, copiedObjects, true);
                    else
                        copy.aVGAT = this.aVGAT.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.AVGAT = (AVGAT)copiedObjects[this.AVGAT];
                    else
                        copy.aVGAT = (AVGAT)copiedObjects[this.AVGAT];
                }
            }
            if(deep && this.fOCIM != null)
            {
                if (!copiedObjects.Contains(this.fOCIM))
                {
                    if (asNew && reuseNestedObjects)
                        copy.FOCIM = this.FOCIM;
                    else if (asNew)
                        copy.FOCIM = this.FOCIM.Copy(deep, copiedObjects, true);
                    else
                        copy.fOCIM = this.fOCIM.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.FOCIM = (FOCIM)copiedObjects[this.FOCIM];
                    else
                        copy.fOCIM = (FOCIM)copiedObjects[this.FOCIM];
                }
            }
            if(deep && this.sRAVG != null)
            {
                if (!copiedObjects.Contains(this.sRAVG))
                {
                    if (asNew && reuseNestedObjects)
                        copy.SRAVG = this.SRAVG;
                    else if (asNew)
                        copy.SRAVG = this.SRAVG.Copy(deep, copiedObjects, true);
                    else
                        copy.sRAVG = this.sRAVG.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.SRAVG = (SRAVG)copiedObjects[this.SRAVG];
                    else
                        copy.sRAVG = (SRAVG)copiedObjects[this.SRAVG];
                }
            }
            if(deep && this.cOMBS != null)
            {
                if (!copiedObjects.Contains(this.cOMBS))
                {
                    if (asNew && reuseNestedObjects)
                        copy.COMBS = this.COMBS;
                    else if (asNew)
                        copy.COMBS = this.COMBS.Copy(deep, copiedObjects, true);
                    else
                        copy.cOMBS = this.cOMBS.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.COMBS = (COMBS)copiedObjects[this.COMBS];
                    else
                        copy.cOMBS = (COMBS)copiedObjects[this.COMBS];
                }
            }
            if(deep && this.sOLPO != null)
            {
                if (!copiedObjects.Contains(this.sOLPO))
                {
                    if (asNew && reuseNestedObjects)
                        copy.SOLPO = this.SOLPO;
                    else if (asNew)
                        copy.SOLPO = this.SOLPO.Copy(deep, copiedObjects, true);
                    else
                        copy.sOLPO = this.sOLPO.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.SOLPO = (SOLPO)copiedObjects[this.SOLPO];
                    else
                        copy.sOLPO = (SOLPO)copiedObjects[this.SOLPO];
                }
            }
            if(deep && this.dATEF != null)
            {
                if (!copiedObjects.Contains(this.dATEF))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DATEF = this.DATEF;
                    else if (asNew)
                        copy.DATEF = this.DATEF.Copy(deep, copiedObjects, true);
                    else
                        copy.dATEF = this.dATEF.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DATEF = (DATEF)copiedObjects[this.DATEF];
                    else
                        copy.dATEF = (DATEF)copiedObjects[this.DATEF];
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
            if(deep && this.tIMSH != null)
            {
                if (!copiedObjects.Contains(this.tIMSH))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TIMSH = this.TIMSH;
                    else if (asNew)
                        copy.TIMSH = this.TIMSH.Copy(deep, copiedObjects, true);
                    else
                        copy.tIMSH = this.tIMSH.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TIMSH = (TIMSH)copiedObjects[this.TIMSH];
                    else
                        copy.tIMSH = (TIMSH)copiedObjects[this.TIMSH];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as KPIsResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("KPIsResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.KPIsResponseKey.GetHashCode();
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
            return this.KPIsResponseKey == default(Guid) || this.KPIsResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(KPIsResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.KPIsResponseKey.Equals(compareTo.KPIsResponseKey);
        }

        #endregion
    }
}
