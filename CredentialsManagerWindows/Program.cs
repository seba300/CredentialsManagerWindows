using System;
//DOWNLOAD NUGGET
//Meziantou.Framework.Win32.CredentialManager    
namespace CredentialsManagerWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            // Save the credential to the credential manager
            CredentialManager.WriteCredential(
                applicationName: "CredentialManagerTests",//location
                userName: "meziantou",//login
                secret: "Pa$$w0rd",//password
                comment: "Test",//doesn't matter
                persistence: CredentialPersistence.LocalMachine);

            // Get a credential from the credential manager
            var cred = CredentialManager.ReadCredential(applicationName: "CredentialManagerTests");
            Console.WriteLine(cred.UserName);
            Console.WriteLine(cred.Password);

            // Delete a credential from the credential manager
            CredentialManager.DeleteCredential(applicationName: "CredentialManagerTests");
        }
    }
}
