using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class button_script : MonoBehaviour
{
    public int downness;
    public AudioSource button_hold;
    public bool being_pressed;
    public float go_down_by;
    public bool going_up;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (being_pressed == false)
        {
            button_hold.Stop();
        }
        if (downness < 25 && being_pressed == false)
        {
            going_up = true;
        }
        if (going_up)
        {
            downness += 1;
            base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y + go_down_by, base.transform.position.z);
        }
        if (downness == 25)
        {
            going_up = false;
        }
        if ((downness < 1))
        {
            if (base.name == "StoryButton")
            {
                PlayerPrefs.SetString("CurrentMode", "story");
            }
            else if (base.name == "EndlessButton")
            {
                PlayerPrefs.SetString("CurrentMode", "endless");
            }
            SceneManager.LoadScene("School");
        }
        }

    private void OnTriggerExit(Collider other)
    {
        being_pressed = false;
    }
    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("Getting Touched... ");
        if (collision.tag == "Controller")
        {
            Debug.Log("... And it's a controller!");
            being_pressed = true;
            going_up = false;
            if (button_hold.isPlaying == false)
            {
                button_hold.Play();
            }
            
            if (!(downness < 1))
            {
                downness -= 1;
                base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y - go_down_by, base.transform.position.z);
            }
            
        }
        
    }
}
