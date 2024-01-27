using System.Diagnostics;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    public string title;
    public string path;
    public string url;
    public bool useURL;
    private LauncherUI launcher;

    private void Start()
    {
        launcher = FindObjectOfType<LauncherUI>();
    }

    public void LaunchGame()
    {
        // if exe
        // else if webgl
        string path = Application.dataPath + url;
        var process = Process.Start(path);
        launcher.LaunchGame(title, process);
    }
}
