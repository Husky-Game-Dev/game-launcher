using System.Diagnostics;
using TMPro;
using UI.Pagination;
using UnityEngine;
using UnityEngine.UI;

public class GameButton : MonoBehaviour
{
    public string title;
    public string path;
    public string url;
    public bool useURL;
    public string imagePath;

    private LauncherUI launcher;
    private PagedRect pagedRect;

    private Image gameImage;
    private Button button;

    [SerializeField] TextMeshProUGUI gameTitle;

    private void Start()
    {
        launcher = FindObjectOfType<LauncherUI>();
        pagedRect = GameObject.FindGameObjectWithTag("pageRect").GetComponent<PagedRect>();
        gameImage = Resources.Load<Image>(imagePath);
        button = gameObject.GetComponent<Button>();
        button.image = gameImage;
        gameTitle.text = title;
    }

    public void LaunchGame()
    {
        if (pagedRect.CurrentPage == gameObject.GetComponent<Page>().PageNumber)
        {
            if (useURL)
            {
                Application.OpenURL(url);
            }
            else
            {
                string path = Application.dataPath + url;
                var process = Process.Start(path);
                launcher.LaunchGame(title, process);
            }
        }
    }
}
