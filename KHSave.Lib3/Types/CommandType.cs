/*
    Kingdom Save Editor
    Copyright (C) 2020 Luciano Ciccariello

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using KHSave.Attributes;

namespace KHSave.Lib3.Types
{
    public enum CommandType : int
    {
        [Info] Empty,
        [Command(" ")] Empty_1 = 0x1,
        [Command("Payback Strike")] PaybackStrike = 0x2,
        [Command("Counter Slash")] CounterSlash = 0x3,
        [Command("Counter Impact")] CounterImpact = 0x4,
        [Command("Counter Kick")] CounterKick = 0x5,
        [Command("Counter Blast")] CounterBlast = 0x6,
        [Command("Rising Hook")] RisingHook = 0x7,
        [Command("Risk Raid")] RiskRaid = 0x8,
        Backslash = 0x9,
        [Command("Teleport Slash")] TeleportSlash = 0xa,
        [Command("Diving Strike")] DivingStrike = 0xb,
        [Command("Final Blow")] FinalBlow = 0xc,
        Raid = 0xd,
        [Command("Nano Counter")] NanoCounter = 0xe,
        [Command("Counter Blade")] CounterBlade = 0xf,
        [Command("Wrathful Fist")] WrathfulFist = 0x10,
        [Command("Wrathful Flurry")] WrathfulFlurry = 0x11,
        [Command("Flame Torrent")] FlameTorrent = 0x12,
        [Command("Flame Barrage")] FlameBarrage = 0x13,
        Lightning = 0x14,
        Sneeze = 0x15,
        [Command("Unison Fire")] UnisonFire = 0x16,
        [Command("Unison Blizzard")] UnisonBlizzard = 0x17,
        [Command("Unison Thunder")] UnisonThunder = 0x18,
        [Command("Fusion Spin")] FusionSpin,
        [Command("Fusion Rocket")] FusionRocket,
        Attack,
        [Command(" ")] Empty_1C,
        [Magic] Fire,
        [Magic] Fira,
        [Magic] Firaga,
        [Magic("Firaza [Doesn't work]")] Firaza,
        [Magic] Blizzard,
        [Magic] Blizzara,
        [Magic] Blizzaga,
        [Magic("Blizzaza [Doesn't work]")] Blizzaza,
        [Magic] Thunder,
        [Magic] Thundara,
        [Magic] Thundaga,
        [Magic("Thundaza [Doesn't work]")] Thundaza,
        [Magic] Water,
        [Magic] Watera,
        [Magic] Waterga,
        [Magic("Waterza [Doesn't work]")] Waterza,
        [Magic] Aero,
        [Magic] Aerora,
        [Magic] Aeroga,
        [Magic("Aeroza [Doesn't work]")] Aeroza,
        [Magic] Cure,
        [Magic] Cura,
        [Magic] Curaga,
        [Magic("Curaza [Doesn't work]")] Curaza,
        [Magic("Sea-Fire")] SeaFire,
        [Magic("Sea-Blizzard")] SeaBlizzard,
        [Magic("Sea-Thunder")] SeaThunder,
        [Magic("Sea-Aero")] SeaAero,
        Unused,
        [Consumable("Potion")] Potion,
        [Consumable("Hi-Potion")] HiPotion,
        [Consumable("Mega-Potion")] MegaPotion,
        [Consumable("Ether")] Ether,
        [Consumable("Hi-Ether")] HiEther,
        [Consumable("Mega-Ether")] MegaEther,
        [Consumable("Elixir")] Elixir,
        [Consumable("Megalixir")] Megalixir,
        [Consumable("Refocuser")] Refocuser,
        [Consumable("Hi-Refocuser")] HiRefocuser,
        [Consumable("Panacea")] Panacea,
        Unused40,
        [Link("Meow Wow Balloon")] MeowWowBaloon,
        [Link("8-Bit Blast")] EightBitBlast,
        [Link("King's Flare")] KingFlare,
        [Link("Plasma Encounter")] PlasmaEncounter,
        [Link("Sea Spectacle")] SeaSpectacle,
        Finish,
        Save,
        Talk,
        Open,
        [Command("Examine")] Unused41,
        [Command("Shop")] Unused42,
        [Command("Help")] Unused43,
        [Command("Board")] Unused44,
        [Command("Take the Helm")] Unused45,
        [Command("Ride")] Unused46,
        [Command("Eject")] Unused47,
        [Command("Mag Assemble")] Unused48,
        [Command("Get On")] GetOn,
        [Command("Ride")] Ride_58,
        [Command("Cover Shot")] Unused51,
        [Command("Cover Slide")] Unused52,
        [Command("Perform")] Unused53,
        [Command("Splash")] Unused54,
        [Command("Reach Out")] Unused55,
        [Command("Board")] Unused56,
        [Command("Raging Cannons")] RagingCannons,
        [Command("Wind Chasers")] WindChasers,
        [Command("Tidal Wave")] TidalWave,
        Tailwind,
        Swing,
        [Command("Boinnng!")] Boinnng,
        [Command("")] Empty_65,
        [Command("Send Postcard")] SendPostcard,
        [Command("Choose Vitality")] ChooseVitality,
        [Command("Choose Wisdom")] ChooseWisdom,
        [Command("Choose Balance")] ChooseBalance,
        [Command("Choose the Warrior")] ChooseTheWarrior,
        [Command("Choose the Mystic")] ChooseTheMystic,
        [Command("Choose the Guardian")] ChooseTheGuardian,
        [Command("Return to the Light")] ReturnToTheLight,
        [Magic("Fira")] Fira_6E,
        [Magic("Firaga")] Firaga_6F,
        [Magic("Firaza")] Firaza_70,
        [Magic("Blizzara")] Blizzara_71,
        [Magic("Blizzaga")] Blizzaga_72,
        [Magic("Blizzaza")] Blizzaza_73,
        [Magic("Thundara")] Thundara_74,
        [Magic("Thundaga")] Thundaga_75,
        [Magic("Thundaza")] Thundaza_76,
        [Magic("Watera")] Watera_77,
        [Magic("Waterga")] Waterga_78,
        [Magic("Waterza")] Waterza_79,
        [Magic("Aerora")] Aerora_7A,
        [Magic("Aeroga")] Aeroga_7B,
        [Magic("Aeroza")] Aeroza_7C,
        [Magic("Curaza")] Curaza_7D,
        [Command("Dark Firaga")] DarkFiraga,
        [Command(" ")] Empty_7F,
        [Command("Double Arrowguns")] DoubleArrowguns,
        [Command("Hyper Hammer")] HyperHammer,
        [Command("Twin Yo-Yos")] TwinYoYos,
        [Command("Magic Launcher")] MagicLauncher,
        [Command("Drill Punch")] DrillPunch,
        [Command("Blizzard Blades")] BlizzardBlades,
        [Command("Nano Arms")] NanoArms,
        [Command("Ultimate Form")] UltimateForm,
        [Command("Mirage Staff")] MirageStaff,
        Countershield,
        [Command("Agile Claws")] AgileClaws,
        [Command("Rage Form")] RageForm,
        Highwind,
        [Command("Storm Flag")] StormFlag,
        [Command("Hunny Blasters")] HunnyBlasters,
        [Command("Hunny Launcher")] HunnyLauncher,
        [Command("Blizzard Claws")] BlizzardClaws,
        [Command("Frying Pan")] FryingPan,
        [Command("Boom Hammer")] BoomHammer,
        [Command("Clock Drill")] ClockDrill,
        [Command("Second Form")] SecondForm,
        [Command("Second Form S (Starlight)")] SecondFormS,
        [Command("Second Form M (Midnight Blue)")] SecondFormM,
        [Command("Second Form P (Phantom Green)")] SecondFormP,
        [Command("Second Form D (Dusk til Dawn)")] SecondFormD,
        Spellweaver,
        [Command(" ")] Empty_9A,
        [Command("Finish")] Finish_9B,
        [Command("Finish")] Finish_9C,
        [Command("Finish")] Finish_9D,
        [Command("Finish")] Finish_9E,
        [Command("Finish")] Finish_9F,
        [Command("Finish")] Finish_A0,
        [Command("Finish")] Finish_A1,
        [Command("Finish")] Finish_A2,
        [Command("Finish")] Finish_A3,
        [Command("Finish")] Finish_A4,
        [Command("Finish")] Finish_A5,
        [Command("Finish")] Finish_A6,
        [Command("Finish")] Finish_A7,
        [Command("Finish")] Finish_A8,
        [Command("Double Duel")] DoubleDuel,
        [Command("Thunder")] Thunder_AA,
        [Command("Stun Impact")] StunImpact,
        [Command("Sonic Blade")] SonicBlade,
        [Command("Ars Arcanum")] ArsArcanum,
        [Command("Ancient Light")] AncientLight,
        [Command("Rave")] Unused137,
        [Command("Blast")] Unused138,
        [Command("Bash")] Unused139,
        [Command("Finish")] Unused140,
        [Command("Riskcharge")] Unused141,
        [Command("Union x")] UnionX,
        [Command("USERNAME")] USERNAME_1,
        [Command("USERNAME")] USERNAME_2,
        [Command("USERNAME")] USERNAME_3,
        [Command("USERNAME")] USERNAME_4,
        [Command("USERNAME")] USERNAME_5,
        [Command("Mountain Coaster")] MountainCoaster,
        [Command("Pirate Ship")] PirateShip,
        [Command("Mad Tea Cups")] MadTeaCups,
        [Command("Blaster Blaze")] BlasterBlaze,
        [Command("Magic Carousel")] MagicCarrousel,
        [Command("Splash Run")] SplashRun,
        [Command("Finish")] Finish_C0,
        [Command("Trinity Guard")] TrinityGuard,
        [Info("Infinite jump")] TrinitySled,
        [Command("Goofy Bombardier")] GoofyBombardier,
        [Command(" ")] Empty_C4,
        [Command(" ")] Empty_C5,
        [Info("Infinite jump")] Empty_C6,
        [Command("Scream Strike")] ScreamStrike,
        [Command("Never Fear")] NeverFear,
        [Info("Infinite jump")] Empty_C9,
        [Command("Heroic Swing")] HeroicSwing,
        [Command("Mighty Avalanche")] MightyAvalanche,
        [Command("Rocket Ruckus")] RocketRuckus,
        [Command("Tangled Twist")] TangledTwist,
        [Command("Tree Whip")] TreeWhip,
        [Command("Donald Meteor")] DonaldMeteor,
        [Command("Flare Force")] FlareForce,
        [Command("Interceptor Wing")] InterceptorWing,
        [Command("Subzero Impact")] SubzeroImpact,
        [Command("Last Ray")] LastRay,
        Trinity,
        Sora,
        [Command("Finish")] Finish_D7,
        [Command("Light Burst")] Unused177,
        [Command("Dark Burst")] Unused178,
        [Command("Dual Smasher")] Unused179,
        [Command("Dual Counter")] Unused180,
        [Command("Starcracker")] Unused181,
        [Command("Reversal")] Unused182,
        [Command("Light Form")] Unused183,
        [Command("Dark Form")] Unused184,
        [Command("Double Form OKP")] Unused185,
        [Command("Double Form OBV")] Unused186,
        [Command("Finish")] Unused187,
        [Command("Finish")] Unused233,
        [Command("Dual Shot")] Unused188,
        [Command("Seven Wishes")] Unused189,
        [Command("Dispel")] Unused190,
        [Command("Showdown")] Unused191,
        [Command("Dual Shot")] Unused192,
        [Command("Sora")] Unused193,
        [Command("Help")] Unused194,
        [Command("Help")] Unused195,
        [Command("Help")] Unused196,
        [Command("Help")] Unused197,
        [Command("Faith Volley")] Unused198,
        [Command("Icy Slider")] Unused199,
        [Command("Thinking of You")] Unused200,
        [Command("True End")] Unused201,
        [Command("Connecting Hearts")] Unused202,
        [Command("One Heart")] Unused203,
        [Command("Blitz")] Unused204,
        [Command("Usual Adventure")] Unused205,
        [Command("Easy Adventure")] Unused206,
        [Command("Challenging  Adventure")] Unused207,
        [Command("Draw Card")] Unused208,
        [Command(" ")] Unused209,
        [Command(" ")] Unused210,
        [Command(" ")] Unused211,
        [Command(" ")] Unused212,
        [Command(" ")] Unused213,
        [Command(" ")] Unused214,
        [Command(" ")] Unused215,
        [Command("Crash")] Crash,
    }
}
