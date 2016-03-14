using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using log4net;

namespace SwitchNetConfig
{
    /// <summary>
    /// A Helper class which provides convenient methods to set/get network
    /// configuration
    /// </summary>
    public class WMIHelper
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(WMIHelper));

        #region Public Static

        private static NetworkInterface[] adapters;
        /// <summary>
        /// Enable DHCP on the NIC
        /// </summary>
        /// <param name="nicName">Name of the NIC</param>
        public static void SetDHCP(string nicName)
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                // Make sure this is a IP enabled device. Not something like memory card or VM Ware
                if ((bool)mo["IPEnabled"])
                {
                    if (mo["Caption"].Equals(nicName))
                    {
                        ManagementBaseObject newDNS = mo.GetMethodParameters("SetDNSServerSearchOrder");
                        newDNS["DNSServerSearchOrder"] = null;
                        ManagementBaseObject enableDHCP = mo.InvokeMethod("EnableDHCP", null, null);
                        ManagementBaseObject setDNS = mo.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    }
                }
            }
        }

        /// <summary>
        /// Set IP for the specified network card name
        /// </summary>
        /// <param name="nicName">Caption of the network card</param>
        /// <param name="IpAddresses">Comma delimited string containing one or more IP</param>
        /// <param name="SubnetMask">Subnet mask</param>
        /// <param name="Gateway">Gateway IP</param>
        /// <param name="DnsSearchOrder">Comma delimited DNS IP</param>
        public static void SetIP(string nicName, string IpAddresses, string SubnetMask, string Gateway, string DnsSearchOrder)
        {
            log.Debug("Trying to setup IP address...");
            log.Debug("nicName: " + nicName);
            log.Debug("IpAddresses: " + IpAddresses);
            log.Debug("SubnetMask: " + SubnetMask);
            log.Debug("Gateway: " + Gateway);
            log.Debug("DnsSearchOrder: " + DnsSearchOrder);

            try
            {


                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();


                foreach (ManagementObject mo in moc)
                {
                    Console.WriteLine(mo["Caption"]);
                    var parts = mo["Caption"].ToString().Split(' ');
                    var currentNICName = string.Join(" ", parts, 1, parts.Length - 1);
                    Console.WriteLine(currentNICName);
                    log.Debug("NIC: " + currentNICName);

                    // Make sure this is a IP enabled device. Not something like memory card or VM Ware
                    //if ((bool)mo["IPEnabled"])
                    //{
                    //    if (mo["Caption"].Equals(nicName))
                    //    {
                    if (currentNICName.Equals(nicName))
                    {
                        log.Debug("Found selected NIC to be updated: " + currentNICName);

                        ManagementBaseObject newIP = mo.GetMethodParameters("EnableStatic");
                        ManagementBaseObject newGate = mo.GetMethodParameters("SetGateways");
                        ManagementBaseObject newDNS = mo.GetMethodParameters("SetDNSServerSearchOrder");

                        newGate["DefaultIPGateway"] = new string[] { Gateway };
                        newGate["GatewayCostMetric"] = new int[] { 1 };

                        log.Debug("New IP Addresses: " + IpAddresses);
                        newIP["IPAddress"] = IpAddresses.Split(',');
                        newIP["SubnetMask"] = new string[] { SubnetMask };

                        newDNS["DNSServerSearchOrder"] = DnsSearchOrder.Split(',');

                        ManagementBaseObject setIP = mo.InvokeMethod("EnableStatic", newIP, null);
                        ManagementBaseObject setGateways = mo.InvokeMethod("SetGateways", newGate, null);
                        ManagementBaseObject setDNS = mo.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);

                        log.Debug("Updated IP address succesfully!");

                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                log.Error(exception);
            }
        }

        /// <summary>
        /// Returns the network card configuration of the specified NIC
        /// </summary>
        /// <param name="nicName">Name of the NIC</param>
        /// <param name="ipAdresses">Array of IP</param>
        /// <param name="subnets">Array of subnet masks</param>
        /// <param name="gateways">Array of gateways</param>
        /// <param name="dnses">Array of DNS IP</param>
        public static void GetIP(string nicName, out string[] ipAdresses, out string[] subnets, out string[] gateways, out string[] dnses)
        {
            ipAdresses = null;
            subnets = null;
            gateways = null;
            dnses = null;

            List<string> allIpAddressList = new List<string>();
            int ipAdddressIndex = 0;
            foreach (var networkInterface in adapters)
            {
                ipAdddressIndex = 0;
                //var temp = networkInterface.Name + " - " + networkInterface.Description;
                if (networkInterface.Description.Equals(nicName))
                {

                    var stringAddress = networkInterface.GetIPProperties().UnicastAddresses[0].Address.ToString();
                    var ipProps = networkInterface.GetIPProperties();
                    var gatewayAddresses = networkInterface.GetIPProperties().GatewayAddresses;
                    if (gatewayAddresses?[0] != null)
                    {
                        gateways = new[] { gatewayAddresses[0].Address.ToString() };
                    }

                    var dnsAddresses = networkInterface.GetIPProperties().DnsAddresses;
                    if (dnsAddresses?[0] != null)
                    {
                        dnses = new[] { dnsAddresses[0].ToString() };
                    }
                    foreach (var ip in ipProps.UnicastAddresses)
                    {
                        if ((networkInterface.OperationalStatus == OperationalStatus.Up) && (ip.Address.AddressFamily == AddressFamily.InterNetwork))
                        {
                            if (ip.Address != null)
                            {
                                allIpAddressList.Add(ip.Address.ToString());
                            }
                            if (ip.IPv4Mask != null)
                            {
                                subnets = new[] { ip.IPv4Mask.ToString() };
                            }

                        }
                    }
                }
            }

            ipAdresses = allIpAddressList.ToArray();


            //ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            //ManagementObjectCollection moc = mc.GetInstances();

            //foreach (ManagementObject mo in moc)
            //{
            //    // Make sure this is a IP enabled device. Not something like memory card or VM Ware
            //    //if( (bool)mo["ipEnabled"] )
            //    {

            //        var nicNamePart = nicName.Split('-')[1].Trim();

            //        if (mo["Caption"].ToString().Contains(nicNamePart))
            //        {
            //            ipAdresses = (string[])mo["IPAddress"];
            //            subnets = (string[])mo["IPSubnet"];
            //            gateways = (string[])mo["DefaultIPGateway"];
            //            dnses = (string[])mo["DNSServerSearchOrder"];

            //            break;
            //        }
            //    }
            //}
        }

        /// <summary>
        /// Returns the list of Network Interfaces installed
        /// </summary>
        /// <returns>Array list of string</returns>
        public static ArrayList GetNICNames()
        {
            ArrayList nicNames = new ArrayList();
            adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Tunnel ||
                    adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                IPInterfaceProperties properties = adapter.GetIPProperties();
                //nicNames.Add(adapter.Name + " - " + adapter.Description);
                nicNames.Add(adapter.Description);
            }
            return nicNames;
        }

        #endregion
    }
}
