﻿namespace RestaurantAutomation.UI.Forms
{
    partial class OrderForm
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
            btnMainMenu = new Button();
            label1 = new Label();
            lblOrderStatus = new Label();
            lblTotalAmount = new Label();
            lblOrderNotes = new Label();
            btnStarters = new Button();
            btnMainCourses = new Button();
            btnDesserts = new Button();
            btnBeverages = new Button();
            dataGridView1 = new DataGridView();
            btnCancelOrder = new Button();
            btnPayment = new Button();
            btnAddNote = new Button();
            btnOrderHistory = new Button();
            label2 = new Label();
            cmbTableNo = new ComboBox();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(12, 12);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(45, 28);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "🡰";
            btnMainMenu.TextAlign = ContentAlignment.TopCenter;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Table No:";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(171, 58);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(52, 20);
            lblOrderStatus.TabIndex = 1;
            lblOrderStatus.Text = "Status:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(312, 58);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(45, 20);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "Total:";
            // 
            // lblOrderNotes
            // 
            lblOrderNotes.AutoSize = true;
            lblOrderNotes.Location = new Point(490, 58);
            lblOrderNotes.Name = "lblOrderNotes";
            lblOrderNotes.Size = new Size(45, 20);
            lblOrderNotes.TabIndex = 1;
            lblOrderNotes.Text = "Note:";
            // 
            // btnStarters
            // 
            btnStarters.Location = new Point(31, 105);
            btnStarters.Name = "btnStarters";
            btnStarters.Size = new Size(107, 29);
            btnStarters.TabIndex = 2;
            btnStarters.Text = "Starters";
            btnStarters.UseVisualStyleBackColor = true;
            btnStarters.Click += btnStarters_Click;
            // 
            // btnMainCourses
            // 
            btnMainCourses.Location = new Point(31, 152);
            btnMainCourses.Name = "btnMainCourses";
            btnMainCourses.Size = new Size(107, 29);
            btnMainCourses.TabIndex = 2;
            btnMainCourses.Text = "Main Courses";
            btnMainCourses.UseVisualStyleBackColor = true;
            btnMainCourses.Click += btnMainCourses_Click;
            // 
            // btnDesserts
            // 
            btnDesserts.Location = new Point(31, 198);
            btnDesserts.Name = "btnDesserts";
            btnDesserts.Size = new Size(107, 29);
            btnDesserts.TabIndex = 2;
            btnDesserts.Text = "Desserts";
            btnDesserts.UseVisualStyleBackColor = true;
            btnDesserts.Click += btnDesserts_Click;
            // 
            // btnBeverages
            // 
            btnBeverages.Location = new Point(31, 246);
            btnBeverages.Name = "btnBeverages";
            btnBeverages.Size = new Size(109, 29);
            btnBeverages.TabIndex = 2;
            btnBeverages.Text = "Beverages";
            btnBeverages.UseVisualStyleBackColor = true;
            btnBeverages.Click += btnBeverages_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(171, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(637, 201);
            dataGridView1.TabIndex = 3;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(272, 310);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(94, 58);
            btnCancelOrder.TabIndex = 2;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(398, 310);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(94, 58);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(518, 310);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(94, 58);
            btnAddNote.TabIndex = 2;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.Location = new Point(643, 310);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Size = new Size(94, 58);
            btnOrderHistory.TabIndex = 2;
            btnOrderHistory.Text = "Order History";
            btnOrderHistory.UseVisualStyleBackColor = true;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(428, 12);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 5;
            label2.Text = "Order Management";
            // 
            // cmbTableNo
            // 
            cmbTableNo.FormattingEnabled = true;
            cmbTableNo.Location = new Point(102, 55);
            cmbTableNo.Name = "cmbTableNo";
            cmbTableNo.Size = new Size(50, 28);
            cmbTableNo.TabIndex = 6;
            cmbTableNo.SelectedIndexChanged += cmbTableNo_SelectedIndexChanged;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(519, 58);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 20);
            lbl.TabIndex = 7;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 399);
            ControlBox = false;
            Controls.Add(lbl);
            Controls.Add(cmbTableNo);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnOrderHistory);
            Controls.Add(btnAddNote);
            Controls.Add(btnPayment);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnBeverages);
            Controls.Add(btnDesserts);
            Controls.Add(btnMainCourses);
            Controls.Add(btnStarters);
            Controls.Add(lblOrderNotes);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblOrderStatus);
            Controls.Add(label1);
            Controls.Add(btnMainMenu);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMainMenu;
        private Label label1;
        private Label lblOrderStatus;
        private Label lblTotalAmount;
        private Label lblOrderNotes;
        private Button btnStarters;
        private Button btnMainCourses;
        private Button btnDesserts;
        private Button btnBeverages;
        private DataGridView dataGridView1;
        private Button btnCancelOrder;
        private Button btnPayment;
        private Button btnAddNote;
        private Button btnOrderHistory;
        private Label label2;
        private ComboBox cmbTableNo;
        private Label lbl;
    }
}