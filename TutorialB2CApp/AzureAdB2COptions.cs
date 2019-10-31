using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialB2CApp
{
    public class AzureAdB2COptions
    {

        public const string SelecteuserFlowKey = "UserFlow";
        //public const string PolicyAuthenticationProperty = "Policy";




        //public AzureAdB2COptions()
        //{
        //    AzureAdB2CInstance= "https://login.microsoftonline.com/tfp";
        //}

        public string ClientId { get; set; }
        public string AzureAdB2CInstance { get; set; }
        public string Tenant { get; set; }
       // public string SignUpSignInPolicyId { get; set; }
        public string SignUpSignInUserFlowId { get; set; }

        //public string SignInPolicyId { get; set; }
        //public string SignInUserFlowId { get; set; }
        //public string SignUpPolicyId { get; set; }
        //public string ResetPasswordPolicyId { get; set; }
        public string ResetPasswordUserFlowId { get; set; }
        public string EditProfilePolicyId { get; set; }
        public string EditProfileUserFlowId { get; set; }
        public string RedirectUri { get; set; }

        public string DefaultPolicy => SignUpSignInUserFlowId;
        public string Authority => $"{AzureAdB2CInstance}/{Tenant}/{DefaultPolicy}/v2.0";

        //public string ClientSecret { get; set; }
        //public string ApiUrl { get; set; }
        //public string ApiScopes { get; set; }

    }
}
