﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public RectTransform Background;
    public RectTransform Cursor;
    public GameObject Character;

    float radius = 0, speed = 5;
    bool isTouch = false;
    Vector3 movePosition = new Vector3(0, 0, 0);
    Vector2 value = new Vector2(0, 0);

    void Start()
    {
        radius = Background.rect.width * 0.5f;
    }

    void Update()
    {
        if (isTouch)
            Character.transform.position += new Vector3(movePosition.x, movePosition.y, 0);
    }

    public void OnDrag(PointerEventData eventData)
    {
        value = eventData.position - (Vector2)Background.position; //방향벡터 계산

        value = Vector2.ClampMagnitude(value, radius); //커서 가두기 : value 크기
        Cursor.localPosition = value;

        value = value.normalized; //단위벡터 변환
        movePosition = new Vector3(value.x * speed * Time.deltaTime, value.y * speed * Time.deltaTime, 0f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isTouch = false;
        Cursor.localPosition = new Vector3(0, 0, 0);
        movePosition = Vector3.zero;
    }
}
