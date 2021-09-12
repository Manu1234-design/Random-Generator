using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public Text numberText;
    

    // Start is called before the first frame update
    

    // Update is called once per frame
    public void Ok(){
        PickRandom(41);
    }

    private void PickRandom (int maxInt){
        int randomNum = Random.Range(1, maxInt+1);
        numberText.text = randomNum.ToString();

    }

    
}
