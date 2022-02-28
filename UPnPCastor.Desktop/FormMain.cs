using Rssdp;
using UPnPCastor.Core;
using UPnPCastor.Core.Soap;
using UPnPCastor.Core.UPnP.Service.AVTransport.Actions;

namespace UPnPCastor
{
    public partial class FormMain : Form
    {
        public FormMain() => InitializeComponent();

        private void FormMain_Shown(object sender, EventArgs e) => Discover();

        private void CmdDiscover_Click(object sender, EventArgs e) => Discover();

        private async void Discover()
        {
            try
            {
                Ssdp ssdp = new();
                await ssdp.DiscoverAsync();

                cbDevices.DataSource = ssdp.Devices.Where(d => d.Services.Any(s => s.ServiceType == "AVTransport")).ToList();
                cbDevices.DisplayMember = "FriendlyName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CmdCast_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDevices.SelectedItem is not SsdpDevice device) return;

                SoapHttpRequest request;

                request = new(device, new SetAVTransportURI(TxtUri.Text));
                await request.SendAsync();

                request = new(device, new Play());
                await request.SendAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CmdPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDevices.SelectedItem is not SsdpDevice device) return;

                SoapHttpRequest request;

                request = new(device, new Play());
                await request.SendAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CmdPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDevices.SelectedItem is not SsdpDevice device) return;

                SoapHttpRequest request;

                request = new(device, new Pause());
                await request.SendAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CmdStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDevices.SelectedItem is not SsdpDevice device) return;

                SoapHttpRequest request;

                request = new(device, new Stop());
                await request.SendAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}