using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;  //for stringbuilder
using System; //needed 
using UnityEngine.Windows.Speech; //needed for grammar recogniser
using System.Linq; //needed
using System.IO;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class VoiceScript : MonoBehaviour
{
    public AudioSource myFX; //for wrong sound
    public AudioClip wrongFx; //for wrong sound
    
    AudioSource wrongSound; //needed for wrong answer sound
    
    private GrammarRecognizer gr;
  
    private string _spokenPhrase = "";
    
    void Start()
    {
        gr = new GrammarRecognizer(Path.Combine(Application.streamingAssetsPath, "Grammar.xml"), ConfidenceLevel.Low);
        gr.OnPhraseRecognized += GR_OnPhraseRecognized;
        gr.Start();
        Debug.Log("Grammar loaded and recogniser started!");
        
    }
    
     private void GR_OnPhraseRecognized(PhraseRecognizedEventArgs args)
            {
                StringBuilder message = new StringBuilder();
                Debug.Log("Recognised a phrase");
                var meanings = args.semanticMeanings;
    
                foreach(SemanticMeaning meaning in meanings)
                {
                 string keyString = meaning.key.Trim();
                 string valueString = meaning.values[0].Trim();
                 message.Append("Key:  " + keyString + ", Value: " + valueString);
                _spokenPhrase = valueString;
                }
        //using string builder to output the sting to the user
        Debug.Log(message);
            }


    // Update is called once per frame
    void Update()
    {
        //call upon functions
        switch (_spokenPhrase)
        {
            case "boat":            //french correct answers (here down)
                boat();
                break;
            case "bus":
                bus();
                break;
            case "motorbike":
                motorbike();
                break;
            case "plane":
                plane();
                break;
            case "walking":
                walking();
                break;
            case "hello":           //spanish correct answers (here down)
                hello();
                break;
            case "girl":
                girl();
                break;
            case "boy":
                boy();
                break;
            case "rugby":
                rugby();
                break;
            case "baton":             //french wrong answers (here down)
                baton();
                break;
            case "bate":
                bate();
                break;
            case "automatic":
                automatic();
                break;
            case "automobile":
                automobile();
                break;
            case "motor":
                motor();
                break;
            case "motion":
                motion();
                break;
            case "cream":
                cream();
                break;
            case "skateboard":
                skateboard();
                break;
            case "bail":             //spanish wrong answers (here down)
                bail();
                break;
            case "chick":
                chick();
                break;
            case "check":
                check();
                break;
            case "hole":
                hole();
                break;
            case "cola":
                cola();
                break;
            case "rug":
                rug();
                break;
            case "buy":
                buy();
                break;
            case "start":           //menu  (here down)
                start();
                break;
            case "quit":
                quit();
                break;
            case "enter":
                enter();
                break;
            case "level1":
                level1();
                break;
            case "level2":
                level2();
                break;
            case "level3":
                level3();
                break;
            case "mainmenu":
                mainmenu();
                break;
            case "restart":
                restart();
                break;
            case "level":
                level();
                break;
            case "one":
                one();
                break;
            case "two":
                two();
                break;
            case "play":
                play();
                break;
            case "stage":
                stage();
                break;
            case "spanish":
                spanish();
                break;
            case "french":
                french();
                break;
            
        }
    }

    //========================
    // Action Methods
    //========================
    
    //---------
    //FRENCH - correct answers
    //---------
    private void boat()
    {
        SceneManager.LoadScene(8); //go to BUSScene -- next word to guess/learn
    }
    private void bus()
    {
        SceneManager.LoadScene(9); //go to MotorbikeScene -- next word to guess/learn
    }
    
    private void motorbike()
    {
        SceneManager.LoadScene(11); //go to PlaneScene  -- next word to guess/learn
    }
    private void plane()
    {
        SceneManager.LoadScene(10); //go to WalkingScene -- next word to guess/learn
    }
    private void walking()
    {
        SceneManager.LoadScene(6); // go to EndScene -- next word to guess/learn
    }
    
    //-----------
    // french wrong answers
    //-----------
    private void baton()
    {
        myFX.PlayOneShot(wrongFx); // wrong sound
    }
    private void bate()
    {
        myFX.PlayOneShot(wrongFx);  // wrong sound
    }
    
    private void automatic()
    {
        myFX.PlayOneShot(wrongFx);  // wrong sound
    }
    private void automobile()
    {
        myFX.PlayOneShot(wrongFx); // wrong sound
    }
    private void motor()
    {
        myFX.PlayOneShot(wrongFx); // wrong sound
    }
    private void motion()
    {
        myFX.PlayOneShot(wrongFx); // wrong sound
    }
    private void cream()
    {
        myFX.PlayOneShot(wrongFx); // wrong sound
    }
    private void skateboard()
    {
        myFX.PlayOneShot(wrongFx); // wrong sound
    }
    //------------------------
    //SPANISH- correct answers
    //------------------------
    private void hello()
    {
        SceneManager.LoadScene(2); //go to GIRLScene -- next word to guess/learn
    }
    private void girl()
    {
        SceneManager.LoadScene(3); //go to BOYScene -- next word to guess/learn
    }
    
    private void boy()
    {
        SceneManager.LoadScene(4); //go to RUGBYScene  -- next word to guess/learn
    }
    private void rugby()
    {
        SceneManager.LoadScene(6); //go to EndScene -- next word to guess/learn
    }
    
    //----------------------
    // spanish wrong answers
    //----------------------
    private void bail()
    {

        myFX.PlayOneShot(wrongFx);                            // wrong sound

    }
    private void chick()
    {
        myFX.PlayOneShot(wrongFx);                              // wrong sound
    }
    private void check()
    {
        myFX.PlayOneShot(wrongFx);                             // wrong sound
    }
    private void hole()
    {
        myFX.PlayOneShot(wrongFx);                              // wrong sound
    }   
    private void cola()
    {
        myFX.PlayOneShot(wrongFx);                             // wrong sound
    }
    private void rug()
    {
        myFX.PlayOneShot(wrongFx);  // wrong sound
    }
    private void buy()
    {
        myFX.PlayOneShot(wrongFx);  // wrong sound
    }
    //---------
    //Menus
    //---------
    private void start()
    {
        SceneManager.LoadScene(1); // go to Hello starting word scene
    }
    private void quit()
    {
        Application.Quit();
    }
    
    private void level1()
    {
        SceneManager.LoadScene(0);
    }
 
    private void enter()
    {
        SceneManager.LoadScene(13);
    }
    private void level2()
    {
        SceneManager.LoadScene(1);
    }
    
    private void level3()
    {
        SceneManager.LoadScene(2);
    }
    
    private void mainmenu()
    {
        SceneManager.LoadScene(5);
    }
    
    private void restart()
    {
        SceneManager.LoadScene(1);
    }
    
    private void level()
    {
        SceneManager.LoadScene(16);
    }
    
    private void one()
    {
        SceneManager.LoadScene(12);
    }
    
    private void two()
    {
        SceneManager.LoadScene(14);
    }
    private void play()
    {
        SceneManager.LoadScene(0);
    }
    
    private void stage()
    {
        SceneManager.LoadScene(15);
    }
    
    private void spanish()
    {
        SceneManager.LoadScene(1);
    }
    
    private void french()
    {
        SceneManager.LoadScene(7);
    }
    //========================
    // failsafe stop mechanism
    //========================
    private void OnApplicationQuit()
    {
        if (gr != null && gr.IsRunning)
        {
            gr.OnPhraseRecognized -= GR_OnPhraseRecognized;
            gr.Stop();
        }
    }



}
