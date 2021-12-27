using LiveCharts;
using LiveCharts.Wpf;
using Login.Data;
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
        internal From_Main from_TrangChu;
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
        private void lblarow2_Click(object sender, EventArgs e)
        {
            motabSV();
        }
        private void lblarow_Click(object sender, EventArgs e)
        {
            motabAdmin();
        }


        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {      



            BindingList<SinhVien> filtered = new BindingList<SinhVien>(myObjList.Where(sinhvien => sinhvien.HovaTen1.Contains(txttimkiem.Text)).ToList());
            DataGripSV.DataSource = filtered;
      
        }
        private void load()
        {

            ListSinhVien listSinhVien = new ListSinhVien();
            listSinhVien.DocFile(Const.PathfileSV);
            for (int i = 0;i < Const.ListSinhVien.Count; i++)
            {
                myObjList.Add(Const.ListSinhVien[i]);
            }
            DataGripSV.DataSource = myObjList;

        }

      



        //






    }
}
