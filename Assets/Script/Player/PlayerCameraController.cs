using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    private int cameraNum = 0;

    private List<Camera> cameras = new List<Camera>();

    [SerializeField]
    private List<string> cameraNames = new List<string>();

    private void Update()
    {
        if (cameraNum > 1)
        {
            var min = Mathf.Infinity;
            Camera renderCamera = null;

            foreach (var c in cameras)
            {
                var dst = Vector3.Distance(transform.position, c.transform.position);
                if (min > dst)
                {
                    renderCamera = c;
                    min = dst;
                }
            }

            renderCamera.depth = 1;
        }
        else if (cameraNum == 1)
        {
            cameras[0].depth = 1;
        }
        cameras.Clear();
        cameraNum = 0;
    }

    private void OnWillRenderObject()
    {
        if (cameraNames.Contains(Camera.current.name))
        {
            cameras.Add(Camera.current);
            cameraNum++;
        }
    }
}
