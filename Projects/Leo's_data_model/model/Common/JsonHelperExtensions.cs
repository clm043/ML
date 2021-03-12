﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace edu.bucknell.project.moravianLives.model.Common
{
    public static class JsonHelperExtensions
    {
        public static string SVal(this JToken source, string path)
        {
            return path == null ? null : source?.SelectToken(path)?.ToString();
        }

        private static Dictionary<string,string> _defaultCulture = new Dictionary<string, string>()
        {
            {"en", "en-US"}
        };

        public static string GetDefaultCulture(string source)
        {
            return _defaultCulture.ContainsKey(source.ToLower()) ? _defaultCulture[source.ToLower()] : source;
        }
    }
}
