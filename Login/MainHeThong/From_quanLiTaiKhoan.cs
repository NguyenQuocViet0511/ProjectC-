using Login.FromMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.MainHeThong
{
    public partial class From_quanLiTaiKhoan : Form
    {
        internal From_Main from_QuanLiTaiKhoan;

        public From_Main frm;
        public delegate void _dedongtab();
        public _dedongtab Dedongtab;
        public From_quanLiTaiKhoan()
        {
            InitializeComponent();
        }

        private void From_quanLiTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        public static implicit operator From_quanLiTaiKhoan(From_Main v)
        {
            throw new NotImplementedException();
        }
    }
}
