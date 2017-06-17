using System;

namespace EindOpdracht_Csharp.Model
{
    public interface IWeaterdataCondition
    {
        int GetWeatherCode();
        DateTime GetDateTime();
        int GetTemerature();
        string GetWeaterText();
    }
}