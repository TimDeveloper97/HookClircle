
namespace HookClircle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHookStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHookStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHookState = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnHookStop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHookStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // nInterval
            // 
            this.nInterval.Location = new System.Drawing.Point(56, 117);
            this.nInterval.Name = "nInterval";
            this.nInterval.Size = new System.Drawing.Size(129, 23);
            this.nInterval.TabIndex = 5;
            this.nInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interval:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stop:";
            // 
            // btnHookStop
            // 
            this.btnHookStop.Location = new System.Drawing.Point(56, 66);
            this.btnHookStop.Name = "btnHookStop";
            this.btnHookStop.Size = new System.Drawing.Size(129, 38);
            this.btnHookStop.TabIndex = 2;
            this.btnHookStop.Text = "button2";
            this.btnHookStop.UseVisualStyleBackColor = true;
            this.btnHookStop.Click += new System.EventHandler(this.btnHookStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start:";
            // 
            // btnHookStart
            // 
            this.btnHookStart.Location = new System.Drawing.Point(56, 22);
            this.btnHookStart.Name = "btnHookStart";
            this.btnHookStart.Size = new System.Drawing.Size(129, 38);
            this.btnHookStart.TabIndex = 0;
            this.btnHookStart.Text = "button1";
            this.btnHookStart.UseVisualStyleBackColor = true;
            this.btnHookStart.Click += new System.EventHandler(this.btnHookStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHookState);
            this.groupBox2.Location = new System.Drawing.Point(209, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "State";
            // 
            // btnHookState
            // 
            this.btnHookState.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHookState.Location = new System.Drawing.Point(18, 22);
            this.btnHookState.Name = "btnHookState";
            this.btnHookState.Size = new System.Drawing.Size(187, 118);
            this.btnHookState.TabIndex = 1;
            this.btnHookState.Text = "button3";
            this.btnHookState.UseVisualStyleBackColor = true;
            this.btnHookState.Click += new System.EventHandler(this.btnHookState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 174);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHookStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHookStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHookState;
        private System.Windows.Forms.NumericUpDown nInterval;
        private System.Windows.Forms.Label label3;
    }
}

