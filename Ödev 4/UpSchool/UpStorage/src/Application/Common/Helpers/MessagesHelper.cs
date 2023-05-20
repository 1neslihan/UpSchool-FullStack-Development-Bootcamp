﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Helpers
{
    public static class MessagesHelper
    {
        public static class Email
        {
            public static class Confirmation
            {
                public static string Subject => "Thank you for signing up to UpStorage!";
                public static string ActivationMessage =>"Thanx for signing up to UpStorage! in order to activate your account please click the button below.";
                public static string Name(string firstName) =>
                    $"Hi, {firstName}";
                public static string ButtonText => "Activate My Account";
                public static string ButtonLink(string email,string emailToken) => 
                    $"https://upstorage.app/account/account-activation?email={email}&token={emailToken}";
            }
        }
    }
}
