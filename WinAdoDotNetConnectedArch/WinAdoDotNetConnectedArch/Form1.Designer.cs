
namespace WinAdoDotNetConnectedArch
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMovieDetails = new System.Windows.Forms.TabPage();
            this.lblvalueTicketsSold = new System.Windows.Forms.Label();
            this.lblvalueActor = new System.Windows.Forms.Label();
            this.lblvalueMName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtEnterMId = new System.Windows.Forms.TextBox();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.lblActor = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblEnterMID = new System.Windows.Forms.Label();
            this.tabShowMovies = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabUpdateMovie = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTicketsSold = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtMId = new System.Windows.Forms.TextBox();
            this.lbl1TicketsSold = new System.Windows.Forms.Label();
            this.lbl1Actor = new System.Windows.Forms.Label();
            this.lbl1MName = new System.Windows.Forms.Label();
            this.lbl1MId = new System.Windows.Forms.Label();
            this.btnShowOnlyMName = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMovieDetails.SuspendLayout();
            this.tabShowMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabUpdateMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMovieDetails);
            this.tabControl1.Controls.Add(this.tabShowMovies);
            this.tabControl1.Controls.Add(this.tabUpdateMovie);
            this.tabControl1.Location = new System.Drawing.Point(30, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMovieDetails
            // 
            this.tabMovieDetails.BackColor = System.Drawing.Color.Transparent;
            this.tabMovieDetails.Controls.Add(this.btnShowOnlyMName);
            this.tabMovieDetails.Controls.Add(this.lblvalueTicketsSold);
            this.tabMovieDetails.Controls.Add(this.lblvalueActor);
            this.tabMovieDetails.Controls.Add(this.lblvalueMName);
            this.tabMovieDetails.Controls.Add(this.btnShow);
            this.tabMovieDetails.Controls.Add(this.txtEnterMId);
            this.tabMovieDetails.Controls.Add(this.lblTicketsSold);
            this.tabMovieDetails.Controls.Add(this.lblActor);
            this.tabMovieDetails.Controls.Add(this.lblMName);
            this.tabMovieDetails.Controls.Add(this.lblEnterMID);
            this.tabMovieDetails.Location = new System.Drawing.Point(4, 22);
            this.tabMovieDetails.Name = "tabMovieDetails";
            this.tabMovieDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovieDetails.Size = new System.Drawing.Size(562, 314);
            this.tabMovieDetails.TabIndex = 0;
            this.tabMovieDetails.Text = "Movie Details";
            // 
            // lblvalueTicketsSold
            // 
            this.lblvalueTicketsSold.AutoSize = true;
            this.lblvalueTicketsSold.Location = new System.Drawing.Point(208, 210);
            this.lblvalueTicketsSold.Name = "lblvalueTicketsSold";
            this.lblvalueTicketsSold.Size = new System.Drawing.Size(0, 13);
            this.lblvalueTicketsSold.TabIndex = 8;
            // 
            // lblvalueActor
            // 
            this.lblvalueActor.AutoSize = true;
            this.lblvalueActor.Location = new System.Drawing.Point(208, 151);
            this.lblvalueActor.Name = "lblvalueActor";
            this.lblvalueActor.Size = new System.Drawing.Size(0, 13);
            this.lblvalueActor.TabIndex = 7;
            // 
            // lblvalueMName
            // 
            this.lblvalueMName.AutoSize = true;
            this.lblvalueMName.Location = new System.Drawing.Point(205, 93);
            this.lblvalueMName.Name = "lblvalueMName";
            this.lblvalueMName.Size = new System.Drawing.Size(0, 13);
            this.lblvalueMName.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(74, 246);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(131, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Movie Details";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtEnterMId
            // 
            this.txtEnterMId.Location = new System.Drawing.Point(205, 31);
            this.txtEnterMId.Name = "txtEnterMId";
            this.txtEnterMId.Size = new System.Drawing.Size(100, 20);
            this.txtEnterMId.TabIndex = 4;
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.Location = new System.Drawing.Point(77, 210);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(66, 13);
            this.lblTicketsSold.TabIndex = 3;
            this.lblTicketsSold.Text = "Tickets Sold";
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Location = new System.Drawing.Point(77, 151);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(32, 13);
            this.lblActor.TabIndex = 2;
            this.lblActor.Text = "Actor";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.BackColor = System.Drawing.Color.Transparent;
            this.lblMName.Location = new System.Drawing.Point(74, 93);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(67, 13);
            this.lblMName.TabIndex = 1;
            this.lblMName.Text = "Movie Name";
            // 
            // lblEnterMID
            // 
            this.lblEnterMID.AutoSize = true;
            this.lblEnterMID.Location = new System.Drawing.Point(71, 38);
            this.lblEnterMID.Name = "lblEnterMID";
            this.lblEnterMID.Size = new System.Drawing.Size(75, 13);
            this.lblEnterMID.TabIndex = 0;
            this.lblEnterMID.Text = "Enter MovieID";
            // 
            // tabShowMovies
            // 
            this.tabShowMovies.Controls.Add(this.dataGridView1);
            this.tabShowMovies.Location = new System.Drawing.Point(4, 22);
            this.tabShowMovies.Name = "tabShowMovies";
            this.tabShowMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowMovies.Size = new System.Drawing.Size(562, 314);
            this.tabShowMovies.TabIndex = 1;
            this.tabShowMovies.Text = " Show Movies";
            this.tabShowMovies.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabUpdateMovie
            // 
            this.tabUpdateMovie.Controls.Add(this.btnUpdate);
            this.tabUpdateMovie.Controls.Add(this.txtTicketsSold);
            this.tabUpdateMovie.Controls.Add(this.txtActor);
            this.tabUpdateMovie.Controls.Add(this.txtMName);
            this.tabUpdateMovie.Controls.Add(this.txtMId);
            this.tabUpdateMovie.Controls.Add(this.lbl1TicketsSold);
            this.tabUpdateMovie.Controls.Add(this.lbl1Actor);
            this.tabUpdateMovie.Controls.Add(this.lbl1MName);
            this.tabUpdateMovie.Controls.Add(this.lbl1MId);
            this.tabUpdateMovie.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateMovie.Name = "tabUpdateMovie";
            this.tabUpdateMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateMovie.Size = new System.Drawing.Size(562, 314);
            this.tabUpdateMovie.TabIndex = 2;
            this.tabUpdateMovie.Text = "Update Movie";
            this.tabUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTicketsSold
            // 
            this.txtTicketsSold.Location = new System.Drawing.Point(269, 222);
            this.txtTicketsSold.Name = "txtTicketsSold";
            this.txtTicketsSold.Size = new System.Drawing.Size(125, 20);
            this.txtTicketsSold.TabIndex = 7;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(269, 164);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(125, 20);
            this.txtActor.TabIndex = 6;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(269, 93);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(125, 20);
            this.txtMName.TabIndex = 5;
            // 
            // txtMId
            // 
            this.txtMId.Location = new System.Drawing.Point(269, 38);
            this.txtMId.Name = "txtMId";
            this.txtMId.Size = new System.Drawing.Size(125, 20);
            this.txtMId.TabIndex = 4;
            // 
            // lbl1TicketsSold
            // 
            this.lbl1TicketsSold.AutoSize = true;
            this.lbl1TicketsSold.Location = new System.Drawing.Point(85, 225);
            this.lbl1TicketsSold.Name = "lbl1TicketsSold";
            this.lbl1TicketsSold.Size = new System.Drawing.Size(63, 13);
            this.lbl1TicketsSold.TabIndex = 3;
            this.lbl1TicketsSold.Text = "TicketsSold";
            // 
            // lbl1Actor
            // 
            this.lbl1Actor.AutoSize = true;
            this.lbl1Actor.Location = new System.Drawing.Point(85, 164);
            this.lbl1Actor.Name = "lbl1Actor";
            this.lbl1Actor.Size = new System.Drawing.Size(32, 13);
            this.lbl1Actor.TabIndex = 2;
            this.lbl1Actor.Text = "Actor";
            // 
            // lbl1MName
            // 
            this.lbl1MName.AutoSize = true;
            this.lbl1MName.Location = new System.Drawing.Point(85, 93);
            this.lbl1MName.Name = "lbl1MName";
            this.lbl1MName.Size = new System.Drawing.Size(64, 13);
            this.lbl1MName.TabIndex = 1;
            this.lbl1MName.Text = "MovieName";
            // 
            // lbl1MId
            // 
            this.lbl1MId.AutoSize = true;
            this.lbl1MId.Location = new System.Drawing.Point(85, 38);
            this.lbl1MId.Name = "lbl1MId";
            this.lbl1MId.Size = new System.Drawing.Size(48, 13);
            this.lbl1MId.TabIndex = 0;
            this.lbl1MId.Text = "Movie Id";
            // 
            // btnShowOnlyMName
            // 
            this.btnShowOnlyMName.Location = new System.Drawing.Point(279, 246);
            this.btnShowOnlyMName.Name = "btnShowOnlyMName";
            this.btnShowOnlyMName.Size = new System.Drawing.Size(152, 23);
            this.btnShowOnlyMName.TabIndex = 9;
            this.btnShowOnlyMName.Text = "Show Only Movie Name";
            this.btnShowOnlyMName.UseVisualStyleBackColor = true;
            this.btnShowOnlyMName.Click += new System.EventHandler(this.btnShowOnlyMName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMovieDetails.ResumeLayout(false);
            this.tabMovieDetails.PerformLayout();
            this.tabShowMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabUpdateMovie.ResumeLayout(false);
            this.tabUpdateMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMovieDetails;
        private System.Windows.Forms.TabPage tabShowMovies;
        private System.Windows.Forms.TabPage tabUpdateMovie;
        private System.Windows.Forms.Label lblvalueTicketsSold;
        private System.Windows.Forms.Label lblvalueActor;
        private System.Windows.Forms.Label lblvalueMName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtEnterMId;
        private System.Windows.Forms.Label lblTicketsSold;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblEnterMID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTicketsSold;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtMId;
        private System.Windows.Forms.Label lbl1TicketsSold;
        private System.Windows.Forms.Label lbl1Actor;
        private System.Windows.Forms.Label lbl1MName;
        private System.Windows.Forms.Label lbl1MId;
        private System.Windows.Forms.Button btnShowOnlyMName;
    }
}

