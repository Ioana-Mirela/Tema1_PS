using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _piataAZ.Entities;
using _piataAZ.DAL;
using System.Collections;

namespace _piataAZ.BL
{
    public class AdService
    {
        AdDAL adDal;
        Ad ad;

        public AdService()
        {
            adDal = AdDAL.getInstance();
        }

        public void createAd(String title, String description, String image, String username)
        {
            adDal.createAd(title, description, image, username);
        }

        public ArrayList getAllTitles()
        {
            return adDal.getAllTitles();
        }

        public void deleteAd(String title)
        {
            adDal.deleteAd(title);
        }

        public String getImage(String title)
        {
            ad = adDal.getAd(title);
            return ad.getImage();
        }

        public String getDescription(String title)
        {
            ad = adDal.getAd(title);
            return ad.getDescription();
        }

        public void updateAd(String oldTitle, String newTitle, String newDescription, String newImage, String newUser)
        {
            adDal.updateAd(oldTitle, newTitle, newDescription, newImage, newUser);
        }

        public ArrayList getAllReports(ArrayList employees)
        {
            return adDal.getAllReports(employees);
        }

        
    }
}
