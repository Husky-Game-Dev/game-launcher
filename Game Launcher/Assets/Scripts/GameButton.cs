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

    private Sprite gameImage;

    [SerializeField] TextMeshProUGUI gameTitle;

    private void Start()
    {
        launcher = FindObjectOfType<LauncherUI>();
        pagedRect = GameObject.FindGameObjectWithTag("pageRect").GetComponent<PagedRect>();

        gameImage = Resources.Load<Sprite>(imagePath);
        gameObject.GetComponent<Image>().sprite = gameImage;

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
                string fullPath = Application.dataPath + path;
                var process = Process.Start(fullPath);
                launcher.LaunchGame(title, process);
            }
        }
    }
}
