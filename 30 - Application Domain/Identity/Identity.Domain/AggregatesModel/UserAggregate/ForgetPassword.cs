//-----------------------------------------------------------------
// <copyright file="ForgetPassword.cs" company="Smart Solution">
// Copyright (c) Smart Solution. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace Identity.Domain
{
    public class ForgetPassword
    {
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmNewPassword { get; set; }
    }
}
