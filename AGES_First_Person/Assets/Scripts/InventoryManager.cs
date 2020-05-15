using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] CamLook clook;

    [SerializeField] GameObject pickup1;
    [SerializeField] GameObject pickup2;
    [SerializeField] GameObject pickup3;
    [SerializeField] GameObject pickup4;
    public bool isinmenu = false;
    [SerializeField] GameObject Inventory;
    [SerializeField] PlayerMov pmov;
    [SerializeField] GameObject Inven1;
    [SerializeField] GameObject Inven2;
    [SerializeField] GameObject Inven3;
    [SerializeField] GameObject Inven4;
    [SerializeField] GameObject UsualMenu;
    public bool candoor = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            Inventory.SetActive(true);
            pmov.canmove = false;
                UsualMenu.SetActive(false);
            clook.canlook = false;
                InventoryAdd();
                isinmenu = true;


            
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            Inventory.SetActive(false);
            pmov.canmove = true;
            UsualMenu.SetActive(true);
            clook.canlook = true;
            InventorySub();
            isinmenu = false;
        }

        if (clook.bu1 == true)
        {
            pickup1.SetActive(false);
        }
        if (clook.bu2 == true)
        {
            pickup2.SetActive(false);
        }
        if (clook.bu3 == true)
        {
            pickup3.SetActive(false);
        }
        if (clook.bu4 == true)
        {
            pickup4.SetActive(false);
        }

        if (clook.bu1 == true && clook.bu2 == true && clook.bu3 == true && clook.bu4 == true)
        {
            candoor = true;
        }
    }

    void InventoryAdd()
    {
        if (clook.bu1 == true)
        {
            Inven1.SetActive(true);
        }
        if (clook.bu2 == true)
        {
            Inven2.SetActive(true);
        }
        if (clook.bu4 == true)
        {
            Inven4.SetActive(true);
        }
        if (clook.bu4 == true)
        {
            Inven4.SetActive(true);
        }
    }

    void InventorySub()
    {
        if (clook.bu1 == false)
        {
            Inven1.SetActive(false);
        }
        if (clook.bu2 == false)
        {
            Inven2.SetActive(false);
        }
        if (clook.bu4 == false)
        {
            Inven4.SetActive(false);
        }
        if (clook.bu4 == false)
        {
            Inven4.SetActive(false);
        }
    }
}
