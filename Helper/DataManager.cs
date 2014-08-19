using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace iOS.Data
{
    public static class DataManager
    {

      public static IEnumerable<Influencer> GetTopInfluencers()
      {
          var path = Path.Combine(System.Environment.CurrentDirectory,
              @"data/data.json");

          var json = File.ReadAllText(path);
          
          var list = JsonConvert.DeserializeObject<List<Influencer>>(json);

          return list;
      }
    }
}