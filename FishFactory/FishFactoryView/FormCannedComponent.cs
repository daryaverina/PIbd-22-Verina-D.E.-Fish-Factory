using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.ViewModels;



namespace FishFactoryView
{
    public partial class FormCannedComponent : Form
    {
        public int Id
        {
            get { return Convert.ToInt32(Component_comboBox.SelectedValue); }
            set { Component_comboBox.SelectedValue = value; }
        }
        public string ComponentName { get { return Component_comboBox.Text; } }
        public int Count
        {
            get { return Convert.ToInt32(Amount_textBox.Text); }
            set
            {
                Amount_textBox.Text = value.ToString();
            }
        }
        public FormCannedComponent(IComponentLogic logic)
        {
            InitializeComponent();
            List<ComponentViewModel> list = logic.Read(null);
            if (list != null)
            {
                Component_comboBox.DisplayMember = "ComponentName";
                Component_comboBox.ValueMember = "Id";
                Component_comboBox.DataSource = list;
                Component_comboBox.SelectedItem = null;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Amount_textBox.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Component_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

