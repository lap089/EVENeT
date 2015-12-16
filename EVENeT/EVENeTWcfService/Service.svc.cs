﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EVENeTWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public DataClassesDataContext Data { get; set; }

        public Service()
        {
            Data = new DataClassesDataContext(@"Data Source=(local);Initial Catalog=EVENet;Integrated Security=True");
        }

        public bool UsernameExists(string username)
        {
            return (bool)Data.isUserExisted(username);
        }

        public void CreateIndividual(string username, string password, string profilePic, string cover, string firstName, string midName, string lastName, DateTime dob, bool gender)
        {
            Data.createIndividual(username, password, profilePic, cover, firstName, midName, lastName, dob, gender);
        }

        public bool CorrectUserNameAndPassword(string username, string password)
        {
            bool result = (bool)Data.auth(username, password);
            return result;
        }

        public void CreateOrganization(string username, string password, string name, string logo, string cover, string description, string type, string phone, string website)
        {
            Data.createOrganization(username, password, name, logo, cover, description, type, phone, website);
        }

        public bool IndividualFullySetUp(string username)
        {
            return (bool)Data.isIndividualFullySetUp(username);
        }

        public void SetIndividualInfo(string username, string firstName, string midName, string lastName, DateTime dob, bool gender)
        {
            Data.setIndividual(username, firstName, midName, lastName, dob, gender);
        }

        public int UserType(string username)
        {
            var tmp = Data.getUserType(username);
            if (tmp == null)
                return -1;
            else
                return (int)tmp;
        }

        public void SetProfilePicture(string username, string imagePath)
        {
            Data.setProfilePicture(username, imagePath);
        }

        public void SetCoverPicture(string username, string imagePath)
        {
            Data.setCoverPictureUser(username, imagePath);
        }

        public void SetOrganizationInfo(string username, string name, string description, string type, string phone, string website)
        {
            Data.setOrganization(username, name, description, type, phone, website);
        }

        public bool CreateEvent(DateTime beginTime, DateTime endTime, string description, string thumbnail, string title, int ticket, int locationId, string currentUser)
        {
            try
            {
                Data.createEvent(beginTime, endTime, description, thumbnail, title, ticket, locationId, currentUser);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public int GetLocationFromAddress(string address)
        {
            var result = Data.getLocationFromAddress(address);
            if (result != null)
                return (int)result;
            return -1;
        }

        public void CreateLocation(string name, string description, string address, double longitude, double latitude, string thumbnail)
        {
            Data.createLocation(name, description, address, longitude, latitude, thumbnail);
        }

        public void GetIndividual(string username, out string FirstName, out string MiddleName, out string LastName, out DateTime DOB, out bool Gender, out string ProfilePic, out string CoverPic)
        {
            ISingleResult<getIndividualResult> result1 = Data.getIndividual(username);
            ISingleResult<getUserResult> result2 = Data.getUser(username);
            if (result1 != null && result2 != null)
            {
                getIndividualResult i = result1.First();
                getUserResult u = result2.First();
                FirstName = i.firstName;
                MiddleName = i.midName;
                LastName = i.lastName;
                DOB = i.DOB;
                Gender = i.gender;
                ProfilePic = u.profilePicture;
                CoverPic = u.coverPicture;
            }
            else
            {
                FirstName = "";
                MiddleName = "";
                LastName = "";
                DOB = DateTime.MinValue;
                Gender = false;
                ProfilePic = "";
                CoverPic = "";
            }
        }
    }
}
