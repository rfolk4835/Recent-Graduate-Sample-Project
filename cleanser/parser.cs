using System;

namespace JSONparcer {
    public class parcer {
        public static void Main(string[] args) {
            var json = System.IO.File.ReadAllText(@"d:\data\data_model.json");
            var objects = JArray.Parse(json);
            foreach(JObject root in objects) {
                foreach(KeyValuePair<String, JToken> app in root) {
                   
                }
            }
        }
    }
}