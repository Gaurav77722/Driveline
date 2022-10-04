using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorController : MonoBehaviour /*, IPointerDownHandler, IPointerUpHandler*/
{
    public Texture2D cursor;

    public Texture2D cursorClicked;

    private CursorControl controls;

    private Camera mainCamera;

    public object gasCan;
    public object oilCan;
    public object battery;
    public object wheel;
    

    // Start is called before the first frame update

    /*private void StartedClick()
    {
        Debug.Log("Cursor Clicked");
        ChangeCursor((cursorClicked));
        mainCamera = Camera.main;
    }

    private void EndedClick()
    {
        ChangeCursor(cursor);
    }*/

    /*public void OnPointerUp(PointerEventData eventData)
    {
        ChangeCursor(cursor);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ChangeCursor(cursorClicked);
    }*/

    private void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                InterfaceDef.IClicked click = hit.collider.gameObject.GetComponent<InterfaceDef.IClicked>();
                if(click != null) click.onClickAction();
                Debug.Log("3D Hit: " + hit.collider.tag);
            }
        }

        RaycastHit[] hitsNonAlloc = new RaycastHit[1];
        int numberOfHits = Physics.RaycastNonAlloc(ray, hitsNonAlloc);
        for (int i = 0; i < numberOfHits; ++i)
        {
            if (hitsNonAlloc[i].collider != null)
            {
                Debug.Log("3D Hit Non Alloc All: " + hitsNonAlloc[i].collider.tag);
            }
        }
    }

        private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Awake()
    {
        controls = new CursorControl();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
    }
    
    /*private void Start()
    {
        controls.Mouse.Click.started += _ => StartedClick();
        controls.Mouse.Click.performed += _ => EndedClick();
    }*/

    private void ChangeCursor(Texture2D cursorType)
    {
        //Vector2 hotspot = new Vector2(cursorType.width / 2, cursorType.height / 2);
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }

    private void Update()
    {
        /*Debug.Log(gasCan);
        gasCan.ToString();*/
        if (Input.GetMouseButtonDown(0))
        {
           ChangeCursor(cursorClicked); 
        }
        else if(Input.GetMouseButtonUp(0))
        {
            ChangeCursor(cursor);
            DetectObject();
        }
    }

    private void ObjectSelection()
    {
        
    }
    
    
}
