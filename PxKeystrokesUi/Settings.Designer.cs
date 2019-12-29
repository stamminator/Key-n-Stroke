﻿namespace PxKeystrokesUi
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.button_backcolor = new System.Windows.Forms.Button();
            this.button_textcolor = new System.Windows.Forms.Button();
            this.slider_opacity = new System.Windows.Forms.TrackBar();
            this.label_opacity = new System.Windows.Forms.Label();
            this.label_fontsize = new System.Windows.Forms.Label();
            this.slider_fontsize = new System.Windows.Forms.TrackBar();
            this.rb_align_left = new System.Windows.Forms.RadioButton();
            this.rb_align_center = new System.Windows.Forms.RadioButton();
            this.rb_align_right = new System.Windows.Forms.RadioButton();
            this.groupBox_text_alignment = new System.Windows.Forms.GroupBox();
            this.gb_textdir = new System.Windows.Forms.GroupBox();
            this.rb_td_up = new System.Windows.Forms.RadioButton();
            this.rb_td_down = new System.Windows.Forms.RadioButton();
            this.gb_style = new System.Windows.Forms.GroupBox();
            this.rb_style_slide = new System.Windows.Forms.RadioButton();
            this.rb_style_noani = new System.Windows.Forms.RadioButton();
            this.gb_text = new System.Windows.Forms.GroupBox();
            this.cb_hideWindow = new System.Windows.Forms.CheckBox();
            this.cb_backspace = new System.Windows.Forms.CheckBox();
            this.label_timeout_display = new System.Windows.Forms.Label();
            this.cb_enableHistoryTimeout = new System.Windows.Forms.CheckBox();
            this.slider_history_timeout = new System.Windows.Forms.TrackBar();
            this.label_history_timeout = new System.Windows.Forms.Label();
            this.label_historycount = new System.Windows.Forms.Label();
            this.label_verticalDistance = new System.Windows.Forms.Label();
            this.nud_historycount = new System.Windows.Forms.NumericUpDown();
            this.nud_verticalDistance = new System.Windows.Forms.NumericUpDown();
            this.button_textfont = new System.Windows.Forms.Button();
            this.gb_background = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picker_textcolor = new System.Windows.Forms.ColorDialog();
            this.picker_backcolor = new System.Windows.Forms.ColorDialog();
            this.fontDialog_text = new System.Windows.Forms.FontDialog();
            this.bn_reset_position = new System.Windows.Forms.Button();
            this.bn_reset_all = new System.Windows.Forms.Button();
            this.gb_mouse = new System.Windows.Forms.GroupBox();
            this.button_ci_color = new System.Windows.Forms.Button();
            this.label_ci_size = new System.Windows.Forms.Label();
            this.slider_ci_size = new System.Windows.Forms.TrackBar();
            this.slider_ci_opacity = new System.Windows.Forms.TrackBar();
            this.label_ci_opacity = new System.Windows.Forms.Label();
            this.cb_cursorindicator = new System.Windows.Forms.CheckBox();
            this.picker_ci_color = new System.Windows.Forms.ColorDialog();
            this.gb_buttonindicator = new System.Windows.Forms.GroupBox();
            this.cb_bi_history = new System.Windows.Forms.CheckBox();
            this.label_bi_size = new System.Windows.Forms.Label();
            this.rb_bi_icon = new System.Windows.Forms.RadioButton();
            this.rb_bi_disable = new System.Windows.Forms.RadioButton();
            this.label_bi_angle = new System.Windows.Forms.Label();
            this.slider_bi_angle = new System.Windows.Forms.TrackBar();
            this.slider_bi_distance = new System.Windows.Forms.TrackBar();
            this.label_bi_distance = new System.Windows.Forms.Label();
            this.slider_bi_size = new System.Windows.Forms.TrackBar();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slider_opacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_fontsize)).BeginInit();
            this.groupBox_text_alignment.SuspendLayout();
            this.gb_textdir.SuspendLayout();
            this.gb_style.SuspendLayout();
            this.gb_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_history_timeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_historycount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_verticalDistance)).BeginInit();
            this.gb_background.SuspendLayout();
            this.gb_mouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ci_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ci_opacity)).BeginInit();
            this.gb_buttonindicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_size)).BeginInit();
            this.SuspendLayout();
            // 
            // button_backcolor
            // 
            this.button_backcolor.Location = new System.Drawing.Point(11, 35);
            this.button_backcolor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_backcolor.Name = "button_backcolor";
            this.button_backcolor.Size = new System.Drawing.Size(314, 42);
            this.button_backcolor.TabIndex = 25;
            this.button_backcolor.Text = "Background color";
            this.button_backcolor.UseVisualStyleBackColor = true;
            this.button_backcolor.Click += new System.EventHandler(this.button_backcolor_Click);
            // 
            // button_textcolor
            // 
            this.button_textcolor.Location = new System.Drawing.Point(11, 35);
            this.button_textcolor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_textcolor.Name = "button_textcolor";
            this.button_textcolor.Size = new System.Drawing.Size(147, 42);
            this.button_textcolor.TabIndex = 24;
            this.button_textcolor.Text = "Text color";
            this.button_textcolor.UseVisualStyleBackColor = true;
            this.button_textcolor.Click += new System.EventHandler(this.button_textcolor_Click);
            // 
            // slider_opacity
            // 
            this.slider_opacity.Location = new System.Drawing.Point(125, 102);
            this.slider_opacity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slider_opacity.Maximum = 100;
            this.slider_opacity.Minimum = 10;
            this.slider_opacity.Name = "slider_opacity";
            this.slider_opacity.Size = new System.Drawing.Size(191, 80);
            this.slider_opacity.TabIndex = 17;
            this.slider_opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_opacity.Value = 80;
            this.slider_opacity.Scroll += new System.EventHandler(this.slider_opacity_Scroll);
            // 
            // label_opacity
            // 
            this.label_opacity.AutoSize = true;
            this.label_opacity.Location = new System.Drawing.Point(29, 102);
            this.label_opacity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_opacity.Name = "label_opacity";
            this.label_opacity.Size = new System.Drawing.Size(79, 25);
            this.label_opacity.TabIndex = 16;
            this.label_opacity.Text = "Opacity";
            // 
            // label_fontsize
            // 
            this.label_fontsize.AutoSize = true;
            this.label_fontsize.Location = new System.Drawing.Point(29, 107);
            this.label_fontsize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_fontsize.Name = "label_fontsize";
            this.label_fontsize.Size = new System.Drawing.Size(86, 25);
            this.label_fontsize.TabIndex = 15;
            this.label_fontsize.Text = "Fontsize";
            // 
            // slider_fontsize
            // 
            this.slider_fontsize.Location = new System.Drawing.Point(125, 102);
            this.slider_fontsize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slider_fontsize.Maximum = 3000;
            this.slider_fontsize.Minimum = 800;
            this.slider_fontsize.Name = "slider_fontsize";
            this.slider_fontsize.Size = new System.Drawing.Size(191, 80);
            this.slider_fontsize.TabIndex = 14;
            this.slider_fontsize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_fontsize.Value = 800;
            this.slider_fontsize.Scroll += new System.EventHandler(this.slider_fontsize_Scroll);
            // 
            // rb_align_left
            // 
            this.rb_align_left.AutoSize = true;
            this.rb_align_left.Location = new System.Drawing.Point(11, 35);
            this.rb_align_left.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_align_left.Name = "rb_align_left";
            this.rb_align_left.Size = new System.Drawing.Size(62, 29);
            this.rb_align_left.TabIndex = 26;
            this.rb_align_left.TabStop = true;
            this.rb_align_left.Text = "left";
            this.rb_align_left.UseVisualStyleBackColor = true;
            this.rb_align_left.CheckedChanged += new System.EventHandler(this.rb_align_left_CheckedChanged);
            // 
            // rb_align_center
            // 
            this.rb_align_center.AutoSize = true;
            this.rb_align_center.Location = new System.Drawing.Point(90, 78);
            this.rb_align_center.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_align_center.Name = "rb_align_center";
            this.rb_align_center.Size = new System.Drawing.Size(91, 29);
            this.rb_align_center.TabIndex = 27;
            this.rb_align_center.TabStop = true;
            this.rb_align_center.Text = "center";
            this.rb_align_center.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_align_center.UseVisualStyleBackColor = true;
            this.rb_align_center.CheckedChanged += new System.EventHandler(this.rb_align_center_CheckedChanged);
            // 
            // rb_align_right
            // 
            this.rb_align_right.AutoSize = true;
            this.rb_align_right.Location = new System.Drawing.Point(182, 120);
            this.rb_align_right.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_align_right.Name = "rb_align_right";
            this.rb_align_right.Size = new System.Drawing.Size(74, 29);
            this.rb_align_right.TabIndex = 28;
            this.rb_align_right.TabStop = true;
            this.rb_align_right.Text = "right";
            this.rb_align_right.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_align_right.UseVisualStyleBackColor = true;
            this.rb_align_right.CheckedChanged += new System.EventHandler(this.rb_align_right_CheckedChanged);
            // 
            // groupBox_text_alignment
            // 
            this.groupBox_text_alignment.Controls.Add(this.rb_align_left);
            this.groupBox_text_alignment.Controls.Add(this.rb_align_right);
            this.groupBox_text_alignment.Controls.Add(this.rb_align_center);
            this.groupBox_text_alignment.Location = new System.Drawing.Point(22, 22);
            this.groupBox_text_alignment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_text_alignment.Name = "groupBox_text_alignment";
            this.groupBox_text_alignment.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_text_alignment.Size = new System.Drawing.Size(275, 164);
            this.groupBox_text_alignment.TabIndex = 29;
            this.groupBox_text_alignment.TabStop = false;
            this.groupBox_text_alignment.Text = "Text Alignment";
            // 
            // gb_textdir
            // 
            this.gb_textdir.Controls.Add(this.rb_td_up);
            this.gb_textdir.Controls.Add(this.rb_td_down);
            this.gb_textdir.Location = new System.Drawing.Point(24, 199);
            this.gb_textdir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_textdir.Name = "gb_textdir";
            this.gb_textdir.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_textdir.Size = new System.Drawing.Size(273, 116);
            this.gb_textdir.TabIndex = 30;
            this.gb_textdir.TabStop = false;
            this.gb_textdir.Text = "Text Direction";
            // 
            // rb_td_up
            // 
            this.rb_td_up.AutoSize = true;
            this.rb_td_up.Location = new System.Drawing.Point(13, 72);
            this.rb_td_up.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_td_up.Name = "rb_td_up";
            this.rb_td_up.Size = new System.Drawing.Size(59, 29);
            this.rb_td_up.TabIndex = 1;
            this.rb_td_up.TabStop = true;
            this.rb_td_up.Text = "up";
            this.rb_td_up.UseVisualStyleBackColor = true;
            this.rb_td_up.CheckedChanged += new System.EventHandler(this.rb_td_up_CheckedChanged);
            // 
            // rb_td_down
            // 
            this.rb_td_down.AutoSize = true;
            this.rb_td_down.Location = new System.Drawing.Point(13, 30);
            this.rb_td_down.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_td_down.Name = "rb_td_down";
            this.rb_td_down.Size = new System.Drawing.Size(84, 29);
            this.rb_td_down.TabIndex = 0;
            this.rb_td_down.TabStop = true;
            this.rb_td_down.Text = "down";
            this.rb_td_down.UseVisualStyleBackColor = true;
            this.rb_td_down.CheckedChanged += new System.EventHandler(this.rb_td_down_CheckedChanged);
            // 
            // gb_style
            // 
            this.gb_style.Controls.Add(this.rb_style_slide);
            this.gb_style.Controls.Add(this.rb_style_noani);
            this.gb_style.Location = new System.Drawing.Point(22, 329);
            this.gb_style.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_style.Name = "gb_style";
            this.gb_style.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_style.Size = new System.Drawing.Size(275, 131);
            this.gb_style.TabIndex = 31;
            this.gb_style.TabStop = false;
            this.gb_style.Text = "Style";
            // 
            // rb_style_slide
            // 
            this.rb_style_slide.AutoSize = true;
            this.rb_style_slide.Location = new System.Drawing.Point(15, 78);
            this.rb_style_slide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_style_slide.Name = "rb_style_slide";
            this.rb_style_slide.Size = new System.Drawing.Size(77, 29);
            this.rb_style_slide.TabIndex = 3;
            this.rb_style_slide.TabStop = true;
            this.rb_style_slide.Text = "slide";
            this.rb_style_slide.UseVisualStyleBackColor = true;
            this.rb_style_slide.CheckedChanged += new System.EventHandler(this.rb_style_slide_CheckedChanged);
            // 
            // rb_style_noani
            // 
            this.rb_style_noani.AutoSize = true;
            this.rb_style_noani.Location = new System.Drawing.Point(15, 35);
            this.rb_style_noani.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_style_noani.Name = "rb_style_noani";
            this.rb_style_noani.Size = new System.Drawing.Size(148, 29);
            this.rb_style_noani.TabIndex = 2;
            this.rb_style_noani.TabStop = true;
            this.rb_style_noani.Text = "no animation";
            this.rb_style_noani.UseVisualStyleBackColor = true;
            this.rb_style_noani.CheckedChanged += new System.EventHandler(this.rb_style_noani_CheckedChanged);
            // 
            // gb_text
            // 
            this.gb_text.Controls.Add(this.cb_hideWindow);
            this.gb_text.Controls.Add(this.cb_backspace);
            this.gb_text.Controls.Add(this.label_timeout_display);
            this.gb_text.Controls.Add(this.cb_enableHistoryTimeout);
            this.gb_text.Controls.Add(this.slider_history_timeout);
            this.gb_text.Controls.Add(this.label_history_timeout);
            this.gb_text.Controls.Add(this.label_historycount);
            this.gb_text.Controls.Add(this.label_verticalDistance);
            this.gb_text.Controls.Add(this.nud_historycount);
            this.gb_text.Controls.Add(this.nud_verticalDistance);
            this.gb_text.Controls.Add(this.button_textfont);
            this.gb_text.Controls.Add(this.button_textcolor);
            this.gb_text.Controls.Add(this.slider_fontsize);
            this.gb_text.Controls.Add(this.label_fontsize);
            this.gb_text.Location = new System.Drawing.Point(308, 22);
            this.gb_text.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_text.Name = "gb_text";
            this.gb_text.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_text.Size = new System.Drawing.Size(336, 506);
            this.gb_text.TabIndex = 32;
            this.gb_text.TabStop = false;
            this.gb_text.Text = "Text";
            // 
            // cb_hideWindow
            // 
            this.cb_hideWindow.AutoSize = true;
            this.cb_hideWindow.Location = new System.Drawing.Point(11, 386);
            this.cb_hideWindow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_hideWindow.Name = "cb_hideWindow";
            this.cb_hideWindow.Size = new System.Drawing.Size(258, 29);
            this.cb_hideWindow.TabIndex = 46;
            this.cb_hideWindow.Text = "Hide window when empty";
            this.cb_hideWindow.UseVisualStyleBackColor = true;
            this.cb_hideWindow.CheckedChanged += new System.EventHandler(this.cb_hideWindow_CheckedChanged);
            // 
            // cb_backspace
            // 
            this.cb_backspace.AutoSize = true;
            this.cb_backspace.Location = new System.Drawing.Point(11, 428);
            this.cb_backspace.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_backspace.Name = "cb_backspace";
            this.cb_backspace.Size = new System.Drawing.Size(266, 29);
            this.cb_backspace.TabIndex = 45;
            this.cb_backspace.Text = "Backspace can delete text";
            this.cb_backspace.UseVisualStyleBackColor = true;
            this.cb_backspace.CheckedChanged += new System.EventHandler(this.cb_backspace_CheckedChanged);
            // 
            // label_timeout_display
            // 
            this.label_timeout_display.AutoSize = true;
            this.label_timeout_display.Location = new System.Drawing.Point(216, 281);
            this.label_timeout_display.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_timeout_display.Name = "label_timeout_display";
            this.label_timeout_display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_timeout_display.Size = new System.Drawing.Size(33, 25);
            this.label_timeout_display.TabIndex = 44;
            this.label_timeout_display.Text = "5s";
            // 
            // cb_enableHistoryTimeout
            // 
            this.cb_enableHistoryTimeout.AutoSize = true;
            this.cb_enableHistoryTimeout.Location = new System.Drawing.Point(11, 279);
            this.cb_enableHistoryTimeout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_enableHistoryTimeout.Name = "cb_enableHistoryTimeout";
            this.cb_enableHistoryTimeout.Size = new System.Drawing.Size(166, 29);
            this.cb_enableHistoryTimeout.TabIndex = 43;
            this.cb_enableHistoryTimeout.Text = "History timeout";
            this.cb_enableHistoryTimeout.UseVisualStyleBackColor = true;
            this.cb_enableHistoryTimeout.CheckedChanged += new System.EventHandler(this.cb_enableHistoryTimeout_CheckedChanged);
            // 
            // slider_history_timeout
            // 
            this.slider_history_timeout.Location = new System.Drawing.Point(125, 332);
            this.slider_history_timeout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slider_history_timeout.Maximum = 120000;
            this.slider_history_timeout.Minimum = 1000;
            this.slider_history_timeout.Name = "slider_history_timeout";
            this.slider_history_timeout.Size = new System.Drawing.Size(191, 80);
            this.slider_history_timeout.TabIndex = 41;
            this.slider_history_timeout.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_history_timeout.Value = 1000;
            this.slider_history_timeout.Scroll += new System.EventHandler(this.slider_history_timeout_Scroll);
            // 
            // label_history_timeout
            // 
            this.label_history_timeout.AutoSize = true;
            this.label_history_timeout.Location = new System.Drawing.Point(29, 338);
            this.label_history_timeout.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_history_timeout.Name = "label_history_timeout";
            this.label_history_timeout.Size = new System.Drawing.Size(83, 25);
            this.label_history_timeout.TabIndex = 40;
            this.label_history_timeout.Text = "Timeout";
            // 
            // label_historycount
            // 
            this.label_historycount.AutoSize = true;
            this.label_historycount.Location = new System.Drawing.Point(29, 229);
            this.label_historycount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_historycount.Name = "label_historycount";
            this.label_historycount.Size = new System.Drawing.Size(130, 25);
            this.label_historycount.TabIndex = 39;
            this.label_historycount.Text = "History Count";
            // 
            // label_verticalDistance
            // 
            this.label_verticalDistance.AutoSize = true;
            this.label_verticalDistance.Location = new System.Drawing.Point(29, 181);
            this.label_verticalDistance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_verticalDistance.Name = "label_verticalDistance";
            this.label_verticalDistance.Size = new System.Drawing.Size(158, 25);
            this.label_verticalDistance.TabIndex = 38;
            this.label_verticalDistance.Text = "Vertical Distance";
            // 
            // nud_historycount
            // 
            this.nud_historycount.Location = new System.Drawing.Point(200, 225);
            this.nud_historycount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nud_historycount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_historycount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_historycount.Name = "nud_historycount";
            this.nud_historycount.Size = new System.Drawing.Size(116, 29);
            this.nud_historycount.TabIndex = 37;
            this.nud_historycount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_historycount.ValueChanged += new System.EventHandler(this.nud_historycount_ValueChanged);
            // 
            // nud_verticalDistance
            // 
            this.nud_verticalDistance.Location = new System.Drawing.Point(200, 177);
            this.nud_verticalDistance.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nud_verticalDistance.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_verticalDistance.Name = "nud_verticalDistance";
            this.nud_verticalDistance.Size = new System.Drawing.Size(116, 29);
            this.nud_verticalDistance.TabIndex = 36;
            this.nud_verticalDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_verticalDistance.ValueChanged += new System.EventHandler(this.nud_verticalDistance_ValueChanged);
            // 
            // button_textfont
            // 
            this.button_textfont.Location = new System.Drawing.Point(169, 35);
            this.button_textfont.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_textfont.Name = "button_textfont";
            this.button_textfont.Size = new System.Drawing.Size(147, 42);
            this.button_textfont.TabIndex = 25;
            this.button_textfont.Text = "Text font";
            this.button_textfont.UseVisualStyleBackColor = true;
            this.button_textfont.Click += new System.EventHandler(this.button_textfont_Click);
            // 
            // gb_background
            // 
            this.gb_background.Controls.Add(this.button_backcolor);
            this.gb_background.Controls.Add(this.slider_opacity);
            this.gb_background.Controls.Add(this.label_opacity);
            this.gb_background.Location = new System.Drawing.Point(656, 327);
            this.gb_background.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_background.Name = "gb_background";
            this.gb_background.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_background.Size = new System.Drawing.Size(336, 201);
            this.gb_background.TabIndex = 33;
            this.gb_background.TabStop = false;
            this.gb_background.Text = "Background";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 539);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Press and hold Ctrl + Shift + Alt to reveal setting buttons";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(17, 589);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(434, 25);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Issues? Want to have a look at the source code?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bn_reset_position
            // 
            this.bn_reset_position.Location = new System.Drawing.Point(22, 473);
            this.bn_reset_position.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bn_reset_position.Name = "bn_reset_position";
            this.bn_reset_position.Size = new System.Drawing.Size(158, 42);
            this.bn_reset_position.TabIndex = 36;
            this.bn_reset_position.Text = "Reset position";
            this.bn_reset_position.UseVisualStyleBackColor = true;
            this.bn_reset_position.Click += new System.EventHandler(this.bn_reset_position_Click);
            // 
            // bn_reset_all
            // 
            this.bn_reset_all.Location = new System.Drawing.Point(191, 473);
            this.bn_reset_all.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bn_reset_all.Name = "bn_reset_all";
            this.bn_reset_all.Size = new System.Drawing.Size(106, 42);
            this.bn_reset_all.TabIndex = 37;
            this.bn_reset_all.Text = "Reset all";
            this.bn_reset_all.UseVisualStyleBackColor = true;
            this.bn_reset_all.Click += new System.EventHandler(this.bn_reset_all_Click);
            // 
            // gb_mouse
            // 
            this.gb_mouse.Controls.Add(this.button_ci_color);
            this.gb_mouse.Controls.Add(this.label_ci_size);
            this.gb_mouse.Controls.Add(this.slider_ci_size);
            this.gb_mouse.Controls.Add(this.slider_ci_opacity);
            this.gb_mouse.Controls.Add(this.label_ci_opacity);
            this.gb_mouse.Controls.Add(this.cb_cursorindicator);
            this.gb_mouse.Location = new System.Drawing.Point(656, 24);
            this.gb_mouse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_mouse.Name = "gb_mouse";
            this.gb_mouse.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_mouse.Size = new System.Drawing.Size(336, 292);
            this.gb_mouse.TabIndex = 38;
            this.gb_mouse.TabStop = false;
            this.gb_mouse.Text = "Mouse";
            // 
            // button_ci_color
            // 
            this.button_ci_color.Location = new System.Drawing.Point(11, 218);
            this.button_ci_color.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_ci_color.Name = "button_ci_color";
            this.button_ci_color.Size = new System.Drawing.Size(314, 42);
            this.button_ci_color.TabIndex = 26;
            this.button_ci_color.Text = "Color";
            this.button_ci_color.UseVisualStyleBackColor = true;
            this.button_ci_color.Click += new System.EventHandler(this.button_ci_color_Click);
            // 
            // label_ci_size
            // 
            this.label_ci_size.AutoSize = true;
            this.label_ci_size.Location = new System.Drawing.Point(37, 170);
            this.label_ci_size.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ci_size.Name = "label_ci_size";
            this.label_ci_size.Size = new System.Drawing.Size(51, 25);
            this.label_ci_size.TabIndex = 42;
            this.label_ci_size.Text = "Size";
            // 
            // slider_ci_size
            // 
            this.slider_ci_size.Location = new System.Drawing.Point(125, 157);
            this.slider_ci_size.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slider_ci_size.Maximum = 200;
            this.slider_ci_size.Minimum = 4;
            this.slider_ci_size.Name = "slider_ci_size";
            this.slider_ci_size.Size = new System.Drawing.Size(191, 80);
            this.slider_ci_size.TabIndex = 41;
            this.slider_ci_size.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_ci_size.Value = 100;
            this.slider_ci_size.Scroll += new System.EventHandler(this.slider_ci_size_Scroll);
            // 
            // slider_ci_opacity
            // 
            this.slider_ci_opacity.Location = new System.Drawing.Point(125, 85);
            this.slider_ci_opacity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slider_ci_opacity.Maximum = 100;
            this.slider_ci_opacity.Minimum = 10;
            this.slider_ci_opacity.Name = "slider_ci_opacity";
            this.slider_ci_opacity.Size = new System.Drawing.Size(191, 80);
            this.slider_ci_opacity.TabIndex = 40;
            this.slider_ci_opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_ci_opacity.Value = 80;
            this.slider_ci_opacity.Scroll += new System.EventHandler(this.slider_ci_opacity_Scroll);
            // 
            // label_ci_opacity
            // 
            this.label_ci_opacity.AutoSize = true;
            this.label_ci_opacity.Location = new System.Drawing.Point(37, 96);
            this.label_ci_opacity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ci_opacity.Name = "label_ci_opacity";
            this.label_ci_opacity.Size = new System.Drawing.Size(79, 25);
            this.label_ci_opacity.TabIndex = 1;
            this.label_ci_opacity.Text = "Opacity";
            // 
            // cb_cursorindicator
            // 
            this.cb_cursorindicator.AutoSize = true;
            this.cb_cursorindicator.Location = new System.Drawing.Point(13, 33);
            this.cb_cursorindicator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_cursorindicator.Name = "cb_cursorindicator";
            this.cb_cursorindicator.Size = new System.Drawing.Size(237, 29);
            this.cb_cursorindicator.TabIndex = 0;
            this.cb_cursorindicator.Text = "Indicate cursor position";
            this.cb_cursorindicator.UseVisualStyleBackColor = true;
            this.cb_cursorindicator.CheckedChanged += new System.EventHandler(this.cb_cursorindicator_CheckedChanged);
            // 
            // gb_buttonindicator
            // 
            this.gb_buttonindicator.Controls.Add(this.cb_bi_history);
            this.gb_buttonindicator.Controls.Add(this.label_bi_size);
            this.gb_buttonindicator.Controls.Add(this.rb_bi_icon);
            this.gb_buttonindicator.Controls.Add(this.rb_bi_disable);
            this.gb_buttonindicator.Controls.Add(this.label_bi_angle);
            this.gb_buttonindicator.Controls.Add(this.slider_bi_angle);
            this.gb_buttonindicator.Controls.Add(this.slider_bi_distance);
            this.gb_buttonindicator.Controls.Add(this.label_bi_distance);
            this.gb_buttonindicator.Controls.Add(this.slider_bi_size);
            this.gb_buttonindicator.Location = new System.Drawing.Point(1003, 24);
            this.gb_buttonindicator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_buttonindicator.Name = "gb_buttonindicator";
            this.gb_buttonindicator.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb_buttonindicator.Size = new System.Drawing.Size(336, 504);
            this.gb_buttonindicator.TabIndex = 43;
            this.gb_buttonindicator.TabStop = false;
            this.gb_buttonindicator.Text = "Mouse Clicks";
            // 
            // cb_bi_history
            // 
            this.cb_bi_history.AutoSize = true;
            this.cb_bi_history.Enabled = false;
            this.cb_bi_history.Location = new System.Drawing.Point(11, 338);
            this.cb_bi_history.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cb_bi_history.Name = "cb_bi_history";
            this.cb_bi_history.Size = new System.Drawing.Size(168, 29);
            this.cb_bi_history.TabIndex = 46;
            this.cb_bi_history.Text = "Add To History";
            this.cb_bi_history.UseVisualStyleBackColor = true;
            this.cb_bi_history.CheckedChanged += new System.EventHandler(this.cb_bi_history_CheckedChanged);
            // 
            // label_bi_size
            // 
            this.label_bi_size.AutoSize = true;
            this.label_bi_size.Location = new System.Drawing.Point(37, 140);
            this.label_bi_size.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_bi_size.Name = "label_bi_size";
            this.label_bi_size.Size = new System.Drawing.Size(51, 25);
            this.label_bi_size.TabIndex = 44;
            this.label_bi_size.Text = "Size";
            // 
            // rb_bi_icon
            // 
            this.rb_bi_icon.AutoSize = true;
            this.rb_bi_icon.Location = new System.Drawing.Point(11, 74);
            this.rb_bi_icon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_bi_icon.Name = "rb_bi_icon";
            this.rb_bi_icon.Size = new System.Drawing.Size(129, 29);
            this.rb_bi_icon.TabIndex = 43;
            this.rb_bi_icon.TabStop = true;
            this.rb_bi_icon.Text = "Show Icon";
            this.rb_bi_icon.UseVisualStyleBackColor = true;
            this.rb_bi_icon.CheckedChanged += new System.EventHandler(this.rb_bi_icon_CheckedChanged);
            // 
            // rb_bi_disable
            // 
            this.rb_bi_disable.AutoSize = true;
            this.rb_bi_disable.Location = new System.Drawing.Point(11, 31);
            this.rb_bi_disable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb_bi_disable.Name = "rb_bi_disable";
            this.rb_bi_disable.Size = new System.Drawing.Size(219, 29);
            this.rb_bi_disable.TabIndex = 2;
            this.rb_bi_disable.TabStop = true;
            this.rb_bi_disable.Text = "No not indicate clicks";
            this.rb_bi_disable.UseVisualStyleBackColor = true;
            this.rb_bi_disable.CheckedChanged += new System.EventHandler(this.rb_bi_disable_CheckedChanged);
            // 
            // label_bi_angle
            // 
            this.label_bi_angle.AutoSize = true;
            this.label_bi_angle.Location = new System.Drawing.Point(37, 286);
            this.label_bi_angle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_bi_angle.Name = "label_bi_angle";
            this.label_bi_angle.Size = new System.Drawing.Size(88, 25);
            this.label_bi_angle.TabIndex = 42;
            this.label_bi_angle.Text = "Direction";
            // 
            // slider_bi_angle
            // 
            this.slider_bi_angle.Location = new System.Drawing.Point(125, 273);
            this.slider_bi_angle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slider_bi_angle.Maximum = 65;
            this.slider_bi_angle.Name = "slider_bi_angle";
            this.slider_bi_angle.Size = new System.Drawing.Size(191, 80);
            this.slider_bi_angle.TabIndex = 41;
            this.slider_bi_angle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_bi_angle.Value = 65;
            this.slider_bi_angle.Scroll += new System.EventHandler(this.slider_bi_angle_Scroll);
            // 
            // slider_bi_distance
            // 
            this.slider_bi_distance.Location = new System.Drawing.Point(125, 201);
            this.slider_bi_distance.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slider_bi_distance.Maximum = 100;
            this.slider_bi_distance.Minimum = 10;
            this.slider_bi_distance.Name = "slider_bi_distance";
            this.slider_bi_distance.Size = new System.Drawing.Size(191, 80);
            this.slider_bi_distance.TabIndex = 40;
            this.slider_bi_distance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_bi_distance.Value = 80;
            this.slider_bi_distance.Scroll += new System.EventHandler(this.slider_bi_distance_Scroll);
            // 
            // label_bi_distance
            // 
            this.label_bi_distance.AutoSize = true;
            this.label_bi_distance.Location = new System.Drawing.Point(37, 212);
            this.label_bi_distance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_bi_distance.Name = "label_bi_distance";
            this.label_bi_distance.Size = new System.Drawing.Size(88, 25);
            this.label_bi_distance.TabIndex = 1;
            this.label_bi_distance.Text = "Distance";
            // 
            // slider_bi_size
            // 
            this.slider_bi_size.Location = new System.Drawing.Point(125, 129);
            this.slider_bi_size.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.slider_bi_size.Maximum = 70;
            this.slider_bi_size.Minimum = 20;
            this.slider_bi_size.Name = "slider_bi_size";
            this.slider_bi_size.Size = new System.Drawing.Size(191, 80);
            this.slider_bi_size.TabIndex = 45;
            this.slider_bi_size.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_bi_size.Value = 70;
            this.slider_bi_size.Scroll += new System.EventHandler(this.slider_bi_size_Scroll);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(656, 594);
            this.button_exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(336, 42);
            this.button_exit.TabIndex = 44;
            this.button_exit.Text = "Exit Program";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(1003, 594);
            this.button_close.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(336, 42);
            this.button_close.TabIndex = 45;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 659);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.gb_buttonindicator);
            this.Controls.Add(this.gb_mouse);
            this.Controls.Add(this.bn_reset_all);
            this.Controls.Add(this.bn_reset_position);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_background);
            this.Controls.Add(this.gb_text);
            this.Controls.Add(this.gb_style);
            this.Controls.Add(this.gb_textdir);
            this.Controls.Add(this.groupBox_text_alignment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slider_opacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_fontsize)).EndInit();
            this.groupBox_text_alignment.ResumeLayout(false);
            this.groupBox_text_alignment.PerformLayout();
            this.gb_textdir.ResumeLayout(false);
            this.gb_textdir.PerformLayout();
            this.gb_style.ResumeLayout(false);
            this.gb_style.PerformLayout();
            this.gb_text.ResumeLayout(false);
            this.gb_text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_history_timeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_historycount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_verticalDistance)).EndInit();
            this.gb_background.ResumeLayout(false);
            this.gb_background.PerformLayout();
            this.gb_mouse.ResumeLayout(false);
            this.gb_mouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ci_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ci_opacity)).EndInit();
            this.gb_buttonindicator.ResumeLayout(false);
            this.gb_buttonindicator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_backcolor;
        private System.Windows.Forms.Button button_textcolor;
        private System.Windows.Forms.TrackBar slider_opacity;
        private System.Windows.Forms.Label label_opacity;
        private System.Windows.Forms.Label label_fontsize;
        private System.Windows.Forms.TrackBar slider_fontsize;
        private System.Windows.Forms.RadioButton rb_align_left;
        private System.Windows.Forms.RadioButton rb_align_center;
        private System.Windows.Forms.RadioButton rb_align_right;
        private System.Windows.Forms.GroupBox groupBox_text_alignment;
        private System.Windows.Forms.GroupBox gb_textdir;
        private System.Windows.Forms.RadioButton rb_td_up;
        private System.Windows.Forms.RadioButton rb_td_down;
        private System.Windows.Forms.GroupBox gb_style;
        private System.Windows.Forms.RadioButton rb_style_slide;
        private System.Windows.Forms.RadioButton rb_style_noani;
        private System.Windows.Forms.GroupBox gb_text;
        private System.Windows.Forms.Button button_textfont;
        private System.Windows.Forms.GroupBox gb_background;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ColorDialog picker_textcolor;
        private System.Windows.Forms.ColorDialog picker_backcolor;
        private System.Windows.Forms.FontDialog fontDialog_text;
        private System.Windows.Forms.Label label_historycount;
        private System.Windows.Forms.Label label_verticalDistance;
        private System.Windows.Forms.NumericUpDown nud_historycount;
        private System.Windows.Forms.NumericUpDown nud_verticalDistance;
        private System.Windows.Forms.Button bn_reset_position;
        private System.Windows.Forms.Button bn_reset_all;
        private System.Windows.Forms.GroupBox gb_mouse;
        private System.Windows.Forms.CheckBox cb_cursorindicator;
        private System.Windows.Forms.Button button_ci_color;
        private System.Windows.Forms.Label label_ci_size;
        private System.Windows.Forms.TrackBar slider_ci_size;
        private System.Windows.Forms.TrackBar slider_ci_opacity;
        private System.Windows.Forms.Label label_ci_opacity;
        private System.Windows.Forms.ColorDialog picker_ci_color;
        private System.Windows.Forms.Label label_timeout_display;
        private System.Windows.Forms.CheckBox cb_enableHistoryTimeout;
        private System.Windows.Forms.TrackBar slider_history_timeout;
        private System.Windows.Forms.Label label_history_timeout;
        private System.Windows.Forms.GroupBox gb_buttonindicator;
        private System.Windows.Forms.Label label_bi_size;
        private System.Windows.Forms.RadioButton rb_bi_icon;
        private System.Windows.Forms.RadioButton rb_bi_disable;
        private System.Windows.Forms.Label label_bi_angle;
        private System.Windows.Forms.TrackBar slider_bi_angle;
        private System.Windows.Forms.TrackBar slider_bi_distance;
        private System.Windows.Forms.Label label_bi_distance;
        private System.Windows.Forms.TrackBar slider_bi_size;
        private System.Windows.Forms.CheckBox cb_backspace;
        private System.Windows.Forms.CheckBox cb_bi_history;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.CheckBox cb_hideWindow;
    }
}