using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GodLesZ.Tools.SoundCloudDownloader.Library.Soundcloud.Api.Http;
using MetroFramework;
using MetroFramework.Forms;

namespace GodLesZ.Tools.SoundCloudDownloader.Client {

    public partial class FormMain : MetroForm {

        public FormMain() {
            InitializeComponent();
        }


        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var text = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                return;
            }

            var request = new JsonRequest();
            var result = await request.Search(text);
            Debugger.Break();
        }

    }

}
