// namespace org.molw.metserivce.data


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table ("marineobs")]
public class MarineData{
    [Key]
    public int marine_observation_id { get; set; }
    public string identification { get; set; }
    public byte[] location { get; set; }
    public DateTime time_of_observation { get; set; }
    public double sea_level_pressure { get; set; }
    public int characteristics_of_pressure_tendency { get; set; }
    public double pressure_tendency { get; set; }
    public double air_temperature { get; set; }
    public double wet_bulb_temperature { get; set; }
    public double dew_point_temperature { get; set; }
    public double sea_surface_temperature { get; set; }
    public string wave_direction { get; set; }
    public string wave_period { get; set; }
    public double wave_height { get; set; }
    public string swell_direction { get; set; }
    public string swell_period { get; set; }
    public double swell_height { get; set; }
    public int total_cloud_amount { get; set; }
    public int low_cloud_amount { get; set; }
    public string low_cloud_type { get; set; }
    public string cloud_height_indicator { get; set; }
    public string cloud_height { get; set; }
    public string middle_cloud_type { get; set; }
    public string high_cloud_type { get; set; }
    public string visibility { get; set; }
    public string visibility_indicator { get; set; }
    public string present_weather { get; set; }
    public string past_weather { get; set; }
    public int wind_direction { get; set; }
    public double wind_speed { get; set; }



}