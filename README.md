# Microsoft.Net-Crypto-YubiKey
This repository contains a Visual Studio solution with sample code in C# that use Microsoft .NET Cryptography Model with YubiKey 5 PIV.

The C# code in YubiKeyPivSign.cs demonstrates how to sign some data with a YubiKey 5 PIV on Windows 10.
This sample code is a modified version of the C# code that is [published by Microsoft](https://docs.microsoft.com/en-us/dotnet/standard/security/how-to-access-hardware-encryption-devices).

The YubiKey 5 PIV is accessed from Microsoft .NET Cryptography Model by using the underlying "Microsoft Base Smart Card Crypto Provider".

A X.509 certificate needs to be enrolled to the YubiKey PIV before using this sample code for signing. 
For test purposes, it is possible to use the [Yubico .NET YubiKey SDK](https://github.com/Yubico/Yubico.NET.SDK/tree/develop/Yubico.YubiKey/examples/PivSampleCode/) to generate a key-pair and generate a self-signed certificate on the YubiKey PIV.

In order to compile this C# sample code, just open the solution Microsoft.Net-Crypto-YubiKey.sln in Microsoft Visual Studio 2019 and select "Build".
