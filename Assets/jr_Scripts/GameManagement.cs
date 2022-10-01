using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    private GameObject pauseMenu;
    private GameObject pauseButton;
    private GameObject mainApp;
    private GameObject quitCheck;
    private GameObject optionButtons;
    private GameObject changePortsSection;
    private GameObject documentation;
    private GameObject portInfo;
    private GameObject settingsSection;
    private GameObject muteSymbol;
    private GameObject unMuteSymbol;
    public AudioClip clickSound;
    private Text HUDstate;
    private Text SoundState;
    private OSC osc;
    public Text outPort1Text;
    public Text outPort2Text;
    public bool isPaused = false;
    private bool HUDvisible = true;
    private bool SoundOn = true;
    private AudioSource soundManager;

    private void Awake()
    {
        osc = FindObjectOfType<OSC>();

        pauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        pauseButton = GameObject.FindGameObjectWithTag("PauseButton");
        mainApp = GameObject.FindGameObjectWithTag("MainApp");
        quitCheck = GameObject.FindGameObjectWithTag("QuitCheck");
        optionButtons = GameObject.FindGameObjectWithTag("Options");
        changePortsSection = GameObject.FindGameObjectWithTag("ChangePortsSection");
        documentation = GameObject.FindGameObjectWithTag("DocumentationSection");
        portInfo = GameObject.FindGameObjectWithTag("PortInfo");
        HUDstate = GameObject.FindGameObjectWithTag("StateTextHUD").GetComponent<Text>();
        SoundState = GameObject.FindGameObjectWithTag("StateTextSound").GetComponent<Text>();
        settingsSection = GameObject.FindGameObjectWithTag("Settings");
        soundManager = FindObjectOfType<AudioSource>();
        muteSymbol = GameObject.FindGameObjectWithTag("MuteSymbol");
        unMuteSymbol = GameObject.FindGameObjectWithTag("UnMuteSymbol");
        
        UnPause();

        UpdatePortText();

        muteSymbol.SetActive(false);
        unMuteSymbol.SetActive(false);
       
    }

    public void UpdatePortText()
    {
        outPort1Text.text = osc.outPort.ToString();
        outPort2Text.text = osc.outPort2.ToString();
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            soundManager.PlayOneShot(clickSound);
            if(!isPaused)
            {
                Pause();  
            }
            else
            {
                UnPause();
            }  
        }
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            soundManager.PlayOneShot(clickSound);
            quitCheck.SetActive(true);
        }

        if(quitCheck.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                QuitApp();
            }

            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                QuitApp();
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            soundManager.PlayOneShot(clickSound);
            HUDswitch();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            soundManager.PlayOneShot(clickSound);
            SoundStateSwitch();
        }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        mainApp.SetActive(false);
        quitCheck.SetActive(false);

        // reset pause menu set up to default
        optionButtons.SetActive(true);
        changePortsSection.SetActive(false);
        documentation.SetActive(false);
        settingsSection.SetActive(false);
        
        isPaused = true;
    }

    public void UnPause()
    {
        pauseMenu.SetActive(false);
        if(HUDvisible)
        {
            pauseButton.SetActive(true);
        }
        mainApp.SetActive(true);
        quitCheck.SetActive(false);

        isPaused = false;
    }

    public void HUDswitch()
    {
        if(HUDvisible)
        {
            HUDvisible = false;
            portInfo.SetActive(false);
            pauseButton.SetActive(false);
            HUDstate.text = "Off";
        }
        else
        {
            HUDvisible = true;
            portInfo.SetActive(true);
            if(!isPaused)
            {
                pauseButton.SetActive(true);
            }
            HUDstate.text = "On";
        }
    }

    public void SoundStateSwitch()
    {
        if (SoundOn)
        {
            SoundOn = false;
            SoundState.text = "Off";
            soundManager.volume = 0;
            muteSymbol.SetActive(true);
            Invoke("MuteSymbolOff", 0.5f);
        }
        else
        {
            SoundOn = true;
            SoundState.text = "On";
            soundManager.volume = 1;
            //muteSymbol.GetComponent<Image>().color.
            unMuteSymbol.SetActive(true);
            Invoke("UnMuteSymbolOff", 0.5f);
        }
    }

    public void MuteSymbolOff()
    {
        muteSymbol.SetActive(false);
    }

    public void UnMuteSymbolOff()
    {
        unMuteSymbol.SetActive(false);
    }
}
