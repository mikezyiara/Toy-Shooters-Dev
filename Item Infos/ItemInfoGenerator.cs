using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;

public class ItemInfoGenerator : MonoBehaviour
{
    public static string ITEMS_PATH = "/ItemInfoGenerator/itemExt.json";
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            string json = File.ReadAllText(Application.dataPath + ITEMS_PATH);
            json = fixItemListJson(json);
            Debug.Log(json);
            ItemList list = JsonUtility.FromJson<ItemList>(json);
            List<Item> items = list.itemList;
            foreach (Item it in items)
            {
                Debug.Log(it.id + " | " + it.description);
            }
        }
        catch (Exception e)
        {
            Debug.Log("File not found!");
            Debug.Log(e.Message);
        }
        

    }

    public string fixItemListJson(string json)
    {
        return "{\"itemList\":" + json + "}";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public class ItemList
    {
        public List<Item> itemList;
    }



    [Serializable]
    public class Item
    {

       

        public int id;
        public string name;
        public int price_c;
        public int price_p;
        public string type;
        public string description;
        public int power;
        public int range; // melee
        public int run_speed; //melee
        public int secondary_power; // melee
        public int firing_rate; //sg, sniper, zooka etc
        public int accuracy;
        public int reload_speed;
        public int weapon_bullets;
        public int bullets_max;
        public int warm_up_time; // mg
        public int blast_radius; // bazooka
        public int bullet_speed; // bazooka
        public double explosion_armor; //explosion armor
        public double bullet_armor; // bullet armor
        public int shotgun_bullets; // extra from accesory
        public int rifle_bullets; // extra from accesory
        public int bazooka_bullets; // extra from accesory
        public int grenade_bullets; // extra from accesory
        public int gatling_bullets; // extra from accesory
        public int sniper_bullets; // extra from accesory
        public int tank; // sets
        public double move_speed; // sets
        public int rarity; // 1-5

        public Item(int id, string desc, int cash)
        {
            this.id = id;
            this.description = desc;
            this.price_c = cash;
        }


        public Item(int id, string name, int price_c, int price_p, string type, string description,
                        int power, int range, int run_speed, int secondary_power, int firing_rate, int accuracy,
                        int reload_speed, int weapon_bullets, int bullets_max, int warm_up_time, int blast_radius, int bullet_speed,
                        double explosion_armor, double bullet_armor, int shotgun_bullets, int rifle_bullets, int bazooka_bullets,
                        int grenade_bullets, int gatling_bullets, int sniper_bullets, int tank, double move_speed, int rarity)
        {
            this.id = id;
            this.name = name;
            this.price_c = price_c;
            this.price_p = price_p;
            this.type = type;
            this.description = description;
            this.power = power;
            this.range = range;
            this.run_speed = run_speed;
            this.secondary_power = secondary_power;
            this.firing_rate = firing_rate;
            this.accuracy = accuracy;
            this.reload_speed = reload_speed;
            this.weapon_bullets = weapon_bullets;
            this.bullets_max = bullets_max;
            this.warm_up_time = warm_up_time;
            this.blast_radius = blast_radius;
            this.bullet_speed = bullet_speed;
            this.explosion_armor = explosion_armor;
            this.bullet_armor = bullet_armor;
            this.shotgun_bullets = shotgun_bullets;
            this.rifle_bullets = rifle_bullets;
            this.bazooka_bullets = bazooka_bullets;
            this.grenade_bullets = grenade_bullets;
            this.gatling_bullets = gatling_bullets;
            this.sniper_bullets = sniper_bullets;
            this.tank = tank;
            this.move_speed = move_speed;
            this.rarity = rarity;


        }



        public enum ItemType
        {
            Melee,
            Rifle,
            Shotgun,
            Sniper,
            Minigun,
            Bazooka,
            Grenade,
            Head,
            Face,
            Accesories,
            Top,
            Pants,
            Shoes,
            Set

        }

    }
}
