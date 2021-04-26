namespace GenericsExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.lstSehir = new DevExpress.XtraEditors.ListBoxControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lstSehir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnList.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnList.Appearance.Options.UseBackColor = true;
            this.btnList.Appearance.Options.UseFont = true;
            this.btnList.Appearance.Options.UseForeColor = true;
            this.btnList.Location = new System.Drawing.Point(121, 375);
            this.btnList.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnList.Name = "btnList";
            this.btnList.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnList.Size = new System.Drawing.Size(217, 29);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lstSehir
            // 
            this.lstSehir.Location = new System.Drawing.Point(22, 49);
            this.lstSehir.Name = "lstSehir";
            this.lstSehir.Size = new System.Drawing.Size(409, 305);
            this.lstSehir.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(389, 7);
            this.btnExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExit.Size = new System.Drawing.Size(48, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 424);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstSehir);
            this.Controls.Add(this.btnList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Generics Example";
            ((System.ComponentModel.ISupportInitialize)(this.lstSehir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.ListBoxControl lstSehir;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}

