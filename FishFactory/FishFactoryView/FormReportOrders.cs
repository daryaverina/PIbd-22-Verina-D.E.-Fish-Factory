﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace FishFactoryView
{
    public partial class FormReportOrders : Form
    {
        private readonly ReportViewer reportViewer;
        private readonly IReportLogic logic;

        public FormReportOrders(IReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill
            };
            reportViewer.LocalReport.LoadReportDefinition(new
           FileStream("Report1.rdlc", FileMode.Open));
            Controls.Clear();
            Controls.Add(reportViewer);
            Controls.Add(panel);
        }
        private void forming_button_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var dataSource = logic.GetOrders(new ReportBindingModel
                {
                    DateFrom = dateTimePickerFrom.Value,
                    DateTo = dateTimePickerTo.Value
                });
                var source = new ReportDataSource("DataSetOrders", dataSource);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(source);
                var parameters = new[] { new ReportParameter("ReportParameterPeriod", "c " +
                    dateTimePickerFrom.Value.ToShortDateString() + " по " + dateTimePickerTo.Value.ToShortDateString()) };
                //тут выводит ошибку 
                reportViewer.LocalReport.SetParameters(parameters);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void toPdf_button_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    logic.SaveOrdersToPdfFile(new ReportBindingModel
                    {
                        FileName = dialog.FileName,
                        DateFrom = dateTimePickerFrom.Value,
                        DateTo = dateTimePickerTo.Value
                    });
                    MessageBox.Show("Выполнено", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
