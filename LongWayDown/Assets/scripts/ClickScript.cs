using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class ClickScript : MonoBehaviour, IPointerDownHandler
{
    public MovementScript MoveIt;
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("pointerDown");
        Debug.Log(this.transform.position);
        MoveIt.WhereMoveTo(transform.position);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
