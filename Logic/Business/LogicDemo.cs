using Data.Dao;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Business
{
    public class LogicDemo
    {
        private readonly DemoDAO dao = new DemoDAO();

        public bool Save(Demo demo)
        {
            try
            {
                // Si hubiera que validar hacer calculo o logica, esta es la capa para hacerlo
                dao.Save(demo);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyList<Demo> GetDemos()
        {
            try
            {
                return dao.GetDemos();
            }
            catch (Exception)
            {
                throw;
            }
        }
        // El resto de metodos lo implementaran uds.
    }
}
