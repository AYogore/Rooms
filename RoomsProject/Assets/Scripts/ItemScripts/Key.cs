using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour, IInventoryItem
{
    public GameObject Unique;
    public GameObject TextBox;
    public static bool GameIsPaused = false;

    public bool IsQuestItem
    {
        get
        {
            return false;
        }
    }
    public string Name
    {
        get
        {
            return "Key";
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickup()
    {
        // Add logic what happens when key is picked up by player for example unlock door
        gameObject.SetActive(false);
        Unique.SetActive(true); //key button active in inventory


        //Pause(); //force open key text box FIX, RESUME DOES NOT WORK
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (GameIsPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        TextBox.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        TextBox.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
