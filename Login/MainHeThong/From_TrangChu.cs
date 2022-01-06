using LiveCharts;
using LiveCharts.Wpf;
using Login.Data;
using Login.DataLop;
using Login.DataSinhVien;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Login.MainHeThong
{
    public partial class From_TrangChu : Form
    {
        List<String> vs = new List<string>();
        internal From_Main from_TrangChu;

        private bool mo = true;
        BindingList<SinhVien> myObjList = new BindingList<SinhVien>();
        public From_TrangChu()
        {
            InitializeComponent();
        
        }

        private void From_TrangChu_Load(object sender, EventArgs e)
        {
            AddChart();
            timer1.Enabled = true;               
            load();

            
        }

        public void AddChart()
        {
            
            ListSinhVien listSinhVien = new ListSinhVien();
            listSinhVien.DocFile(Const.PathfileSV);
            int sumNam = 0;
            int sumNu = 0;
            int sumTong = Const.ListSinhVien.Count;
            for(int i = 0; i< Const.ListSinhVien.Count;i++)
            {
                if(Const.ListSinhVien[i].GioiTinh1.Equals("Nam"))
                {
                    sumNam++;
                }
                else
                {
                    sumNu++;
                }
            }
            lblNam.Text = String.Format("" + sumNam);
            lblNu.Text = String.Format("" + sumNu);
            lblsum.Text = String.Format("" + sumTong);

            LiveChart.Series["Sinh Viên"].Points.AddXY("Nam", sumNam);
            LiveChart.Series["Sinh Viên"].Points.AddXY("Nữ", sumNu);




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblarow.Left += 1;
            if(lblarow.Left > 212)
            {
                lblarow.Left = 209;
            }
            lblarow1.Left += 1;
            if (lblarow1.Left > 212)
            {
                lblarow1.Left = 209;
            }
            lblarow2.Left += 1;
            if (lblarow2.Left > 212)
            {
                lblarow2.Left = 209;
            }
        }
        //motab
        public delegate void _MotabSV();
        public _MotabSV motabSV;
        //
        public delegate void _MotabAdmin();
        public _MotabAdmin motabAdmin;
        //
        public delegate void _MotabLop();
        public _MotabLop motabLop;
        //
        private void lblarow2_Click(object sender, EventArgs e)
        {
            motabLop();
        }
        private void lblarow_Click(object sender, EventArgs e)
        {
            motabAdmin();
        }

        private void loadLop()
        {

            vs.Clear();
            ListLop listLop = new ListLop();
            listLop.DocFile(Const.PathfileLop);
            for (int i = 0; i < Const.ListLop.Count; i++)
            {
                vs.Add(Const.ListLop[i].Lop1);
            }


        }
    
        //

        //
        public void PhanQuyen()
        {
            switch (Const.UserLogin.Quyen1)
            {
                case "Admin":
                    lblarow.Enabled = true;
                    lblarow1.Enabled = true;
                    lblarow2.Enabled = true;
                    break;
                case "Manager":
                    lblarow.Enabled = true;
                    lblarow1.Enabled = true;
                    lblarow2.Enabled = true;
                    break;
                case "user":
                    lblarow.Enabled = false;
                    lblarow1.Enabled = false;
                    lblarow2.Enabled = false;
                    break;

            }
        }
        //
        private void load()
        {
            myObjList.Clear();
            ListSinhVien listSinhVien = new ListSinhVien();
            listSinhVien.DocFile(Const.PathfileSV);
            for (int i = 0;i < Const.ListSinhVien.Count; i++)
            {
                myObjList.Add(Const.ListSinhVien[i]);
            }
            DataGripSV.DataSource = myObjList;

        }

   

     

        private void lblarow1_Click(object sender, EventArgs e)
        {
            motabSV();
        }

       
        private void cbnlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (mo == false)
                {
                    BindingList<SinhVien> filtered = new BindingList<SinhVien>(myObjList.Where(sinhvien => sinhvien.Lop1.Contains(cbnlop.SelectedItem.ToString())).ToList());
                    DataGripSV.DataSource = filtered;
                }

            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                mo = true;
                loadLop();
                cbnlop.DataSource = vs;
                cbnlop.SelectedIndex = -1;
            }
            else
            {
                mo = true;
                cbnlop.DataSource = null;
                load();
            }
        }

        private void cbnlop_MouseClick_1(object sender, MouseEventArgs e)
        {
            mo = false;
        }

        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {

            BindingList<SinhVien> filtered = new BindingList<SinhVien>(myObjList.Where(sinhvien => sinhvien.HovaTen1.Contains(txttimkiem.Text)).ToList());
            DataGripSV.DataSource = filtered;
        }







        //






    }
}
