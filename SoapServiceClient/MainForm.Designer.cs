namespace SoapServiceClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCallFibonacci = new System.Windows.Forms.Button();
            this.LblResponse = new System.Windows.Forms.Label();
            this.TxtResponse = new System.Windows.Forms.TextBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.LblResponseJson = new System.Windows.Forms.Label();
            this.TxtResponseJson = new System.Windows.Forms.TextBox();
            this.LblParamXml = new System.Windows.Forms.Label();
            this.TxtParamXml = new System.Windows.Forms.TextBox();
            this.BtnCallXmlToJson = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.RtbJson = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCallFibonacci
            // 
            this.btnCallFibonacci.Location = new System.Drawing.Point(540, 27);
            this.btnCallFibonacci.Name = "btnCallFibonacci";
            this.btnCallFibonacci.Size = new System.Drawing.Size(148, 48);
            this.btnCallFibonacci.TabIndex = 0;
            this.btnCallFibonacci.Text = "Call Fibonacci Method";
            this.btnCallFibonacci.UseVisualStyleBackColor = true;
            this.btnCallFibonacci.Click += new System.EventHandler(this.BtnCallFibonacci_Click);
            // 
            // LblResponse
            // 
            this.LblResponse.AutoSize = true;
            this.LblResponse.Location = new System.Drawing.Point(46, 86);
            this.LblResponse.Name = "LblResponse";
            this.LblResponse.Size = new System.Drawing.Size(84, 17);
            this.LblResponse.TabIndex = 4;
            this.LblResponse.Text = "Response : ";
            // 
            // TxtResponse
            // 
            this.TxtResponse.Location = new System.Drawing.Point(46, 112);
            this.TxtResponse.Multiline = true;
            this.TxtResponse.Name = "TxtResponse";
            this.TxtResponse.ReadOnly = true;
            this.TxtResponse.Size = new System.Drawing.Size(467, 134);
            this.TxtResponse.TabIndex = 3;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(46, 27);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(82, 17);
            this.lblParam.TabIndex = 2;
            this.lblParam.Text = "Parameter :";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(46, 53);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(467, 22);
            this.txtParam.TabIndex = 1;
            // 
            // LblResponseJson
            // 
            this.LblResponseJson.AutoSize = true;
            this.LblResponseJson.Location = new System.Drawing.Point(81, 235);
            this.LblResponseJson.Name = "LblResponseJson";
            this.LblResponseJson.Size = new System.Drawing.Size(84, 17);
            this.LblResponseJson.TabIndex = 4;
            this.LblResponseJson.Text = "Response : ";
            // 
            // TxtResponseJson
            // 
            this.TxtResponseJson.Location = new System.Drawing.Point(81, 261);
            this.TxtResponseJson.Multiline = true;
            this.TxtResponseJson.Name = "TxtResponseJson";
            this.TxtResponseJson.ReadOnly = true;
            this.TxtResponseJson.Size = new System.Drawing.Size(467, 196);
            this.TxtResponseJson.TabIndex = 3;
            // 
            // LblParamXml
            // 
            this.LblParamXml.AutoSize = true;
            this.LblParamXml.Location = new System.Drawing.Point(81, 21);
            this.LblParamXml.Name = "LblParamXml";
            this.LblParamXml.Size = new System.Drawing.Size(82, 17);
            this.LblParamXml.TabIndex = 2;
            this.LblParamXml.Text = "Parameter :";
            // 
            // TxtParamXml
            // 
            this.TxtParamXml.Location = new System.Drawing.Point(81, 47);
            this.TxtParamXml.Multiline = true;
            this.TxtParamXml.Name = "TxtParamXml";
            this.TxtParamXml.Size = new System.Drawing.Size(467, 176);
            this.TxtParamXml.TabIndex = 1;
            // 
            // BtnCallXmlToJson
            // 
            this.BtnCallXmlToJson.Location = new System.Drawing.Point(574, 21);
            this.BtnCallXmlToJson.Name = "BtnCallXmlToJson";
            this.BtnCallXmlToJson.Size = new System.Drawing.Size(148, 48);
            this.BtnCallXmlToJson.TabIndex = 0;
            this.BtnCallXmlToJson.Text = "Call XmlToJson Method";
            this.BtnCallXmlToJson.UseVisualStyleBackColor = true;
            this.BtnCallXmlToJson.Click += new System.EventHandler(this.BtnCallXmlToJson_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 759);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblResponse);
            this.tabPage1.Controls.Add(this.TxtResponse);
            this.tabPage1.Controls.Add(this.btnCallFibonacci);
            this.tabPage1.Controls.Add(this.lblParam);
            this.tabPage1.Controls.Add(this.txtParam);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 730);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fibonacci Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RtbJson);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.LblResponseJson);
            this.tabPage2.Controls.Add(this.TxtResponseJson);
            this.tabPage2.Controls.Add(this.BtnCallXmlToJson);
            this.tabPage2.Controls.Add(this.LblParamXml);
            this.tabPage2.Controls.Add(this.TxtParamXml);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 730);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XmlToJson Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "formatedJson :";
            // 
            // RtbJson
            // 
            this.RtbJson.Location = new System.Drawing.Point(84, 491);
            this.RtbJson.Name = "RtbJson";
            this.RtbJson.Size = new System.Drawing.Size(464, 213);
            this.RtbJson.TabIndex = 7;
            this.RtbJson.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 759);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallFibonacci;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label LblResponse;
        private System.Windows.Forms.TextBox TxtResponse;
        private System.Windows.Forms.Label LblResponseJson;
        private System.Windows.Forms.TextBox TxtResponseJson;
        private System.Windows.Forms.Label LblParamXml;
        private System.Windows.Forms.TextBox TxtParamXml;
        private System.Windows.Forms.Button BtnCallXmlToJson;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtbJson;
    }
}