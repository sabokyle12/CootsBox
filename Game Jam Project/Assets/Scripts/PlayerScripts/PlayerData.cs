using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is basically a bunch of global variables

public class PlayerData
{
    public static int numCatCutsceneDeaths = 0;

    public static bool isFreeze = false;
    public static string hackType = "";
    public static int checkpoint = 0;

    public static bool isDead = false;
    public static bool isUsingDebug = false;

    public static int numDeaths = 0;
    public static int bossFightDeaths = 0;

    public static int numItemsCollected = 0;
    public static Dictionary<string, bool> itemsCollected = new Dictionary<string, bool>()
    {
        { "Computer", false },
        { "Painting", false },
        { "Desk", false },
        { "Chair", false }
    };

    public static int numHacksCompleted = 0;
    public static Dictionary<string, bool> hacksCompleted = new Dictionary<string, bool>()
    {
        { "Invincibility", false },
        { "Flying", false },
        { "DebugTool", false },
        { "TimeFreeze", false }
    };

    public static List<Vector3> startPos = new List<Vector3>(){
        new Vector3(5.95f, -1.92f, 0f),
        new Vector3(18f, 19f, 0f),
        new Vector3(38f, 19f, 0f)
        };

    public static List<string> bossDeathText = new List<string>()
    {
        "Hello (You must be a real hacker if you can see this message).",
        "You stand no chance against me.",
        "Where are your hacks now?",
        "Just give up.",
        "You know, it is literally impossible to beat this level.",
        "I am the developer, you have to press give up to continue lol"
    };

    public static List<string> cootsText = new List<string>()
    {
        "Are you a real hacker? This shouldn't be possible to see.",
        "What do you think you are doing? You know that cheating is illegal, right? I'll let you off the hook for now, but don't think about cheating again, or else...",
        "So you did it again... just wait and see what happens. I'll just fix that bug for now, but be warned.",
        "Stop hacking. This is your final warning.",
        "ENOUGH! It's time for you to pay the price for your misdeeds."
    };

    public static Dictionary<string, string> hackInfo = new Dictionary<string, string>()
    {
        { "Invincibility", "Invincibility: You cannot die." },
        { "Flying", "Flying: You can jump even when in midair." },
        { "DebugTool", "Debug Tool: When you click an pbstacle/enemy, it will disappear for 2 seconds (only one at a time)." },
        { "TimeFreeze", "Time Freeze: When you click, you stop all obstacles from moving/changing state. Click again to unfreeze." }
    };
}
