using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;


namespace FishFactoryView
{
    public partial class FormCanned : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly ICannedLogic _logic;
        private int? id;
        private Dictionary<int, (string, int)> cannedComponents;
        public FormCanned(ICannedLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }
        private void FormCanned_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    CannedViewModel view = _logic.Read(new CannedBindingModel
                    {
                        Id =
                   id.Value
                    })?[0];
                    if (view != null)
                    {
                        Name_textBox.Text = view.CannedName;
                        Price_textBox.Text = view.Price.ToString();
                        cannedComponents = view.CannedComponents;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                cannedComponents = new Dictionary<int, (string, int)>();
            }
        }
        private void LoadData()
        {
            try
            {
                if (cannedComponents != null)
                {
                    Components_dataGridView.Rows.Clear();
                    foreach (var pc in cannedComponents)
                    {
                        Components_dataGridView.Rows.Add(new object[] { pc.Key, pc.Value.Item1,
pc.Value.Item2 });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCannedComponent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (cannedComponents.ContainsKey(form.Id))
                {
                    cannedComponents[form.Id] = (form.ComponentName, form.Count);
                }
                else
                {
                    cannedComponents.Add(form.Id, (form.ComponentName, form.Count));
                }
                LoadData();
            }
        }
        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (Components_dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormCannedComponent>();
                int id = Convert.ToInt32(Components_dataGridView.SelectedRows[0].Cells[0].Value);
                form.Id = id;
                form.Count = cannedComponents[id].Item2;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    cannedComponents[form.Id] = (form.ComponentName, form.Count);
                    LoadData();
                }
            }
        }
        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (Components_dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        cannedComponents.Remove(Convert.ToInt32(Components_dataGridView.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_textBox.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Price_textBox.Text))
            {
                MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (cannedComponents == null || cannedComponents.Count == 0)
            {
                MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logic.CreateOrUpdate(new CannedBindingModel
                {
                    Id = id,
                    CannedName = Name_textBox.Text,
                    Price = Convert.ToDecimal(Price_textBox.Text),
                    CannedComponents = cannedComponents
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
