﻿using Newtonsoft.Json;

namespace SimplyBotUI.Models.Tempus
{
    public class MapInfoModel
    {
        [JsonProperty(PropertyName = "date_added")]
        public double DateAdded { get; set; }

        [JsonProperty(PropertyName = "id")] public int Id { get; set; }

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
    }
}