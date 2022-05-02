using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PublicUtility;

namespace PING {
  public partial class F_Ping: Form {
    public F_Ping() {
      InitializeComponent();
    }

    private bool Executando { get; set; }

    private async Task GetPing() {
      this.Executando = true;

      if(string.IsNullOrEmpty(tb_server.Text)) {
        XScreen.ShowMessageBox("INFO", "SERVER INVALIDO");
      }

      try {
        List<long> lstMs = new List<long>();
        List<string> showLine = new List<string>();
        int timeout = 0;
        int i = 1, count = 0;
        tb_result.Text = string.Empty;

        while(Executando) {

          var result = await X.GetPing(tb_server.Text.RemoveWhiteSpaces(), Convert.ToInt32(nmc_timeout.Value));

          if(result.Timeout) {
            lstMs.Add(0);
            timeout++;

          } else {
            lstMs.Add(result.Ms);

          }

          // real-time sample panel
          lbl_rec_ms.Text = result.Ms.ToString();
          lbl_rec_mediaMs.Text = (lstMs.Sum() / lstMs.Count).ToString();
          lbl_rec_pings.Text = i.ToString();
          lbl_rec_timeout.Text = timeout.ToString();

          showLine.Add($"[ IP: {tb_server.Text} | STATUS: {result.Status} | MS: {result.Ms} ]");
          Thread.Sleep(500);

          // Controls the preview pane
          if(count % 5 == 0) {
            StringBuilder sb = new StringBuilder();
            foreach(string line in showLine) {
              sb.AppendLine(line);
            }

            tb_result.Text = sb.ToString();
          }

          if(count == 10) {
            count = 0;
            showLine.Clear();
            lstMs.Clear();
          }

          i++;
          count++;
        }


      } catch(Exception ex) {
        XScreen.ShowMessageBox("ERROR", ex.Message);
      }


    }

    private void Btn_Go_Click(object sender, EventArgs e) {
      GetPing().GetAwaiter();
    }

    private void Btn_Stop(object sender, EventArgs e) {
      this.Executando = false;
    }
  }
}
