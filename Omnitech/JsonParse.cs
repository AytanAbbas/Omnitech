﻿//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;
//namespace Omnitech
//{
   

//    public partial class JsonParse
//    {
//        [JsonProperty("firstName")]
//        public string FirstName { get; set; }

//        [JsonProperty("lastName")]
//        public string LastName { get; set; }

//        [JsonProperty("keyboardShortcut")]
//        public string KeyboardShortcut { get; set; }

//        [JsonProperty("software")]
//        public string Software { get; set; }

//        [JsonProperty("whatDo")]
//        public string WhatDo { get; set; }
//    }

//    public partial class Welcome
//    {
//        public static Welcome[] FromJson(string json) => JsonConvert.DeserializeObject<Welcome[]>(json, QuickType.Converter.Settings);
//    }

//    public static class Serialize
//    {
//        public static string ToJson(this Welcome[] self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
//    }

//    internal static class Converter
//    {
//        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//        {
//            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//            DateParseHandling = DateParseHandling.None,
//            Converters =
//            {
//                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//            },
//        };
//    }
//}
