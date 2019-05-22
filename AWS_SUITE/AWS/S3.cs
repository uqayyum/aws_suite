﻿using Amazon;
using Amazon.S3;
using AWS_SUITE.Models;
using System;

/**
* @author Umair Qayyum
*
* @date - 5/22/2019 1:03:22 PM 
*/

namespace AWS_SUITE
{
    public class S3
    {
        AWS_Credentials Credentials;

        #region Constructors
        public S3()
        {
            this.Credentials = new AWS_Credentials();
        }

        public S3(AWS_Credentials credentials)
        {
            this.Credentials = credentials;
        }
        #endregion

        #region getS3Client
        public AmazonS3Client getS3Client()
        {
            try
            {
                return new AmazonS3Client();
            }
            catch(Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public AmazonS3Client getS3Client(AWS_Credentials credentials)
        {
            try
            {
                return new AmazonS3Client(credentials.AWS_AccessKey, credentials.AWS_SecretKey, credentials.Region);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public AmazonS3Client getS3Client(string access_key, string secret_key)
        {
            try
            {
                return new AmazonS3Client(access_key, secret_key);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public AmazonS3Client getS3Client(string access_key, string secret_key, RegionEndpoint region)
        {
            try
            {
                return new AmazonS3Client(access_key, secret_key, region);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public AmazonS3Client getS3Client(RegionEndpoint region)
        {
            try
            {
                return new AmazonS3Client(region);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        #endregion

    }
}