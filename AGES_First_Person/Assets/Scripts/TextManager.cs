using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    //Determines which game player is playing
    [SerializeField] bool Game1;
    [SerializeField] bool Game2;
    [SerializeField] bool Game3;
    //Name and most recent dialogue of NPC character
    [SerializeField] Text CurTextTarg;
    [SerializeField] Text CurText;
    //Choice UI button text
    [SerializeField] Text But1text;
    [SerializeField] Text But2text;
    [SerializeField] Text But3text;
    private bool hasbeenset = false;
    public bool choiceavailable = false;
    [SerializeField] InventoryManager invman;
    private bool gameend = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Game1 == true)
        {
            if (hasbeenset == false)
            {
                Game1Set();
                hasbeenset = true;
            }

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            CurText.text = "You'll need to find 4 power orbs, then you can access the bridge! Press E when facing the orbs to pick them up. Check your inventory with R!";
        }

        if (invman.candoor == true)
        {
            CurText.text = "Now you can get through the door!";
            gameend = true;
        }
    }

    void Game1Set()
    {
        CurTextTarg.text = "??????";
        CurText.text = "...\n\n...\n\nERROR- \n\n01100010 01101111 01101111 01110100 00100000 01100101 01110010 01110010 01101111 01110010\n\nSystem loadout failed.";
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PlayerObject")
        {
            CurTextTarg.text = "Computer";
            CurText.text = "Hello? Can you hear me? You must've just gotten into my range! There's been a terrible accident, but if you're here, we can save the ship! Press Q if you can hear me!";

            if (gameend == true)
            {
                SceneManager.LoadScene("FinalApt");
            }
        }
    }
}
