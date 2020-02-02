using System;
using System.Collections.Generic;
using System.Text;

namespace ItemInfoGenerator
{

   
    public class ItemInfo
    {

        private int id;
        private string name;
        private int price_c;
        private int price_p;
        private string type;
        private string description;
        private int power;
        private int range; // melee
        private int run_speed; //melee
        private int secondary_power; // melee
        private int firing_rate; //sg, sniper, zooka etc
        private int accuracy;
        private int reload_speed;
        private int weapon_bullets;
        private int bullets_max;
        private int warm_up_time; // mg
        private int blast_radius; // bazooka
        private int bullet_speed; // bazooka
        private double explosion_armor; //explosion armor
        private double bullet_armor; // bullet armor
        private int shotgun_bullets; // extra from accesory
        private int rifle_bullets; // extra from accesory
        private int bazooka_bullets; // extra from accesory
        private int grenade_bullets; // extra from accesory
        private int gatling_bullets; // extra from accesory
        private int sniper_bullets; // extra from accesory
        private int tank; // sets
        private double move_speed; // sets
        private int rarity; // 1-5

        public ItemInfo(int id, string name, int price_c, int price_p, string type, string description,
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
