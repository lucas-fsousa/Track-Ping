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
      if(string.IsNullOrEmpty(tb_server.Text)) {
        XScreen.ShowMessageBox("INFO", "SERVER INVALIDO");
        return;
      }

      this.Executando = true;
      lbl_rec_executando.Text = "SIM";

      try {
        List<long> lstMs = new List<long>();
        List<string> showLine = new List<string>();
        int timeout = 0;
        int i = 1, count = 1;
        tb_result.Text = string.Empty;
        string server = tb_server.Text.RemoveWhiteSpaces();
        int timeoutValue = Convert.ToInt32(nmc_timeout.Value);

        while(Executando) {
          GC.Collect();

          var result = await X.GetPing(server, timeoutValue);

          if(result.Timeout) {
            lstMs.Add(timeoutValue);
            timeout++;

          } else {
            lstMs.Add(result.Ms);

          }

          // real-time sample panel
          lbl_rec_ms.Text = result.Ms.ToString();
          lbl_rec_mediaMs.Text = (lstMs.Sum() / lstMs.Count).ToString();
          lbl_rec_pings.Text = i.ToString();
          lbl_rec_timeout.Text = timeout.ToString();

          showLine.Add($"[ IP: {server} | STATUS: {result.Status} | MS: {result.Ms} ]");

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
          Thread.Sleep(500);
        }
        
      } catch(Exception ex) {
        XScreen.ShowMessageBox("ERROR", ex.Message);

      }

      lbl_rec_executando.Text = "NÃO";
    }

    private void Btn_Go_Click(object sender, EventArgs e) {
      GetPing().GetAwaiter();
    }

    private void Btn_Stop(object sender, EventArgs e) {
      this.Executando = false;
    }
  }
}
