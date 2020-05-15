using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CamLook : MonoBehaviour
{

    [SerializeField] float mouseSensativity;

    [SerializeField] Transform PlayerB;
    [SerializeField] GameObject ComCan;
    [SerializeField] Text ComText;

    public bool canlook = true;
    public bool comsight = false;
    public bool phonesight = false;
    public bool testbool = false;

    float xRot = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canlook == true)
        {
        ObjectInteraction();
        Cursor.lockState = CursorLockMode.Locked;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensativity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensativity * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90, 90);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        PlayerB.Rotate(Vector3.up * mouseX);
        }

        else if (canlook == false)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }

        if (comsight == false)
        {
            ComCan.SetActive(false);
        }
    }

    void ObjectInteraction()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit))
        {

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

            if (hit.collider.tag == "Phone")
            {
                phonesight = true;
            }

            if (hit.collider.tag == "Computer")
            {
                comsight = true;

                if (comsight == true)
                {
                    ComCan.SetActive(true);
                    ComText.text = "Press E to play a game.";
                }


            }
            else
            {
                comsight = false;
            }
        }
    }
}
