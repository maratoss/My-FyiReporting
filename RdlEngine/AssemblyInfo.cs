using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("RDL Engine")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("My-FyiReporting Software")]
[assembly: AssemblyProduct("RDL Project")]
[assembly: AssemblyCopyright("Copyright (C) 2011-2012 Peter Gill")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("4.12.*")]

//
// In order to sign your assembly you must specify a key to use. Refer to the 
// Microsoft .NET Framework documentation for more information on assembly signing.
//
// Use the attributes below to control which key is used for signing. 
//
// Notes: 
//   (*) If no key is specified, the assembly is not signed.
//   (*) KeyName refers to a key that has been installed in the Crypto Service
//       Provider (CSP) on your machine. KeyFile refers to a file which contains
//       a key.
//   (*) If the KeyFile and the KeyName values are both specified, the 
//       following processing occurs:
//       (1) If the KeyName can be found in the CSP, that key is used.
//       (2) If the KeyName does not exist and the KeyFile does exist, the key 
//           in the KeyFile is installed into the CSP and used.
//   (*) In order to create a KeyFile, you can use the sn.exe (Strong Name) utility.
//       When specifying the KeyFile, the location of the KeyFile should be
//       relative to the project output directory which is
//       %Project Directory%\obj\<configuration>. For example, if your KeyFile is
//       located in the project directory, you would specify the AssemblyKeyFile 
//       attribute as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//   (*) Delay Signing is an advanced option - see the Microsoft .NET Framework
//       documentation for more information on this.
//
[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyName(@"..\..\LogMaster.Solo_TemporaryKey.pfx")]
[assembly: InternalsVisibleTo(@"RdlViewer, PublicKey=002400000480000094000000060200000024000052534131000400000100010057dd2f971f70a1ba19a4a0c6dd65dae6f9d6a6c8a6181ec5b4a3fb808b0abf78533ab4f5b270ebf0e679e3ae1623508cc76f9bd280f276d53f78abc800d46dda7baae9f8598001a4459b6b6b425b098213524869ba81dce84f6b7b0baf7eb7a3c18297c4331689f2f84a63d122be23d18eae536f9b0ce40fd9a54527764c7987")]
[assembly: InternalsVisibleTo(@"RdlReader, PublicKey=002400000480000094000000060200000024000052534131000400000100010057dd2f971f70a1ba19a4a0c6dd65dae6f9d6a6c8a6181ec5b4a3fb808b0abf78533ab4f5b270ebf0e679e3ae1623508cc76f9bd280f276d53f78abc800d46dda7baae9f8598001a4459b6b6b425b098213524869ba81dce84f6b7b0baf7eb7a3c18297c4331689f2f84a63d122be23d18eae536f9b0ce40fd9a54527764c7987")]
