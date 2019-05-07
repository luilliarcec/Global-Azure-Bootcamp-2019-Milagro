using Entities.Model;
using Logic.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GAB2019 : Form
    {
        private LogicDemo _logic = new LogicDemo();

        public GAB2019()
        {
            InitializeComponent();
            ShowDatas();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
            ShowDatas();
        }

        private void ShowDatas()
        {
            _logic = new LogicDemo();
            var demos = _logic.GetDemos();
            DgvDatos.Rows.Clear();

            foreach (var demo in demos)
            {
                DgvDatos.Rows.Add(
                        demo.Id,
                        demo.Descripcion
                    );
            }
        }

        private void Save()
        {
            var demo = new Demo
            {
                Id = 0,
                Descripcion = TxtDescripcion.Text
            };

            if (_logic.Save(demo))
                MessageBox.Show("Se guardó");
            else
                MessageBox.Show("Error");
        }
    }
}
