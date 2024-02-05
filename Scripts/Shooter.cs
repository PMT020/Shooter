using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private Camera camera;
    void Start()
    {
        camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(camera.pixelWidth / 2, camera.scaledPixelHeight / 2, 0);

            Ray ray = camera.ScreenPointToRay(point);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();

                if(target != null)
                {
                    target.ReactToHit();
                }
                else
                {
                    StartCoroutine(SpehereIndicator(hit.point));
                }


                
            }
        }
    }

    private IEnumerator SpehereIndicator(Vector3 position)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = position;

        yield return new WaitForSeconds(1);

        Destroy(sphere);
 
    }

    private void OnGUI()
    {
        int size = 12;
        float posx = camera.pixelWidth / 2 - size / 4;
        float posy = camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posx, posy, size, size), "*");

    }
}
