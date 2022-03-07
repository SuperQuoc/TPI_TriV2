namespace TPI_TriV2
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSortingMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.miBulle = new System.Windows.Forms.ToolStripMenuItem();
            this.miSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.miPeigne = new System.Windows.Forms.ToolStripMenuItem();
            this.miShell = new System.Windows.Forms.ToolStripMenuItem();
            this.miInsertion = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxSpeed = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lbxPseudoCode = new System.Windows.Forms.ListBox();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.displaySorting = new TPI_TriV2._View.DisplaySorting();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displaySorting)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miSortingMethod,
            this.miHelp,
            this.miAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(790, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "&File";
            // 
            // miSortingMethod
            // 
            this.miSortingMethod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBulle,
            this.miSelection,
            this.miPeigne,
            this.miShell,
            this.miInsertion});
            this.miSortingMethod.Name = "miSortingMethod";
            this.miSortingMethod.Size = new System.Drawing.Size(102, 20);
            this.miSortingMethod.Text = "&Sorting Method";
            // 
            // miBulle
            // 
            this.miBulle.Name = "miBulle";
            this.miBulle.Size = new System.Drawing.Size(122, 22);
            this.miBulle.Text = "Bulle";
            this.miBulle.Click += new System.EventHandler(this.miBulle_Click);
            // 
            // miSelection
            // 
            this.miSelection.Name = "miSelection";
            this.miSelection.Size = new System.Drawing.Size(122, 22);
            this.miSelection.Text = "Selection";
            this.miSelection.Click += new System.EventHandler(this.miSelection_Click);
            // 
            // miPeigne
            // 
            this.miPeigne.Name = "miPeigne";
            this.miPeigne.Size = new System.Drawing.Size(122, 22);
            this.miPeigne.Text = "Peigne";
            this.miPeigne.Click += new System.EventHandler(this.miPeigne_Click);
            // 
            // miShell
            // 
            this.miShell.Name = "miShell";
            this.miShell.Size = new System.Drawing.Size(122, 22);
            this.miShell.Text = "Shell";
            this.miShell.Click += new System.EventHandler(this.miShell_Click);
            // 
            // miInsertion
            // 
            this.miInsertion.Name = "miInsertion";
            this.miInsertion.Size = new System.Drawing.Size(122, 22);
            this.miInsertion.Text = "Insertion";
            this.miInsertion.Click += new System.EventHandler(this.miInsertion_Click);
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "&Help";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(52, 20);
            this.miAbout.Text = "&About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // cbxSpeed
            // 
            this.cbxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpeed.FormattingEnabled = true;
            this.cbxSpeed.Items.AddRange(new object[] {
            "Pas à pas",
            "Tres lent",
            "Lent",
            "Normal",
            "Rapide"});
            this.cbxSpeed.Location = new System.Drawing.Point(12, 461);
            this.cbxSpeed.Name = "cbxSpeed";
            this.cbxSpeed.Size = new System.Drawing.Size(121, 21);
            this.cbxSpeed.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(139, 461);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lbxPseudoCode
            // 
            this.lbxPseudoCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxPseudoCode.FormattingEnabled = true;
            this.lbxPseudoCode.Location = new System.Drawing.Point(0, 488);
            this.lbxPseudoCode.Name = "lbxPseudoCode";
            this.lbxPseudoCode.Size = new System.Drawing.Size(790, 225);
            this.lbxPseudoCode.TabIndex = 4;
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(220, 461);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 6;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // displaySorting
            // 
            this.displaySorting.Dock = System.Windows.Forms.DockStyle.Top;
            this.displaySorting.Location = new System.Drawing.Point(0, 24);
            this.displaySorting.Name = "displaySorting";
            this.displaySorting.Size = new System.Drawing.Size(790, 431);
            this.displaySorting.TabIndex = 5;
            this.displaySorting.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 713);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.displaySorting);
            this.Controls.Add(this.lbxPseudoCode);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cbxSpeed);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FrmMain";
            this.Text = "TPI Tri Algo";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displaySorting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miSortingMethod;
        private System.Windows.Forms.ToolStripMenuItem miBulle;
        private System.Windows.Forms.ToolStripMenuItem miSelection;
        private System.Windows.Forms.ToolStripMenuItem miPeigne;
        private System.Windows.Forms.ToolStripMenuItem miShell;
        private System.Windows.Forms.ToolStripMenuItem miInsertion;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ComboBox cbxSpeed;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lbxPseudoCode;
        private _View.DisplaySorting displaySorting;
        private System.Windows.Forms.Button btnRandomize;
    }
}

