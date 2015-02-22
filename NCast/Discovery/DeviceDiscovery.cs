using System;

namespace NCast.Discovery
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Abstract class representing the discovery process of playback devices.
    /// </summary>
    ///-------------------------------------------------------------------------------------------------
    public abstract class DeviceDiscovery
    {
        public abstract void Start();

        public event EventHandler<DeviceDiscoveryEventArgs> DeviceDiscovered;

        protected void OnDeviceDiscovered(DeviceDiscoveryEventArgs e)
        {
            if (DeviceDiscovered != null)
                DeviceDiscovered(this, e);
        }
    }
}
