namespace Washington_s_Pizza
{
    public partial class frmPizza : Form
    {
        private const float Small = 2;
        private const float Medium = 5;
        private const float Large = 10;
        private const float ExtraLarge = 15;
        private const float Ginormous = 20;

        private const float Pepporoni = 2;
        private const float Sausage = 2;
        private const float CanBacon = 2;
        private const float SpicyItaSau = 2;
        private const float Onion = 1;
        private const float GPepper = 1;
        private const float BOlives = 1;
        private const float GOlives = 1;
        private const float BanPeppers = 1;
        private const float Jalepeno = 1;
        private const float ExCheese = 1;
        private const float Mushroom = 1;

        //end instance fields

        public frmPizza()
        {
            InitializeComponent();
        }//end frmPizza

        private void lblPizzaName_Click(object sender, EventArgs e)
        {

        }//end PizzaName

        private void cboPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
           String data = cboPizzaSize.GetItemText(cboPizzaSize.SelectedItem);
           rtfOutput.Text = data;

        }//end cboPizzaSize

        private void BtnOrder_Click(object sender, EventArgs e)
        {

            Summarize();
        }//end BtnOrder
        private void Summarize()
        {
            float subtotal = 0;
            string selectedPizzaSize = cboPizzaSize.SelectedItem.ToString();
            String data = cboPizzaSize.GetItemText(cboPizzaSize.SelectedItem);
            rtfOutput.Text = data;
            // I cannot figure out to get the pizza size onto the rich text box while also getting the price factored in. 
            switch (selectedPizzaSize)
            {
                case "Small":
                    subtotal += Small;
                    break;
                case "Medium":
                    subtotal += Medium;
                    break;
                case "Large":
                    subtotal += Large;
                    break;
                case "ExtraLarge":
                    subtotal += ExtraLarge;
                    break;
                case "Ginormous":
                    subtotal += Ginormous;
                    break;
            }//end switch

            if (ckbPepporoni.Checked) subtotal += Pepporoni;
            if (ckbSausage.Checked) subtotal += Sausage;
            if (ckbCanBacon.Checked) subtotal += CanBacon;
            if (ckbSpicyItaSau.Checked) subtotal += SpicyItaSau;
            if (ckbOnion.Checked) subtotal += Onion;
            if (ckbGPepper.Checked) subtotal += GPepper;
            if (ckbBOlives.Checked) subtotal += BOlives;
            if (ckbGOlives.Checked) subtotal += GOlives;
            if (ckbBanPeppers.Checked) subtotal += BanPeppers;
            if (ckbJalepeno.Checked) subtotal += Jalepeno;
            if (ckbExCheese.Checked) subtotal += ExCheese;
            if (ckbMushroom.Checked) subtotal += Mushroom;

            float tax = subtotal / 100;
            float total = subtotal + tax;

            rtfOutput.Clear();
            rtfOutput.AppendText("Order Summary:\n");
            if (rdoThin.Checked) rtfOutput.AppendText("You ordered Thin Crust\n");
            if (rdoRegular.Checked) rtfOutput.AppendText("You ordered Regular Crust\n");
            if (rdoThick.Checked) rtfOutput.AppendText("You ordered Thick Crust\n");
            rtfOutput.AppendText($"Pizza Size: \n");
            rtfOutput.AppendText("Toppings:\n");

           
            
            
            if (ckbPepporoni.Checked) rtfOutput.AppendText("\u2022 Pepporoni\n");
            if (ckbSausage.Checked) rtfOutput.AppendText("\u2022 Sausage\n");
            if (ckbCanBacon.Checked) rtfOutput.AppendText("\u2022 Canadian Bacon\n");
            if (ckbSpicyItaSau.Checked) rtfOutput.AppendText("\u2022 Spicy Italian Sausage\n");
            if (ckbOnion.Checked) rtfOutput.AppendText("\u2022 Onion\n");
            if (ckbGPepper.Checked) rtfOutput.AppendText("\u2022 Green Pepper\n");
            if (ckbBOlives.Checked) rtfOutput.AppendText("\u2022 Black Olives\n");
            if (ckbGOlives.Checked) rtfOutput.AppendText("\u2022 Green Olives\n");
            if (ckbBanPeppers.Checked) rtfOutput.AppendText("\u2022 Banana Peppers\n");
            if (ckbJalepeno.Checked) rtfOutput.AppendText("\u2022 Jalepeno\n");
            if (ckbExCheese.Checked) rtfOutput.AppendText("\u2022 Extra Cheese\n");
            if (ckbMushroom.Checked) rtfOutput.AppendText("\u2022 Mushroom\n");

            ;

            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");


        }//end Summarize 

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            
            
        }//end txtSubtotal

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            

        }//end txtTax

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
           
        }//end txtTotal

        private void lblSubtotal_Click(object sender, EventArgs e)
        {
            
        }//end lblSubtotal

        private void lblTax_Click(object sender, EventArgs e)
        {

        }//end lblTax

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }// end lblTotal

        private void rtfOutput_TextChanged(object sender, EventArgs e)
        {
            
        }//end rtfOutput
    }///end class
}//end namespace
