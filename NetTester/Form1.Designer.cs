namespace NetTester
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         groupBox1 = new GroupBox();
         label1 = new Label();
         ping_result_ctrl = new RichTextBox();
         ping_run_ctrl = new Button();
         ping_ip_ctrl = new TextBox();
         groupBox2 = new GroupBox();
         port_port_ctrl = new TextBox();
         label3 = new Label();
         port_result_ctrl = new RichTextBox();
         port_run_ctrl = new Button();
         port_ip_ctrl = new TextBox();
         label2 = new Label();
         groupBox3 = new GroupBox();
         showip_ctrl = new Button();
         info_result_ctrl = new RichTextBox();
         groupBox1.SuspendLayout();
         groupBox2.SuspendLayout();
         groupBox3.SuspendLayout();
         SuspendLayout();
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(label1);
         groupBox1.Controls.Add(ping_result_ctrl);
         groupBox1.Controls.Add(ping_run_ctrl);
         groupBox1.Controls.Add(ping_ip_ctrl);
         groupBox1.Location = new Point(12, 12);
         groupBox1.Name = "groupBox1";
         groupBox1.Size = new Size(463, 122);
         groupBox1.TabIndex = 0;
         groupBox1.TabStop = false;
         groupBox1.Text = "Znajdz urządzenie";
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(11, 22);
         label1.Name = "label1";
         label1.Size = new Size(53, 15);
         label1.TabIndex = 3;
         label1.Text = "Adres IP:";
         // 
         // ping_result_ctrl
         // 
         ping_result_ctrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
         ping_result_ctrl.Location = new Point(117, 22);
         ping_result_ctrl.Name = "ping_result_ctrl";
         ping_result_ctrl.Size = new Size(340, 86);
         ping_result_ctrl.TabIndex = 2;
         ping_result_ctrl.Text = "";
         // 
         // ping_run_ctrl
         // 
         ping_run_ctrl.Location = new Point(11, 69);
         ping_run_ctrl.Name = "ping_run_ctrl";
         ping_run_ctrl.Size = new Size(100, 39);
         ping_run_ctrl.TabIndex = 1;
         ping_run_ctrl.Text = "Szukaj";
         ping_run_ctrl.UseVisualStyleBackColor = true;
         ping_run_ctrl.Click += ping_run_ctrl_Click;
         // 
         // ping_ip_ctrl
         // 
         ping_ip_ctrl.Location = new Point(11, 40);
         ping_ip_ctrl.Name = "ping_ip_ctrl";
         ping_ip_ctrl.Size = new Size(100, 23);
         ping_ip_ctrl.TabIndex = 0;
         ping_ip_ctrl.Text = "192.168.1.100";
         // 
         // groupBox2
         // 
         groupBox2.Controls.Add(port_port_ctrl);
         groupBox2.Controls.Add(label3);
         groupBox2.Controls.Add(port_result_ctrl);
         groupBox2.Controls.Add(port_run_ctrl);
         groupBox2.Controls.Add(port_ip_ctrl);
         groupBox2.Controls.Add(label2);
         groupBox2.Location = new Point(12, 172);
         groupBox2.Name = "groupBox2";
         groupBox2.Size = new Size(463, 165);
         groupBox2.TabIndex = 1;
         groupBox2.TabStop = false;
         groupBox2.Text = "Sprawdź połączenie";
         // 
         // port_port_ctrl
         // 
         port_port_ctrl.Location = new Point(117, 38);
         port_port_ctrl.Name = "port_port_ctrl";
         port_port_ctrl.Size = new Size(46, 23);
         port_port_ctrl.TabIndex = 5;
         port_port_ctrl.Text = "60001";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(117, 19);
         label3.Name = "label3";
         label3.Size = new Size(32, 15);
         label3.TabIndex = 4;
         label3.Text = "Port:";
         // 
         // port_result_ctrl
         // 
         port_result_ctrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
         port_result_ctrl.Location = new Point(11, 67);
         port_result_ctrl.Name = "port_result_ctrl";
         port_result_ctrl.Size = new Size(446, 87);
         port_result_ctrl.TabIndex = 3;
         port_result_ctrl.Text = "";
         // 
         // port_run_ctrl
         // 
         port_run_ctrl.Location = new Point(169, 22);
         port_run_ctrl.Name = "port_run_ctrl";
         port_run_ctrl.Size = new Size(100, 39);
         port_run_ctrl.TabIndex = 2;
         port_run_ctrl.Text = "Połącz";
         port_run_ctrl.UseVisualStyleBackColor = true;
         port_run_ctrl.Click += port_run_ctrl_Click;
         // 
         // port_ip_ctrl
         // 
         port_ip_ctrl.Location = new Point(11, 38);
         port_ip_ctrl.Name = "port_ip_ctrl";
         port_ip_ctrl.Size = new Size(100, 23);
         port_ip_ctrl.TabIndex = 1;
         port_ip_ctrl.Text = "127.0.0.1";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(11, 20);
         label2.Name = "label2";
         label2.Size = new Size(53, 15);
         label2.TabIndex = 0;
         label2.Text = "Adres IP:";
         // 
         // groupBox3
         // 
         groupBox3.Controls.Add(showip_ctrl);
         groupBox3.Controls.Add(info_result_ctrl);
         groupBox3.Location = new Point(12, 377);
         groupBox3.Name = "groupBox3";
         groupBox3.Size = new Size(463, 118);
         groupBox3.TabIndex = 2;
         groupBox3.TabStop = false;
         groupBox3.Text = "Informacje";
         // 
         // showip_ctrl
         // 
         showip_ctrl.Location = new Point(11, 22);
         showip_ctrl.Name = "showip_ctrl";
         showip_ctrl.Size = new Size(100, 39);
         showip_ctrl.TabIndex = 1;
         showip_ctrl.Text = "Pokaż IP komputera";
         showip_ctrl.UseVisualStyleBackColor = true;
         showip_ctrl.Click += showip_ctrl_Click;
         // 
         // info_result_ctrl
         // 
         info_result_ctrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
         info_result_ctrl.Location = new Point(117, 21);
         info_result_ctrl.Name = "info_result_ctrl";
         info_result_ctrl.Size = new Size(340, 85);
         info_result_ctrl.TabIndex = 0;
         info_result_ctrl.Text = "";
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(525, 533);
         Controls.Add(groupBox3);
         Controls.Add(groupBox2);
         Controls.Add(groupBox1);
         MaximumSize = new Size(541, 572);
         MinimumSize = new Size(541, 572);
         Name = "Form1";
         Text = "Net tester 1.00";
         groupBox1.ResumeLayout(false);
         groupBox1.PerformLayout();
         groupBox2.ResumeLayout(false);
         groupBox2.PerformLayout();
         groupBox3.ResumeLayout(false);
         ResumeLayout(false);
      }

      #endregion

      private GroupBox groupBox1;
      private GroupBox groupBox2;
      private Label label1;
      private RichTextBox ping_result_ctrl;
      private Button ping_run_ctrl;
      private TextBox ping_ip_ctrl;
      private TextBox port_port_ctrl;
      private Label label3;
      private RichTextBox port_result_ctrl;
      private Button port_run_ctrl;
      private TextBox port_ip_ctrl;
      private Label label2;
      private GroupBox groupBox3;
      private Button showip_ctrl;
      private RichTextBox info_result_ctrl;
   }
}
