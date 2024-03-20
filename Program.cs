using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Label = System.Windows.Forms.Label;

namespace S1125566Ex0318DiyFormV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new Form();

            myForm.Size = new System.Drawing.Size(320, 240);

            myForm.Text = "DIY Form V1";

            //

            System.Windows.Forms.Label lblMessage = new Label();

            lblMessage.Text = "帳號:";

            lblMessage.Location = new System.Drawing.Point(50, 50);

            myForm.Controls.Add(lblMessage);

            //
            System.Windows.Forms.Label lblMessage2 = new Label();

            lblMessage2.Text = "密碼:";

            lblMessage2.Location = new System.Drawing.Point(50, 75);

            myForm.Controls.Add(lblMessage2);

            //

            TextBox tbUsername = new TextBox();

            tbUsername.Width = 150;

            tbUsername.Location = new System.Drawing.Point(80, 50);

            myForm.Controls.Add(tbUsername);

            //
            TextBox tbUserpassword = new TextBox();

            tbUserpassword.Width = 150;

            tbUserpassword.Location = new System.Drawing.Point(80, 75);

            myForm.Controls.Add(tbUserpassword);

            //

            Button btnOK = new Button();

            btnOK.Text = "OK";

            btnOK.Width = 100;

            btnOK.Location = new System.Drawing.Point(50, 100);

            myForm.Controls.Add(btnOK);

            //
            Button btnCancel = new Button();

            btnCancel.Text = "取消";

            btnCancel.Width = 100;

            btnCancel.Location = new System.Drawing.Point(180, 100);

            myForm.Controls.Add(btnCancel);
            // btnOK.Click += BtnOK_Click;
            // btnCancel.Click += BtnCancel_Click;
            //

            System.Windows.Forms.Application.Run(myForm);
        }
    }
}
