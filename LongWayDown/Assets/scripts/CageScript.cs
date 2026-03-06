using UnityEngine;

public class CageScript : MonoBehaviour
{
    public GameObject cage;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(cage);
            Destroy(this.gameObject);
        }
    }
}
