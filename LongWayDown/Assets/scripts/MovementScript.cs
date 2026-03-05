using UnityEngine;

public class MovementScript:MonoBehaviour
{
    public void WhereMoveTo(Vector3 charposition)
    {
        Debug.Log("move func trigger");
        charposition.y += 1.5f;
        this.transform.position = charposition;

    }
}
