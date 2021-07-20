using UnityEngine;
using UnityEngine.UI;

public class DynamicButtonScript : MonoBehaviour
{
    //Prefab button from unity
    [SerializeField] public GameObject prefabButton;
    //Panel or field for buttons to spawn in
    [SerializeField] public RectTransform ParentPanel;

    void Start()
    {
        //Number of buttons
        int number_of_buttons = 15;

        for (int i = 0; i < number_of_buttons; i++)  //Index values can be changed according to the project (How many button you want to spawn?)
        {
            //Initializing a button from the type of our prefab button
            GameObject goButton = (GameObject)Instantiate(prefabButton);
            //Linking this button to an area
            goButton.transform.SetParent(ParentPanel, false);
            //Naming the text field in the button
            goButton.GetComponentInChildren<Text>().text = "Button " + (i + 1);
            //Getting the component of the button
            Button tempButton = goButton.GetComponent<Button>();
            //We are using this in button action when we click, its going to print index of button
            int tempInt = i + 1; //button name, starts from 1
            //Assigning an action to our button when clicked
            tempButton.onClick.AddListener(() => ButtonClicked(tempInt));
        }
    }

    //The action method the buttons will have
    void ButtonClicked(int buttonNo)
    {
        Debug.Log("Button clicked = " + buttonNo);
    }
}