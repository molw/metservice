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
    public double pressure_tendency{ get; set; }
    public air_temperature                      | double precision         | 
    public wet_bulb_temperature                 | double precision         | 
    public dew_point_temperature                | double precision         | 
    public sea_surface_temperature              | double precision         | 
    public wave_direction                       | character varying        | 
    public wave_period                          | character varying        | 
    public wave_height                          | double precision         | 
    public swell_direction                      | character varying        | 
    public swell_period                         | character varying        | 
    public swell_height                         | double precision         | 
    public total_cloud_amount                   | smallint                 | 
    public low_cloud_amount                     | smallint                 | 
    public low_cloud_type                       | character varying        | 
    public cloud_height_indicator               | character varying        | 
    public cloud_height                         | character varying        | 
    public middle_cloud_type                    | character varying        | 
    public high_cloud_type                      | character varying        | 
    public visibility                           | character varying        | 
    public visibility_indicator                 | character varying        | 
    public present_weather                      | character varying        | 
    public past_weather                         | character varying        | 
    public wind_direction                       | integer                  | 
    public wind_speed                           | double precision         | 



}