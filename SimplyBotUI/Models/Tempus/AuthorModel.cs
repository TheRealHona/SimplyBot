﻿using Newtonsoft.Json;

namespace SimplyBotUI.Models.Tempus
{
    public class AuthorModel
    {
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
    }
}