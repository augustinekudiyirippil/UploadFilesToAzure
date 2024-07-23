
namespace AppToCopyFiles
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
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabGeneralAttachments = new System.Windows.Forms.TabPage();
            this.btnUploadToAzure = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.gridGeneralAttachments = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.tabIncomingEmailAttachments = new System.Windows.Forms.TabPage();
            this.btnUploadIncomingToAzure = new System.Windows.Forms.Button();
            this.lblErrorIncomingAttachments = new System.Windows.Forms.Label();
            this.gridIncomingAttachments = new System.Windows.Forms.DataGridView();
            this.btnCSVIncomingAttachment = new System.Windows.Forms.Button();
            this.btnExportIncommingAttachmenys = new System.Windows.Forms.Button();
            this.btnShowIncomingAttachments = new System.Windows.Forms.Button();
            this.tabOutgoingEmailAttachments = new System.Windows.Forms.TabPage();
            this.cmdCreateContainer = new System.Windows.Forms.Button();
            this.btnUploadOutgoingToAzure = new System.Windows.Forms.Button();
            this.lblErrorOutgoingAttachments = new System.Windows.Forms.Label();
            this.btnCSVOutgoingAttachment = new System.Windows.Forms.Button();
            this.btnExportOutgoingAttachmenys = new System.Windows.Forms.Button();
            this.gridOutgoingAttachments = new System.Windows.Forms.DataGridView();
            this.btnShowOutgoingAttachments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContainer = new System.Windows.Forms.TextBox();
            this.cmdContainers = new System.Windows.Forms.Button();
            this.cmbContainers = new System.Windows.Forms.ComboBox();
            this.tabData.SuspendLayout();
            this.tabGeneralAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneralAttachments)).BeginInit();
            this.tabIncomingEmailAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncomingAttachments)).BeginInit();
            this.tabOutgoingEmailAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutgoingAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tabGeneralAttachments);
            this.tabData.Controls.Add(this.tabIncomingEmailAttachments);
            this.tabData.Controls.Add(this.tabOutgoingEmailAttachments);
            this.tabData.Location = new System.Drawing.Point(26, 72);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1253, 683);
            this.tabData.TabIndex = 0;
            // 
            // tabGeneralAttachments
            // 
            this.tabGeneralAttachments.Controls.Add(this.btnUploadToAzure);
            this.tabGeneralAttachments.Controls.Add(this.btnCSV);
            this.tabGeneralAttachments.Controls.Add(this.lblError);
            this.tabGeneralAttachments.Controls.Add(this.btnCopy);
            this.tabGeneralAttachments.Controls.Add(this.gridGeneralAttachments);
            this.tabGeneralAttachments.Controls.Add(this.btnShow);
            this.tabGeneralAttachments.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralAttachments.Name = "tabGeneralAttachments";
            this.tabGeneralAttachments.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralAttachments.Size = new System.Drawing.Size(1245, 657);
            this.tabGeneralAttachments.TabIndex = 0;
            this.tabGeneralAttachments.Text = "General attachments        ";
            this.tabGeneralAttachments.UseVisualStyleBackColor = true;
            // 
            // btnUploadToAzure
            // 
            this.btnUploadToAzure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadToAzure.Location = new System.Drawing.Point(383, 21);
            this.btnUploadToAzure.Name = "btnUploadToAzure";
            this.btnUploadToAzure.Size = new System.Drawing.Size(140, 37);
            this.btnUploadToAzure.TabIndex = 9;
            this.btnUploadToAzure.Text = "Upload to Azure";
            this.btnUploadToAzure.UseVisualStyleBackColor = true;
            this.btnUploadToAzure.Click += new System.EventHandler(this.btnUploadToAzure_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSV.Location = new System.Drawing.Point(256, 21);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(100, 37);
            this.btnCSV.TabIndex = 8;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(10, 604);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(167, 17);
            this.lblError.TabIndex = 7;
            this.lblError.Text = " Exception message here";
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(136, 21);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 37);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Export";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gridGeneralAttachments
            // 
            this.gridGeneralAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGeneralAttachments.Location = new System.Drawing.Point(6, 64);
            this.gridGeneralAttachments.Name = "gridGeneralAttachments";
            this.gridGeneralAttachments.Size = new System.Drawing.Size(1202, 519);
            this.gridGeneralAttachments.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(13, 21);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 37);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tabIncomingEmailAttachments
            // 
            this.tabIncomingEmailAttachments.Controls.Add(this.btnUploadIncomingToAzure);
            this.tabIncomingEmailAttachments.Controls.Add(this.lblErrorIncomingAttachments);
            this.tabIncomingEmailAttachments.Controls.Add(this.gridIncomingAttachments);
            this.tabIncomingEmailAttachments.Controls.Add(this.btnCSVIncomingAttachment);
            this.tabIncomingEmailAttachments.Controls.Add(this.btnExportIncommingAttachmenys);
            this.tabIncomingEmailAttachments.Controls.Add(this.btnShowIncomingAttachments);
            this.tabIncomingEmailAttachments.Location = new System.Drawing.Point(4, 22);
            this.tabIncomingEmailAttachments.Name = "tabIncomingEmailAttachments";
            this.tabIncomingEmailAttachments.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncomingEmailAttachments.Size = new System.Drawing.Size(1245, 657);
            this.tabIncomingEmailAttachments.TabIndex = 1;
            this.tabIncomingEmailAttachments.Text = "Incoming email attachments     ";
            this.tabIncomingEmailAttachments.UseVisualStyleBackColor = true;
            // 
            // btnUploadIncomingToAzure
            // 
            this.btnUploadIncomingToAzure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadIncomingToAzure.Location = new System.Drawing.Point(385, 16);
            this.btnUploadIncomingToAzure.Name = "btnUploadIncomingToAzure";
            this.btnUploadIncomingToAzure.Size = new System.Drawing.Size(140, 37);
            this.btnUploadIncomingToAzure.TabIndex = 12;
            this.btnUploadIncomingToAzure.Text = "Upload to Azure";
            this.btnUploadIncomingToAzure.UseVisualStyleBackColor = true;
            this.btnUploadIncomingToAzure.Click += new System.EventHandler(this.btnUploadIncomingToAzure_Click);
            // 
            // lblErrorIncomingAttachments
            // 
            this.lblErrorIncomingAttachments.AutoSize = true;
            this.lblErrorIncomingAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIncomingAttachments.ForeColor = System.Drawing.Color.Red;
            this.lblErrorIncomingAttachments.Location = new System.Drawing.Point(17, 599);
            this.lblErrorIncomingAttachments.Name = "lblErrorIncomingAttachments";
            this.lblErrorIncomingAttachments.Size = new System.Drawing.Size(167, 17);
            this.lblErrorIncomingAttachments.TabIndex = 11;
            this.lblErrorIncomingAttachments.Text = " Exception message here";
            // 
            // gridIncomingAttachments
            // 
            this.gridIncomingAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIncomingAttachments.Location = new System.Drawing.Point(13, 59);
            this.gridIncomingAttachments.Name = "gridIncomingAttachments";
            this.gridIncomingAttachments.Size = new System.Drawing.Size(1202, 519);
            this.gridIncomingAttachments.TabIndex = 10;
            // 
            // btnCSVIncomingAttachment
            // 
            this.btnCSVIncomingAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVIncomingAttachment.Location = new System.Drawing.Point(257, 16);
            this.btnCSVIncomingAttachment.Name = "btnCSVIncomingAttachment";
            this.btnCSVIncomingAttachment.Size = new System.Drawing.Size(100, 37);
            this.btnCSVIncomingAttachment.TabIndex = 9;
            this.btnCSVIncomingAttachment.Text = "CSV";
            this.btnCSVIncomingAttachment.UseVisualStyleBackColor = true;
            this.btnCSVIncomingAttachment.Click += new System.EventHandler(this.btnCSVIncomingAttachment_Click);
            // 
            // btnExportIncommingAttachmenys
            // 
            this.btnExportIncommingAttachmenys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportIncommingAttachmenys.Location = new System.Drawing.Point(136, 16);
            this.btnExportIncommingAttachmenys.Name = "btnExportIncommingAttachmenys";
            this.btnExportIncommingAttachmenys.Size = new System.Drawing.Size(100, 37);
            this.btnExportIncommingAttachmenys.TabIndex = 7;
            this.btnExportIncommingAttachmenys.Text = "Export";
            this.btnExportIncommingAttachmenys.UseVisualStyleBackColor = true;
            this.btnExportIncommingAttachmenys.Click += new System.EventHandler(this.btnExportIncommingAttachmenys_Click);
            // 
            // btnShowIncomingAttachments
            // 
            this.btnShowIncomingAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowIncomingAttachments.Location = new System.Drawing.Point(13, 16);
            this.btnShowIncomingAttachments.Name = "btnShowIncomingAttachments";
            this.btnShowIncomingAttachments.Size = new System.Drawing.Size(100, 37);
            this.btnShowIncomingAttachments.TabIndex = 6;
            this.btnShowIncomingAttachments.Text = "Show";
            this.btnShowIncomingAttachments.UseVisualStyleBackColor = true;
            this.btnShowIncomingAttachments.Click += new System.EventHandler(this.btnShowIncomingAttachments_Click);
            // 
            // tabOutgoingEmailAttachments
            // 
            this.tabOutgoingEmailAttachments.Controls.Add(this.cmdCreateContainer);
            this.tabOutgoingEmailAttachments.Controls.Add(this.btnUploadOutgoingToAzure);
            this.tabOutgoingEmailAttachments.Controls.Add(this.lblErrorOutgoingAttachments);
            this.tabOutgoingEmailAttachments.Controls.Add(this.btnCSVOutgoingAttachment);
            this.tabOutgoingEmailAttachments.Controls.Add(this.btnExportOutgoingAttachmenys);
            this.tabOutgoingEmailAttachments.Controls.Add(this.gridOutgoingAttachments);
            this.tabOutgoingEmailAttachments.Controls.Add(this.btnShowOutgoingAttachments);
            this.tabOutgoingEmailAttachments.Location = new System.Drawing.Point(4, 22);
            this.tabOutgoingEmailAttachments.Name = "tabOutgoingEmailAttachments";
            this.tabOutgoingEmailAttachments.Size = new System.Drawing.Size(1245, 657);
            this.tabOutgoingEmailAttachments.TabIndex = 2;
            this.tabOutgoingEmailAttachments.Text = "Outgoing email attachments          ";
            this.tabOutgoingEmailAttachments.UseVisualStyleBackColor = true;
            // 
            // cmdCreateContainer
            // 
            this.cmdCreateContainer.Location = new System.Drawing.Point(597, 15);
            this.cmdCreateContainer.Name = "cmdCreateContainer";
            this.cmdCreateContainer.Size = new System.Drawing.Size(230, 36);
            this.cmdCreateContainer.TabIndex = 15;
            this.cmdCreateContainer.Text = "Create Container";
            this.cmdCreateContainer.UseVisualStyleBackColor = true;
            this.cmdCreateContainer.Click += new System.EventHandler(this.cmdCreateContainer_Click);
            // 
            // btnUploadOutgoingToAzure
            // 
            this.btnUploadOutgoingToAzure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadOutgoingToAzure.Location = new System.Drawing.Point(394, 15);
            this.btnUploadOutgoingToAzure.Name = "btnUploadOutgoingToAzure";
            this.btnUploadOutgoingToAzure.Size = new System.Drawing.Size(140, 37);
            this.btnUploadOutgoingToAzure.TabIndex = 14;
            this.btnUploadOutgoingToAzure.Text = "Upload to Azure";
            this.btnUploadOutgoingToAzure.UseVisualStyleBackColor = true;
            this.btnUploadOutgoingToAzure.Click += new System.EventHandler(this.btnUploadOutgoingToAzure_Click);
            // 
            // lblErrorOutgoingAttachments
            // 
            this.lblErrorOutgoingAttachments.AutoSize = true;
            this.lblErrorOutgoingAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOutgoingAttachments.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOutgoingAttachments.Location = new System.Drawing.Point(17, 613);
            this.lblErrorOutgoingAttachments.Name = "lblErrorOutgoingAttachments";
            this.lblErrorOutgoingAttachments.Size = new System.Drawing.Size(167, 17);
            this.lblErrorOutgoingAttachments.TabIndex = 13;
            this.lblErrorOutgoingAttachments.Text = " Exception message here";
            // 
            // btnCSVOutgoingAttachment
            // 
            this.btnCSVOutgoingAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVOutgoingAttachment.Location = new System.Drawing.Point(263, 15);
            this.btnCSVOutgoingAttachment.Name = "btnCSVOutgoingAttachment";
            this.btnCSVOutgoingAttachment.Size = new System.Drawing.Size(100, 37);
            this.btnCSVOutgoingAttachment.TabIndex = 12;
            this.btnCSVOutgoingAttachment.Text = "CSV";
            this.btnCSVOutgoingAttachment.UseVisualStyleBackColor = true;
            this.btnCSVOutgoingAttachment.Click += new System.EventHandler(this.btnCSVOutgoingAttachment_Click);
            // 
            // btnExportOutgoingAttachmenys
            // 
            this.btnExportOutgoingAttachmenys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportOutgoingAttachmenys.Location = new System.Drawing.Point(143, 15);
            this.btnExportOutgoingAttachmenys.Name = "btnExportOutgoingAttachmenys";
            this.btnExportOutgoingAttachmenys.Size = new System.Drawing.Size(100, 37);
            this.btnExportOutgoingAttachmenys.TabIndex = 11;
            this.btnExportOutgoingAttachmenys.Text = "Export";
            this.btnExportOutgoingAttachmenys.UseVisualStyleBackColor = true;
            this.btnExportOutgoingAttachmenys.Click += new System.EventHandler(this.btnExportOutgoingAttachmenys_Click);
            // 
            // gridOutgoingAttachments
            // 
            this.gridOutgoingAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutgoingAttachments.Location = new System.Drawing.Point(13, 65);
            this.gridOutgoingAttachments.Name = "gridOutgoingAttachments";
            this.gridOutgoingAttachments.Size = new System.Drawing.Size(1202, 519);
            this.gridOutgoingAttachments.TabIndex = 9;
            // 
            // btnShowOutgoingAttachments
            // 
            this.btnShowOutgoingAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOutgoingAttachments.Location = new System.Drawing.Point(20, 15);
            this.btnShowOutgoingAttachments.Name = "btnShowOutgoingAttachments";
            this.btnShowOutgoingAttachments.Size = new System.Drawing.Size(100, 37);
            this.btnShowOutgoingAttachments.TabIndex = 10;
            this.btnShowOutgoingAttachments.Text = "Show";
            this.btnShowOutgoingAttachments.UseVisualStyleBackColor = true;
            this.btnShowOutgoingAttachments.Click += new System.EventHandler(this.btnShowOutgoingAttachments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Database  ";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(166, 24);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(266, 24);
            this.cmbDatabases.TabIndex = 2;
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(579, 24);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(124, 23);
            this.dtFromDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select from Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(737, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Container name";
            // 
            // txtContainer
            // 
            this.txtContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainer.Location = new System.Drawing.Point(844, 56);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(253, 23);
            this.txtContainer.TabIndex = 6;
            this.txtContainer.Text = "simplisysltd";
            this.txtContainer.Visible = false;
            // 
            // cmdContainers
            // 
            this.cmdContainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdContainers.Location = new System.Drawing.Point(1135, 24);
            this.cmdContainers.Name = "cmdContainers";
            this.cmdContainers.Size = new System.Drawing.Size(140, 37);
            this.cmdContainers.TabIndex = 10;
            this.cmdContainers.Text = "Containers";
            this.cmdContainers.UseVisualStyleBackColor = true;
            this.cmdContainers.Click += new System.EventHandler(this.cmdContainers_Click);
            // 
            // cmbContainers
            // 
            this.cmbContainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContainers.FormattingEnabled = true;
            this.cmbContainers.Location = new System.Drawing.Point(844, 28);
            this.cmbContainers.Name = "cmbContainers";
            this.cmbContainers.Size = new System.Drawing.Size(253, 24);
            this.cmbContainers.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 767);
            this.Controls.Add(this.cmbContainers);
            this.Controls.Add(this.cmdContainers);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDatabases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabData);
            this.Name = "Form1";
            this.Text = "Files to export";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabData.ResumeLayout(false);
            this.tabGeneralAttachments.ResumeLayout(false);
            this.tabGeneralAttachments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGeneralAttachments)).EndInit();
            this.tabIncomingEmailAttachments.ResumeLayout(false);
            this.tabIncomingEmailAttachments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncomingAttachments)).EndInit();
            this.tabOutgoingEmailAttachments.ResumeLayout(false);
            this.tabOutgoingEmailAttachments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutgoingAttachments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabGeneralAttachments;
        private System.Windows.Forms.TabPage tabIncomingEmailAttachments;
        private System.Windows.Forms.DataGridView gridGeneralAttachments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Label lblErrorIncomingAttachments;
        private System.Windows.Forms.DataGridView gridIncomingAttachments;
        private System.Windows.Forms.Button btnCSVIncomingAttachment;
        private System.Windows.Forms.Button btnExportIncommingAttachmenys;
        private System.Windows.Forms.Button btnShowIncomingAttachments;
        private System.Windows.Forms.TabPage tabOutgoingEmailAttachments;
        private System.Windows.Forms.Label lblErrorOutgoingAttachments;
        private System.Windows.Forms.Button btnCSVOutgoingAttachment;
        private System.Windows.Forms.Button btnExportOutgoingAttachmenys;
        private System.Windows.Forms.DataGridView gridOutgoingAttachments;
        private System.Windows.Forms.Button btnShowOutgoingAttachments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContainer;
        private System.Windows.Forms.Button btnUploadToAzure;
        private System.Windows.Forms.Button btnUploadIncomingToAzure;
        private System.Windows.Forms.Button btnUploadOutgoingToAzure;
        private System.Windows.Forms.Button cmdCreateContainer;
        private System.Windows.Forms.Button cmdContainers;
        private System.Windows.Forms.ComboBox cmbContainers;
    }
}

