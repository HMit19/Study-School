using System.Text.RegularExpressions;

namespace LoginController
{
    public partial class LoginControl<T> : UserControl
    {
        public String username;
        public String password;
        public String messageLoginTrue;
        public bool checkLoginForm;
        public List<T> list;
        public LoginControl()
        {
            InitializeComponent();
            list = new List<T>();
        }
        public void addUser(T t)
        {
            list.Add(t);
        }
        public List<T> getUser()
        {
            return list;
        }

        public virtual void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter username!");
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter password!");
                txtPassword.Focus();
                return;
            }
            if (this.validate(username) && this.validate(password))
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                if (cbRemember.Checked)
                {
                    txtUsername.AutoCompleteCustomSource.Add(username);
                }
                this.checkLogin(username, password);
            }

        }
        public virtual bool validate(string regex)
        {
            return true;
        }

        public virtual bool checkLogin(String username, String password)
        {
            return false;
        }

        public virtual void lbRegister_Click(object sender, EventArgs e)
        {
            return;
        }

        public virtual void lbForgot_Click(object sender, EventArgs e)
        {
            return;
        }
        public virtual void showMessage(String message, String title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, button, icon);
            return;
        }
        public virtual void showMessage(String message)
        {
            MessageBox.Show(message);
        }
        public virtual void showMessage(String message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, icon);
        }
    }
}
