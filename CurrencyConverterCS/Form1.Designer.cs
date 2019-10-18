namespace CurrencyConverterCS
{
    partial class Form1
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
            this.xInput = new System.Windows.Forms.TextBox();
            this.xFrom = new System.Windows.Forms.ComboBox();
            this.xTo = new System.Windows.Forms.ComboBox();
            this.xConfirm = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.beforeResLbl = new System.Windows.Forms.Label();
            this.resLbl = new System.Windows.Forms.Label();
            this.toToFromLbl = new System.Windows.Forms.Label();
            this.fromToToLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.updateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(27, 63);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(105, 22);
            this.xInput.TabIndex = 0;
            // 
            // xFrom
            // 
            this.xFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xFrom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.xFrom.FormattingEnabled = true;
            this.xFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xFrom.Location = new System.Drawing.Point(210, 61);
            this.xFrom.Name = "xFrom";
            this.xFrom.Size = new System.Drawing.Size(130, 24);
            this.xFrom.TabIndex = 1;
            // 
            // xTo
            // 
            this.xTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xTo.FormattingEnabled = true;
            this.xTo.Location = new System.Drawing.Point(425, 61);
            this.xTo.Name = "xTo";
            this.xTo.Size = new System.Drawing.Size(130, 24);
            this.xTo.TabIndex = 2;
            // 
            // xConfirm
            // 
            this.xConfirm.Location = new System.Drawing.Point(587, 61);
            this.xConfirm.Name = "xConfirm";
            this.xConfirm.Size = new System.Drawing.Size(41, 24);
            this.xConfirm.TabIndex = 3;
            this.xConfirm.Text = ">";
            this.xConfirm.UseVisualStyleBackColor = true;
            this.xConfirm.Click += new System.EventHandler(this.XConfirm_Click);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(24, 43);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(56, 17);
            this.amountLbl.TabIndex = 4;
            this.amountLbl.Text = "Amount";
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(207, 41);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(40, 17);
            this.fromLbl.TabIndex = 5;
            this.fromLbl.Text = "From";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(422, 41);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(25, 17);
            this.toLbl.TabIndex = 6;
            this.toLbl.Text = "To";
            // 
            // beforeResLbl
            // 
            this.beforeResLbl.AutoSize = true;
            this.beforeResLbl.Location = new System.Drawing.Point(174, 140);
            this.beforeResLbl.Name = "beforeResLbl";
            this.beforeResLbl.Size = new System.Drawing.Size(0, 17);
            this.beforeResLbl.TabIndex = 7;
            // 
            // resLbl
            // 
            this.resLbl.AutoSize = true;
            this.resLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLbl.Location = new System.Drawing.Point(170, 182);
            this.resLbl.Name = "resLbl";
            this.resLbl.Size = new System.Drawing.Size(0, 39);
            this.resLbl.TabIndex = 8;
            // 
            // toToFromLbl
            // 
            this.toToFromLbl.AutoSize = true;
            this.toToFromLbl.Location = new System.Drawing.Point(174, 248);
            this.toToFromLbl.Name = "toToFromLbl";
            this.toToFromLbl.Size = new System.Drawing.Size(0, 17);
            this.toToFromLbl.TabIndex = 9;
            // 
            // fromToToLbl
            // 
            this.fromToToLbl.AutoSize = true;
            this.fromToToLbl.Location = new System.Drawing.Point(174, 295);
            this.fromToToLbl.Name = "fromToToLbl";
            this.fromToToLbl.Size = new System.Drawing.Size(0, 17);
            this.fromToToLbl.TabIndex = 10;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(536, 391);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 17);
            this.errorLbl.TabIndex = 11;
            // 
            // updateLbl
            // 
            this.updateLbl.AutoSize = true;
            this.updateLbl.Location = new System.Drawing.Point(24, 391);
            this.updateLbl.Name = "updateLbl";
            this.updateLbl.Size = new System.Drawing.Size(0, 17);
            this.updateLbl.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(724, 451);
            this.Controls.Add(this.updateLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.fromToToLbl);
            this.Controls.Add(this.toToFromLbl);
            this.Controls.Add(this.resLbl);
            this.Controls.Add(this.beforeResLbl);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.fromLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.xConfirm);
            this.Controls.Add(this.xTo);
            this.Controls.Add(this.xFrom);
            this.Controls.Add(this.xInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.ComboBox xFrom;
        private System.Windows.Forms.ComboBox xTo;
        private System.Windows.Forms.Button xConfirm;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Label beforeResLbl;
        private System.Windows.Forms.Label resLbl;
        private System.Windows.Forms.Label toToFromLbl;
        private System.Windows.Forms.Label fromToToLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label updateLbl;
    }
}

