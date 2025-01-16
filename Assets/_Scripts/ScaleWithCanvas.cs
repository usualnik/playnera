using UnityEngine;

public class ScaleWithCanvas : MonoBehaviour
{
    private void Start()
    {
        
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2 
            (
                gameObject.GetComponent<RectTransform>().sizeDelta.x,
                gameObject.GetComponent<RectTransform>().sizeDelta.y
            );
    }
  
}
