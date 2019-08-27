using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using XanderUI.Designers;
using System.Security.Cryptography;
using Nemiro.OAuth.LoginForms;

namespace ePatient
{
    public partial class frm_ePatient : MetroSetForm
    {

        //Entity DB Verbindung mit dem db als Objekt 
        ePatientDBlocalEntities db = new ePatientDBlocalEntities();

        //Entity Login Verbindung
        Logins login = new Logins();

        public int userID;




        public frm_ePatient()
        {
            InitializeComponent();
        }



        private void FormLoad(object sender, EventArgs e)
        {
            tbx_password.UseSystemPasswordChar = true;

            tbx_regPassword.UseSystemPasswordChar = true;
            tbx_regConirmPassword.UseSystemPasswordChar = true;
            lbl_Beschreibung.Text = "Der ePatient ermöglicht es Dir, für den Notfall vorberietet zu sein. Er beantwortet die Frage: 'Was passiert, wenn was passiert !' ";
            
        }

        private void click_anmelden(object sender, EventArgs e)
        {
            // Locale Variable 
            string username = tbx_Login.Text;
            string password = HPass(tbx_password.Text);

            foreach (var user in db.Logins)
            {
                // Suche nach Benutzern 
                if (user.Username == username && user.Password == password)
                {
                    tbx_Login.Text = String.Empty;
                    tbx_password.Text = String.Empty;


                    userID = user.Id_Login;

                    Form_Dashboard dboard = new Form_Dashboard(userID);
                    dboard.Show();

                    // MessageBox.Show("Login war erfolgreich !");
                    Form_Verstecken();

                    return;
                    //hier ist der Exitpunkt für die Anmeldeung

                }

                MessageBox.Show("Password/Username sind Falsch !");

            }


        }

        private void AddUser(string username, string password, string confirmPass)
        {
            foreach (var user in db.Logins)
            {
                if (user.Username.Equals(username))
                {
                    MessageBox.Show("Dieser Benutzer exsitiert !");
                    return;
                }
            }

            if (password != confirmPass)
            {
                MessageBox.Show("Das Password stimmt nicht überein !");
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Das Password muss 8 Zeichen haben");
            }

            else
            {
                String Epass = HPass(password);
                login.Username = username;
                login.Password = Epass;

                tbx_regUsername.Text = String.Empty;
                tbx_regPassword.Text = String.Empty;
                tbx_regConirmPassword.Text = String.Empty;

                db.Logins.Add(login);
                db.SaveChanges();


                MessageBox.Show("Danke für die Registrierung");


            }

        }



        public string HPass(string password)
        {

            SHA384 sha = new SHA384CryptoServiceProvider();
            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = sha.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void Click_Registrierung(object sender, EventArgs e)
        {
            AddUser(tbx_regUsername.Text, tbx_regPassword.Text, tbx_regConirmPassword.Text);
        }


        private void Form_Verstecken()
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Login = new GoogleLogin();
             Login = 
        }
    }
}
