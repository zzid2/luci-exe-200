﻿namespace RevokeMsgPatcher
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblPathTag = new System.Windows.Forms.Label();
            this.btnPatch = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblUpdatePachJson = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionTag = new System.Windows.Forms.Label();
            this.rbtWechat = new System.Windows.Forms.RadioButton();
            this.rbtQQ = new System.Windows.Forms.RadioButton();
            this.rbtTIM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtQQLite = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.高级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.特征码防撤回强制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.手动输入补丁信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通用微信多开工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支持版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.常见问题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.防撤回原理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完整文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelNotice = new System.Windows.Forms.Panel();
            this.labelNotice = new System.Windows.Forms.Label();
            this.rbtQQNT = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panelNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPathTag
            // 
            this.lblPathTag.AutoSize = true;
            this.lblPathTag.Location = new System.Drawing.Point(14, 63);
            this.lblPathTag.Name = "lblPathTag";
            this.lblPathTag.Size = new System.Drawing.Size(65, 12);
            this.lblPathTag.TabIndex = 1;
            this.lblPathTag.Text = "应用路径：";
            // 
            // btnPatch
            // 
            this.btnPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatch.Location = new System.Drawing.Point(378, 108);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(98, 23);
            this.btnPatch.TabIndex = 3;
            this.btnPatch.Text = "安装补丁！";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(84, 58);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(352, 21);
            this.txtPath.TabIndex = 4;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoosePath.Location = new System.Drawing.Point(442, 56);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(34, 23);
            this.btnChoosePath.TabIndex = 5;
            this.btnChoosePath.Text = "...";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "软件主页(免费开源)：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(138, 139);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(290, 108);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(82, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "备份还原";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblUpdatePachJson
            // 
            this.lblUpdatePachJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdatePachJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpdatePachJson.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUpdatePachJson.Location = new System.Drawing.Point(177, 141);
            this.lblUpdatePachJson.Name = "lblUpdatePachJson";
            this.lblUpdatePachJson.Size = new System.Drawing.Size(299, 12);
            this.lblUpdatePachJson.TabIndex = 9;
            this.lblUpdatePachJson.Text = "[ 获取最新补丁信息中... ]";
            this.lblUpdatePachJson.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUpdatePachJson.Click += new System.EventHandler(this.lblUpdatePachJson_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(85, 113);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 12);
            this.lblVersion.TabIndex = 10;
            // 
            // lblVersionTag
            // 
            this.lblVersionTag.AutoSize = true;
            this.lblVersionTag.Location = new System.Drawing.Point(14, 113);
            this.lblVersionTag.Name = "lblVersionTag";
            this.lblVersionTag.Size = new System.Drawing.Size(65, 12);
            this.lblVersionTag.TabIndex = 9;
            this.lblVersionTag.Text = "当前版本：";
            // 
            // rbtWechat
            // 
            this.rbtWechat.AutoSize = true;
            this.rbtWechat.Checked = true;
            this.rbtWechat.Location = new System.Drawing.Point(84, 36);
            this.rbtWechat.Name = "rbtWechat";
            this.rbtWechat.Size = new System.Drawing.Size(47, 16);
            this.rbtWechat.TabIndex = 12;
            this.rbtWechat.TabStop = true;
            this.rbtWechat.Text = "微信";
            this.rbtWechat.UseVisualStyleBackColor = true;
            this.rbtWechat.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rbtQQ
            // 
            this.rbtQQ.AutoSize = true;
            this.rbtQQ.Location = new System.Drawing.Point(190, 36);
            this.rbtQQ.Name = "rbtQQ";
            this.rbtQQ.Size = new System.Drawing.Size(35, 16);
            this.rbtQQ.TabIndex = 13;
            this.rbtQQ.Text = "QQ";
            this.rbtQQ.UseVisualStyleBackColor = true;
            this.rbtQQ.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rbtTIM
            // 
            this.rbtTIM.AutoSize = true;
            this.rbtTIM.Location = new System.Drawing.Point(236, 36);
            this.rbtTIM.Name = "rbtTIM";
            this.rbtTIM.Size = new System.Drawing.Size(41, 16);
            this.rbtTIM.TabIndex = 14;
            this.rbtTIM.Text = "TIM";
            this.rbtTIM.UseVisualStyleBackColor = true;
            this.rbtTIM.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "选择应用：";
            // 
            // rbtQQLite
            // 
            this.rbtQQLite.AutoSize = true;
            this.rbtQQLite.Location = new System.Drawing.Point(285, 36);
            this.rbtQQLite.Name = "rbtQQLite";
            this.rbtQQLite.Size = new System.Drawing.Size(71, 16);
            this.rbtQQLite.TabIndex = 18;
            this.rbtQQLite.Text = "QQ轻聊版";
            this.rbtQQLite.UseVisualStyleBackColor = true;
            this.rbtQQLite.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.高级ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 高级ToolStripMenuItem
            // 
            this.高级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.特征码防撤回强制ToolStripMenuItem,
            this.手动输入补丁信息ToolStripMenuItem,
            this.通用微信多开工具ToolStripMenuItem});
            this.高级ToolStripMenuItem.Name = "高级ToolStripMenuItem";
            this.高级ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.高级ToolStripMenuItem.Text = "高级";
            // 
            // 特征码防撤回强制ToolStripMenuItem
            // 
            this.特征码防撤回强制ToolStripMenuItem.Name = "特征码防撤回强制ToolStripMenuItem";
            this.特征码防撤回强制ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.特征码防撤回强制ToolStripMenuItem.Text = "特征码防撤回（强制）";
            this.特征码防撤回强制ToolStripMenuItem.Visible = false;
            this.特征码防撤回强制ToolStripMenuItem.Click += new System.EventHandler(this.特征码防撤回强制ToolStripMenuItem_Click);
            // 
            // 手动输入补丁信息ToolStripMenuItem
            // 
            this.手动输入补丁信息ToolStripMenuItem.Name = "手动输入补丁信息ToolStripMenuItem";
            this.手动输入补丁信息ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.手动输入补丁信息ToolStripMenuItem.Text = "手动输入补丁信息";
            this.手动输入补丁信息ToolStripMenuItem.Visible = false;
            this.手动输入补丁信息ToolStripMenuItem.Click += new System.EventHandler(this.手动输入补丁信息ToolStripMenuItem_Click);
            // 
            // 通用微信多开工具ToolStripMenuItem
            // 
            this.通用微信多开工具ToolStripMenuItem.Name = "通用微信多开工具ToolStripMenuItem";
            this.通用微信多开工具ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.通用微信多开工具ToolStripMenuItem.Text = "通用微信多开工具";
            this.通用微信多开工具ToolStripMenuItem.Click += new System.EventHandler(this.通用微信多开工具ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.支持版本ToolStripMenuItem,
            this.常见问题ToolStripMenuItem,
            this.防撤回原理ToolStripMenuItem,
            this.完整文档ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 支持版本ToolStripMenuItem
            // 
            this.支持版本ToolStripMenuItem.Name = "支持版本ToolStripMenuItem";
            this.支持版本ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.支持版本ToolStripMenuItem.Text = "支持版本";
            this.支持版本ToolStripMenuItem.Click += new System.EventHandler(this.支持版本ToolStripMenuItem_Click);
            // 
            // 常见问题ToolStripMenuItem
            // 
            this.常见问题ToolStripMenuItem.Name = "常见问题ToolStripMenuItem";
            this.常见问题ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.常见问题ToolStripMenuItem.Text = "常见问题";
            this.常见问题ToolStripMenuItem.Click += new System.EventHandler(this.常见问题ToolStripMenuItem_Click);
            // 
            // 防撤回原理ToolStripMenuItem
            // 
            this.防撤回原理ToolStripMenuItem.Name = "防撤回原理ToolStripMenuItem";
            this.防撤回原理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.防撤回原理ToolStripMenuItem.Text = "防撤回原理";
            this.防撤回原理ToolStripMenuItem.Click += new System.EventHandler(this.防撤回原理ToolStripMenuItem_Click);
            // 
            // 完整文档ToolStripMenuItem
            // 
            this.完整文档ToolStripMenuItem.Name = "完整文档ToolStripMenuItem";
            this.完整文档ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.完整文档ToolStripMenuItem.Text = "完整文档";
            this.完整文档ToolStripMenuItem.Click += new System.EventHandler(this.完整文档ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者ToolStripMenuItem,
            this.主页ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 作者ToolStripMenuItem
            // 
            this.作者ToolStripMenuItem.Name = "作者ToolStripMenuItem";
            this.作者ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.作者ToolStripMenuItem.Text = "关于";
            this.作者ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.主页ToolStripMenuItem.Text = "软件主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 89);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 12);
            this.lblCategory.TabIndex = 20;
            this.lblCategory.Text = "可选功能：";
            // 
            // panelCategories
            // 
            this.panelCategories.AutoSize = true;
            this.panelCategories.Location = new System.Drawing.Point(83, 85);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(393, 18);
            this.panelCategories.TabIndex = 22;
            // 
            // panelNotice
            // 
            this.panelNotice.BackColor = System.Drawing.SystemColors.Info;
            this.panelNotice.Controls.Add(this.labelNotice);
            this.panelNotice.Location = new System.Drawing.Point(16, 173);
            this.panelNotice.Margin = new System.Windows.Forms.Padding(2);
            this.panelNotice.Name = "panelNotice";
            this.panelNotice.Size = new System.Drawing.Size(460, 0);
            this.panelNotice.TabIndex = 23;
            // 
            // labelNotice
            // 
            this.labelNotice.BackColor = System.Drawing.Color.Transparent;
            this.labelNotice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNotice.Location = new System.Drawing.Point(11, 7);
            this.labelNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(441, 0);
            this.labelNotice.TabIndex = 0;
            this.labelNotice.Text = "测试测试测试测试";
            // 
            // rbtQQNT
            // 
            this.rbtQQNT.AutoSize = true;
            this.rbtQQNT.Location = new System.Drawing.Point(135, 36);
            this.rbtQQNT.Name = "rbtQQNT";
            this.rbtQQNT.Size = new System.Drawing.Size(47, 16);
            this.rbtQQNT.TabIndex = 24;
            this.rbtQQNT.Text = "QQNT";
            this.rbtQQNT.UseVisualStyleBackColor = true;
            this.rbtQQNT.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 169);
            this.Controls.Add(this.rbtQQNT);
            this.Controls.Add(this.panelNotice);
            this.Controls.Add(this.panelCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.rbtQQLite);
            this.Controls.Add(this.lblUpdatePachJson);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblVersionTag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.rbtTIM);
            this.Controls.Add(this.lblPathTag);
            this.Controls.Add(this.rbtQQ);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.rbtWechat);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(504, 144);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微信/QQ/TIM防撤回补丁";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelNotice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPathTag;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblUpdatePachJson;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersionTag;
        private System.Windows.Forms.RadioButton rbtWechat;
        private System.Windows.Forms.RadioButton rbtQQ;
        private System.Windows.Forms.RadioButton rbtTIM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtQQLite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 高级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支持版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 常见问题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 防撤回原理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完整文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手动输入补丁信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 特征码防撤回强制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通用微信多开工具ToolStripMenuItem;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.FlowLayoutPanel panelCategories;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelNotice;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.RadioButton rbtQQNT;
    }
}

