using UnityEngine;

[RequireComponent(typeof(GameController))]
public class UIController : MonoBehaviour
{
    private GameController gameCtrl;
    public GameObject title;
    public GameObject tips;
    public GameObject loose;
    private void OnEnable()
    {
        gameCtrl = GetComponent<GameController>();
    }

    private void Update()
    {
        switch (gameCtrl.state)
        {
            case GameState.Title:
                {
                    title.SetActive(true);
                    tips.SetActive(false);
                    loose.SetActive(false);
                    break;
                }
            case GameState.Game:
                {
                    title.SetActive(false);
                    tips.SetActive(true);
                    loose.SetActive(false);
                    break;
                }
            case GameState.Loose:
                {
                    title.SetActive(false);
                    tips.SetActive(false);
                    loose.SetActive(true);
                    break;
                }
        }
    }
}
