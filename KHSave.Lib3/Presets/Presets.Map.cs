using System.Collections.Generic;

namespace KHSave.Lib3.Presets
{
    public static partial class Presets
    {
        public class Map
        {
            public string Name { get; set; }
        }

        public static readonly Dictionary<string, Map> MAPS = new Dictionary<string, Map>
        {
            ["/Game/Levels/he/he_01/he_01"] = new Map { Name = "Realm of the Gods" },
            ["/Game/Levels/he/he_02/he_02"] = new Map { Name = "Mount Olympus" },
            ["/Game/Levels/he/he_03/he_03"] = new Map { Name = "Thebes (in flames)" },
            ["/Game/Levels/he/he_04/he_04"] = new Map { Name = "Thebes" },
            ["/Game/Levels/he/he_05/he_05"] = new Map { Name = "Titans battle arena" },
            ["/Game/Levels/he/he_06/he_06"] = new Map { Name = "Titans battle tornado" },
            ["/Game/Levels/he/he_50/he_50"] = new Map { Name = "Cutscene map" },
            ["/Game/Levels/he_DLC/he_52/he"] = new Map { Name = "DLC cutscene map" },
            ["/Game/Maps/he_DLC/umap/he_52/he_52_CheckMap"] = new Map { Name = "Thebes cutscene map (playable)" },
            ["/Game/Levels/tt/tt_01/tt_01"] = new Map { Name = "The Neighborhood" },
            ["/Game/Levels/tt/tt_40/tt_40"] = new Map { Name = "Bistro" },
            ["/Game/Levels/tt/tt_50/tt_50"] = new Map { Name = "Computer Laboratory" },
            ["/Game/Maps/tt/umap/tt_01/tt_01_CheckMap"] = new Map { Name = "Twilight Town (out of bounds)" },
            ["/Game/Levels/ts/ts_01/ts_01"] = new Map { Name = "Andy’s House" },
            ["/Game/Levels/ts/ts_02/ts_02"] = new Map { Name = "Galaxy Toys" },
            ["/Game/Levels/ts/ts_03/ts_03"] = new Map { Name = "Verux Rem Minigame" },
            ["/Game/Levels/ts/ts_04/ts_04"] = new Map { Name = "UFO battle arena" },
            ["/Game/Levels/ra/ra_01/ra_01"] = new Map { Name = "The Forest" },
            ["/Game/Levels/ra/ra_02/ra_02"] = new Map { Name = "The Kingdom" },
            ["/Game/Levels/ra/ra_50/ra_50"] = new Map { Name = "Cutscene map" },
            ["/Game/Maps/ra/umap/ra_02/ra_02_CheckMap"] = new Map { Name = "Lantern map (explorable)" },
            ["/Game/Levels/mi/mi_01/mi_01"] = new Map { Name = "Monsters. Inc." },
            ["/Game/Levels/mi/mi_02/mi_02"] = new Map { Name = "The Factory" },
            ["/Game/Levels/mi/mi_03/mi_03"] = new Map { Name = "The Powerplant" },
            ["/Game/Levels/mi/mi_04/mi_04"] = new Map { Name = "The Door Vault" },
            ["/Game/Levels/mi/mi_50/mi_50"] = new Map { Name = "Outside the factory" },
            ["/Game/Levels/ca/ca_01/ca_01"] = new Map { Name = "Port Royal" },
            ["/Game/Levels/ca/ca_02/ca_02"] = new Map { Name = "The High Seas" },
            ["/Game/Levels/ca/ca_03/ca_03"] = new Map { Name = "Unused map?" },
            ["/Game/Levels/ca/ca_04/ca_04"] = new Map { Name = "Davy Jones' Locker" },
            ["/Game/Levels/ca/ca_05/ca_05"] = new Map { Name = "Over the Edge" },
            ["/Game/Levels/ca/ca_50/ca_50"] = new Map { Name = "Cutscene map, no collision" },
            ["/Game/Levels/fz/fz_01/fz_01"] = new Map { Name = "The North Mountain" },
            ["/Game/Maps/fz/umap/fz_01/fz_01_CheckMap"] = new Map { Name = "The North Mountain" },
            ["/Game/Levels/fz/fz_02/fz_02"] = new Map { Name = "The Labyrinth of Ice" },
            ["/Game/Maps/fz/umap/fz_02/fz_02_CheckMap"] = new Map { Name = "The Labyrinth of Ice" },
            ["/Game/Levels/fz/fz_03/fz_03"] = new Map { Name = "Trinity Sled Minigame" },
            ["/Game/Levels/fz/fz_04/fz_04"] = new Map { Name = "" },
            ["/Game/Levels/fz/fz_05/fz_05"] = new Map { Name = "Sköl fight arena" },
            ["/Game/Levels/fz/fz_06/fz_06"] = new Map { Name = "" },
            ["/Game/Levels/bx/bx_01/bx_01"] = new Map { Name = "The Bridge" },
            ["/Game/Levels/bx/bx_02/bx_02"] = new Map { Name = "The City" },
            ["/Game/Levels/bx/bx_03/bx_03"] = new Map { Name = "Hiro's Garage" },
            ["/Game/Maps/dp/umap/dp_01/dp_01_CheckMap_Mezame"] = new Map { Name = "Station of Awakening (playable)" },
            ["/Game/Levels/dp/dp_01/dp_01"] = new Map { Name = "Land of Departure" },
            ["/Game/Levels/dp_DLC/dp_50/dp_50"] = new Map { Name = "DLC unused map" },
            ["/Game/Levels/dp_DLC/dp_50/dp"] = new Map { Name = "DLC cutscene" },
            ["/Game/Levels/kg/kg_01/kg_01"] = new Map { Name = "" },
            ["/Game/Levels/kg/kg_02/kg_02"] = new Map { Name = "" },
            ["/Game/Levels/kg/kg_03/kg_03"] = new Map { Name = "" },
            ["/Game/Levels/kg_DLC/kg_04/kg_04"] = new Map { Name = "" },
            ["/Game/Levels/kg_DLC/kg_04/kg_05"] = new Map { Name = "" },
            ["/Game/Levels/kg_DLC/kg_06/kg_06"] = new Map { Name = "Group Fight with Replica Xehanorts" },
            ["/Game/Levels/kg_DLC/kg_07/kg_07"] = new Map { Name = "Connect the Dots/Keyholes" },
            ["/Game/Levels/kg_DLC/kg_08/kg_08"] = new Map { Name = "Terranort fight" },
            ["/Game/Levels/kg/kg_50/kg_50"] = new Map { Name = "" },
            ["/Game/Levels/kg/kg_51/kg_51"] = new Map { Name = "" },
            ["/Game/Levels/kg_DLC/kg_52/kg_52"] = new Map { Name = "" },
            ["/Game/Levels/kg_DLC/kg_52/kg"] = new Map { Name = "" },
            ["/Game/Maps/kg_DLC/umap/kg_06/kg_06_CheckMap"] = new Map { Name = "Group Fight with Replica Xehanorts (explorable)" },
            ["/Game/Maps/kg_DLC/umap/kg_07/kg_07_CheckMap"] = new Map { Name = "Connect the Dots/Keyholes (explorable)" },
            ["/Game/Maps/kg_DLC/umap/kg_08/kg_08_CheckMap"] = new Map { Name = "Terranort fight (explorable)" },
            ["/Game/Levels/bt/bt_01/bt_01"] = new Map { Name = "The Stairway to the Sky" },
            ["/Game/Maps/bt/umap/bt_01/bt_01_CheckMap"] = new Map { Name = "The Stairway to the Sky (explorable)" },
            ["/Game/Levels/bt/bt_02/bt_02"] = new Map { Name = "The Stairway to the Sky - Deformed" },
            ["/Game/Maps/bt/umap/bt_02/bt_02_CheckMap"] = new Map { Name = "The Stairway to the Sky - Deformed (explorable)" },
            ["/Game/Levels/bt/bt_03/bt_03"] = new Map { Name = "The Stairway to the Sky - Underwater" },
            ["/Game/Maps/bt/umap/bt_03/bt_03_CheckMap"] = new Map { Name = "The Stairway to the Sky - Underwater (explorable)" },
            ["/Game/Levels/bt/bt_04/bt_04"] = new Map { Name = "The Stairway to the Sky - Destroyed" },
            ["/Game/Maps/bt/umap/bt_04/bt_04_CheckMap"] = new Map { Name = "The Stairway to the Sky - Destroyed (explorable)" },
            ["/Game/Levels/bt_DLC/bt_07/bt_07"] = new Map { Name = "Breezy Quarter" },
            ["/Game/Maps/bt_DLC/umap/bt_07/bt_07_CheckMap"] = new Map { Name = "Breezy Quarter (explorable)" },
            ["/Game/Levels/bt_DLC/bt_08/bt_08"] = new Map { Name = "The Stairway to the Sky (ReMind)" },
            ["/Game/Levels/bt/bt_50/bt_50"] = new Map { Name = "Chess room (cutscene)" },
            ["/Game/Maps/bt/umap/bt_50/bt_50"] = new Map { Name = "Chess room (explorable)" },
            ["/Game/Levels/bt_DLC/bt_51/bt_51"] = new Map { Name = "Blank screen" },
            ["/Game/Levels/yt/yt_50/yt_50"] = new Map { Name = "Yen Sid Tower (cutscene)" },
            ["/Game/Maps/yt/umap/yt_50/yt_50_CheckMap"] = new Map { Name = "Yen Sid Tower - Room" },
            ["/Game/Maps/yt/umap/yt_50/yt_50_tower"] = new Map { Name = "Yen Sid Tower - Tower garden" },
            ["/Game/Maps/dc/umap/dc_50/dc_50_basemap"] = new Map { Name = "Disney Castle (keep falling to explore)" },
            ["/Game/Levels/ew/ew_01/ew_01"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_02/ew_02"] = new Map { Name = "" },
            ["/Game/Levels/ew_DLC/ew_03/ew_03"] = new Map { Name = "" },
            ["/Game/Levels/ew_DLC/ew_04/ew_04"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_21/ew_21"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_22/ew_22"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_23/ew_23"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_24/ew_24"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_25/ew_25"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_26/ew_26"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_27/ew_27"] = new Map { Name = "" },
            ["/Game/Levels/ew/ew_28/ew_28"] = new Map { Name = "" },
            ["/Game/Maps/ew/umap/ew_01/ew_01_CheckMap_WaterWorld"] = new Map { Name = "Water world (explorable)" },
            ["/Game/Maps/ew/umap/ew_02/ew_02_CheckMap_Heart"] = new Map { Name = "Water world heart fragmented (explorable)" },
            ["/Game/Maps/ew/umap/ew_28/ew_28_CheckMap"] = new Map { Name = "Dive into world hearts" },
            ["/Game/Levels/rg_DLC/rg_01/rg_01"] = new Map { Name = "Merlin's House" },
            ["/Game/Levels/rg_DLC/rg_03/rg_03"] = new Map { Name = "Garden of Assemblage" },
            ["/Game/Levels/rg_DLC/rg_10/rg_10"] = new Map { Name = "Xehanort Data Battle" },
            ["/Game/Levels/rg_DLC/rg_11/rg_11"] = new Map { Name = "Ansem Data Battle" },
            ["/Game/Levels/rg_DLC/rg_12/rg_12"] = new Map { Name = "Xemnas Data Battle" },
            ["/Game/Levels/rg_DLC/rg_13/rg_13"] = new Map { Name = "Xigbar Data Battle" },
            ["/Game/Levels/rg_DLC/rg_14/rg_14"] = new Map { Name = "Luxord Data Battle" },
            ["/Game/Levels/rg_DLC/rg_15/rg_15"] = new Map { Name = "Larxene Data Battle" },
            ["/Game/Levels/rg_DLC/rg_16/rg_16"] = new Map { Name = "Marluxia Data Battle" },
            ["/Game/Levels/rg_DLC/rg_17/rg_17"] = new Map { Name = "Saix Data Battle" },
            ["/Game/Levels/rg_DLC/rg_18/rg_18"] = new Map { Name = "Terranort Data Battle" },
            ["/Game/Levels/rg_DLC/rg_19/rg_19"] = new Map { Name = "Riku Data Battle" },
            ["/Game/Levels/rg_DLC/rg_20/rg_20"] = new Map { Name = "Vanitas Data Battle" },
            ["/Game/Levels/rg_DLC/rg_21/rg_21"] = new Map { Name = "Young Xehanort Data Battle" },
            ["/Game/Levels/rg_DLC/rg_22/rg_22"] = new Map { Name = "Xion Data Battle" },
            ["/Game/Levels/rg/rg_50/rg_50"] = new Map { Name = "Radiant Garden (cutscene)" },
            ["/Game/Levels/rg/rg_51/rg_51"] = new Map { Name = "Radiant Garden (cutscene)" },
            ["/Game/Maps/rg_DLC/umap/rg_01/rg_01_CheckMap"] = new Map { Name = "Radiant Garden (explorable)" },
            ["/Game/Maps/rg_DLC/umap/rg_10/rg_10_CheckMap"] = new Map { Name = "Organization XIII Battle Map (explorable)" },
            ["/Game/Levels/dw/dw_21/dw_21"] = new Map { Name = "" },
            ["/Game/Maps/dw/umap/dw_21/dw_21_CheckMap"] = new Map { Name = "Dark World (playable)" },
            ["/Game/Levels/dw_DLC/dw_22/dw_22"] = new Map { Name = "" },
            ["/Game/Levels/dw_DLC/dw_22/dw"] = new Map { Name = "" },
            ["/Game/Levels/dw/dw_71/dw_71"] = new Map { Name = "" },
            ["/Game/Levels/dw/dw_71/dw"] = new Map { Name = "" },
            ["/Game/Maps/dw/umap/dw_71/dw_71_CheckMap"] = new Map { Name = "Dark World (playable cutscene)" },
            ["/Game/Levels/wm/wm_01/wm_01"] = new Map { Name = "World Map" },
            ["/Game/Levels/po/po_01/po_01"] = new Map { Name = "" },
            ["/Game/Levels/po/po_02/po_02"] = new Map { Name = "" },
            ["/Game/Levels/po/po_03/po_03"] = new Map { Name = "" },
            ["/Game/Levels/po/po_04/po_04"] = new Map { Name = "" },
            ["/Game/Levels/di/di_50/di_50"] = new Map { Name = "Destiny Island (infinite loading)" },
            ["/Game/Levels/di/di_50/di"] = new Map { Name = "Destiny Island (cutscene)" },
            ["/Game/Maps/di/umap/di_50/di_50_CheckMap"] = new Map { Name = "Destiny Island (playable)" },
            ["/Game/Levels/gm/gm_01/gm_01"] = new Map { Name = "Starlight Way" },
            ["/Game/Levels/gm/gm_02/gm_02"] = new Map { Name = "Misty Stream" },
            ["/Game/Levels/gm/gm_03/gm_03"] = new Map { Name = "Eclipse Galaxy" },
            ["/Game/Levels/gm/gm_50/gm"] = new Map { Name = "Gummiship (cutscene)" },
            ["/Game/Maps/gm/umap/gm_50/gm_50_CheckMap"] = new Map { Name = "Gummiship (explorable)" },
            ["/Game/Maps/gm/umap/gm_02/gm_02_Tornado_Map"] = new Map { Name = "Gummiship - Tornado map" },
            ["/Game/Levels/sf/sf_50/sf_50"] = new Map { Name = "" },
            ["/Game/Levels/sf/sf_50/sf"] = new Map { Name = "" },
            ["/Game/Levels/sp/sp_01/sp_01"] = new Map { Name = "" },
            ["/Game/Levels/ss/ss"] = new Map { Name = "" },
            ["/Game/Levels/ss_DLC/ss_01/ss_01"] = new Map { Name = "Shibuya - Yozora Fight" },
            ["/Game/Maps/ss_DLC/umap/ss_01/ss_01_CheckMap"] = new Map { Name = "Shibuya (explorable)" },
            ["/Game/Levels/ss/ss_50/ss_50"] = new Map { Name = "" },
            ["/Game/Levels/ss/ss_50/ss"] = new Map { Name = "" },
            ["/Game/Levels/ss_DLC/ss_51/ss"] = new Map { Name = "DLC secret ending" },
            ["/Game/Levels/ex/ex_21/ex_21"] = new Map { Name = "Battlegate 1, Olympus" },
            ["/Game/Levels/ex/ex_22/ex_22"] = new Map { Name = "Battlegate 2, Olympus" },
            ["/Game/Levels/ex/ex_23/ex_23"] = new Map { Name = "Battlegate 3, Twilight Town" },
            ["/Game/Levels/ex/ex_24/ex_24"] = new Map { Name = "Battlegate 4, Toy Box" },
            ["/Game/Levels/ex/ex_25/ex_25"] = new Map { Name = "Battlegate 5, Toy Box" },
            ["/Game/Levels/ex/ex_26/ex_26"] = new Map { Name = "Battlegate 6, Kingdom of Corona" },
            ["/Game/Levels/ex/ex_27/ex_27"] = new Map { Name = "Battlegate 7, Kingdom of Corona" },
            ["/Game/Levels/ex/ex_28/ex_28"] = new Map { Name = "Unused battlegate" },
            ["/Game/Levels/ex/ex_29/ex_29"] = new Map { Name = "Battlegate 8, Monstropolis" },
            ["/Game/Levels/ex/ex_30/ex_30"] = new Map { Name = "Unused battlegate" },
            ["/Game/Levels/ex/ex_31/ex_31"] = new Map { Name = "Battlegate 9, Arendelle" },
            ["/Game/Levels/ex/ex_32/ex_32"] = new Map { Name = "Unused battlegate" },
            ["/Game/Levels/ex/ex_33/ex_33"] = new Map { Name = "Battlegate 10, Caribbean" },
            ["/Game/Levels/ex/ex_34/ex_34"] = new Map { Name = "Battlegate 11, San Fransokyo" },
            ["/Game/Levels/ex/ex_35/ex_35"] = new Map { Name = "Battlegate 12, San Fransokyo" },
            ["/Game/Levels/ex/ex_36/ex_36"] = new Map { Name = "Unused battlegate" },
            ["/Game/Levels/ex/ex_37/ex_37"] = new Map { Name = "Battlegate 13, Keyblade Graveyard" },
            ["/Game/Levels/ex/ex_38/ex_38"] = new Map { Name = "Battlegate 14, Keyblade Graveyard" },
            ["/Game/Levels/ex/ex_39/ex_39"] = new Map { Name = "Battlegate 0, Battlegate at Keyblade Graveyard" },
            ["/Game/Levels/ex/ex_40/ex_40"] = new Map { Name = "Unused battlegate" },
        };
    }
}
