using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int GameNum;
    [SerializeField] Text choicealert;
    [SerializeField] GameObject choicefreeze;
    [SerializeField] PlayerMov pmov;
    [SerializeField] CamLook maincam;
    [SerializeField] GameObject playercamera;
    [SerializeField] TextManager textman;
    [SerializeField] GameObject phonetext;
    [SerializeField] GameObject ChoiceCanvas;
    [SerializeField] GameObject CreditsCanvas;
    [SerializeField] GameObject TitleScreen;

    [SerializeField] Animation ScreenLook;
    [SerializeField] TitleAnimation titleanim;
    [SerializeField] GameObject ScreenGlow;
    [SerializeField] PhoneScript pscript;
    [SerializeField] PlayerMov phonecheck;

    [SerializeField] AudioSource ringingphone;
    [SerializeField] AudioClip phoneringclip;
    [SerializeField] GameObject PhoneCamera;
    [SerializeField] bool phoneactive = false;
    public bool gamepick = false;
    
    public bool ts = false;
    public bool doorauth = false;

    [SerializeField] Phonecall1 pc1;
    [SerializeField] GameObject pcallmen;
    public bool choicealarm = false;

    void Start()
    {
        ScreenGlow.SetActive(false);
        ringingphone.Stop();
    }


    void Update()
    {
        if (gamepick == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if (ts == true)
        {
            Sceneman();
        }
        if (choicealarm == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {

        }

        if (maincam.comsight == true)
        {
            if (Input.GetKeyDown("e"))
            {
                if (GameNum == 1)
                {
                SceneManager.LoadScene("GameChoose");
                }
                if (GameNum == 2)
                {
                    SceneManager.LoadScene("GameChoose2");
                }
            }
        }

        RingingPhone();
        Call1();
    }

    void PlayerChoice()
    {
        pmov.canmove = false;
        maincam.canlook = false;
        Cursor.lockState = CursorLockMode.Confined;
        
    }

    
    void Sceneman()
  {
        if (titleanim.collcheck == true)
     {
         SceneManager.LoadScene("BeginningDialogue");
     }
  }
    public void GameEnter()
    {
        CreditsCanvas.SetActive(false);
        TitleScreen.SetActive(false);
        ScreenGlow.SetActive(true);
        ScreenLook.Play();
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        CreditsCanvas.SetActive(true);
        TitleScreen.SetActive(false);
    }

    public void ReturnToTitle()
    {
        CreditsCanvas.SetActive(false);
        TitleScreen.SetActive(true);
    }

    public void SohoGame()
    {
        SceneManager.LoadScene("Opening Scene");
    }

    public void SciFiGame()
    {
        SceneManager.LoadScene("Game1");
    }

    void RingingPhone()
    {
        if (phonecheck.phonecall == true)
        {
            if (phoneactive == false)
            {
                ringingphone.Play();
                phoneactive = true;
                ScreenGlow.SetActive(true);
            }

        }
    }

    void Call1()
    {
        if (pmov.onphone == true)
        {
            choicealarm = true;
        }

        if (choicealarm == true)
        {
            ringingphone.Stop();
            pmov.canmove = false;
            phonetext.SetActive(false);
            maincam.canlook = false;
            ScreenGlow.SetActive(false);
            playercamera.SetActive(false);
            PhoneCamera.SetActive(true);
            choicefreeze.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            pscript.oncurcall = true;
        }

        if (pc1.callended == true)
        {
            pmov.canmove = true;
            phonetext.SetActive(false);
            maincam.canlook = true;
            ScreenGlow.SetActive(false);
            playercamera.SetActive(true);
            PhoneCamera.SetActive(false);
            pcallmen.SetActive(false);
            choicefreeze.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            pscript.oncurcall = true;
        }
    }
}
