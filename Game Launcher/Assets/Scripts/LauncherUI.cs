using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class LauncherUI : MonoBehaviour
{
    public Process process;
    public List<GameObject> buttons;

    [SerializeField] private TextAsset jsonGameList;
    [SerializeField] private GameObject gameButtonPrefab;
    [SerializeField] private GameObject pagePreviewContentParent;

    private Transform messageTransform;
    private TextMeshProUGUI messageText;
    
    private void Awake()
    {
        Application.runInBackground = false;
        Application.targetFrameRate = 60;

        messageTransform = transform.Find("Playing Message");
        messageText = messageTransform.Find("Message text").GetComponent<TextMeshProUGUI>();
        messageTransform.gameObject.SetActive(false);
    }

    private void Start()
    {
        GameList gameListJSON = JsonUtility.FromJson<GameList>(jsonGameList.text);

        foreach (GameListItem game in gameListJSON.gamesList)
        {
            GameObject button = Instantiate(gameButtonPrefab, pagePreviewContentParent.transform);
            var gameButtonScript = button.GetComponent<GameButton>();
            gameButtonScript.title = game.title;
            gameButtonScript.path = game.path;
            gameButtonScript.url = game.url;
            gameButtonScript.useURL = game.useURL;
            buttons.Add(button);
        }
    }

    public void LaunchGame(string gameTitle, Process process)
    {
        this.process = process;
        ShowProcessLaunchedMessage(gameTitle);
    }

    private void Update()
    {
        if (process != null && process.HasExited)
        {
            process = null;
            HideProcessLaunchedMessage();
        }
    }

    private void ShowProcessLaunchedMessage(string message)
    {
        messageTransform.gameObject.SetActive(true);
        messageText.text = "Currently playing: " + message;
    }

    private void HideProcessLaunchedMessage()
    {
        messageTransform.gameObject.SetActive(false);
    }
}
