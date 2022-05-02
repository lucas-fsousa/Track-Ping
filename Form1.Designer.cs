namespace PING {
  partial class F_Ping {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.panel1 = new System.Windows.Forms.Panel();
      this.Btn_Parar = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.lbl_rec_timeout = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_rec_mediaMs = new System.Windows.Forms.Label();
      this.lbl_rec_pings = new System.Windows.Forms.Label();
      this.lbl_rec_ms = new System.Windows.Forms.Label();
      this.lbl_qtd_request = new System.Windows.Forms.Label();
      this.lbl_media = new System.Windows.Forms.Label();
      this.lbl_ms = new System.Windows.Forms.Label();
      this.nmc_timeout = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.tb_result = new System.Windows.Forms.TextBox();
      this.Btn_Go = new System.Windows.Forms.Button();
      this.lbl_server = new System.Windows.Forms.Label();
      this.tb_server = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.lbl_rec_executando = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nmc_timeout)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.Btn_Parar);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.nmc_timeout);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.tb_result);
      this.panel1.Controls.Add(this.Btn_Go);
      this.panel1.Controls.Add(this.lbl_server);
      this.panel1.Controls.Add(this.tb_server);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(521, 192);
      this.panel1.TabIndex = 0;
      // 
      // Btn_Parar
      // 
      this.Btn_Parar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.Btn_Parar.Location = new System.Drawing.Point(9, 161);
      this.Btn_Parar.Name = "Btn_Parar";
      this.Btn_Parar.Size = new System.Drawing.Size(77, 25);
      this.Btn_Parar.TabIndex = 12;
      this.Btn_Parar.Text = "PARAR";
      this.Btn_Parar.UseVisualStyleBackColor = true;
      this.Btn_Parar.Click += new System.EventHandler(this.Btn_Stop);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(144, 44);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 15);
      this.label3.TabIndex = 11;
      this.label3.Text = "MS";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
      this.panel2.Controls.Add(this.lbl_rec_executando);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.lbl_rec_timeout);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.lbl_rec_mediaMs);
      this.panel2.Controls.Add(this.lbl_rec_pings);
      this.panel2.Controls.Add(this.lbl_rec_ms);
      this.panel2.Controls.Add(this.lbl_qtd_request);
      this.panel2.Controls.Add(this.lbl_media);
      this.panel2.Controls.Add(this.lbl_ms);
      this.panel2.Location = new System.Drawing.Point(9, 71);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(189, 87);
      this.panel2.TabIndex = 10;
      // 
      // lbl_rec_timeout
      // 
      this.lbl_rec_timeout.AutoSize = true;
      this.lbl_rec_timeout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lbl_rec_timeout.Location = new System.Drawing.Point(93, 49);
      this.lbl_rec_timeout.Name = "lbl_rec_timeout";
      this.lbl_rec_timeout.Size = new System.Drawing.Size(14, 15);
      this.lbl_rec_timeout.TabIndex = 12;
      this.lbl_rec_timeout.Text = "0";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 15);
      this.label2.TabIndex = 11;
      this.label2.Text = "Timeout:";
      // 
      // lbl_rec_mediaMs
      // 
      this.lbl_rec_mediaMs.AutoSize = true;
      this.lbl_rec_mediaMs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lbl_rec_mediaMs.Location = new System.Drawing.Point(93, 34);
      this.lbl_rec_mediaMs.Name = "lbl_rec_mediaMs";
      this.lbl_rec_mediaMs.Size = new System.Drawing.Size(14, 15);
      this.lbl_rec_mediaMs.TabIndex = 10;
      this.lbl_rec_mediaMs.Text = "0";
      // 
      // lbl_rec_pings
      // 
      this.lbl_rec_pings.AutoSize = true;
      this.lbl_rec_pings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lbl_rec_pings.Location = new System.Drawing.Point(93, 19);
      this.lbl_rec_pings.Name = "lbl_rec_pings";
      this.lbl_rec_pings.Size = new System.Drawing.Size(14, 15);
      this.lbl_rec_pings.TabIndex = 9;
      this.lbl_rec_pings.Text = "0";
      // 
      // lbl_rec_ms
      // 
      this.lbl_rec_ms.AutoSize = true;
      this.lbl_rec_ms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lbl_rec_ms.Location = new System.Drawing.Point(93, 4);
      this.lbl_rec_ms.Name = "lbl_rec_ms";
      this.lbl_rec_ms.Size = new System.Drawing.Size(14, 15);
      this.lbl_rec_ms.TabIndex = 8;
      this.lbl_rec_ms.Text = "0";
      // 
      // lbl_qtd_request
      // 
      this.lbl_qtd_request.AutoSize = true;
      this.lbl_qtd_request.Location = new System.Drawing.Point(14, 19);
      this.lbl_qtd_request.Name = "lbl_qtd_request";
      this.lbl_qtd_request.Size = new System.Drawing.Size(39, 15);
      this.lbl_qtd_request.TabIndex = 6;
      this.lbl_qtd_request.Text = "Pings:";
      // 
      // lbl_media
      // 
      this.lbl_media.AutoSize = true;
      this.lbl_media.Location = new System.Drawing.Point(14, 34);
      this.lbl_media.Name = "lbl_media";
      this.lbl_media.Size = new System.Drawing.Size(63, 15);
      this.lbl_media.TabIndex = 5;
      this.lbl_media.Text = "Media MS:";
      // 
      // lbl_ms
      // 
      this.lbl_ms.AutoSize = true;
      this.lbl_ms.Location = new System.Drawing.Point(14, 4);
      this.lbl_ms.Name = "lbl_ms";
      this.lbl_ms.Size = new System.Drawing.Size(27, 15);
      this.lbl_ms.TabIndex = 7;
      this.lbl_ms.Text = "MS:";
      // 
      // nmc_timeout
      // 
      this.nmc_timeout.Location = new System.Drawing.Point(87, 42);
      this.nmc_timeout.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
      this.nmc_timeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nmc_timeout.Name = "nmc_timeout";
      this.nmc_timeout.Size = new System.Drawing.Size(51, 23);
      this.nmc_timeout.TabIndex = 9;
      this.nmc_timeout.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(9, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 20);
      this.label1.TabIndex = 8;
      this.label1.Text = "Timeout:";
      // 
      // tb_result
      // 
      this.tb_result.BackColor = System.Drawing.SystemColors.Desktop;
      this.tb_result.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.tb_result.ForeColor = System.Drawing.SystemColors.Window;
      this.tb_result.Location = new System.Drawing.Point(204, 9);
      this.tb_result.Multiline = true;
      this.tb_result.Name = "tb_result";
      this.tb_result.ReadOnly = true;
      this.tb_result.Size = new System.Drawing.Size(314, 180);
      this.tb_result.TabIndex = 3;
      // 
      // Btn_Go
      // 
      this.Btn_Go.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.Btn_Go.Location = new System.Drawing.Point(114, 161);
      this.Btn_Go.Name = "Btn_Go";
      this.Btn_Go.Size = new System.Drawing.Size(84, 25);
      this.Btn_Go.TabIndex = 2;
      this.Btn_Go.Text = "INICIAR";
      this.Btn_Go.UseVisualStyleBackColor = true;
      this.Btn_Go.Click += new System.EventHandler(this.Btn_Go_Click);
      // 
      // lbl_server
      // 
      this.lbl_server.AutoSize = true;
      this.lbl_server.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lbl_server.Location = new System.Drawing.Point(12, 8);
      this.lbl_server.Name = "lbl_server";
      this.lbl_server.Size = new System.Drawing.Size(27, 20);
      this.lbl_server.TabIndex = 1;
      this.lbl_server.Text = "IP:";
      // 
      // tb_server
      // 
      this.tb_server.Location = new System.Drawing.Point(45, 9);
      this.tb_server.Name = "tb_server";
      this.tb_server.Size = new System.Drawing.Size(153, 23);
      this.tb_server.TabIndex = 0;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(15, 64);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(72, 15);
      this.label4.TabIndex = 13;
      this.label4.Text = "Executando:";
      // 
      // lbl_rec_executando
      // 
      this.lbl_rec_executando.AutoSize = true;
      this.lbl_rec_executando.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lbl_rec_executando.Location = new System.Drawing.Point(93, 64);
      this.lbl_rec_executando.Name = "lbl_rec_executando";
      this.lbl_rec_executando.Size = new System.Drawing.Size(33, 15);
      this.lbl_rec_executando.TabIndex = 14;
      this.lbl_rec_executando.Text = "NÃO";
      // 
      // F_Ping
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(521, 192);
      this.Controls.Add(this.panel1);
      this.MaximizeBox = false;
      this.Name = "F_Ping";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PING";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nmc_timeout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox tb_result;
    private System.Windows.Forms.Button Btn_Go;
    private System.Windows.Forms.Label lbl_server;
    private System.Windows.Forms.TextBox tb_server;
    private System.Windows.Forms.Label lbl_ms;
    private System.Windows.Forms.Label lbl_qtd_request;
    private System.Windows.Forms.Label lbl_media;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label lbl_rec_mediaMs;
    private System.Windows.Forms.Label lbl_rec_pings;
    private System.Windows.Forms.Label lbl_rec_ms;
    private System.Windows.Forms.NumericUpDown nmc_timeout;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbl_rec_timeout;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button Btn_Parar;
    private System.Windows.Forms.Label lbl_rec_executando;
    private System.Windows.Forms.Label label4;
  }
}
