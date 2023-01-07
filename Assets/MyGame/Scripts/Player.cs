using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    Manager m;

    [SerializeField]
    float kmh;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    private void FixedUpdate()
    {
        // Die Rotation wird über die Rotate Funktion gemanaget
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal")* (kmh/4));

        // Die Bewegung nach vorne und hinten wird gemanaget
        rb.velocity = transform.rotation * new Vector2(0, Input.GetAxis("Vertical") * kmh);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Es wird überprüft, mit welchem Objekt kollidiert wurde 
        if(collision.CompareTag("Tile"))
        {
            m.SpawnTile();
            Destroy(collision.gameObject);
            //Item wird nach Collecten wieder gespawnt
        }
        else if (collision.CompareTag("Droppoint"))
        {

        }
    }
}