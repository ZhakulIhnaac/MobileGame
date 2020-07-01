using UnityEngine;

public class Diamond : MonoBehaviour
{
    public Color color;
    private GameObject gameObj;
    private Game game;

    private void Start()
    {
        gameObj = GameObject.Find("Game");
        game = gameObj.GetComponent<Game>();
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (game.firstDiamond == null)
            {
                game.firstDiamond = gameObject;
            }
            else
            {
                game.secondDiamond = gameObject;
            }
        }

    }
}
