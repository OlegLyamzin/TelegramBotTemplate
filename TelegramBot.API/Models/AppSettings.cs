﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.API.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; }  = "http://telegrambottemplate.azurewebsites.net:443/{0}";
        public static string Name { get; set; } = "Tamplate_bot";
        public static string Key { get; set; }  = "1667348802:AAG7vUsH34oxyajl0x1rygeB9UXlLynQA8k";
    }
}
