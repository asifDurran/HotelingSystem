namespace HotelManagmentApp
{
    partial class ManageRooms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFree = new System.Windows.Forms.Panel();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.Free = new System.Windows.Forms.Label();
            this.comboRoomType = new System.Windows.Forms.ComboBox();
            this.buttonResetClient = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.buttonInsertRoom = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.textRoomPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textRoomNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelFree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panelFree);
            this.panel1.Controls.Add(this.Free);
            this.panel1.Controls.Add(this.comboRoomType);
            this.panel1.Controls.Add(this.buttonResetClient);
            this.panel1.Controls.Add(this.buttonEditRoom);
            this.panel1.Controls.Add(this.buttonRemoveRoom);
            this.panel1.Controls.Add(this.buttonInsertRoom);
            this.panel1.Controls.Add(this.dataGridViewRooms);
            this.panel1.Controls.Add(this.textRoomPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textRoomNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 534);
            this.panel1.TabIndex = 1;
            // 
            // panelFree
            // 
            this.panelFree.BackColor = System.Drawing.Color.White;
            this.panelFree.Controls.Add(this.radioButtonNo);
            this.panelFree.Controls.Add(this.radioButtonYes);
            this.panelFree.Location = new System.Drawing.Point(163, 319);
            this.panelFree.Name = "panelFree";
            this.panelFree.Size = new System.Drawing.Size(208, 57);
            this.panelFree.TabIndex = 18;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.ForeColor = System.Drawing.Color.Red;
            this.radioButtonNo.Location = new System.Drawing.Point(119, 12);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(49, 24);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.ForeColor = System.Drawing.Color.Green;
            this.radioButtonYes.Location = new System.Drawing.Point(3, 12);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(58, 24);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // Free
            // 
            this.Free.AutoSize = true;
            this.Free.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Free.Location = new System.Drawing.Point(78, 331);
            this.Free.Name = "Free";
            this.Free.Size = new System.Drawing.Size(60, 24);
            this.Free.TabIndex = 17;
            this.Free.Text = "Free:";
            // 
            // comboRoomType
            // 
            this.comboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoomType.FormattingEnabled = true;
            this.comboRoomType.Items.AddRange(new object[] {
            "",
            "Single",
            "Double\t",
            "Suite",
            "Falimy"});
            this.comboRoomType.Location = new System.Drawing.Point(163, 192);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(231, 32);
            this.comboRoomType.TabIndex = 16;
            // 
            // buttonResetClient
            // 
            this.buttonResetClient.BackColor = System.Drawing.Color.White;
            this.buttonResetClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonResetClient.Location = new System.Drawing.Point(3, 469);
            this.buttonResetClient.Name = "buttonResetClient";
            this.buttonResetClient.Size = new System.Drawing.Size(407, 53);
            this.buttonResetClient.TabIndex = 15;
            this.buttonResetClient.Text = "Clear Fields";
            this.buttonResetClient.UseVisualStyleBackColor = false;
            this.buttonResetClient.Click += new System.EventHandler(this.buttonResetClient_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.BackColor = System.Drawing.Color.White;
            this.buttonEditRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEditRoom.Location = new System.Drawing.Point(163, 401);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(97, 52);
            this.buttonEditRoom.TabIndex = 14;
            this.buttonEditRoom.Text = "Edit";
            this.buttonEditRoom.UseVisualStyleBackColor = false;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.BackColor = System.Drawing.Color.White;
            this.buttonRemoveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemoveRoom.Location = new System.Drawing.Point(266, 401);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(144, 52);
            this.buttonRemoveRoom.TabIndex = 13;
            this.buttonRemoveRoom.Text = "Remove";
            this.buttonRemoveRoom.UseVisualStyleBackColor = false;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.buttonRemoveRoom_Click);
            // 
            // buttonInsertRoom
            // 
            this.buttonInsertRoom.BackColor = System.Drawing.Color.White;
            this.buttonInsertRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInsertRoom.Location = new System.Drawing.Point(3, 401);
            this.buttonInsertRoom.Name = "buttonInsertRoom";
            this.buttonInsertRoom.Size = new System.Drawing.Size(154, 52);
            this.buttonInsertRoom.TabIndex = 12;
            this.buttonInsertRoom.Text = "Add New Room";
            this.buttonInsertRoom.UseVisualStyleBackColor = false;
            this.buttonInsertRoom.Click += new System.EventHandler(this.buttonInsertRoom_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(416, 128);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.Size = new System.Drawing.Size(535, 394);
            this.dataGridViewRooms.TabIndex = 11;
            this.dataGridViewRooms.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRooms_RowHeaderMouseClick);
            // 
            // textRoomPhone
            // 
            this.textRoomPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRoomPhone.Location = new System.Drawing.Point(163, 256);
            this.textRoomPhone.Name = "textRoomPhone";
            this.textRoomPhone.Size = new System.Drawing.Size(231, 29);
            this.textRoomPhone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Type:";
            // 
            // textRoomNumber
            // 
            this.textRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRoomNumber.Location = new System.Drawing.Point(163, 128);
            this.textRoomNumber.Name = "textRoomNumber";
            this.textRoomNumber.Size = new System.Drawing.Size(122, 29);
            this.textRoomNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 94);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(419, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 534);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFree.ResumeLayout(false);
            this.panelFree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonResetClient;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Button buttonInsertRoom;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.TextBox textRoomPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Free;
        private System.Windows.Forms.ComboBox comboRoomType;
        private System.Windows.Forms.Panel panelFree;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
    }
}