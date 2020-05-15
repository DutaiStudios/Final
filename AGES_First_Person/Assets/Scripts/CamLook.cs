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
    public bool canpickup = false;
    public bool canlook = true;
    public bool comsight = false;
    public bool phonesight = false;
    public bool testbool = false;

    public bool bu1 = false;
    public bool bu2 = false;
    public bool bu3 = false;
    public bool bu4 = false;

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

            if (hit.collider.tag == "Pickup1")
            {
                canpickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    bu1 = true;
                }
            }

            if (hit.collider.tag == "Pickup2")
            {
                canpickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    bu2 = true;
                }
            }

            if (hit.collider.tag == "Pickup3")
            {
                canpickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    bu3 = true;
                }
            }

            if (hit.collider.tag == "Pickup4")
            {
                canpickup = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    bu4 = true;
                }
            }
            else
            {
                comsight = false;
            }
        }
    }
}
