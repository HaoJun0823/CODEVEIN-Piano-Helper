﻿namespace CODEVEINPianoHelper
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.TableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.FlowLayoutPanel_ButtonGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.TableLayoutPanel_Controller = new System.Windows.Forms.TableLayoutPanel();
            this.RichTextBox_MusicScore = new System.Windows.Forms.RichTextBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Label_StartDelay = new System.Windows.Forms.Label();
            this.NumericUpDown_Delay = new System.Windows.Forms.NumericUpDown();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.Button_Help = new System.Windows.Forms.Button();
            this.Button_About = new System.Windows.Forms.Button();
            this.Button_Score = new System.Windows.Forms.Button();
            this.Label_Editor = new System.Windows.Forms.Label();
            this.Label_EditorTime = new System.Windows.Forms.Label();
            this.FlowLayoutPanel_EditorTime = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_SwitchXbox = new System.Windows.Forms.Button();
            this.FlowLayoutPanel_EditorKey = new System.Windows.Forms.FlowLayoutPanel();
            this.TableLayoutPanel_Main.SuspendLayout();
            this.TableLayoutPanel_Controller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.ColumnCount = 2;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutPanel_Main.Controls.Add(this.RichTextBox_Log, 0, 1);
            this.TableLayoutPanel_Main.Controls.Add(this.FlowLayoutPanel_ButtonGroup, 0, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.TableLayoutPanel_Controller, 1, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_Editor, 1, 2);
            this.TableLayoutPanel_Main.Controls.Add(this.Label_EditorTime, 0, 2);
            this.TableLayoutPanel_Main.Controls.Add(this.FlowLayoutPanel_EditorTime, 0, 3);
            this.TableLayoutPanel_Main.Controls.Add(this.FlowLayoutPanel_EditorKey, 1, 3);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 4;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(1008, 729);
            this.TableLayoutPanel_Main.TabIndex = 0;
            // 
            // RichTextBox_Log
            // 
            this.RichTextBox_Log.BackColor = System.Drawing.SystemColors.Window;
            this.TableLayoutPanel_Main.SetColumnSpan(this.RichTextBox_Log, 2);
            this.RichTextBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_Log.Location = new System.Drawing.Point(3, 367);
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            this.RichTextBox_Log.ReadOnly = true;
            this.RichTextBox_Log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBox_Log.Size = new System.Drawing.Size(1002, 212);
            this.RichTextBox_Log.TabIndex = 1;
            this.RichTextBox_Log.Text = "";
            this.RichTextBox_Log.TextChanged += new System.EventHandler(this.RichTextBox_Log_TextChanged);
            // 
            // FlowLayoutPanel_ButtonGroup
            // 
            this.FlowLayoutPanel_ButtonGroup.AutoScroll = true;
            this.FlowLayoutPanel_ButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_ButtonGroup.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutPanel_ButtonGroup.Name = "FlowLayoutPanel_ButtonGroup";
            this.FlowLayoutPanel_ButtonGroup.Size = new System.Drawing.Size(296, 358);
            this.FlowLayoutPanel_ButtonGroup.TabIndex = 0;
            // 
            // TableLayoutPanel_Controller
            // 
            this.TableLayoutPanel_Controller.ColumnCount = 4;
            this.TableLayoutPanel_Controller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_Controller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_Controller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_Controller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_Controller.Controls.Add(this.RichTextBox_MusicScore, 0, 1);
            this.TableLayoutPanel_Controller.Controls.Add(this.Button_Start, 0, 0);
            this.TableLayoutPanel_Controller.Controls.Add(this.Label_StartDelay, 2, 0);
            this.TableLayoutPanel_Controller.Controls.Add(this.NumericUpDown_Delay, 3, 0);
            this.TableLayoutPanel_Controller.Controls.Add(this.Button_Stop, 1, 0);
            this.TableLayoutPanel_Controller.Controls.Add(this.Button_Help, 0, 2);
            this.TableLayoutPanel_Controller.Controls.Add(this.Button_About, 1, 2);
            this.TableLayoutPanel_Controller.Controls.Add(this.Button_Score, 2, 2);
            this.TableLayoutPanel_Controller.Controls.Add(this.Button_SwitchXbox, 3, 2);
            this.TableLayoutPanel_Controller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_Controller.Location = new System.Drawing.Point(305, 3);
            this.TableLayoutPanel_Controller.Name = "TableLayoutPanel_Controller";
            this.TableLayoutPanel_Controller.RowCount = 3;
            this.TableLayoutPanel_Controller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel_Controller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel_Controller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel_Controller.Size = new System.Drawing.Size(700, 358);
            this.TableLayoutPanel_Controller.TabIndex = 2;
            // 
            // RichTextBox_MusicScore
            // 
            this.RichTextBox_MusicScore.BackColor = System.Drawing.SystemColors.Window;
            this.TableLayoutPanel_Controller.SetColumnSpan(this.RichTextBox_MusicScore, 4);
            this.RichTextBox_MusicScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_MusicScore.Location = new System.Drawing.Point(3, 74);
            this.RichTextBox_MusicScore.Name = "RichTextBox_MusicScore";
            this.RichTextBox_MusicScore.Size = new System.Drawing.Size(694, 208);
            this.RichTextBox_MusicScore.TabIndex = 0;
            this.RichTextBox_MusicScore.Text = resources.GetString("RichTextBox_MusicScore.Text");
            // 
            // Button_Start
            // 
            this.Button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Start.Location = new System.Drawing.Point(3, 3);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(169, 65);
            this.Button_Start.TabIndex = 1;
            this.Button_Start.Text = "Start Score!";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Label_StartDelay
            // 
            this.Label_StartDelay.AutoSize = true;
            this.Label_StartDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_StartDelay.Location = new System.Drawing.Point(353, 0);
            this.Label_StartDelay.Name = "Label_StartDelay";
            this.Label_StartDelay.Size = new System.Drawing.Size(169, 71);
            this.Label_StartDelay.TabIndex = 2;
            this.Label_StartDelay.Text = "Sensitivity(ms):";
            this.Label_StartDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericUpDown_Delay
            // 
            this.NumericUpDown_Delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUpDown_Delay.AutoSize = true;
            this.NumericUpDown_Delay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumericUpDown_Delay.Location = new System.Drawing.Point(528, 25);
            this.NumericUpDown_Delay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericUpDown_Delay.Name = "NumericUpDown_Delay";
            this.NumericUpDown_Delay.Size = new System.Drawing.Size(169, 21);
            this.NumericUpDown_Delay.TabIndex = 3;
            this.NumericUpDown_Delay.ValueChanged += new System.EventHandler(this.NumericUpDown_Delay_ValueChanged);
            // 
            // Button_Stop
            // 
            this.Button_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Stop.Location = new System.Drawing.Point(178, 3);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(169, 65);
            this.Button_Stop.TabIndex = 4;
            this.Button_Stop.Text = "Stop Score!";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Button_Help
            // 
            this.Button_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Help.Location = new System.Drawing.Point(3, 288);
            this.Button_Help.Name = "Button_Help";
            this.Button_Help.Size = new System.Drawing.Size(169, 67);
            this.Button_Help.TabIndex = 5;
            this.Button_Help.Text = "Help";
            this.Button_Help.UseVisualStyleBackColor = true;
            this.Button_Help.Click += new System.EventHandler(this.Button_Help_Click);
            // 
            // Button_About
            // 
            this.Button_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_About.Location = new System.Drawing.Point(178, 288);
            this.Button_About.Name = "Button_About";
            this.Button_About.Size = new System.Drawing.Size(169, 67);
            this.Button_About.TabIndex = 6;
            this.Button_About.Text = "About";
            this.Button_About.UseVisualStyleBackColor = true;
            this.Button_About.Click += new System.EventHandler(this.Button_About_Click);
            // 
            // Button_Score
            // 
            this.Button_Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Score.Location = new System.Drawing.Point(353, 288);
            this.Button_Score.Name = "Button_Score";
            this.Button_Score.Size = new System.Drawing.Size(169, 67);
            this.Button_Score.TabIndex = 7;
            this.Button_Score.Text = "Open Score Script Website";
            this.Button_Score.UseVisualStyleBackColor = true;
            this.Button_Score.Click += new System.EventHandler(this.Button_Score_Click);
            // 
            // Label_Editor
            // 
            this.Label_Editor.AutoSize = true;
            this.Label_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Editor.Location = new System.Drawing.Point(305, 582);
            this.Label_Editor.Name = "Label_Editor";
            this.Label_Editor.Size = new System.Drawing.Size(700, 18);
            this.Label_Editor.TabIndex = 3;
            this.Label_Editor.Text = "Script editing helper (musical note)";
            this.Label_Editor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_EditorTime
            // 
            this.Label_EditorTime.AutoSize = true;
            this.Label_EditorTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_EditorTime.Location = new System.Drawing.Point(3, 582);
            this.Label_EditorTime.Name = "Label_EditorTime";
            this.Label_EditorTime.Size = new System.Drawing.Size(296, 18);
            this.Label_EditorTime.TabIndex = 4;
            this.Label_EditorTime.Text = "Script editing helper (time delay)";
            this.Label_EditorTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowLayoutPanel_EditorTime
            // 
            this.FlowLayoutPanel_EditorTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_EditorTime.Location = new System.Drawing.Point(3, 603);
            this.FlowLayoutPanel_EditorTime.Name = "FlowLayoutPanel_EditorTime";
            this.FlowLayoutPanel_EditorTime.Size = new System.Drawing.Size(296, 123);
            this.FlowLayoutPanel_EditorTime.TabIndex = 5;
            // 
            // Button_SwitchXbox
            // 
            this.Button_SwitchXbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SwitchXbox.Location = new System.Drawing.Point(528, 288);
            this.Button_SwitchXbox.Name = "Button_SwitchXbox";
            this.Button_SwitchXbox.Size = new System.Drawing.Size(169, 67);
            this.Button_SwitchXbox.TabIndex = 8;
            this.Button_SwitchXbox.Text = "Line Feed";
            this.Button_SwitchXbox.UseVisualStyleBackColor = true;
            this.Button_SwitchXbox.Click += new System.EventHandler(this.Button_SwitchXbox_Click);
            // 
            // FlowLayoutPanel_EditorKey
            // 
            this.FlowLayoutPanel_EditorKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_EditorKey.Location = new System.Drawing.Point(305, 603);
            this.FlowLayoutPanel_EditorKey.Name = "FlowLayoutPanel_EditorKey";
            this.FlowLayoutPanel_EditorKey.Size = new System.Drawing.Size(700, 123);
            this.FlowLayoutPanel_EditorKey.TabIndex = 6;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "CODEVEIN Piano Helper By HaoJun0823";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.TableLayoutPanel_Main.ResumeLayout(false);
            this.TableLayoutPanel_Main.PerformLayout();
            this.TableLayoutPanel_Controller.ResumeLayout(false);
            this.TableLayoutPanel_Controller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Delay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Main;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_ButtonGroup;
        private System.Windows.Forms.RichTextBox RichTextBox_Log;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Controller;
        private System.Windows.Forms.RichTextBox RichTextBox_MusicScore;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label Label_StartDelay;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Delay;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Button Button_Help;
        private System.Windows.Forms.Button Button_About;
        private System.Windows.Forms.Button Button_Score;
        private System.Windows.Forms.Label Label_Editor;
        private System.Windows.Forms.Label Label_EditorTime;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_EditorTime;
        private System.Windows.Forms.Button Button_SwitchXbox;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_EditorKey;
    }
}

