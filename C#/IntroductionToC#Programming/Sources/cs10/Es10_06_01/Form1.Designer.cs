namespace Es10_06_01
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuFileNew = new System.Windows.Forms.MenuItem();
            this.mnuFileOpen = new System.Windows.Forms.MenuItem();
            this.mnuFileClose = new System.Windows.Forms.MenuItem();
            this.mnuFileSave = new System.Windows.Forms.MenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.MenuItem();
            this.mnuSep1 = new System.Windows.Forms.MenuItem();
            this.mnuFilePrint = new System.Windows.Forms.MenuItem();
            this.mnuFileView = new System.Windows.Forms.MenuItem();
            this.mnuSep2 = new System.Windows.Forms.MenuItem();
            this.mnuFileExit = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuEditCut = new System.Windows.Forms.MenuItem();
            this.mnuEditCopy = new System.Windows.Forms.MenuItem();
            this.mnuEditPaste = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.MenuItem();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.mnuFile,
                                                                                      this.mnuEdit,
                                                                                      this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                    this.mnuFileNew,
                                                                                    this.mnuFileOpen,
                                                                                    this.mnuFileClose,
                                                                                    this.mnuFileSave,
                                                                                    this.mnuFileSaveAs,
                                                                                    this.mnuSep1,
                                                                                    this.mnuFilePrint,
                                                                                    this.mnuFileView,
                                                                                    this.mnuSep2,
                                                                                    this.mnuFileExit});
            this.mnuFile.Text = "파일(&F)";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Index = 0;
            this.mnuFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mnuFileNew.Text = "새파일(&N)";
            this.mnuFileNew.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Index = 1;
            this.mnuFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuFileOpen.Text = "열기(&O)";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Index = 2;
            this.mnuFileClose.Text = "닫기(&C)";
            this.mnuFileClose.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Index = 3;
            this.mnuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuFileSave.Text = "저장(&S)";
            this.mnuFileSave.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Index = 4;
            this.mnuFileSaveAs.Text = "다른 이름으로 저장(&A)";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuSep1
            // 
            this.mnuSep1.Index = 5;
            this.mnuSep1.Text = "-";
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Index = 6;
            this.mnuFilePrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.mnuFilePrint.Text = "인쇄(&P)";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuFileView
            // 
            this.mnuFileView.Index = 7;
            this.mnuFileView.Text = "미리 보기(&V)";
            this.mnuFileView.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuSep2
            // 
            this.mnuSep2.Index = 8;
            this.mnuSep2.Text = "-";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Index = 9;
            this.mnuFileExit.Text = "종료(&X)";
            this.mnuFileExit.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Index = 1;
            this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                    this.mnuEditCut,
                                                                                    this.mnuEditCopy,
                                                                                    this.mnuEditPaste});
            this.mnuEdit.Text = "편집(&E)";
            // 
            // mnuEditCut
            // 
            this.mnuEditCut.Index = 0;
            this.mnuEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.mnuEditCut.Text = "잘라내기(&T)";
            this.mnuEditCut.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuEditCopy
            // 
            this.mnuEditCopy.Index = 1;
            this.mnuEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.mnuEditCopy.Text = "복사(&C)";
            this.mnuEditCopy.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuEditPaste
            // 
            this.mnuEditPaste.Index = 2;
            this.mnuEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.mnuEditPaste.Text = "붙여넣기(&P)";
            this.mnuEditPaste.Click += new System.EventHandler(this.mnu_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 2;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                    this.mnuHelpAbout});
            this.mnuHelp.Text = "도움말(&H)";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Index = 0;
            this.mnuHelpAbout.Text = "프로그램 정보(&A)";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnu_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(292, 226);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Es10_06_01";
        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuFileNew;
        private System.Windows.Forms.MenuItem mnuFileOpen;
        private System.Windows.Forms.MenuItem mnuFileClose;
        private System.Windows.Forms.MenuItem mnuFileSave;
        private System.Windows.Forms.MenuItem mnuFileSaveAs;
        private System.Windows.Forms.MenuItem mnuSep1;
        private System.Windows.Forms.MenuItem mnuFilePrint;
        private System.Windows.Forms.MenuItem mnuFileView;
        private System.Windows.Forms.MenuItem mnuSep2;
        private System.Windows.Forms.MenuItem mnuFileExit;
        private System.Windows.Forms.MenuItem mnuEdit;
        private System.Windows.Forms.MenuItem mnuEditCut;
        private System.Windows.Forms.MenuItem mnuEditCopy;
        private System.Windows.Forms.MenuItem mnuEditPaste;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuHelpAbout;
    }
}

