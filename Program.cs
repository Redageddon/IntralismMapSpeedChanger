using System;
using System.IO;
using Newtonsoft.Json;

namespace IntralismMapSpeedChanger
{
    internal static class Program
    {
        private static void Main()
        {
            var speedChange = ConsoleDataPuller.Get(
                "Enter the speed you want to change a beatmap. " + Environment.NewLine + "Ex: input of 2 doubles the map speed", 
                "Incorrect input, please enter a decimal number.", 
                (string str, out float val) => !float.TryParse(str, out val));
            
            var beatmapDirectory = ConsoleDataPuller.Get(
                "Enter the directory to the beatmap.", 
                "Incorrect directory, Please input an existing directory.",
                (string str, out string val) => !Directory.Exists(val = str));

            var beatmapPath = Path.Combine(beatmapDirectory, "config.txt");
            var beatmapData = File.ReadAllText(beatmapPath);
            var beatmap = JsonConvert.DeserializeObject<Beatmap>(beatmapData);
            beatmap.events.ForEach(e => e.time *= 1 / speedChange);
            
            File.WriteAllText(beatmapPath, JsonConvert.SerializeObject(beatmap));

            Console.WriteLine("Beatmap speed changed. Press any key to exit");
            Console.ReadKey();
        }
    }
}