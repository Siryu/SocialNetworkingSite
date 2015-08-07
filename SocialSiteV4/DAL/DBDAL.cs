using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialSiteV4.Models;

namespace SocialSiteV4.DAL
{
    public class DBDAL : IDAL
    {
        public Models.Profile GetProfile(string Name)
        {
            Profile foundProfile = null;
            using(ProfileDBContextNew db = new ProfileDBContextNew())
            {
                foundProfile = db.Profiles.Find(Name);
            }
            return foundProfile;
        }

        public IEnumerable<Models.Profile> GetAllProfiles()
        {
            IEnumerable<Profile> foundProfiles = null;
            using (ProfileDBContextNew db = new ProfileDBContextNew())
            {
                foundProfiles = db.Profiles.ToList();
            }
            return foundProfiles;
        }

        public void UpdateProfile(Models.Profile profile)
        {
            using (ProfileDBContextNew db = new ProfileDBContextNew())
            {
                Profile original = db.Profiles.Find(profile.User);
                original.Name = profile.Name;
                original.ImageLink = profile.ImageLink;
                original.Bio = profile.Bio;
                original.FavoriteContent1 = profile.FavoriteContent1;
                original.FavoriteContent2 = profile.FavoriteContent2;
                original.FavoriteContent3 = profile.FavoriteContent3;
                original.FavoriteTitle1 = profile.FavoriteTitle1;
                original.FavoriteTitle2 = profile.FavoriteTitle2;
                original.FavoriteTitle3 = profile.FavoriteTitle3;
                db.SaveChanges();
            }
        }

        public void CreateProfile(Models.Profile profile)
        {
            using (ProfileDBContextNew db = new ProfileDBContextNew())
            {
                db.Profiles.Add(profile);
            }
        }

        public string GetUserName(int id)
        {
            //using()
            throw new NotImplementedException();
        }
    }
}