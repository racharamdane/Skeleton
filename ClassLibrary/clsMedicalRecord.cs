using System;
                                                          

namespace ClassLibrary
{
    public class clsMedicalRecord
    {
        //private data member for the patient id property
        private Int32 mPatientId;
        private DateTime mDob;
        private String mMeds;
        private String mDiagnoses;
        private Boolean mSex;
        private string mNotes;

        public DateTime Dob
        {
            get
            { return mDob; }
            set
            { mDob = value; }
        }
        public int PatientId
        {
            get
            { return mPatientId; }
            set
            { mPatientId = value; }
        }
        public string Medications
        {
            get
            { return mMeds; }
            set
            { mMeds = value; }
        }
        public string Diagnoses
        {
            get
            { return mDiagnoses; }
            set
            { mDiagnoses = value; }
        }
        public bool Sex
        {
            get
            { return mSex; }
            set
            { mSex = value; }
        }
        public string ClinicalNotes
        {
            get
            { return mNotes; }
            set
            { mNotes = value; }
        }

        public bool Find(int PatientId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PatientId", PatientId);
            DB.Execute("sproc_tblMedicalRecord_FilterByPatientId");
            if (DB.Count == 1)
            {
                mPatientId = Convert.ToInt32(DB.DataTable.Rows[0]["PatientId"]);
                mDob = Convert.ToDateTime(DB.DataTable.Rows[0]["Dob"]);
                mSex = Convert.ToBoolean(DB.DataTable.Rows[0]["Sex"]);
                mMeds = Convert.ToString(DB.DataTable.Rows[0]["Medications"]);
                mDiagnoses = Convert.ToString(DB.DataTable.Rows[0]["Diagnoses"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["ClinicalNotes"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(DateTime dob, string medications, string diagnoses, string clinicalNotes)
        {
            String Error = "";

            // normalize date to date-only for boundary comparisons
            DateTime DateTemp = dob.Date;

            // DOB must not be in the future and must not be more than 150 years in the past
            if (DateTemp > DateTime.Now.Date || DateTemp < DateTime.Now.Date.AddYears(-150))
            {
                Error += "DOB cannot be in the future or more than 150 years in the past";
            }

            // guard against null strings before checking length
            if (!string.IsNullOrEmpty(medications))
            {
                if (medications.Length > 100)
                {
                    Error += "Medications cannot exceed 100 char";
                }
            }

            if (!string.IsNullOrEmpty(diagnoses))
            {
                if (diagnoses.Length > 100)
                {
                    Error += "Diagnoses cannot exceed 100 char";
                }
            }

            // clinical notes validation: required, min 2 chars, max 100 chars
            if (string.IsNullOrEmpty(clinicalNotes))
            {
                Error += "Must attach some clinical notes";
            }
            else
            {
                if (clinicalNotes.Length < 2)
                {
                    Error += "Clinical notes must be at least 2 characters";
                }
                if (clinicalNotes.Length > 100)
                {
                    Error += "Clinical notes cannot exceed 100 char";
                }
            }

            return Error;
        }
    }
}