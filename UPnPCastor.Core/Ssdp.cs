using Rssdp;

namespace UPnPCastor.Core
{
    public class Ssdp
    {
        /// <summary>
        /// UPnP devices discovered.
        /// </summary>
        public List<SsdpDevice> Devices { get; set; } = new List<SsdpDevice>();

        public Ssdp() { }

        public async Task DiscoverAsync()
        {
            using SsdpDeviceLocator deviceLocator = new();

            // (Optional) Set the filter so we only see notifications for devices we care about 
            // (can be any search target value i.e device type, uuid value etc - any value that appears in the 
            // DiscoverdSsdpDevice.NotificationType property or that is used with the searchTarget parameter of the Search method).
            deviceLocator.NotificationFilter = "upnp:rootdevice";

            IEnumerable<DiscoveredSsdpDevice> discoveredDevices = await deviceLocator.SearchAsync();

            foreach (DiscoveredSsdpDevice device in discoveredDevices)
            {
                try
                {
                    Devices.Add(await device.GetDeviceInfo());
                }
                catch (Exception)
                {

                }
            }
        }
    }
}