using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUIBackEnd.DAL;

namespace TUIBackEnd.BLL
{
    /// <summary>
    /// ICountryBLL interface
    /// </summary>
    public interface  ICountryBLL
    {
        List<Country> GetCountriesList();
    }
}
