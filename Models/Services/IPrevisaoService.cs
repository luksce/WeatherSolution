using System.Collections.Generic;
using WeatherSolution.Models;

namespace WeatherSolution.Models.Services

{
    public interface IPrevisaoService
    {

        List<PrevisaoClima> Lista();
    }
}
