﻿using Amazon;

/**
* @author Umair Qayyum
*
* @date - 5/22/2019 1:12:59 PM 
*/
namespace AWS_SUITE.Models
{
    public class AWS_Credentials
    {
        string AWS_AccessKey;
        string AWS_SecretKey;
        RegionEndpoint Region;

        #region Constructors
        public AWS_Credentials()
        {
        }

        public AWS_Credentials(string access_key, string secret_key)
        {
            this.AWS_AccessKey = access_key;
            this.AWS_SecretKey = secret_key;
        }

        public AWS_Credentials(string access_key, string secret_key, RegionEndpoint region)
        {
            this.AWS_AccessKey = access_key;
            this.AWS_SecretKey = secret_key;
            this.Region = region;
        }
        #endregion
    }
}