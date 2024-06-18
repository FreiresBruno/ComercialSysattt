﻿using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Produto produto = new Produto(mskCodigo.Text

              , txtDescricao.Text
              , Convert.ToDouble(mskValor.Text)
              , cmbUnidedeVendas.Text
              , Convert.ToInt32(txtCategoria.Text)
              , Convert.ToDouble(txtEstoqueMinimo.Text)
              , Convert.ToDouble(txtClasseDesconto.Text)
                );

            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto {produto.GetHashCode()} cadastrado com sucesso");
            }

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnObterPorID_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Produto produto = new Produto(

                int.Parse(txtId.Text)
              , mskCodigo.Text
              , txtDescricao.Text
              , Convert.ToDouble(mskValor.Text)
              , cmbUnidedeVendas.Text
              , Convert.ToInt32(txtCategoria.Text)
              , Convert.ToDouble(txtEstoqueMinimo.Text)
              , Convert.ToDouble(txtClasseDesconto.Text)
              , true);
            if (produto.Editar(produto.Id))
            {
                MessageBox.Show($"o Produto {produto.Descricao} foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o produto \"{produto.Descricao}\" !");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
} 
