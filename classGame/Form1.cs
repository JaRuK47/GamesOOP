namespace classGame
{
    public partial class Form1 : Form
    {
        List<Gadgets> gadgetsList = new List<Gadgets>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.gadgetsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.gadgetsList.Add(Laptops.Generate());
                        break;
                    case 1:
                        this.gadgetsList.Add(Tablets.Generate());
                        break;
                    case 2:
                        this.gadgetsList.Add(Smartphones.Generate());
                        break;
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            int laptopsCount = 0;
            int tabletsCount = 0;
            int smartphonesCount = 0;

            foreach (var gadget in this.gadgetsList)
            {
                if (gadget is Laptops)
                {
                    laptopsCount += 1;
                }
                else if (gadget is Tablets)
                {
                    tabletsCount += 1;
                }
                else if (gadget is Smartphones)
                {
                    smartphonesCount += 1;
                }
            }

            txtInfo.Text = "Íîóò\tÏëíò\tÑìðò";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", laptopsCount, tabletsCount, smartphonesCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.gadgetsList.Count == 0)
            {
                txtOut.Text = "Ïóñòî Q_Q";
                return;
            }

            var fruit = this.gadgetsList[0];
            
            this.gadgetsList.RemoveAt(0);

            txtOut.Text = fruit.GetInfo();

            ShowInfo();
        }
    }
}
