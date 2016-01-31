using UnityEngine;
using System.Collections;

public class EnumUtils {
    #region MagicClasses
    public enum MagicClasses {
        HERBOLOGY,
        MAGIC_ARTIFACTS,
        ALCHEMY
    }

    public enum Herbology {
        PLAGUE_CONTROL,
        MAGIC_PLANT_CARE
    }

        public enum Plague_Control {
            COLOR
        }
        public enum Magic_Plant_Care {
            SHAPE
        }

    public enum Magic_Artifacts {
        AMULETS,
        RUNES,
        WANDS
    }

        public enum Amulets {
            SHAPE
        }

        public enum RUNES {
            GLYPHS
        }

        public enum Wands {
            COLOR,
            MATERIAL
        }

    public enum Alchemy {
        POTIONS,
        GEMS,
        TRANSFIGURATION
    }

    public enum Potions {
        COLOR,
        SHAPE
    }

    public enum Gems {
        COLOR,
        SHAPE
    }

    public enum Transfiguration {
        COLOR,
        SHAPE,
        GLYPHS
    }

    #endregion

    #region LevelData
    public static PlayerPrefsKeys NEXTLEVEL = PlayerPrefsKeys.NEXTLEVEL;
    public static PlayerPrefsKeys LOADLEVELMODE = PlayerPrefsKeys.LOADLEVELMODE;

    public enum PlayerPrefsKeys {
        NEXTLEVEL,
        LOADLEVELMODE
    }
    #endregion

    #region GameFlow
    public enum EScreenState {
        SPLASH_SCREEN,
        LOADING_SCREEN,
        CREDITS_SCREEN,
        MAIN_MENU_SCREEN,
        IN_GAME_SCREEN
    }

    public enum ESplashState {
        PLAYING,
        DONE
    }

    public enum ELoadingState {
        LOADING,
        WAITING_INPUT,
        DONE
    }

    public enum ECreditsState {
        PLAYING,
        PAUSED,
        DONE
    }

    public enum EMainMenuState {
        MAIN,
        PLAY_DIALOG,
        SETTINGS_DIALOG,
        EXIT_DIALOG
    }

    public enum EGameState {
        PLAYING,
        PAUSED,
        CUTSCENE,
        TUTORIAL
    }
    #endregion
}