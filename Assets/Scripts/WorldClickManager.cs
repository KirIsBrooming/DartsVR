using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldClickManager : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] public Transform worldCursorPosition;
    //Kirill Noob

    private void Update()
    {
        CursorCheck();
    }

    public void CursorCheck()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        Ray cameraToMouseRay = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (!Physics.Raycast(cameraToMouseRay, out RaycastHit c2mrHit))
        {
            return;
        }

        transform.position = c2mrHit.point;

        Debug.Log(c2mrHit.collider.gameObject.name);
    }
}

