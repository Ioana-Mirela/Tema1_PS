using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _piataAZ.Entities
{
    public class Ad
    {
        private String _title;
        private String _description;
        private String _usernameEmployee;
        private String _image;

        public Ad(String title, String description, String usernameEmployee, String image)
        {
            _title = title;
            _description = description;
            _usernameEmployee = usernameEmployee;
            _image = image;
        }

        public String getDescription()
        {
            return _description;
        }

        public String getImage()
        {
            return _image;
        }

    }
}
