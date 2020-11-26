using KHSave.Attributes;
using KHSave.LibBbs.Attributes;

namespace KHSave.LibBbs.Types
{
    public enum CommandType : ushort
    {
        [Info] Empty = 0,
        [Finisher("Finish")] Finish = 0x003F,
        [Finisher("Air Flair 1")] AirFlair1 = 0x0040,
        [Finisher("Magic Pulse 1")] MagicPulse1 = 0x0041,
        [Finisher("Rising Rock 1")] RisingRock1 = 0x0042,
        [Finisher("Heat Slash 1")] HeatSlash1 = 0x0043,
        [Finisher("Gold Rush")] GoldRush = 0x0044,
        [Finisher("Air Flair 2")] AirFlair2 = 0x0045,
        [Finisher("Magic Pulse 2")] MagicPulse2 = 0x0046,
        [Finisher("Rising Rock 2")] RisingRock2 = 0x0047,
        [Finisher("Heat Slash 2")] HeatSlash2 = 0x0048,
        [Finisher("Ramuh's Judgement")] RamuhsJudgement = 0x0049,
        [Finisher("Twisted Hours")] TwistedHours = 0x004A,
        [Finisher("Surprise! 1")] Surprise1 = 0x004B,
        [Finisher("Air Flair 3")] AirFlair3 = 0x004C,
        [Finisher("Magic Pulse 3")] MagicPulse3 = 0x004D,
        [Finisher("Dark Star 1")] DarkStar1 = 0x004E,
        [Finisher("Heal Strike")] HealStrike = 0x004F,
        [Finisher("Random End")] RandomEnd = 0x0050,
        [Finisher("Surprise! 2")] Surprise2 = 0x0051,
        [Finisher("Air Flair 4")] AirFlair4 = 0x0052,
        [Finisher("Magic Pulse 4")] MagicPulse4 = 0x0053,
        [Finisher("Dark Star 2")] DarkStar2 = 0x0054,
        [Finisher("Explosion")] Explosion = 0x0055,
        [Finisher("Ice Burst")] IceBurst = 0x0056,
        [Finisher("Celebration")] Celebration = 0x0057,
        [Finisher("Stratosphere")] Stratosphere = 0x0058,
        [Finisher("Teleport Spike")] TeleportSpike = 0x0059,
        [Finisher("Demolition")] Demolition = 0x005A,
        [Attack("Quick Blitz")] QuickBlitz = 0x005B,
        [Attack("Blitz")] Blitz = 0x005C,
        [Attack("Magic Hour")] MagicHour = 0x005D,
        [Attack("Meteor Crash")] MeteorCrash = 0x005E,
        [Attack("Sliding Dash")] SlidingDash = 0x005F,
        [Attack("Fire Dash")] FireDash = 0x0060,
        [Attack("Dark Haze")] DarkHaze = 0x0061,
        [Attack("Sonic Blade")] SonicBlade = 0x0062,
        [Attack("Chaos Blade")] ChaosBlade = 0x0063,
        [Attack("Zantetsuken")] Zantetsuken = 0x0064,
        [Attack("Strike Raid")] StrikeRaid = 0x0065,
        [Attack("Freeze Raid")] FreezeRaid = 0x0066,
        [Attack("Treasure Raid")] TreasureRaid = 0x0067,
        [Attack("Spark Raid")] SparkRaid = 0x0068,
        [Attack("Wind Raid")] WindRaid = 0x0069,
        [Attack("Fire Surge")] FireSurge = 0x006A,
        [Attack("Barrier Surge")] BarrierSurge = 0x006B,
        [Attack("Thunder Surge")] ThunderSurge = 0x006C,
        [Attack("Aerial Slam")] AerialSlam = 0x006D,
        [Attack("Ars Solum")] ArsSolum = 0x006E,
        [Attack("Ars Arcanum")] ArsArcanum = 0x006F,
        [Attack("Time Splicer")] TimeSplicer = 0x0070,
        [Attack("Poison Edge")] PoisonEdge = 0x0071,
        [Attack("Wishing Edge")] WishingEdge = 0x0072,
        [Attack("Blizzard Edge")] BlizzardEdge = 0x0073,
        [Attack("Stun Edge")] StunEdge = 0x0074,
        [Attack("Slot Edge")] SlotEdge = 0x0075,
        [Attack("Fire Strike")] FireStrike = 0x0076,
        [Attack("Confusion Strike")] ConfusionStrike = 0x0077,
        [Attack("Binding Strike")] BindingStrike = 0x0078,
        [Attack("Tornado Strike")] TornadoStrike = 0x0079,
        [Attack("Brutal Blast")] BrutalBlast = 0x007A,
        [Attack("Magnet Spiral")] MagnetSpiral = 0x007B,
        [Attack("Salvation")] Salvation = 0x007C,
        [Attack("Windcutter")] Windcutter = 0x007D,
        [Attack("Limit Storm")] LimitStorm = 0x007E,
        [Attack("Collision Magnet")] CollisionMagnet = 0x007F,
        [Attack("Geo Impact")] GeoImpact = 0x0080,
        [Attack("Sacrifice")] Sacrifice = 0x0081,
        [Attack("Break Time")] BreakTime = 0x0082,
        [Magic("Fire")] Fire = 0x0083,
        [Magic("Fira")] Fira = 0x0084,
        [Magic("Firaga")] Firaga = 0x0085,
        [Magic("Dark Firaga")] DarkFiraga = 0x0086,
        [Magic("Fission Firaga")] FissionFiraga = 0x0087,
        [Magic("Triple Firaga")] TripleFiraga = 0x0088,
        [Magic("Crawling Fire")] CrawlingFire = 0x0089,
        [Magic("Blizzard")] Blizzard = 0x008A,
        [Magic("Blizzara")] Blizzara = 0x008B,
        [Magic("Blizzaga")] Blizzaga = 0x008C,
        [Magic("Triple Blizzaga")] TripleBlizzaga = 0x008D,
        [Magic("Thunder")] Thunder = 0x008E,
        [Magic("Thundara")] Thundara = 0x008F,
        [Magic("Thundaga")] Thundaga = 0x0090,
        [Magic("Thundaga Shot")] ThundagaShot = 0x0091,
        [Magic("Cure")] Cure = 0x0092,
        [Magic("Cura")] Cura = 0x0093,
        [Magic("Curaga")] Curaga = 0x0094,
        [Magic("Esuna")] Esuna = 0x0095,
        [Magic("Mine Shield")] MineShield = 0x0096,
        [Magic("Mine Square")] MineSquare = 0x0097,
        [Magic("Seeker Mine")] SeekerMine = 0x0098,
        [Magic("Zero Gravity")] ZeroGravity = 0x0099,
        [Magic("Zero Gravira")] ZeroGravira = 0x009A,
        [Magic("Zero Graviga")] ZeroGraviga = 0x009B,
        [Magic("Magnet")] Magnet = 0x009C,
        [Magic("Magnera")] Magnera = 0x009D,
        [Magic("Magnega")] Magnega = 0x009E,
        [Magic("Munny Magnet")] MunnyMagnet = 0x009F,
        [Magic("Energy Magnet")] EnergyMagnet = 0x00A0,
        [Magic("D-Link Magnet")] DLinkMagnet = 0x00A1,
        [Magic("Aero")] Aero = 0x00A2,
        [Magic("Aerora")] Aerora = 0x00A3,
        [Magic("Aeroga")] Aeroga = 0x00A4,
        [Magic("Warp")] Warp = 0x00A5,
        [Magic("Faith")] Faith = 0x00A6,
        [Magic("Deep Freeze")] DeepFreeze = 0x00A7,
        [Magic("Glacier")] Glacier = 0x00A8,
        [Magic("Ice Barrage")] IceBarrage = 0x00A9,
        [Magic("Firaga Burst")] FiragaBurst = 0x00AA,
        [Magic("Raging Storm")] RagingStorm = 0x00AB,
        [Magic("Mega Flare")] MegaFlare = 0x00AC,
        [Magic("Quake")] Quake = 0x00AD,
        [Magic("Tornado")] Tornado = 0x00AE,
        [Magic("Meteor")] Meteor = 0x00AF,
        [Magic("Transcendence")] Transcendence = 0x00B0,
        [Magic("Mini")] Mini = 0x00B1,
        [Magic("Blackout")] Blackout = 0x00B2,
        [Magic("Ignite")] Ignite = 0x00B3,
        [Magic("Confuse")] Confuse = 0x00B4,
        [Magic("Bind")] Bind = 0x00B5,
        [Magic("Poison")] Poison = 0x00B6,
        [Magic("Slow")] Slow = 0x00B7,
        [Magic("Stop")] Stop = 0x00B8,
        [Magic("Stopra")] Stopra = 0x00B9,
        [Magic("Stopga")] Stopga = 0x00BA,
        [Magic("Sleep")] Sleep = 0x00BB,
        [Consumable("Potion")] Potion = 0x00BC,
        [Consumable("Hi-Potion")] HiPotion = 0x00BD,
        [Consumable("Mega-Potion")] MegaPotion = 0x00BE,
        [Consumable("Ether")] Ether = 0x00BF,
        [Consumable("Mega-Ether")] MegaEther = 0x00C0,
        [Consumable("Panacea")] Panacea = 0x00C1,
        [Consumable("Elixir")] Elixir = 0x00C2,
        [Consumable("Megalixir")] Megalixir = 0x00C3,
        [Consumable("Balloon Letter")] BalloonLetter = 0x00C4,
        [Consumable("Vanilla Glitz")] VanillaGlitz = 0x00C5,
        [Consumable("Fabracadabra")] Fabracadabra = 0x00C6,
        [Consumable("Honeybunny")] Honeybunny = 0x00C7,
        [Consumable("Bueno Volcano")] BuenoVolcanoFirestorm = 0x00C8,
        [Consumable("Snow Bear")] SnowBearDiamondDust = 0x00C9,
        [Consumable("Spark Lemon")] SparkLemonThunderbolt = 0x00CA,
        [Consumable("Goofy Parfait")] GoofyParfait = 0x00CB,
        [Consumable("Royalberry")] Royalberry = 0x00CC,
        [Consumable("Sugary Skies")] SugarySkies = 0x00CD,
        [Consumable("Rockin' Crunch")] RockinCrunch = 0x00CE,
        [Consumable("Donald Fizz")] DonaldFizz = 0x00CF,
        [Consumable("Daisy Sorbet")] DaisySorbet = 0x00D0,
        [Consumable("Big Bad Pete")] BigBadPete = 0x00D1,
        [Consumable("Double Crunch")] DoubleCrunch = 0x00D2,
        [Friendship("Group Cure")] GroupCure = 0x00D3,
        [Friendship("Group Cura")] GroupCura = 0x00D4,
        [Friendship("Group Curaga")] GroupCuraga = 0x00D5,
        [Friendship("Group Esuna")] GroupEsuna = 0x00D6,
        [Friendship("Confetti")] Confetti = 0x00D7,
        [Friendship("Fireworks")] Fireworks = 0x00D8,
        [Friendship("Taunt")] Taunt = 0x00D9,
        [Friendship("Victory Pose")] VictoryPose = 0x00DA,
        [Info("Deck Scramble")] DeckScramble = 0x00DB,
        [Friendship("Vanish")] Vanish = 0x00DC,
        [Friendship("Unison Rush")] UnisonRush = 0x00DD,
        [Friendship("Voltage Stack")] VoltageStack = 0x00DE,
        [Friendship("Trinity Limit")] TrinityLimit = 0x00DF,
        [Info("Gold")] Gold = 0x00E0,
        [Info("Black")] Black = 0x00E1,
        [Info("Finish (Finish Command)")] FinishFinishCommand = 0x00E2,
        [Info("Wrath of Darkness (No Heart Fight)")] WrathofDarkness = 0x00E3,
        [Friendship("Sign of Faith (Mickey D-Link)")] SignofFaith = 0x00E4,
        [Friendship("Wish Circle (Cinderella D-Link)")] WishCircle = 0x00E5,
        [Friendship("Enchanted Step (Cinderella D-Link)")] EnchantedStep = 0x00E6,
        [Friendship("Wish Shot (Cinderella D-Link)")] WishShot = 0x00E7,
        [Friendship("Magic Mending (Cinderella D-Link)")] MagicMending = 0x00E8,
        [Friendship("Doc (Snow White D-Link)")] Doc = 0x00E9,
        [Friendship("Grumpy (Snow White D-Link)")] Grumpy = 0x00EA,
        [Friendship("Sneezy (Snow White D-Link)")] Sneezy = 0x00EB,
        [Friendship("Happy (Snow White D-Link)")] Happy = 0x00EC,
        [Friendship("Sleepy (Snow White D-Link)")] Sleepy = 0x00ED,
        [Friendship("Bashful (Snow White D-Link)")] Bashful = 0x00EE,
        [Friendship("Dopey (Snow White D-Link)")] Dopey = 0x00EF,
        [Friendship("Dark Spiral (Vanitas D-Link)")] DarkSpiral = 0x00F0,
        [Friendship("Dark Splicer (Vanitas D-Link)")] DarkSplicer = 0x00F1,
        [Friendship("Illusion-F")] IllusionF = 0x00F2,
        [Friendship("Illusion-L")] IllusionL = 0x00F3,
        [Friendship("Illusion-V")] IllusionV = 0x00F4,
        [Friendship("Illusion-R")] IllusionR = 0x00F5,
        [Friendship("Illusion-B")] IllusionB = 0x00F6,
        [Movement("Slide")] Slide = 0x00F8,
        [Movement("Jump")] Jump = 0x00F9,
        [Movement("High Jump")] HighJump = 0x00FA,
        [Movement("Dodge Roll")] DodgeRoll = 0x00FB,
        [Movement("Thunder Roll")] ThunderRoll = 0x00FC,
        [Movement("Cartwheel")] Cartwheel = 0x00FD,
        [Movement("Firewheel")] Firewheel = 0x00FE,
        [Movement("Air Slide")] AirSlide = 0x00FF,
        [Movement("Ice Slide")] IceSlide = 0x0100,
        [Movement("Reversal")] Reversal = 0x0101,
        [Movement("Glide")] Glide = 0x0102,
        [Movement("Superglide")] Superglide = 0x0103,
        [Movement("Fire Glide")] FireGlide = 0x0104,
        [Movement("Homing Slide")] HomingSlide = 0x0105,
        [Movement("Teleport")] Teleport = 0x0106,
        [Movement("Sonic Impact")] SonicImpact = 0x0107,
        [Movement("Doubleflight")] Doubleflight = 0x0108,
        [Defense("Block")] Block = 0x0109,
        [Defense("Renewal Block")] RenewalBlock = 0x010A,
        [Defense("Focus Guard")] FocusGuard = 0x010B,
        [Defense("Stun Block")] StunBlock = 0x010C,
        [Defense("Poison Block")] PoisonBlock = 0x010D,
        [Defense("Barrier")] Barrier = 0x010E,
        [Defense("Renewal Barrier")] RenewalBarrier = 0x010F,
        [Defense("Focus Barrier")] FocusBarrier = 0x0110,
        [Defense("Confuse Barrier")] ConfuseBarrier = 0x0111,
        [Defense("Stop Barrier")] StopBarrier = 0x0112,
        [Reprisal("Counter Rush")] CounterRush = 0x0113,
        [Reprisal("Counter Hammer")] CounterHammer = 0x0114,
        [Reprisal("Reversal Slash")] ReversalSlash = 0x0115,
        [Reprisal("Counter Barrier")] CounterBarrier = 0x0116,
        [Reprisal("Payback Raid")] PaybackRaid = 0x0117,
        [Reprisal("Payback Surge")] PaybackSurge = 0x0118,
        [Reprisal("Payback Fang")] PaybackFang = 0x0119,
        [Reprisal("Aerial Recovery")] AerialRecovery = 0x011A,
        [Shotlock("Shotlock")] Shotlock = 0x011B,
        [Shotlock("Meteor Shower")] MeteorShower = 0x011C,
        [Shotlock("Flame Salvo")] FlameSalvo = 0x011D,
        [Shotlock("Chaos Snake")] ChaosSnake = 0x011E,
        [Shotlock("Bubble Blaster")] BubbleBlaster = 0x011F,
        [Shotlock("Dark Volley")] DarkVolley = 0x0120,
        [Shotlock("Ragnarok")] Ragnarok = 0x0121,
        [Shotlock("Thunderstorm")] Thunderstorm = 0x0122,
        [Shotlock("Bio Barrage")] BioBarrage = 0x0123,
        [Shotlock("Prism Rain")] PrismRain = 0x0124,
        [Shotlock("Pulse Bomb")] PulseBomb = 0x0125,
        [Shotlock("Photon Charge")] PhotonCharge = 0x0126,
        [Shotlock("Absolute Zero")] AbsoluteZero = 0x0127,
        [Shotlock("Lightning Ray")] LightningRay = 0x0128,
        [Shotlock("Sonic Shadow")] SonicShadow = 0x0129,
        [Shotlock("Dark Link")] DarkLink = 0x012A,
        [Shotlock("Ultima Cannon")] UltimaCannon = 0x012B,
        [Shotlock("Lightbloom")] Lightbloom = 0x012C,
        [Shotlock("Multivortex")] Multivortex = 0x012D,
        [Info("Call")] Call = 0x0137,
        [Info("Last Dance")] LastDance = 0x0138,
        [Info("Saber Counter")] SaberCounter = 0x0139,
        [Info("Tornado Counter")] TornadoCounter = 0x013A,
        [Info("Rush Counter")] RushCounter = 0x013B,
        [Info("White Calm")] WhiteCalm = 0x013C,
        [Info("Selfless Prince")] SelflessPrince = 0x013D,
        [Info("Swing Slash")] SwingSlash = 0x013E,
        [Info("Astro Shot")] AstroShot = 0x013F,
        [Info("Astro Strike")] AstroStrike = 0x0140,
        [Info("Holy Burst")] HolyBurstVentus = 0x0141,
        [Info("Dual Limit")] DualLimit = 0x0142,
        [Info("Grab")] Grab = 0x0143,
        [Info("Bronco Strike")] BroncoStrike = 0x0144,
        [Info("Joint Force")] JointForce = 0x0145,
        [Info("Turn Over")] TurnOver = 0x0146,
        [Info("Heal Light")] HealLight = 0x0149,
        [Info("Nothing")] Nothing = 0x0151,
        [CommandStyleLevel1("Critical Impact")] CriticalImpact = 0x0152,
        [CommandStyleLevel1("Spellweaver")] Spellweaver = 0x0153,
        [CommandStyleLevel1("Fever Pitch")] FeverPitch = 0x0154,
        [CommandStyleLevel1("Firestorm")] Firestorm = 0x0155,
        [CommandStyleLevel1("Diamond Dust")] DiamondDust = 0x0156,
        [CommandStyleLevel1("Thunderbolt")] Thunderbolt = 0x0157,
        [CommandStyleLevel2("Cyclone")] Cyclone = 0x0158,
        [CommandStyleLevel2("Bladecharge")] Bladecharge = 0x0159,
        [CommandStyleLevel2("Sky Climber")] SkyClimber = 0x015A,
        [CommandStyleLevel2("Rockbreaker")] Rockbreaker = 0x015B,
        [CommandStyleLevel2("Ghost Drive")] GhostDrive = 0x015C,
        [CommandStyleLevel2("Rhythm Mixer")] RhythmMixer = 0x015D,
        [CommandStyleLevel2("Dark Impulse")] DarkImpulse = 0x015E,
        [CommandStyleLevel2("Wingblade")] Wingblade = 0x015F,
        [CommandStyleOther("Frozen Fortune")] FrozenFortune = 0x0160,
        [Info("-")] Empty2 = 0x0161,
        [Info("Nothing")] Nothing2 = 0x0162,
        [Dlink("Mickey")] Mickey = 0x0163,
        [Dlink("Donald")] Donald = 0x0164,
        [Dlink("Goofy")] Goofy = 0x0165,
        [Dlink("Experiment 626")] Experiment626 = 0x0166,
        [Dlink("Peter Pan")] PeterPan = 0x0167,
        [Dlink("Maleficent")] Maleficent = 0x0168,
        [Dlink("Cinderella")] Cinderella = 0x0169,
        [Dlink("Snow White")] SnowWhite = 0x016A,
        [Dlink("Zack")] Zack = 0x016B,
        [Dlink("Pete")] Pete = 0x016C,
        [Dlink("Aqua")] Aqua = 0x016D,
        [Dlink("Ventus")] Ventus = 0x016E,
        [Dlink("Terra")] Terra = 0x016F,
        [Dlink("X Aqua")] XAqua = 0x0170,
        [Dlink("X Ventus")] XVentus = 0x0171,
        [Dlink("X Terra")] XTerra = 0x0172,
        [Dlink("Vanitas")] Vanitas = 0x0173,
        [Dlink("Mickey")] Mickey2 = 0x0174,
        [Dlink("Donald")] Donald2 = 0x0175,
        [Dlink("Goofy")] Goofy2 = 0x0176,
        [Dlink("Experiment 626")] Experiment6262 = 0x0177,
        [Dlink("Peter Pan")] PeterPan2 = 0x0178,
        [Dlink("Maleficent")] Maleficent2 = 0x0179,
        [Dlink("Cinderella")] Cinderella2 = 0x017A,
        [Dlink("Snow White")] SnowWhite2 = 0x017B,
        [Dlink("Zack")] Zack2 = 0x017C,
        [Dlink("Pete")] Pete2 = 0x017D,
        [Dlink("Aqua")] Aqua2 = 0x017E,
        [Dlink("Ventus")] Ventus2 = 0x017F,
        [Dlink("Terra")] Terra2 = 0x0180,
        [Dlink("Player 1's Mirage Arena Name")] Player1sMirageArenaName = 0x0181,
        [Dlink("Player 2's Mirage Arena Name")] Player2sMirageArenaName = 0x0182,
        [Dlink("Player 3's Mirage Arena Name")] Player3sMirageArenaName = 0x0183,
        [Dlink("Player 4's Mirage Arena Name")] Player4sMirageArenaName = 0x0184,
        [Dlink("Player 5's Mirage Arena Name")] Player5sMirageArenaName = 0x0185,
        [Dlink("Player 6's Mirage Arena Name")] Player6sMirageArenaName = 0x0186,
        [Dlink("Player 7's Mirage Arena Name")] Player7sMirageArenaName = 0x0187,
        [Dlink("Player 8's Mirage Arena Name")] Player8sMirageArenaName = 0x0188,
        [Info("Return")] Return = 0x0189,
        [Info("Nothing")] Nothing3 = 0x018A,
        [Info("Illusion lvl")] Illusionlvl = 0x018B,
        [Info("Illusion-S")] IllusionS = 0x018C,
        [Info("Illusion-B")] IllusionB2 = 0x018D,
        [Info("Illusion-P")] IllusionP = 0x018E,
        [Info("Illusion-I")] IllusionI = 0x018F,
        [Friendship("Borrow/Surface")] BorrowSurface = 0x019B,
        [Attack("Stomp")] Stomp = 0x019C,
        [Magic("Aromatherapy")] Aromatherapy = 0x019D,
        [Attack("Bloody Bounce")] BloodyBounce = 0x019F,
        [Info("Avoid Jump")] AvoidJump = 0x01A0,
        [Info("Block")] Block2 = 0x01A1,

        //Move abilities into seperate enum for better accessibility
    }
}
