using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SqlDers.modell;
using SqlDers.controller.service;

namespace SqlDers.controller
{
    internal class ModelController
    {
        Connection _connection;
        ModelService _modelService; 
        public ModelController() 
        {
            _connection = new Connection(); 
            _modelService = new ModelService();
        }
        public List<Model> GetAll()
        {
            return _modelService.getAll();
        }
    }
}
