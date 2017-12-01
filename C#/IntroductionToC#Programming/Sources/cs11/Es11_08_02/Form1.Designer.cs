namespace Es11_08_02
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("워드", 2, 2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("파워포인트", 3, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("엑셀", 4, 4);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("비지오", 5, 5);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("아웃룩", 6, 6);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("오피스", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("메모장", 7, 7);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("그림판", 8, 8);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("계산기", 9, 9);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("보조프로그램", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("내컴퓨터", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(8, 8);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "워드";
            treeNode2.ImageIndex = 3;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "파워포인트";
            treeNode3.ImageIndex = 4;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 4;
            treeNode3.Text = "엑셀";
            treeNode4.ImageIndex = 5;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 5;
            treeNode4.Text = "비지오";
            treeNode5.ImageIndex = 6;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 6;
            treeNode5.Text = "아웃룩";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "오피스";
            treeNode7.ImageIndex = 7;
            treeNode7.Name = "";
            treeNode7.SelectedImageIndex = 7;
            treeNode7.Text = "메모장";
            treeNode8.ImageIndex = 8;
            treeNode8.Name = "";
            treeNode8.SelectedImageIndex = 8;
            treeNode8.Text = "그림판";
            treeNode9.ImageIndex = 9;
            treeNode9.Name = "";
            treeNode9.SelectedImageIndex = 9;
            treeNode9.Text = "계산기";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "보조프로그램";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "";
            treeNode11.SelectedImageIndex = 0;
            treeNode11.Text = "내컴퓨터";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(152, 224);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "내컴퓨터.jpg");
            this.imageList1.Images.SetKeyName(1, "폴더.jpg");
            this.imageList1.Images.SetKeyName(2, "워드.jpg");
            this.imageList1.Images.SetKeyName(3, "파워포인트.jpg");
            this.imageList1.Images.SetKeyName(4, "엑셀.jpg");
            this.imageList1.Images.SetKeyName(5, "비지오.jpg");
            this.imageList1.Images.SetKeyName(6, "아웃룩.jpg");
            this.imageList1.Images.SetKeyName(7, "메모장.jpg");
            this.imageList1.Images.SetKeyName(8, "그림판.jpg");
            this.imageList1.Images.SetKeyName(9, "계산기.JPG");
            // 
            // listView1
            // 
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(168, 8);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(192, 224);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(368, 238);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Es11_08_02:탐색기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
    }
}

