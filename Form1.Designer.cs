namespace Washington_s_Pizza
{
    partial class frmPizza
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPizzaName = new Label();
            picPizza = new PictureBox();
            grpPizzaBox = new GroupBox();
            ckbExCheese = new CheckBox();
            ckbJalepeno = new CheckBox();
            ckbBanPeppers = new CheckBox();
            ckbMushroom = new CheckBox();
            ckbGOlives = new CheckBox();
            ckbBOlives = new CheckBox();
            ckbGPepper = new CheckBox();
            ckbOnion = new CheckBox();
            ckbSpicyItaSau = new CheckBox();
            ckbCanBacon = new CheckBox();
            ckbSausage = new CheckBox();
            ckbPepporoni = new CheckBox();
            lblToppings = new Label();
            lblCrust = new Label();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            lblSize = new Label();
            cboPizzaSize = new ComboBox();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            txtTotal = new TextBox();
            rtfOutput = new RichTextBox();
            lblOrderSum = new Label();
            BtnOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)picPizza).BeginInit();
            grpPizzaBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblPizzaName
            // 
            lblPizzaName.AutoSize = true;
            lblPizzaName.Font = new Font("Baskerville Old Face", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPizzaName.Location = new Point(15, 9);
            lblPizzaName.Name = "lblPizzaName";
            lblPizzaName.Size = new Size(398, 53);
            lblPizzaName.TabIndex = 0;
            lblPizzaName.Text = "Washington's Pizza";
            lblPizzaName.Click += lblPizzaName_Click;
            // 
            // picPizza
            // 
            picPizza.Image = Properties.Resources.istockphoto_1442417585_612x612;
            picPizza.Location = new Point(675, 12);
            picPizza.Name = "picPizza";
            picPizza.Size = new Size(612, 377);
            picPizza.TabIndex = 1;
            picPizza.TabStop = false;
            // 
            // grpPizzaBox
            // 
            grpPizzaBox.Controls.Add(ckbExCheese);
            grpPizzaBox.Controls.Add(ckbJalepeno);
            grpPizzaBox.Controls.Add(ckbBanPeppers);
            grpPizzaBox.Controls.Add(ckbMushroom);
            grpPizzaBox.Controls.Add(ckbGOlives);
            grpPizzaBox.Controls.Add(ckbBOlives);
            grpPizzaBox.Controls.Add(ckbGPepper);
            grpPizzaBox.Controls.Add(ckbOnion);
            grpPizzaBox.Controls.Add(ckbSpicyItaSau);
            grpPizzaBox.Controls.Add(ckbCanBacon);
            grpPizzaBox.Controls.Add(ckbSausage);
            grpPizzaBox.Controls.Add(ckbPepporoni);
            grpPizzaBox.Controls.Add(lblToppings);
            grpPizzaBox.Controls.Add(lblCrust);
            grpPizzaBox.Controls.Add(rdoRegular);
            grpPizzaBox.Controls.Add(rdoThick);
            grpPizzaBox.Controls.Add(rdoThin);
            grpPizzaBox.Controls.Add(lblSize);
            grpPizzaBox.Controls.Add(cboPizzaSize);
            grpPizzaBox.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPizzaBox.Location = new Point(15, 66);
            grpPizzaBox.Name = "grpPizzaBox";
            grpPizzaBox.Size = new Size(574, 323);
            grpPizzaBox.TabIndex = 2;
            grpPizzaBox.TabStop = false;
            // 
            // ckbExCheese
            // 
            ckbExCheese.AutoSize = true;
            ckbExCheese.Location = new Point(400, 248);
            ckbExCheese.Name = "ckbExCheese";
            ckbExCheese.Size = new Size(148, 27);
            ckbExCheese.TabIndex = 18;
            ckbExCheese.Text = "Extra Cheese";
            ckbExCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            ckbJalepeno.AutoSize = true;
            ckbJalepeno.Location = new Point(400, 201);
            ckbJalepeno.Name = "ckbJalepeno";
            ckbJalepeno.Size = new Size(109, 27);
            ckbJalepeno.TabIndex = 17;
            ckbJalepeno.Text = "Jalepeno";
            ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbBanPeppers
            // 
            ckbBanPeppers.AutoSize = true;
            ckbBanPeppers.Location = new Point(400, 164);
            ckbBanPeppers.Name = "ckbBanPeppers";
            ckbBanPeppers.Size = new Size(175, 27);
            ckbBanPeppers.TabIndex = 16;
            ckbBanPeppers.Text = "Banana Peppers";
            ckbBanPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Location = new Point(400, 294);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(136, 27);
            ckbMushroom.TabIndex = 15;
            ckbMushroom.Text = "Mushrooms";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbGOlives
            // 
            ckbGOlives.AutoSize = true;
            ckbGOlives.Location = new Point(217, 294);
            ckbGOlives.Name = "ckbGOlives";
            ckbGOlives.Size = new Size(149, 27);
            ckbGOlives.TabIndex = 14;
            ckbGOlives.Text = "Green Olives";
            ckbGOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBOlives
            // 
            ckbBOlives.AutoSize = true;
            ckbBOlives.Location = new Point(217, 248);
            ckbBOlives.Name = "ckbBOlives";
            ckbBOlives.Size = new Size(144, 27);
            ckbBOlives.TabIndex = 13;
            ckbBOlives.Text = "Black Olives";
            ckbBOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGPepper
            // 
            ckbGPepper.AutoSize = true;
            ckbGPepper.Location = new Point(217, 201);
            ckbGPepper.Name = "ckbGPepper";
            ckbGPepper.Size = new Size(156, 27);
            ckbGPepper.TabIndex = 12;
            ckbGPepper.Text = "Green Pepper";
            ckbGPepper.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Location = new Point(217, 164);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(88, 27);
            ckbOnion.TabIndex = 11;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItaSau
            // 
            ckbSpicyItaSau.AutoSize = true;
            ckbSpicyItaSau.Location = new Point(6, 294);
            ckbSpicyItaSau.Name = "ckbSpicyItaSau";
            ckbSpicyItaSau.Size = new Size(216, 27);
            ckbSpicyItaSau.TabIndex = 10;
            ckbSpicyItaSau.Text = "Spicy Italian Sausage";
            ckbSpicyItaSau.UseVisualStyleBackColor = true;
            // 
            // ckbCanBacon
            // 
            ckbCanBacon.AutoSize = true;
            ckbCanBacon.Location = new Point(6, 248);
            ckbCanBacon.Name = "ckbCanBacon";
            ckbCanBacon.Size = new Size(176, 27);
            ckbCanBacon.TabIndex = 9;
            ckbCanBacon.Text = "Canadian Bacon";
            ckbCanBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Location = new Point(6, 201);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(101, 27);
            ckbSausage.TabIndex = 8;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepporoni
            // 
            ckbPepporoni.AutoSize = true;
            ckbPepporoni.Location = new Point(6, 164);
            ckbPepporoni.Name = "ckbPepporoni";
            ckbPepporoni.Size = new Size(123, 27);
            ckbPepporoni.TabIndex = 7;
            ckbPepporoni.Text = "Pepperoni";
            ckbPepporoni.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Location = new Point(6, 124);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(98, 23);
            lblToppings.TabIndex = 6;
            lblToppings.Text = "Toppings:";
            // 
            // lblCrust
            // 
            lblCrust.AutoSize = true;
            lblCrust.Location = new Point(6, 82);
            lblCrust.Name = "lblCrust";
            lblCrust.Size = new Size(114, 23);
            lblCrust.TabIndex = 5;
            lblCrust.Text = "Crust Type:";
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(306, 78);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(99, 27);
            rdoRegular.TabIndex = 4;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Location = new Point(217, 78);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(83, 27);
            rdoThick.TabIndex = 3;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Location = new Point(137, 78);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(74, 27);
            rdoThin.TabIndex = 2;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(6, 37);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(52, 23);
            lblSize.TabIndex = 1;
            lblSize.Text = "Size:";
            // 
            // cboPizzaSize
            // 
            cboPizzaSize.FormattingEnabled = true;
            cboPizzaSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "GINORMOUS" });
            cboPizzaSize.Location = new Point(64, 29);
            cboPizzaSize.Name = "cboPizzaSize";
            cboPizzaSize.Size = new Size(151, 31);
            cboPizzaSize.TabIndex = 0;
            cboPizzaSize.SelectedIndexChanged += cboPizzaSize_SelectedIndexChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Baskerville Old Face", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(912, 418);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(77, 19);
            lblSubtotal.TabIndex = 3;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Baskerville Old Face", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(912, 460);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(44, 19);
            lblTax.TabIndex = 4;
            lblTax.Text = "Tax:";
            lblTax.Click += lblTax_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Baskerville Old Face", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(912, 501);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(55, 19);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            lblTotal.Click += lblTotal_Click;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(1007, 453);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(125, 27);
            txtTax.TabIndex = 6;
            txtTax.TextChanged += txtTax_TextChanged;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(1007, 411);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 7;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1007, 494);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 8;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // rtfOutput
            // 
            rtfOutput.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtfOutput.Location = new Point(232, 412);
            rtfOutput.Name = "rtfOutput";
            rtfOutput.Size = new Size(642, 290);
            rtfOutput.TabIndex = 9;
            rtfOutput.Text = "";
            rtfOutput.TextChanged += rtfOutput_TextChanged;
            // 
            // lblOrderSum
            // 
            lblOrderSum.AutoSize = true;
            lblOrderSum.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderSum.Location = new Point(19, 412);
            lblOrderSum.Name = "lblOrderSum";
            lblOrderSum.Size = new Size(183, 26);
            lblOrderSum.TabIndex = 10;
            lblOrderSum.Text = "Order Summary:";
            // 
            // BtnOrder
            // 
            BtnOrder.Font = new Font("Baskerville Old Face", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOrder.Location = new Point(912, 576);
            BtnOrder.Name = "BtnOrder";
            BtnOrder.Size = new Size(220, 82);
            BtnOrder.TabIndex = 11;
            BtnOrder.Text = "Calculate";
            BtnOrder.UseVisualStyleBackColor = true;
            BtnOrder.Click += BtnOrder_Click;
            // 
            // frmPizza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 749);
            Controls.Add(BtnOrder);
            Controls.Add(lblOrderSum);
            Controls.Add(rtfOutput);
            Controls.Add(txtTotal);
            Controls.Add(txtSubtotal);
            Controls.Add(txtTax);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(grpPizzaBox);
            Controls.Add(picPizza);
            Controls.Add(lblPizzaName);
            Name = "frmPizza";
            Text = "Washington's Pizza";
            ((System.ComponentModel.ISupportInitialize)picPizza).EndInit();
            grpPizzaBox.ResumeLayout(false);
            grpPizzaBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPizzaName;
        private PictureBox picPizza;
        private GroupBox grpPizzaBox;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private Label lblSize;
        private ComboBox cboPizzaSize;
        private Label lblCrust;
        private Label lblToppings;
        private CheckBox ckbExCheese;
        private CheckBox ckbJalepeno;
        private CheckBox ckbBanPeppers;
        private CheckBox ckbMushroom;
        private CheckBox ckbGOlives;
        private CheckBox ckbBOlives;
        private CheckBox ckbGPepper;
        private CheckBox ckbOnion;
        private CheckBox ckbSpicyItaSau;
        private CheckBox ckbCanBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbPepporoni;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private TextBox txtTotal;
        private RichTextBox rtfOutput;
        private Label lblOrderSum;
        private Button BtnOrder;
    }
}
