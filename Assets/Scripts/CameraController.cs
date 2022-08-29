using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CameraController : MonoBehaviour
{
    private CinemachineFreeLook freeLookCamera;

    // Start is called before the first frame update
    private void Start()
    {
        freeLookCamera = GetComponent<CinemachineFreeLook>();

        freeLookCamera.m_XAxis.m_InputAxisName = "";
        freeLookCamera.m_YAxis.m_InputAxisName = "";
    }   

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector2 mouseVector = InputManager.Instance.MouseDeltaLook;
        bool CameraRotationToggle = InputManager.Instance.CameraRotateToggle;
        float CameraZoomScroll = InputManager.Instance.ScrollMouse;

        CameraOrbitsZoom(CameraZoomScroll);

        if (CameraRotationToggle)
        {
            freeLookCamera.m_XAxis.m_InputAxisValue = mouseVector.x;
            freeLookCamera.m_YAxis.m_InputAxisValue = mouseVector.y;
        }
        // provides the mouse vector for camera control if the Camera rotate control is pressed.
        // Try to adjust input deadzone if needed. (or ask for advice on how to do that).
        // The controller would also allow to zoom in and out via the scrollwheel by expanding the radius and height of orbitals.
    }

    private void CameraOrbitsZoom(float zoom) 
    {
        freeLookCamera.m_Orbits[0].m_Radius += zoom;
        freeLookCamera.m_Orbits[1].m_Radius += zoom;
        freeLookCamera.m_Orbits[2].m_Radius += zoom;
    }



}


