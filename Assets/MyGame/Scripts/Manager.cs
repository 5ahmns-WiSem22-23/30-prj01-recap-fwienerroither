using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private float minRange;
    [SerializeField]
    private float maxRange;
    [SerializeField]
    private GameObject tile;

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
