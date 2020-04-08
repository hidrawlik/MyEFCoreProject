namespace DB_Requester
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnect = new System.Windows.Forms.Button();
            this.datGridDBTables = new System.Windows.Forms.DataGridView();
            this.datGridSQLResult = new System.Windows.Forms.DataGridView();
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.labDatSource = new System.Windows.Forms.Label();
            this.labInitCat = new System.Windows.Forms.Label();
            this.tbInitCat = new System.Windows.Forms.TextBox();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.labSQLReq = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datGridDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(535, 66);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 26);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // datGridDBTables
            // 
            this.datGridDBTables.AccessibleName = "";
            this.datGridDBTables.AllowUserToAddRows = false;
            this.datGridDBTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datGridDBTables.Location = new System.Drawing.Point(17, 113);
            this.datGridDBTables.Name = "datGridDBTables";
            this.datGridDBTables.Size = new System.Drawing.Size(638, 180);
            this.datGridDBTables.TabIndex = 3;
            this.datGridDBTables.MouseUp += new System.Windows.Forms.MouseEventHandler(this.datGridDBTables_MouseUp);
            // 
            // datGridSQLResult
            // 
            this.datGridSQLResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridSQLResult.Location = new System.Drawing.Point(17, 345);
            this.datGridSQLResult.Name = "datGridSQLResult";
            this.datGridSQLResult.Size = new System.Drawing.Size(638, 180);
            this.datGridSQLResult.TabIndex = 6;
            // 
            // tbDatSource
            // 
            this.tbDatSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDatSource.Location = new System.Drawing.Point(159, 25);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(496, 26);
            this.tbDatSource.TabIndex = 0;
            this.tbDatSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDatSource_KeyPress);
            // 
            // labDatSource
            // 
            this.labDatSource.AutoSize = true;
            this.labDatSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDatSource.Location = new System.Drawing.Point(23, 25);
            this.labDatSource.Name = "labDatSource";
            this.labDatSource.Size = new System.Drawing.Size(130, 24);
            this.labDatSource.TabIndex = 7;
            this.labDatSource.Text = "Data Source:";
            // 
            // labInitCat
            // 
            this.labInitCat.AutoSize = true;
            this.labInitCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInitCat.Location = new System.Drawing.Point(13, 66);
            this.labInitCat.Name = "labInitCat";
            this.labInitCat.Size = new System.Drawing.Size(140, 24);
            this.labInitCat.TabIndex = 10;
            this.labInitCat.Text = "Initial Catalog:";
            // 
            // tbInitCat
            // 
            this.tbInitCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInitCat.Location = new System.Drawing.Point(159, 66);
            this.tbInitCat.Name = "tbInitCat";
            this.tbInitCat.Size = new System.Drawing.Size(370, 26);
            this.tbInitCat.TabIndex = 1;
            this.tbInitCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbInitCat_KeyPress);
            // 
            // tbRequest
            // 
            this.tbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRequest.Location = new System.Drawing.Point(159, 306);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(370, 26);
            this.tbRequest.TabIndex = 4;
            this.tbRequest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbRequest_KeyPress);
            // 
            // labSQLReq
            // 
            this.labSQLReq.AutoSize = true;
            this.labSQLReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSQLReq.Location = new System.Drawing.Point(13, 306);
            this.labSQLReq.Name = "labSQLReq";
            this.labSQLReq.Size = new System.Drawing.Size(139, 24);
            this.labSQLReq.TabIndex = 13;
            this.labSQLReq.Text = "SQL Request:";
            // 
            // btnRequest
            // 
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequest.Location = new System.Drawing.Point(535, 306);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(120, 26);
            this.btnRequest.TabIndex = 5;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 546);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.labSQLReq);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tbInitCat);
            this.Controls.Add(this.labInitCat);
            this.Controls.Add(this.labDatSource);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.datGridSQLResult);
            this.Controls.Add(this.datGridDBTables);
            this.Controls.Add(this.btnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Data Base Requests";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datGridDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView datGridDBTables;
        private System.Windows.Forms.DataGridView datGridSQLResult;
        private System.Windows.Forms.TextBox tbDatSource;
        private System.Windows.Forms.Label labDatSource;
        private System.Windows.Forms.Label labInitCat;
        private System.Windows.Forms.TextBox tbInitCat;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Label labSQLReq;
        private System.Windows.Forms.Button btnRequest;
    }
}

