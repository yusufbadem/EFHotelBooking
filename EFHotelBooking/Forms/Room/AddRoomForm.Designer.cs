namespace EFHotelBooking.Forms.Room;

partial class AddRoomForm
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
        lblName = new Label();
        txtName = new TextBox();
        txtDescription = new TextBox();
        label2 = new Label();
        txtPrice = new TextBox();
        label3 = new Label();
        txtCapacity = new TextBox();
        label4 = new Label();
        btnAdd = new Button();
        dgvRooms = new DataGridView();
        label1 = new Label();
        btnDelete = new Button();
        label5 = new Label();
        txtMin = new TextBox();
        txtMax = new TextBox();
        label6 = new Label();
        btnFilter = new Button();
        room = new Label();
        lblTotal = new Label();
        radioAll = new RadioButton();
        radioAvailable = new RadioButton();
        radioNotAvailable = new RadioButton();
        ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(61, 29);
        lblName.Name = "lblName";
        lblName.Size = new Size(49, 20);
        lblName.TabIndex = 0;
        lblName.Text = "Name";
        // 
        // txtName
        // 
        txtName.Location = new Point(159, 26);
        txtName.Name = "txtName";
        txtName.Size = new Size(125, 27);
        txtName.TabIndex = 1;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(159, 66);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(125, 27);
        txtDescription.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(64, 69);
        label2.Name = "label2";
        label2.Size = new Size(85, 20);
        label2.TabIndex = 2;
        label2.Text = "Description";
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(428, 26);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(125, 27);
        txtPrice.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(331, 29);
        label3.Name = "label3";
        label3.Size = new Size(41, 20);
        label3.TabIndex = 4;
        label3.Text = "Price";
        // 
        // txtCapacity
        // 
        txtCapacity.Location = new Point(428, 62);
        txtCapacity.Name = "txtCapacity";
        txtCapacity.Size = new Size(125, 27);
        txtCapacity.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(331, 69);
        label4.Name = "label4";
        label4.Size = new Size(66, 20);
        label4.TabIndex = 6;
        label4.Text = "Capacity";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(430, 105);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(123, 32);
        btnAdd.TabIndex = 8;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // dgvRooms
        // 
        dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRooms.Location = new Point(36, 296);
        dgvRooms.Name = "dgvRooms";
        dgvRooms.RowHeadersWidth = 51;
        dgvRooms.Size = new Size(711, 252);
        dgvRooms.TabIndex = 9;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15F);
        label1.Location = new Point(42, 185);
        label1.Name = "label1";
        label1.Size = new Size(123, 35);
        label1.TabIndex = 10;
        label1.Text = "ODALAR :";
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.IndianRed;
        btnDelete.Location = new Point(653, 205);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 42);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(42, 227);
        label5.Name = "label5";
        label5.Size = new Size(41, 20);
        label5.TabIndex = 12;
        label5.Text = "Min :";
        // 
        // txtMin
        // 
        txtMin.Location = new Point(82, 223);
        txtMin.Name = "txtMin";
        txtMin.Size = new Size(125, 27);
        txtMin.TabIndex = 13;
        // 
        // txtMax
        // 
        txtMax.Location = new Point(260, 220);
        txtMax.Name = "txtMax";
        txtMax.Size = new Size(125, 27);
        txtMax.TabIndex = 15;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(220, 224);
        label6.Name = "label6";
        label6.Size = new Size(44, 20);
        label6.TabIndex = 14;
        label6.Text = "Max :";
        // 
        // btnFilter
        // 
        btnFilter.Location = new Point(407, 218);
        btnFilter.Name = "btnFilter";
        btnFilter.Size = new Size(94, 29);
        btnFilter.TabIndex = 16;
        btnFilter.Text = "Filter";
        btnFilter.UseVisualStyleBackColor = true;
        btnFilter.Click += btnFilter_Click;
        // 
        // room
        // 
        room.AutoSize = true;
        room.Location = new Point(37, 265);
        room.Name = "room";
        room.Size = new Size(93, 20);
        room.TabIndex = 17;
        room.Text = "Total Room :";
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Location = new Point(128, 265);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(21, 20);
        lblTotal.TabIndex = 18;
        lblTotal.Text = " 0";
        // 
        // radioAll
        // 
        radioAll.AutoSize = true;
        radioAll.Checked = true;
        radioAll.Location = new Point(453, 267);
        radioAll.Name = "radioAll";
        radioAll.Size = new Size(48, 24);
        radioAll.TabIndex = 19;
        radioAll.TabStop = true;
        radioAll.Text = "All";
        radioAll.UseVisualStyleBackColor = true;
        radioAll.CheckedChanged += radioAll_CheckedChanged;
        // 
        // radioAvailable
        // 
        radioAvailable.AutoSize = true;
        radioAvailable.Location = new Point(514, 267);
        radioAvailable.Name = "radioAvailable";
        radioAvailable.Size = new Size(106, 24);
        radioAvailable.TabIndex = 20;
        radioAvailable.TabStop = true;
        radioAvailable.Text = "Is Available";
        radioAvailable.UseVisualStyleBackColor = true;
        radioAvailable.CheckedChanged += radioAvailable_CheckedChanged;
        // 
        // radioNotAvailable
        // 
        radioNotAvailable.AutoSize = true;
        radioNotAvailable.Location = new Point(626, 267);
        radioNotAvailable.Name = "radioNotAvailable";
        radioNotAvailable.Size = new Size(121, 24);
        radioNotAvailable.TabIndex = 21;
        radioNotAvailable.TabStop = true;
        radioNotAvailable.Text = "Not Available";
        radioNotAvailable.UseVisualStyleBackColor = true;
        radioNotAvailable.CheckedChanged += radioNotAvailable_CheckedChanged;
        // 
        // AddRoomForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 577);
        Controls.Add(radioNotAvailable);
        Controls.Add(radioAvailable);
        Controls.Add(radioAll);
        Controls.Add(lblTotal);
        Controls.Add(room);
        Controls.Add(btnFilter);
        Controls.Add(txtMax);
        Controls.Add(label6);
        Controls.Add(txtMin);
        Controls.Add(label5);
        Controls.Add(btnDelete);
        Controls.Add(label1);
        Controls.Add(dgvRooms);
        Controls.Add(btnAdd);
        Controls.Add(txtCapacity);
        Controls.Add(label4);
        Controls.Add(txtPrice);
        Controls.Add(label3);
        Controls.Add(txtDescription);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(lblName);
        Name = "AddRoomForm";
        Text = "AddRoomForm";
        Load += AddRoomForm_Load;
        ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblName;
    private TextBox txtName;
    private TextBox txtDescription;
    private Label label2;
    private TextBox txtPrice;
    private Label label3;
    private TextBox txtCapacity;
    private Label label4;
    private Button btnAdd;
    private DataGridView dgvRooms;
    private Label label1;
    private Button btnDelete;
    private Label label5;
    private TextBox txtMin;
    private TextBox txtMax;
    private Label label6;
    private Button btnFilter;
    private Label room;
    private Label lblTotal;
    private RadioButton radioAll;
    private RadioButton radioAvailable;
    private RadioButton radioNotAvailable;
}