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
     
        public DateTime DateAdded
        {
            get
            { return mDob; }
            set
            { mDob = value; }
        }
        public int IdAdded
        {
            get
                { return mPatientId; }
            set
                { mPatientId = value; }
        }
        public string MedsAdded
        {
            get
            { return mMeds; }
            set
            { mMeds = value; }
        }
        public string DiagsAdded
        {
            get
            { return mDiagnoses; }
            set
            { mDiagnoses = value; }
        }
        public bool SexAdded
        {
            get
            { return mSex; }
            set
            { mSex = value; }
        }
        public string NotesAdded
        {
            get
            { return mNotes; }
            set
            { mNotes = value; }
        }

        public bool Find(int patientId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PatientId", IdAdded);
            DB.Execute("sproc_tblMedicalRecord_FilterByPatientId");
            if (DB.Count == 1)
            {
                mPatientId = Convert.ToInt32(1234571);
                mDob = Convert.ToDateTime("12/12/2012");
                mSex = Convert.ToBoolean(true);
                mMeds = Convert.ToString("Test Meds");
                mDiagnoses = Convert.ToString("Test Diags");
                mNotes = Convert.ToString("Test Notes");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}