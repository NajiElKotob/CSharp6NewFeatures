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

        /// <summary>
        /// Expression-bodied functions/properties use lambda and have no statement body.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpressionBodiedMembers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ToString()); //Expression-bodied functions
            MessageBox.Show(this.MyProperty); //Expression-bodied properties

        }

        public override string ToString() => $"ToString using Expression-bodied functions";
        public string MyProperty => $"MyProperty using Expression-bodied properties";

        /// <summary>
        /// Used to test for null before performing a member access (?.) or index (?[) operation. 
        /// </summary>
        /// <remarks>
        /// Null-conditional Operators https://msdn.microsoft.com/en-us/library/dn986595.aspx
        /// Null-conditional Operators https://msdn.microsoft.com/en-us/library/dn986595.aspx
        /// Null-conditional Operators https://msdn.microsoft.com/en-us/library/dn986595.aspx
        /// Null-conditional Operators https://msdn.microsoft.com/en-us/library/dn986595.aspx
        /// Null-conditional Operators https://msdn.microsoft.com/en-us/library/dn986595.aspx
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNullConditionalOperators_Click(object sender, EventArgs e)
        {
            //Category category = new Category() { Name = "MyCategory" };
            Category category = null;

            // MessageBox.Show($"Name: {category.Name}"); //Error: Object reference not set to an instance of an object.
            MessageBox.Show($"Name: {category?.Name}"); // If ?. Null Then Null
            MessageBox.Show($"Name: {category?.Name ?? "Unspecified"}"); //The ?? operator is called the null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand https://msdn.microsoft.com/en-us/library/ms173224.aspx

        }


        /// <summary>
        /// Used to obtain the simple (unqualified) string name of a variable, type, or member.
        /// </summary>
        /// <remarks>
        /// nameof (C# and Visual Basic Reference) https://msdn.microsoft.com/en-us/library/dn986596.aspx
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNameofOperator_Click(object sender, EventArgs e)
        {
            Category category = null;

            try
            {
                if (category == null)
                {
                    throw new NullReferenceException($"The object '{nameof(Category)}' is null");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private class Category
        {
            public string Name { get; set; }
        }
    }
}

