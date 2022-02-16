using Fiap.Web.AspNet2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet2.Repository.Interface
{
   public interface IRepresentanteRepository
    {
        public IList<RepresentanteModel> FindAll();
        public RepresentanteModel FindById(int id);
        public RepresentanteModel FindByIdWithClientes(int id);
        public IList<RepresentanteModel> FindByName(String nome);
        public void Insert(RepresentanteModel representanteModel);
        public void Update(RepresentanteModel representanteModel);
        public void Delete(int id);
        public void Delete(RepresentanteModel representanteModel);
    }
}
