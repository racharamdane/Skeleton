using System;
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
            mPatientId = 100;
            mDob = Convert.ToDateTime("12/12/2012");
            mSex = true;
            mMeds = "Test Meds";
            mDiagnoses = "Test Diags";
            mNotes = "Test Notes";
            return true;
        }
    }
}