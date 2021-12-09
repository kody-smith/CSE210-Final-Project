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
        public const int DEFAULT_FONT_SIZE = 40;
        public const int DEFAULT_TEXT_OFFSET = 4;

        // Images

        // Sounds

        //Player Constants
        public const int PLAYER_X = MAX_X/2;
        public const int PLAYER_Y = MAX_Y/2;
        public const int PLAYER_WIDTH = 50;
        public const int PLAYER_HEIGHT = 50;
        public const int PLAYER_SPEED = 10;
        public const string PLAYER_UP_IMAGE = "./Assets/player.png";
        public const string PLAYER_DOWN_IMAGE = "./Assets/playerDown.png";
        public const string PLAYER_LEFT_IMAGE = "./Assets/playerLeft.png";
        public const string PLAYER_RIGHT_IMAGE = "./Assets/playerRight.png";
        //Enemy Constants
        public const int ENEMY_X = MAX_X-100;
        public const int ENEMY_Y = MAX_Y-100;
        public const int ENEMY_DX = 5;
        public const int ENEMY_DY = 0;
        public const string ENEMY_RIGHT_IMAGE = "./Assets/enemyRight.png";
        public const string ENEMY_LEFT_IMAGE = "./Assets/enemyLeft.png";
        public const int ENEMY_WIDTH = 50;
        public const int ENEMY_HEIGHT = 50;
        //Wall Constants
        public const int WALL_WIDTH = 60;
        public const int WALL_HEIGHT = 30;
        public const string WALL_IMAGE = "./Assets/horizontalWall.png";
        //Vertical Wall Constants
        public const int VERT_WALL_WIDTH = 30;
        public const int VERT_WALL_HEIGHT = 60;
        public const string VERT_WALL_IMAGE = "./Assets/vertWall.png";
        //Door Constants
        public const int DOOR_WIDTH = 190;
        public const int DOOR_HEIGHT = 30;
        public const string DOOR_IMAGE = "./Assets/door.png";
        //Life Constants
        public const int LIFE_SPACE = 10;
        public const int LIFE_WIDTH = 24;
        public const int LIFE_HEIGHT = 24;
        public const int LIFE_MAX_X = 150;
        public const string LIFE_IMAGE = "./Assets/life.png";
        //PowerUp Constants
        public const int POWERUP_WIDTH = 12;
        public const int POWERUP_HEIGHT = 12;
        //Key Constants
        public const int KEY_WIDTH = 20;
        public const int KEY_HEIGHT = 30;
        public const string KEY_IMAGE = "./Assets/key.png";
        //Artifact Constants
        public const int ARTIFACT_WIDTH = 24;
        public const int ARTIFACT_HEIGHT = 36;
        public const string ARTIFACT_IMAGE = "./Assets/artifact.png";
        //Final Atrifact Constants
        public const int FINAL_ARTIFACT_WIDTH = 36;
        public const int FINAL_ARTIFACT_HEIGHT = 36;
        public const string FINAL_ARTIFACT_IMAGE = "./Assets/finalArtifact.png";

        //Sounds
        public const string BACKGROUND_MUSIC = "./Assets/mixkit-arcade-retro-background-219.wav";
        public const string FOOTSTEPS = "./Assets/mixkit-footsteps-in-a-tunnel-loop-543.wav";
        public const string COLLECT_ARTIFACT = "./Assets/mixkit-game-treasure-coin-2038.wav";
        public const string PAIN = "./Assets/mixkit-man-in-pain-2197.wav";
        public const string GAME_OVER = "./Assets/mixkit-retro-game-over-1947.wav";
        public const string WIN = "./Assets/mixkit-video-game-win-2016.wav";

    }

}