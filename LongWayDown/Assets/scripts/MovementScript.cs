using UnityEngine;

public class MovementScript:MonoBehaviour
{
    public float speed = 2f;
    Vector3 CurrentPOS;
    Vector3 newPOS;
    float MoveFlag = 1f;
    public void WhereMoveTo(Vector3 charposition)
    {
        Debug.Log("move func trigger");
        charposition.y += 1.5f;
        CurrentPOS = this.transform.position;
        newPOS = charposition;
        MoveFlag = 0f;
    }

    public void Update()
    {
        if (MoveFlag < 1f)
        {
                MoveFlag += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(CurrentPOS, newPOS, MoveFlag);
        }
    }

}
