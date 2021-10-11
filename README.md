<div id="top"></div>

<h3 align="center">Using YubiKey PIV with Microsoft.Net Cryptography Model</h3>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>

<!-- ABOUT -->
## About

This repository contains a Visual Studio 2019 solution with sample code in C# that uses Microsoft .NET Cryptography Model with YubiKey 5 PIV.

The C# code in `YubiKeyPivSign.cs` demonstrates how to sign some data with a YubiKey 5 PIV on Windows 10.

The YubiKey 5 PIV is accessed from Microsoft .NET Cryptography Model by using the underlying `Microsoft Base Smart Card Crypto Provider`.

<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [Microsoft .NET](https://docs.microsoft.com/en-us/dotnet/)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

To get started with the project follow the steps below.

### Prerequisites

Use a PC with Windows 10 or higher as operating system.

Download and install [Microsoft Visual Studio 2019](https://visualstudio.microsoft.com/downloads/).

A X.509 certificate needs to be enrolled to the YubiKey 5 PIV before using this sample code for signing. 
For test purposes, it is possible to use the [Yubico .NET YubiKey SDK](https://github.com/Yubico/Yubico.NET.SDK/tree/develop/Yubico.YubiKey/examples/PivSampleCode/) to generate a key-pair and generate a self-signed certificate on the YubiKey 5 PIV.

### Build the solution

1. Clone the repo
   ```sh
   git clone https://github.com/YubicoLabs/Microsoft.Net-Crypto-YubiKey.git
   ```
2. Open the solutions file `Microsoft.Net-Crypto-YubiKey.sln` with Microsoft Visual Studio 2019.

3. Select the menu item "Build" and select the option "Build Solution".

![](/images/build.png)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Insert a YubiKey 5 with a X.509 certificate in the USB-port at the PC.

Run the application by either pressing the button "Microsoft.Net-Crypto-YubiKey" in the top bar of Microsoft Visual Studio 2019 (see the image above), or running the executable file `<file path to the solution>\Microsoft.Net-Crypto-YubiKey\bin\Debug\net5.0\Microsoft.Net-Crypto-YubiKey.exe`.

This will launch a command prompt, which in turn will present the Windows Security dialog box for a Smart Card. Enter the PIN code to the YubiKey 5 PIV in this dialog box.

![](/images/run.png)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the Apache License 2.0. See `LICENSE` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Please contact the Yubico solutions developer program if you have any questions.

Website: https://developers.yubico.com/

Email: developersprogram@yubico.com

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

More information on how to use hardware modules and smart cards with Microsoft .NET is available at Microsoft's web: [How to Access Hardware Encryption Devices](https://docs.microsoft.com/en-us/dotnet/standard/security/how-to-access-hardware-encryption-devices).

<p align="right">(<a href="#top">back to top</a>)</p>

