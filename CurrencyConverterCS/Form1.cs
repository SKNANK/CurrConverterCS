using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CurrencyConverterCS
{
    public partial class Form1 : Form
    {

        XmlDocument doc;

        public Form1()
        {
            InitializeComponent();

            doc = new XmlDocument();
            doc.Load("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");


            // Additional additions for EURO as it is not in the original xml
            // EURO still required as an option for conversions.
            xFrom.Items.Add("EUR");
            xTo.Items.Add("EUR");
            // Adding Currency codes to combo boxes
            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Name.Equals("Cube"))
                {
                    updateLbl.Text = $"Last Updated: {node.FirstChild.Attributes[0].InnerText}";
                    foreach (XmlNode child in node.FirstChild.ChildNodes)
                    {
                        string currencyCode = child.Attributes[0].InnerText;
                        xFrom.Items.Add(currencyCode);
                        xTo.Items.Add(currencyCode);
                    }
                }
            }
            
            
        }

        // Search method called on click
        void Search()
        {
            if (xInput.Text != null)
            {
                Currency x = new Currency();
                Currency y = new Currency();
                float result;
                float singleRes;
                float reverseRes;

                // Loop to find correct element
                foreach (XmlNode node in doc.DocumentElement)
                {
                    if (node.Name.Equals("Cube"))
                    {
                        x = childSearch(node, xFrom);
                        y = childSearch(node, xTo);
                    }
                }

                // Calls converter class to calculate values
                CurrencyConverter convert = new CurrencyConverter();
                try
                {
                    result = convert.Calculate(float.Parse(xInput.Text), x, y);
                    singleRes = convert.Calculate(1, x, y);
                    reverseRes = convert.Calculate(1, y, x);

                    resultDisplay(result, singleRes, reverseRes, x, y);
                }
                catch (Exception e)
                {
                    errorLbl.Text = "Input amount is invalid";
                }

            }

        }

        // Displays results on the WinForm
        void resultDisplay(float res, float sinRes, float rRes, Currency x, Currency y)
        {
            beforeResLbl.Text = $"{xInput.Text} {x.currCode} =";
            resLbl.Text = $"{res} {y.currCode}";
            toToFromLbl.Text = $"1 {x.currCode} = {sinRes} {y.currCode}";
            fromToToLbl.Text = $"1 {y.currCode} = {rRes} {x.currCode}";
        }

        // Iterates through childNodes to find matching currency that is chosen then adds to a list.
        Currency childSearch(XmlNode node, ComboBox comboBox)
        {
            Currency currency = new Currency();
            foreach (XmlNode child in node.FirstChild.ChildNodes)
            {
                string currencyCode = child.Attributes[0].InnerText;
                if (currencyCode.Equals(comboBox.SelectedItem.ToString()))
                {
                    currency.currCode = currencyCode;
                    currency.rate = float.Parse(child.Attributes[1].InnerText);

                    return currency;
                }
                else if (comboBox.SelectedItem.Equals("EUR"))
                {
                    currency.currCode = "EUR";
                    currency.rate = 1.00f;

                    return currency;
                }
            }
            return currency;
        }

        private void XConfirm_Click(object sender, EventArgs e)
        {
            errorLbl.Text = " ";
            Search();
        }


    }
}
