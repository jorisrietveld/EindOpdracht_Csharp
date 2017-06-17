using System;

namespace EindOpdracht_Csharp.Model
{
    public interface IWeatherData
    {
        string GetCityName();
        string GetCountryName();
        string GetProvinceName();
        IWeaterdataCondition GetCondition();
    }
}