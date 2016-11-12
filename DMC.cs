using Rocket.API;

namespace DeathMessages
{
    public class DMC2 : IRocketPluginConfiguration
    {
        public bool suicidemsg;
        public bool healthwarningmsg;
        public bool foodwarningmsg;
        public bool waterwarningmsg;
        public bool viruswarningmsg;
        public string warning1;
        public string warning2;
        public string zombie;
        public string gun;
        public string melee;
        public string melee2;
        public string punch;
        public string punch2;
        public string roadkill;
        public string vehicle;
        public string food;
        public string water;
        public string infection;
        public string bleeding;
        public string suicide;
        public string landmine;
        public string breath;
        public string grenade;
        public string charge;
        public string missile;
        public string freezing;
        public string bones;
        public string sentry;
        public string splash;
        public string headshotgun;
        public string headchop;
        public string headpunch;
        public string shred;
        public string shred2;
        public string acid;
        public string spit;
        public string fire;
        public string spark;
        public string boulder;
        
        public void LoadDefaults()
        {

                    suicidemsg = true;
                    healthwarningmsg = true;
                    warning1 = "WARNING: You are about to die!";
                    warning2 = "We recommend you to patch yourself up!";
                    zombie = "has been mauled by a zombie!";
                    gun = "shot and killed";
                    melee = "has melee'd";
                    melee2 = "to death!";
                    punch = "has punched";
                    punch2 = "to death!";
                    roadkill = "ran over";
                    vehicle = "has died due to an explosion of a vehicle!";
                    food = "has starved to death!";
                    water = "has dehydrated to death!";
                    infection = "has become a zombie himself!";
                    bleeding = "has bled to death!";
                    suicide = "has killed himself!";
                    landmine = "has been blown up by a landmine!";
                    breath = "died of holding his breath for too long!";
                    grenade = "blew up by a grenade!";
                    charge = "was obliterated by a charge!";
                    missile = "was annihilated by a missile!";
                    freezing = "froze to death!";
                    bones = "fell to their death!";
                    sentry = "was shot down by a sentry";
                    splash = " was killed by splash damage!";
                    headshotgun = "was shot in the head by";
                    headchop = "was slashed in the head by";
                    headpunch = "was punched in the head by";
                    shred = "has been shreaded to death!";
                    acid = "was killed by acid";
                    spit = "was killed by spit!";
                    fire = "was killed by fire!";
                    spark = "has been sparked out";
                    boulder = "was killed by a gigantic boulder!";

        }
    }
}