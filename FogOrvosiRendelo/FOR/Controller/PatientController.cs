using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOR.Model;

namespace FOR.Controller
{
    

    class PatientController
    {
        PatientModel model;
        NewPatientForm form;
        /// <summary>
        /// Check all data from NewPatientForm and EditPatientDataForm before save them
        /// </summary>
        /// <param name="nT">Title name</param>
        /// <param name="nF">First name</param>
        /// <param name="nL">Last name</param>
        /// <param name="aZ">Address zipcode</param>
        /// <param name="aC">Address city</param>
        /// <param name="aS">Address street</param>
        /// <param name="aN">Address housenumber</param>
        /// <param name="bM">Mother birthname</param>
        /// <param name="bN">Birthname</param>
        /// <param name="bP">Birth place</param>
        /// <param name="bD">Birth date</param>
        /// <param name="dTB">Data TB number</param>
        /// <param name="dP">Data phone number</param>
        /// <param name="dE">Data Email address</param>
        public bool checkData(string nT, string nF, string nL, string aZ, string aC, string aS, string aN, string bM, string bN, string bP, string bD, string dTB, string dP, string dE)
        {
            bool correct = true;
            if (correct==true)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nT">Title name</param>
        /// <param name="nF">First name</param>
        /// <param name="nL">Last name</param>
        /// <param name="aZ">Address zipcode</param>
        /// <param name="aC">Address city</param>
        /// <param name="aS">Address street</param>
        /// <param name="aN">Address housenumber</param>
        /// <param name="bM">Mother birthname</param>
        /// <param name="bN">Birthname</param>
        /// <param name="bP">Birth place</param>
        /// <param name="bD">Birth date</param>
        /// <param name="dTB">Data TB number</param>
        /// <param name="dP">Data phone number</param>
        /// <param name="dE">Data Email address</param>
        public void saveNewPatient(string nT, string nF, string nL, string aZ, string aC, string aS, string aN, string bM, string bN, string bP, string bD, string dTB, string dP, string de)
        {
            model.saveNewPatientData(nT,nF,nL,aZ,aC,aS,aN,bM,bN,bP,bD,dTB,dP,de);
        }
    }
}
