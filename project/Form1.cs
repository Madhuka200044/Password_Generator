using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Password_TB_Scroll(object sender, EventArgs e)
        {
            trackBarLength.Text = Password_TB.Value.ToString();
        }

        private void GenerateBTN_Click(object sender, EventArgs e)
        {
            GenerateConfigs configs = getGenerateConfigs();
            GeneraterText.Text = PasswordGenHelper.PasswordGenerater(configs);
        }

        private GenerateConfigs getGenerateConfigs()
        {
            GenerateConfigs configs = new GenerateConfigs();
            configs.length = Password_TB.Value;
            configs.isLowercase = CB_lower.Checked;
            configs.isUppercase = CB_upper.Checked;
            configs.isDigits = CB_digits.Checked;
            configs.isSymbols = CB_symbols.Checked;
            return configs;
        }
    }
}
