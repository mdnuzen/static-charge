using UnityEngine;
using UnityEngine.UI;

public class ActiveButton : MonoBehaviour
{

    public static ActiveButton activeObj;

    public Transform player; // Reference to the player's transform
    public GameObject objectToActivate; // Reference to the object you want to activate
    public KeyCode activationKey; // The key to press for activation
    public int requiredItemCount; // Number of items required to activate the object
    public float activationRange = 5f; // The range within which activation is allowed
    public bool objIsActive = false;
    
    public int boltCount;

    WinScript winScript;

        void Start()
    {
        //winScript = WinScript.connectWin;
    }

    void Update()
    {
        
        //boltCount = CollectionUI.instance.ReturnScore();

        boltCount = CollectionUI.instance.ReturnScore();
        
        if (Input.GetKeyDown(activationKey))
        {
            Activate();
        }
    }

    public bool CheckActive()
    {
        return objIsActive;
    }

    public void Activate()
    {
        // Check if the player is within the activation range
        if (Vector3.Distance(transform.position, player.position) <= activationRange)
            
        {

            Debug.Log("Player is in range!");
            Debug.Log(boltCount);

            // Check if the player has the required number of items

            if (boltCount >= requiredItemCount)
            {

                    objIsActive = true;

                    //WinScript.canMove = true;
                    //winScript.canMove = true;
                    Debug.Log("Object activated!");
            }
            else
            {
                Debug.Log("Player does not have enough items to activate the object!");
            }

        }
        else
        {
            Debug.Log("Player is not in range to activate the object!");
        }
    }
}