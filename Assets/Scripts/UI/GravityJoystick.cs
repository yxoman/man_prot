using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class GravityJoystick : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private Vector2 axis;

    [SerializeField] private RectTransform back;
    [SerializeField] private RectTransform handle;

    public RectTransform Back
    {
        get { return back; }
    }

    private Vector2 startPointerPosition;
    private float maxDelta;

    public Action pointerDown;

    public Vector2 Axis
    {
        get { return axis; }
        set
        {
            axis = value;
            handle.position = startPointerPosition + value * maxDelta;
        }
    }

    public void Enable()
    {
        var corners = new Vector3[4];
        back.GetWorldCorners(corners);
        maxDelta = Vector3.Distance(corners[0], corners[1]) / 2f;
        startPointerPosition = back.position;
    }

    private void OnEnable()
    {
        Enable();
        Axis = new Vector2(Physics.gravity.normalized.x, Physics.gravity.normalized.y);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Enable();

        if (pointerDown != null)
        {
            pointerDown.Invoke();
        }
        
        CalcDelta(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        CalcDelta(eventData);
    }

    private void CalcDelta(PointerEventData eventData)
    {
        var delta = eventData.position - startPointerPosition;
        delta = delta.normalized * maxDelta;

        Axis = delta / maxDelta;
    }
}