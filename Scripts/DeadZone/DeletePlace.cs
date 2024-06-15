using System.Xml;
using UnityEngine;

public class DeletePlace : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        Debug.Log(collision.name);

        if (collision.name == "Grid")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.name == "Ball")
        {
            player.Dead();
        }
    }
}
