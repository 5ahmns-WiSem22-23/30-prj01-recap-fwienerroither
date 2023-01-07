using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private float minRange;
    [SerializeField]
    private float maxRange;
    [SerializeField]
    private GameObject tile;

    public static int tileCounter;

    void Start()
    {
        SpawnTile();
    }


    public void SpawnTile()
    {
        // Der Bereich des gespawnten Objekts wird zufällig auserwählt
        Instantiate(tile, new Vector3(Random.Range(minRange, maxRange), Random.Range(minRange, maxRange), 0), Quaternion.identity);
    }
}
