namespace Church_Solution_API.Helpers.Permission
{
    public class GenerateClientAssertion
    {
        public static string ClientAssertion(string message) 
        {
            string private_key_sig = @"
            {
                 ""kty"": ""EC"",
                 ""d"": ""rPPp7p4eVbrLcgkyId5Rh3NnC2jkoSx-0rq_sKY_sfI"",
                 ""use"": ""sig"",
                 ""crv"": ""P-256"",
                 ""kid"": ""sig-1635840676"",
                 ""x"": ""326HCqg04F_BZDw2w16Jxe7RTflFg4h5lPBi_w2ZDlc"",
                 ""y"": ""rxSPf-gv4ixJqDrD8nk00BTkAMuSNX8o9kiKqKve7ak"",
                 ""alg"": ""ES256"",
            }";
            return message; 
        }
    }
}
