﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHome
{
    public partial class FormImovel : Form
    {
        public FormImovel()
        {
            InitializeComponent();
        }

        private void FormImovel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet1.imovel' table. You can move, or remove it, as needed.
            this.imovelTableAdapter1.Fill(this.masterimovelDataSet1.imovel);
            // TODO: This line of code loads data into the 'masterimovelDataSet.imovel' table. You can move, or remove it, as needed.
            this.imovelTableAdapter.Fill(this.masterimovelDataSet.imovel);

        }

        private void dgv_imovel_DoubleClick(object sender, EventArgs e)
        {

            // Obtem o codigo do do gride da linha selecionad pelo duplo clique.
            int codigo = Convert.ToInt32(dgv_imovel.SelectedRows[0].Cells[0].Value.ToString());

            // Instancia a clesse FormeClasseManutencao enviando o codigo da classe como argumento
            FormImovelManutencao FormImovelManutencao = new FormImovelManutencao(codigo);
            FormImovelManutencao.ShowDialog(this);
        }
    }
}
