using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.ViewModels;

using System;
using System.Windows.Forms;
using Unity;
using System.Collections.Generic;

namespace FishFactoryView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IOrderLogic _orderLogic;
        public FormMain(IOrderLogic orderLogic)
        {
            InitializeComponent();
            _orderLogic = orderLogic;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                // продумать логику
                List<OrderViewModel> list = _orderLogic.Read(null);
                if (list != null)
                {
                    Main_dataGridView.DataSource = list;
                    Main_dataGridView.Columns[0].Visible = false;
                    Main_dataGridView.Columns[1].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка LoadData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void компонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormComponents>();
            form.ShowDialog();
        }
        private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCanneds>();
            form.ShowDialog();
        }
        private void ButtonCreateOrder_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateOrder>();
            form.ShowDialog();
            LoadData();
        }
        private void ButtonTakeOrderInWork_Click(object sender, EventArgs e)
        {
            if (Main_dataGridView.SelectedRows.Count == 1)
            {
                  int id = Convert.ToInt32(Main_dataGridView.SelectedRows[0].Cells[0].Value);
               // int id = Convert.ToInt32(Main_dataGridView.SelectedCells[0].RowIndex);
                try
                {
                    _orderLogic.TakeOrderInWork(new ChangeStatusBindingModel
                    {
                        OrderId =
                   id
                    });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void ButtonOrderReady_Click(object sender, EventArgs e)
        {
            if (Main_dataGridView.SelectedRows.Count == 1)
            {
                // int id = Convert.ToInt32(Main_dataGridView.SelectedCells[0].RowIndex);
                int id = Convert.ToInt32(Main_dataGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    _orderLogic.FinishOrder(new ChangeStatusBindingModel
                    {
                        OrderId = id
                    });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void ButtonIssuedOrder_Click(object sender, EventArgs e)
        {
            if (Main_dataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(Main_dataGridView.SelectedRows[0].Cells[0].Value);
                //int id = Convert.ToInt32(Main_dataGridView.SelectedCells[0].RowIndex);
                try
                {
                    _orderLogic.DeliveryOrder(new ChangeStatusBindingModel
                    {
                        OrderId = id
                    });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}

