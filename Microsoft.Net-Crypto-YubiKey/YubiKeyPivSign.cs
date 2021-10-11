using System;
using System.Security.Cryptography;

namespace YubiKeyPivSign
{
    class YKSign
    {
        static void Main(string[] args)
        {

            if (OperatingSystem.IsWindows()) // Check that the OS is Windows.
            {

                /*
                Create a new CspParameters object that initiates the
                "Microsoft Base Smart Card Crypto Provider".
                The YubiKey 5 PIV is accessed through this CSP.
                */

                CspParameters csp = new CspParameters(1, "Microsoft Base Smart Card Crypto Provider");
                csp.Flags = CspProviderFlags.UseDefaultKeyContainer;

                /*
                Initialize an RSACryptoServiceProvider object with CSP object.
                */
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);

                // Create a byte array of data to be signed.
                byte[] dataTBS = new byte[] { 7, 6, 5, 4, 3, 2, 1, 0 };

                Console.WriteLine("Data to be signed: " + BitConverter.ToString(dataTBS));

                // Sign the data using a YubiKey PIV with the Smart Card CSP.
                byte[] sigData = rsa.SignData(dataTBS, "SHA1");

                Console.WriteLine("Signed data: " + BitConverter.ToString(sigData));

                // Verify the signed data using the Smart Card CSP.
                bool verifiedSig = rsa.VerifyData(dataTBS, "SHA1", sigData);

                Console.WriteLine("Signature verification (true or false): " + verifiedSig);
            }
            else
            {
                Console.WriteLine("The Microsoft CSP is not supported on this OS.");
            }
        }
    }
}


