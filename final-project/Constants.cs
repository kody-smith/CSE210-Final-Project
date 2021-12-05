using System;

namespace final_project
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 2000;
        public const int MAX_Y = 1300;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        // Images

        // Sounds

        //Player Constants
        public const int PLAYER_X = MAX_X/2;
        public const int PLAYER_Y = MAX_Y/2;
        public const int PLAYER_WIDTH = 24;
        public const int PLAYER_HEIGHT = 24;
        public const int PLAYER_SPEED = 15;
        //Enemy Constants
        public const int ENEMY_X = MAX_X-100;
        public const int ENEMY_Y = MAX_Y-100;
        public const int ENEMY_DX = 5;
        public const int ENEMY_DY = 0;
        public const int ENEMY_WIDTH = 24;
        public const int ENEMY_HEIGHT = 24;
        //Wall Constants
        public const int WALL_WIDTH = 60;
        public const int WALL_HEIGHT = 30;
        //Vertical Wall Constants
        public const int VERT_WALL_WIDTH = 30;
        public const int VERT_WALL_HEIGHT = 60;
        //Door Constants
        public const int DOOR_WIDTH = 190;
        public const int DOOR_HEIGHT = 30;
        //Life Constants
        public const int LIFE_SPACE = 10;
        public const int LIFE_WIDTH = 24;
        public const int LIFE_HEIGHT = 24;
        public const int LIFE_MAX_X = 150;
        //PowerUp Constants
        public const int POWERUP_WIDTH = 12;
        public const int POWERUP_HEIGHT = 12;
        //Key Constants
        public const int KEY_WIDTH = 12;
        public const int KEY_HEIGHT = 12;
        //Artifact Constants
        public const int ARTIFACT_WIDTH = 12;
        public const int ARTIFACT_HEIGHT = 24;
        //Final Atrifact Constants
        public const int FINAL_ARTIFACT_WIDTH = 24;
        public const int FINAL_ARTIFACT_HEIGHT = 24;

    }

}