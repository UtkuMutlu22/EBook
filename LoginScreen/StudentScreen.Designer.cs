
namespace LoginScreen
{
    partial class StudentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScreen));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnQuestionView = new DevExpress.XtraBars.BarButtonItem();
            this.btnArticleView = new DevExpress.XtraBars.BarButtonItem();
            this.ExercisesView = new DevExpress.XtraBars.BarButtonItem();
            this.btnAudioView = new DevExpress.XtraBars.BarButtonItem();
            this.btnVideoView = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuestionAnswerVideo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnQuestionView,
            this.btnArticleView,
            this.ExercisesView,
            this.btnAudioView,
            this.btnVideoView,
            this.btnQuestionAnswerVideo});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(870, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnQuestionView
            // 
            this.btnQuestionView.Caption = "Soruları Göster";
            this.btnQuestionView.Id = 1;
            this.btnQuestionView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuestionView.ImageOptions.Image")));
            this.btnQuestionView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuestionView.ImageOptions.LargeImage")));
            this.btnQuestionView.Name = "btnQuestionView";
            // 
            // btnArticleView
            // 
            this.btnArticleView.Caption = "Konu Anlatımlarını Listele";
            this.btnArticleView.Id = 2;
            this.btnArticleView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnArticleView.ImageOptions.Image")));
            this.btnArticleView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnArticleView.ImageOptions.LargeImage")));
            this.btnArticleView.Name = "btnArticleView";
            // 
            // ExercisesView
            // 
            this.ExercisesView.Caption = "Alıştırmalar";
            this.ExercisesView.Id = 3;
            this.ExercisesView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExercisesView.ImageOptions.Image")));
            this.ExercisesView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ExercisesView.ImageOptions.LargeImage")));
            this.ExercisesView.Name = "ExercisesView";
            // 
            // btnAudioView
            // 
            this.btnAudioView.Caption = "Sesli Sınavlar";
            this.btnAudioView.Id = 4;
            this.btnAudioView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAudioView.ImageOptions.Image")));
            this.btnAudioView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAudioView.ImageOptions.LargeImage")));
            this.btnAudioView.Name = "btnAudioView";
            // 
            // btnVideoView
            // 
            this.btnVideoView.Caption = "Konu Videoları";
            this.btnVideoView.Id = 5;
            this.btnVideoView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVideoView.ImageOptions.Image")));
            this.btnVideoView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVideoView.ImageOptions.LargeImage")));
            this.btnVideoView.Name = "btnVideoView";
            // 
            // btnQuestionAnswerVideo
            // 
            this.btnQuestionAnswerVideo.Caption = "Soru Çözüm Videoları";
            this.btnQuestionAnswerVideo.Id = 6;
            this.btnQuestionAnswerVideo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuestionAnswerVideo.ImageOptions.Image")));
            this.btnQuestionAnswerVideo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuestionAnswerVideo.ImageOptions.LargeImage")));
            this.btnQuestionAnswerVideo.Name = "btnQuestionAnswerVideo";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQuestionView);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnArticleView);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.ExercisesView);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnAudioView);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVideoView);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnQuestionAnswerVideo);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 519);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(870, 24);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 158);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.Size = new System.Drawing.Size(200, 361);
            this.accordionControl1.TabIndex = 2;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "accordionControlElement1";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement5});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "MAT-1";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "TEMEL KAVRAMLAR";
           // this.accordionControlElement5.Click += new System.EventHandler(this.accordionControlElement5_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "MAT-2";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "ALES";
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 543);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "StudentScreen";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "StudentScreen";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnQuestionView;
        private DevExpress.XtraBars.BarButtonItem btnArticleView;
        private DevExpress.XtraBars.BarButtonItem ExercisesView;
        private DevExpress.XtraBars.BarButtonItem btnAudioView;
        private DevExpress.XtraBars.BarButtonItem btnVideoView;
        private DevExpress.XtraBars.BarButtonItem btnQuestionAnswerVideo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
    }
}