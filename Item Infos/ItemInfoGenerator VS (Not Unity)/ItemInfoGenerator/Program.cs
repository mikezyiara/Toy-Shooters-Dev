﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ItemInfoGenerator
{
    class Program
    {
        private const string ITEMS_PATH = "itemExt.json";
        // !! STREAMREADER SEARCHES FOR PATH IN bin/Debug/netcoreapp2.1
        // I will change that soon
        static void Main(string[] args)
        {
            var items = loadItems(ITEMS_PATH);
        }

        private static List<ItemInfo> loadItems(string path) 
        {
            
           
            List<ItemInfo> items;
            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<ItemInfo>>(json);
                    Console.WriteLine("Found the file and converted the objects");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found");
                Console.WriteLine(e.Message);
                items = new List<ItemInfo>();
            }
            return items;
        }
    }
}
