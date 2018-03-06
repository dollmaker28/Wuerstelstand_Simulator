using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Wuerstelstand_Simulator.Database
{
    class DBTables
    {
    }

    // Klasse für Artikel
    public class StoredItems
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int Bestbefore { get; set; }
        public int ItemTypeId { get; set;}
    }

    // Klasse für Artikeltypen
    public class ItemType
    {
        public int Id { get; set; }
        public string ItemTypeName { get; set; }
    }


    // Klasse für Verkaufsquoten je nach Artikel und Temperaturbereich
    public class ItemSalesQuota
    {
        public int Id { get; set; }
        public int ItemTypeId { get; set; }
        public int SeasonTempRangeId { get; set; }
        public int SalesQuotaFrom { get; set; }
        public int SalesQuotaTo { get; set; }
    }

    // Klasse für Finanzen
    public class Finance
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string AssetLabel { get; set; }
    }

    // Klasse für Wetter
    public class Weather
    {
        public int Id { get; set; }
        public string WeatherNextDay { get; set; }
        public int SeasonTempRangeId { get; set; }
    }

    // Klasse für die Jahreszeiten
    public class Season
    {
        public int Id { get; set; }
        public string SeasonText { get; set; }
        public int TempFrom { get; set; }
        public int TempTo { get; set; }
    }

    // Klasse für die Temperaturbereiche je Jahreszeit
    public class SeasonTempRange
    {
        public int Id { get; set; }
        public string SeasonTempRangeWeatherText { get; set; }
        public int SeasonId { get; set; }
        public int TempFrom { get; set; }
        public int TempTo { get; set; }
    }
}
