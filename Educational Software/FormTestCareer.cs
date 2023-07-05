using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Software
{
    public partial class FormTestCareer : Form
    {

        private RadioButton[] btns;
        private string[] careers = { "Game Developer", "UX Designer", "Software Engineer", "Machine Learning Engineer",
            "Full-Stack Developer", "Data Scientist", "Back-end Developer", "Front-end Developer" };
        private int[] points = { 0, 0, 0, 0, 0, 0, 0, 0 };

        private int[][] btn_points =
        {
            new int[] { 1, 0, 1, 1, 1, 1, 0, 0 }, // 1
            new int[] { 0, 0, 0, 0, 0, 0, 1, 1 }, // 1
            new int[] { 0, 0, 1, 1, 1, 0, 0, 0 }, // 2
            new int[] { 0, 0, 0, 0, 0, 0, 0, 1 }, // 2
            new int[] { 0, 0, 0, 0, 0, 1, 1, 1 }, // 3
            new int[] { 0, 0, 1, 1, 1, 0, 0, 0 }, // 3
            new int[] { 1, 0, 1, 1, 1, 1, 0, 0 }, // 4
            new int[] { 0, 1, 0, 0, 0, 0, 1, 1 }, // 4
            new int[] { 1, 1, 0, 0, 0, 0, 0, 1 }, // 5
            new int[] { 0, 0, 0, 1, 0, 1, 1, 0 }, // 5
            new int[] { 0, 0, 1, 0, 1, 0, 0, 0 }, // 5
            new int[] { 0, 0, 0, 0, 0, 0, 1, 1 }, // 6
            new int[] { 1, 0, 1, 0, 1, 0, 0, 0 }, // 6
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }, // 6
            new int[] { 0, 0, 1, 0, 1, 0, 0, 0 }, // 7
            new int[] { 0, 0, 0, 0, 0, 0, 1, 1 }, // 7
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // 8
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // 8
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, // 8
            new int[] { 1, 0, 0, 1, 0, 1, 0, 0 }, // 9
            new int[] { 0, 0, 0, 0, 0, 0, 1, 1 }, // 9
            new int[] { 0, 0, 0, 1, 0, 1, 0, 0 }, // 10
            new int[] { 1, 0, 0, 1, 0, 1, 0, 0 }, // 10
            new int[] { 0, 1, 0, 0, 0, 0, 0, 1 }, // 10
            new int[] { 1, 1, 0, 0, 0, 0, 0, 0 }, // 11
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }  // 11
        };

        public FormTestCareer()
        {
            InitializeComponent();
            btns = new RadioButton[] {
                b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13,
                b14, b15, b16, b17, b18, b19, b20, b21, b22, b23, b24, b25, b26
            };
        }

        private void Next_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < btns.Length; i++)
            {
                if (btns[i].Checked) {
                    for (int j = 0; j < 8; j++)
                        points[j] += btn_points[i][j];
                }
            }
            MessageBox.Show(string.Join(", ", points));
        }
    }
}
