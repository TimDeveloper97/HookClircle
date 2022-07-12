
namespace HookCircleWD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHookStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHookStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHookState = new System.Windows.Forms.Button();
            this.nRadius = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nRadius);
            this.groupBox1.Controls.Add(this.btnHookStop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnHookStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btnHookStop
            // 
            this.btnHookStop.Location = new System.Drawing.Point(45, 58);
            this.btnHookStop.Name = "btnHookStop";
            this.btnHookStop.Size = new System.Drawing.Size(148, 34);
            this.btnHookStop.TabIndex = 4;
            this.btnHookStop.Text = "button2";
            this.btnHookStop.UseVisualStyleBackColor = true;
            this.btnHookStop.Click += new System.EventHandler(this.btnHookStop_Click);
            this.btnHookStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnHookStop_KeyDown);
            this.btnHookStop.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnHookStop_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop:";
            // 
            // btnHookStart
            // 
            this.btnHookStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHookStart.Location = new System.Drawing.Point(45, 18);
            this.btnHookStart.Name = "btnHookStart";
            this.btnHookStart.Size = new System.Drawing.Size(148, 34);
            this.btnHookStart.TabIndex = 1;
            this.btnHookStart.Text = "button1";
            this.btnHookStart.UseVisualStyleBackColor = true;
            this.btnHookStart.Click += new System.EventHandler(this.btnHookStart_Click);
            this.btnHookStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnHookStart_KeyDown);
            this.btnHookStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnHookStart_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHookState);
            this.groupBox2.Location = new System.Drawing.Point(217, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "State";
            // 
            // btnHookState
            // 
            this.btnHookState.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHookState.Location = new System.Drawing.Point(6, 18);
            this.btnHookState.Name = "btnHookState";
            this.btnHookState.Size = new System.Drawing.Size(190, 100);
            this.btnHookState.TabIndex = 0;
            this.btnHookState.Text = "button3";
            this.btnHookState.UseVisualStyleBackColor = true;
            // 
            // nRadius
            // 
            this.nRadius.Location = new System.Drawing.Point(68, 103);
            this.nRadius.Name = "nRadius";
            this.nRadius.Size = new System.Drawing.Size(125, 20);
            this.nRadius.TabIndex = 6;
            this.nRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nRadius.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radius:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 150);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nRadius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHookStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHookStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHookState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nRadius;
    }
}

