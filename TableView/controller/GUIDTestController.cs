using SqlDers.controller.service;
using SqlDers.modell;
using SqlDers.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.controller
{
    internal class GUIDTestController
    {
        Connection _connection;
        GUIDTestService _gUIDTestService;
        public GUIDTestController()
        {
            _connection = new Connection();
            _gUIDTestService = new GUIDTestService();
        }
        public List<GUIDTest> GetAll()
        {
            return _gUIDTestService.getAll();
        }
    }
}
