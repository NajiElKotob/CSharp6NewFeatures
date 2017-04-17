using System;
using System.Windows.Forms;
using static System.Media.SystemSounds;

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

        /// <summary>
        /// Getter-only Property
        /// </summary>
        /// <remarks>
        /// Using Properties (C# Programming Guide) https://msdn.microsoft.com/en-us/library/w86s7x04.aspx
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetterOnly_Click(object sender, EventArgs e)
        {
            //GetterOnlyProperty = "Value..."; //Error: Cannot be assigned it is read only
            MessageBox.Show($"GetterOnlyProperty: {GetterOnlyProperty}, GetterOnlyPropertyWithInitialValue: {GetterOnlyPropertyWithInitialValue}");
        }

        /// <summary>
        /// using static imports static members of types directly into scope.
        /// </summary>
        /// <example>
        /// using static System.Media.SystemSounds;
        /// </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsingStaticMembers_Click(object sender, EventArgs e)
        {
            Beep.Play();
        }

        /// <summary>
        /// An interpolated string expression creates a string by replacing the contained expressions 
        /// with the ToString represenations of the expressions’ results. 
        /// </summary>
        /// <remarks>
        /// Interpolated Strings (C# and Visual Basic Reference) https://msdn.microsoft.com/en-us/library/dn961160.aspx
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStringInterpolation_Click(object sender, EventArgs e)
        {
            var Name = "Naji";
            var Age = 41;
            var Id = 5;
            var now = DateTime.Now;

            MessageBox.Show($"{Name,30} is {Age} year{(Age == 1 ? "" : "s")} old, Id: {Id:D3}");
            MessageBox.Show($"Hour: {now:hh}, Min: {now:MM}");

        }
    }
}

