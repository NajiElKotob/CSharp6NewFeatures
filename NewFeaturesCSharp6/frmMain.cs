using System;
using System.Windows.Forms;

/*
New Features in C# 6.0 by Naji El Kotob
naji@dotnetheroes.com
*/

namespace NewFeaturesCSharp6
{

    public partial class frmMain : Form
    {
        public string GetterOnlyProperty { get; }
        public string GetterOnlyPropertyWithInitialValue { get; } = "Getter-Only Property Initial Value!";


        public frmMain()
        {
            InitializeComponent();
            GetterOnlyProperty = "Getter-Only Property Value!"; // Can assign a value for a read only property in the constructor
        }

        private void btnGetterOnly_Click(object sender, EventArgs e)
        {
            //GetterOnlyProperty = "Value..."; //Error: Cannot be assigned it is read only
            MessageBox.Show($"GetterOnlyProperty: {GetterOnlyProperty}, GetterOnlyPropertyWithInitialValue: {GetterOnlyPropertyWithInitialValue}");
        }
    }
}

