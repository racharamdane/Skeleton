using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

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

        public string Valid(string dob, string medications, string diagnoses, string clinicalNotes)
        {
            String Error = "";
            DateTime DateTemp;
            DateTemp = Convert.ToDateTime(dob);
            try
            {
                if (DateTemp > DateTime.Now.Date || DateTemp < DateTime.Now.Date.AddYears(150))
                {
                    Error += "DOB is invalid";
                }
                if (dob == null)
                {
                    Error += "DOB is required";
                }

            }
            catch
            {
                Error += "DOB must be a date, dd/mm/yyyy";
            }

            if(medications.Length > 100)
            {
                Error += "Medications cannot exceed 100 char";
            }
            if (diagnoses.Length > 100)
            {
                Error += "Diagnoses cannot exceed 100 char";
            }
            if(clinicalNotes.Length == 0)
            {
                Error += "Must attach some clinical notes";
            }
            return Error;
        }
    }
}