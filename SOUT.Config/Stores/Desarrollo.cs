using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOUT.Config
{
    internal static partial class Settings
    {

        internal static string[] DNSHosts = { "localhost", "localhost" }; //El primero es el default
        internal static string[] ClientPorts = { "80", "80" }; //El primero es el default, ultimo es el backup, los demas son backwards compatibility
        internal static string ClientEnableLog = @"1";
        internal static string DBServerName = @"DESKTOP-BAR55RE\DEVELOP";
        internal static string DataName = @"DB3000";
        internal static string DBPwd1 = @"desarrollo";
        internal static string DBPwd2 = @"desarrollo";
        internal static string ServiceProtocol = @"http";
        internal static string ServiceFolder = @"MarWebService/";
        internal static string ServiceFile = @"mar-ptovta.asmx";
        internal static string DBUser1 = @"sa";
        internal static string DBUser2 = @"sa";



        //internal static string[] DNSHosts = { "localhost", "localhost" }; //El primero es el default
        //internal static string[] ClientPorts = { "80", "80" }; //El primero es el default, ultimo es el backup, los demas son backwards compatibility
        //internal static string ClientEnableLog = @"1";
        //internal static string DBServerName = @"SQLHAPROD01.Finanzas.gov.do";
        //internal static string DataName = @"Hacienda";
        //internal static string DBPwd1 = @"x6auAfaGg8n*b";
        //internal static string DBPwd2 = @"x6auAfaGg8n*b";
        //internal static string ServiceProtocol = @"http";
        //internal static string ServiceFolder = @"MarWebService/";
        //internal static string ServiceFile = @"mar-ptovta.asmx";
        //internal static string DBUser1 = @"usrappcas01";
        //internal static string DBUser2 = @"usrappcas01";



        //internal static string[] DNSHosts = { "localhost", "localhost" }; //El primero es el default
        //internal static string[] ClientPorts = { "80", "80" }; //El primero es el default, ultimo es el backup, los demas son backwards compatibility
        //internal static string ClientEnableLog = @"1";
        //internal static string DBServerName = @"SRVDBPROD01";
        //internal static string DataName = @"Hacienda";
        //internal static string DBPwd1 = @"crazyhorn63";
        //internal static string DBPwd2 = @"crazyhorn63";
        //internal static string ServiceProtocol = @"http";
        //internal static string ServiceFolder = @"MarWebService/";
        //internal static string ServiceFile = @"mar-ptovta.asmx";
        //internal static string DBUser1 = @"usrappcas01";
        //internal static string DBUser2 = @"usrappcas01";




    }
}