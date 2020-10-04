using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;

    public static int numberOfCoins;
    public Text coinsText;

    public Text BestCoinsText;

    public static int bestCoins;
    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        isGameStarted = false;
        numberOfCoins = 0;
        BestCoinsText.text = "Best: " + PlayerPrefs.GetInt("coin");
        bestCoins = PlayerPrefs.GetInt("coin");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;

            if (numberOfCoins > bestCoins)
            {
                PlayerPrefs.SetInt("coin", numberOfCoins);
            }

        }

        coinsText.text = numberOfCoins.ToString();

        if (SwipeManager.tap && !isGameStarted)
        {
            isGameStarted = true;
            Destroy(startingText);
        }

    }
}
