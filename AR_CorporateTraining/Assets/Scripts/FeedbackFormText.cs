using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackFormText : MonoBehaviour
{
    public Text feedbackFormText = null;
    public Text q1 = null;
    public Text q2 = null;
    public Text q3 = null;

    // Start is called before the first frame update
    void Start()
    {
        feedbackFormText.text = "Have you enjoyed using our system? Give us some rating and feedback!";
        q1.text = "1. Are you satisfied with our system?";
        q2.text = "2. Which part do you think we can improve for the system?";
        q3.text = "3. Would you like to use this system again?";
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
