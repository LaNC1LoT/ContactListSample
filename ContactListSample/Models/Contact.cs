﻿
namespace ContactListSample.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string[] Emails { get; set; }
        public string[] PhoneNumbers { get; set; }
    }
}
