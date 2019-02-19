namespace ConnectionStringTester
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.buttonRunQuery = new System.Windows.Forms.Button();
            this.textBoxSQLQuery = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSourceResults = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCheckConnection = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonCheckConnection);
            this.groupBox2.Controls.Add(this.comboBoxProvider);
            this.groupBox2.Controls.Add(this.dataGridViewResults);
            this.groupBox2.Controls.Add(this.buttonRunQuery);
            this.groupBox2.Controls.Add(this.textBoxSQLQuery);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxConnectionString);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 386);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Connection";
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(104, 19);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(482, 21);
            this.comboBoxProvider.Sorted = true;
            this.comboBoxProvider.TabIndex = 4;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(14, 220);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.Size = new System.Drawing.Size(572, 160);
            this.dataGridViewResults.TabIndex = 9;
            // 
            // buttonRunQuery
            // 
            this.buttonRunQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRunQuery.Location = new System.Drawing.Point(482, 171);
            this.buttonRunQuery.Name = "buttonRunQuery";
            this.buttonRunQuery.Size = new System.Drawing.Size(104, 43);
            this.buttonRunQuery.TabIndex = 8;
            this.buttonRunQuery.Text = "Run";
            this.buttonRunQuery.UseVisualStyleBackColor = true;
            this.buttonRunQuery.Click += new System.EventHandler(this.buttonRunQuery_Click);
            // 
            // textBoxSQLQuery
            // 
            this.textBoxSQLQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSQLQuery.Location = new System.Drawing.Point(104, 145);
            this.textBoxSQLQuery.Name = "textBoxSQLQuery";
            this.textBoxSQLQuery.Size = new System.Drawing.Size(482, 20);
            this.textBoxSQLQuery.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SQL Query : ";
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConnectionString.Location = new System.Drawing.Point(104, 46);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(482, 20);
            this.textBoxConnectionString.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection String :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provider : ";
            // 
            // bindingSourceResults
            // 
            this.bindingSourceResults.AllowNew = false;
            // 
            // buttonCheckConnection
            // 
            this.buttonCheckConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCheckConnection.Location = new System.Drawing.Point(482, 72);
            this.buttonCheckConnection.Name = "buttonCheckConnection";
            this.buttonCheckConnection.Size = new System.Drawing.Size(104, 67);
            this.buttonCheckConnection.TabIndex = 10;
            this.buttonCheckConnection.Text = "Check";
            this.buttonCheckConnection.UseVisualStyleBackColor = true;
            this.buttonCheckConnection.Click += new System.EventHandler(this.buttonCheckConnection_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 410);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Connection String Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button buttonRunQuery;
        private System.Windows.Forms.TextBox textBoxSQLQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSourceResults;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Button buttonCheckConnection;
    }
}

