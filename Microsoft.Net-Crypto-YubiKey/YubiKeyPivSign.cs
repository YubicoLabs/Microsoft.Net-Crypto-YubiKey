using System;
using System.Security.Cryptography;

namespace YubiKeyPivSign
{
    class YKSign
    {
        static void Main(string[] args)
        {
            /*
            Create a new CspParameters object that identifies a
            Smart Card Cryptographic Provider.
            The YubiKey 5 PIV application is accessed through the 
            "Microsoft Base Smart Card Crypto Provider".
            */
            CspParameters csp = new CspParameters(1, "Microsoft Base Smart Card Crypto Provider");
            csp.Flags = CspProviderFlags.UseDefaultKeyContainer;

            /*
            Initialize an RSACryptoServiceProvider object using
            the CspParameters object.
            */
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);

            // Create some data to sign.
            byte[] data = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Data			: " + BitConverter.ToString(data));

            // Sign the data using a YubiKey with the Smart Card Cryptographic Provider.
            byte[] sig = rsa.SignData(data, "SHA1");

            Console.WriteLine("Signature	: " + BitConverter.ToString(sig));

            // Verify the signed data using the Smart Card Cryptographic Provider.
            bool verified = rsa.VerifyData(data, "SHA1", sig);

            Console.WriteLine("Verified		: " + verified);
        }
    }
}


