using SocialSiteV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialSiteV4.DAL
{
    public interface IDAL
    {
        Profile GetProfile(string Name);
        IEnumerable<Profile> GetAllProfiles();
        void UpdateProfile(Profile profile);
        void CreateProfile(Profile profile);

        string GetUserName(int id);
    }
}