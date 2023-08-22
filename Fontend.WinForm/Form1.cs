using Backend.Service;

namespace Fontend.WinForm
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;
        public Form1(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _userService.GetAll().FirstOrDefault().Name;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}