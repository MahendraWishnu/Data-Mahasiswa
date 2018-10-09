using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mskNpm.MaskFull)
            {
                MessageBox.Show("NPM harus diisi!!", "Peringatan", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                mskNpm.Focus();
                return;
            }

                if (!(txtNama.Text.Length > 0))
                {
                    MessageBox.Show("Nama harus diisi!!", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtNama.Focus();
                    return;
                }

                if (!(txtTempatLahir.Text.Length > 0))
                {
                    MessageBox.Show("Tanggal Lahir harus diisi!!", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtTempatLahir.Focus();
                    return;
                }

                if (!(txtTempatLahir.Text.Length > 0))
                {
                    MessageBox.Show("Tanggal Lahir harus diisi!!", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtTempatLahir.Focus();
                    return;
                }

                if (!(dtpTanggalLahir.Text.Length > 0))
                {
                    MessageBox.Show("Tempat Lahir harus diisi!!", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    dtpTanggalLahir.Focus();
                    return;
                }

                var jenisKelamin = rdoLakilaki.Checked ? "Laki-laki" : "Perempuan";

                var msg = string.Format("NPM: {0} \nNama: {1} \nJenis Kelamin: {2},\nTempat & tgl.Lahir: {3},{4}",
                    mskNpm.Text, txtNama.Text, jenisKelamin, txtTempatLahir.Text, dtpTanggalLahir.Text);

                MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
  

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            var msg = "Apakah Anda Yakin ? ";

            var result = MessageBox.Show(msg, "Konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
        }

        private void txtTempatLahir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
