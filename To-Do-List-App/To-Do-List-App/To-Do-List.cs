using System.Data;

namespace To_Do_List_App
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        DataTable dt = new DataTable();
        bool isEditing = false;
        private void ToDoList_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");

            ToDoListView.DataSource = dt;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            DescTextBox.Text = "";
        }

        private void EdtBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            TitleTextBox.Text = dt.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescTextBox.Text = dt.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void Dltbtn_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine("Error : " + ex);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                dt.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTextBox.Text;
                dt.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescTextBox.Text;
            }
            else
            {
                dt.Rows.Add(TitleTextBox.Text, DescTextBox.Text);
            }

            TitleTextBox.Text = "";
            DescTextBox.Text = "";
            isEditing = false;
        }
    }
}
