using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using ML.RealEstate.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML.RealEstateDemo
{
    public partial class frmDatabase : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            RealEstateDatabase.LoadAllDataset();
            
            string[] X = RealEstateDatabase.DistrictList.OrderBy(x=>x.Id).Select(x => x.DistrictName).ToArray();
            int[] Xid = RealEstateDatabase.DistrictList.OrderBy(x => x.Id).Select(x => (int)(x.Id)).ToArray();
            List<int> Y = new List<int>();
            foreach (int x in Xid)
            {
                int sum = RealEstateDatabase.HouseDataList.Where(c => (int)c.DistrictId== x).Count();
                Y.Add(sum);
            }
            chart1.Series[0].IsVisibleInLegend = false;
            //chart1.Series[0].LegendText = "Number of house by District";
            //chart1.Series[0].AxisLabel = "c";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LabelForeColor = Color.DarkRed;
            chart1.Series[0].IsXValueIndexed = true;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series[0].Points.DataBindXY(X, Y);

            LoadHouseDataIntoTree();
        }

        private void LoadHouseDataIntoTree()
        {
            ElementStyle style = new ElementStyle(Color.Blue);
            tvHouse.Nodes.Clear();
            foreach (District district in RealEstateDatabase.DistrictList)
            {
                Node districtNode = new Node(district.DistrictName);
                districtNode.Style = style;

                foreach (Ward war in RealEstateDatabase.WardList.Where(x=>x.DistrictId==district.Id))
                {
                    Node warNode = new Node(war.WardName);
                    districtNode.Nodes.Add(warNode);
                    int id = 1;
                    foreach (House house in RealEstateDatabase.HouseDataList.Where(x => x.WardId== war.Id))
                    {
                        Node houseNode = new Node(id+"");id++;
                        houseNode.Cells.Add(new Cell(house.Area + ""));
                        houseNode.Cells.Add(new Cell(house.FrontiSpiece+""));
                        houseNode.Cells.Add(new Cell(house.Entrance + ""));
                        houseNode.Cells.Add(new Cell(house.Floor+ ""));
                        houseNode.Cells.Add(new Cell(house.BedRoom+ ""));
                        houseNode.Cells.Add(new Cell(house.ToiletRoom+ ""));
                        houseNode.Cells.Add(new Cell(house.Price+ ""));

                        warNode.Nodes.Add(houseNode);

                    }
                }

                tvHouse.Nodes.Add(districtNode);
            }
        }
    }
}
