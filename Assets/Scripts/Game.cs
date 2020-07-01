using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject firstDiamond;
    public GameObject secondDiamond;
    [SerializeField] Diamond diamond;

    private void InstantiateDiamond()
    {
        var diamondColor = diamond.GetComponent<SpriteRenderer>();

        switch (Random.Range(0, 5))
        {
            case 0:
                diamondColor.color = Color.red;
                break;
            case 1:
                diamondColor.color = Color.blue;
                break;
            case 2:
                diamondColor.color = Color.white;
                break;
            case 3:
                diamondColor.color = Color.green;
                break;
            default:
                diamondColor.color = Color.yellow;
                break;
        }

        Instantiate(diamond, new Vector2(Random.Range(-2.5f, 2.5f), 6), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        firstDiamond = null;
        secondDiamond = null;
        InvokeRepeating("InstantiateDiamond", 0.3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (firstDiamond != null && secondDiamond != null)
        {

            if (firstDiamond.GetComponent<SpriteRenderer>().color == secondDiamond.GetComponent<SpriteRenderer>().color)
            {
                Debug.Log("BothDestroyed");
                Destroy(firstDiamond);
                Destroy(secondDiamond);
            }
            else
            {
                Debug.Log("Nope");
                firstDiamond = null;
                secondDiamond = null;
            }
        }

    }
}