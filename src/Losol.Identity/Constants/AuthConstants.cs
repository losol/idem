﻿namespace Losol.Identity.Constants
{
    public class AuthConstants
    {
        public struct TokenRequest
        {
            public const string PhoneNumber = "phone_number";
            public const string Token = "verification_token";
        }

        public struct GrantType
        {
            public const string PhoneNumberToken = "phone_number_token";
        }
    }
}
