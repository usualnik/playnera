using UnityEngine;
using UnityEngine.EventSystems;

public class Scroll : MonoBehaviour, IDragHandler
{
    private RectTransform _rectTransform;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        _rectTransform.anchoredPosition += new Vector2(eventData.delta.x,_rectTransform.anchoredPosition.y);
    }
}
