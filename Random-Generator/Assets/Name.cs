using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    
    public Text nameText;

    public void PickRandomFromList(){
        string[] students = new string[] { "Manu", "Rajeev", "Adithyan"};
        string RandomName = students[Random.Range(0, students.Length)];
        nameText.text = RandomName;
    }
}
