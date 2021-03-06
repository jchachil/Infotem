﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TUIBackEnd.BLL;
using TUIBackEnd.DAL;
using TUIBackEnd.Models;
using TUIBackEnd.Web.Helper;

namespace TUIBackEnd.Web.Controllers
{
    /// <summary>
    ///  Airport controller
    /// </summary>
    public class AirportsController : BaseController
    {

        IAirportBLL _airportBLL;
        public AirportsController(IAirportBLL airportBLL)
        {
            _airportBLL = airportBLL;
        }

        /// <summary>
        /// Get all Airports data from database
        /// </summary>
        /// <returns></returns>
        [Route(WebApiRoutes.GetAllAirportsListActionName)]
        public List<AirportModel> GetAllAirportsList()
        {

            List<AirportModel> model = new List<AirportModel>();
            
            IEnumerable<Airport> airportsList = _airportBLL.GetAirportsList(); 

             model = AutoMapper.Mapper.Map<List<AirportModel>>(airportsList);

            return model;
        }

       

    }
}
