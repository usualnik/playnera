using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler,IPointerDownHandler, IDropHandler
{
    [SerializeField] private Canvas _canvas;
    
    private RectTransform _rectTransform;

    private Rigidbody2D _rb;
    private float gravity = 50f;

    [SerializeField] private bool _canDrag;
   

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _rb = GetComponent<Rigidbody2D>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (_canDrag)
        {
            _rb.gravityScale = 0;
        }
       
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (_canDrag)
        {
            _rectTransform.anchoredPosition += eventData.delta / _canvas.scaleFactor;
        }
        

    }

    public void OnDrop(PointerEventData eventData)
    {
        _canDrag = false;
        _rb.gravityScale = gravity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _canDrag = true;
    }
}


