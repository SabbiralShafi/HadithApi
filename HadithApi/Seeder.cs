using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HadithApi.Data;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace HadithApi
{
    public static class Seeder
    {
        public static void SeedIt(IServiceProvider serviceProvider)
        {
            const string dataPath = "./hadith.json";
            var response = File.ReadAllText(dataPath);
            var allHadith = JsonConvert.DeserializeObject<ReadHadith>(response);

            if (!allHadith.doUpdate) return;

            using var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetService<HadithApiContext>();
            context.Hadith.RemoveRange(context.Hadith);
            context.Hadith.AddRange(allHadith.Hadiths!);
            context.SaveChanges();

            allHadith.doUpdate = false;
            File.WriteAllTextAsync(dataPath, JsonConvert.SerializeObject(allHadith));

        }
    }
}