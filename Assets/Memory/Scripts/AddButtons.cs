using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddButtons : MonoBehaviour
{
    [SerializeField] private Transform puzzleField;
    [SerializeField] private GameObject button;
    [SerializeField] private Transform TobipuzzleField;
    [SerializeField] private GameObject Tobibutton;
    [SerializeField] public GridLayoutGroup field;
    [SerializeField] public GridLayoutGroup tobiField;
    public static int counter = 6;

    private void Start()
    {
        Level();
    }

    public void Level()
    {
        if (counter <= 4)
        {
            tobiField.cellSize = new Vector2(300, 300);
            tobiField.constraintCount = 2;
            field.cellSize = new Vector2(300, 300);
            field.constraintCount = 2;
        } 
        else if (counter <= 6)
        {
            tobiField.cellSize = new Vector2(300, 300);
            tobiField.constraintCount = 3;
            field.cellSize = new Vector2(300, 300);
            field.constraintCount = 3;
        } 
        else if (counter <= 8)
        {
            tobiField.cellSize = new Vector2(300, 300);
            tobiField.constraintCount = 4;
            field.cellSize = new Vector2(300, 300);
            field.constraintCount = 4;
        }
        else if (counter <= 10)
        {
            tobiField.cellSize = new Vector2(300, 300);
            tobiField.constraintCount = 5;
            field.cellSize = new Vector2(300, 300);
            field.constraintCount = 5;
        } 
        else if (counter <= 12)
        {
            tobiField.cellSize = new Vector2(300, 300);
            tobiField.constraintCount = 4;
            field.cellSize = new Vector2(300, 300);
            field.constraintCount = 4;
        }
        else if (counter <= 16)
        {
            tobiField.cellSize = new Vector2(200, 200);
            tobiField.constraintCount = 4;
            field.cellSize = new Vector2(200, 200);
            field.constraintCount = 4;
        } 
        else if (counter <= 18)
        {
            tobiField.cellSize = new Vector2(200, 200);
            tobiField.constraintCount = 6;
            field.cellSize = new Vector2(200, 200);
            field.constraintCount = 6;
        }
        else if (counter <= 20)
        {
            tobiField.cellSize = new Vector2(200, 200);
            tobiField.constraintCount = 5;
            field.cellSize = new Vector2(200, 200);
            field.constraintCount = 5;
        } 
        
    }
    private void Awake()
    {
        for (int i = 0; i < counter; i++)
        {
            GameObject _button = Instantiate(this.button);
            _button.name = "" + i;
            _button.transform.SetParent(puzzleField, false);
            //GameObject _tobiButton = Instantiate(this.Tobibutton);
            //_tobiButton.name = "" + i;
            _button.transform.SetParent(TobipuzzleField, false);
            _button.GetComponent<TobiButton>().Button = _button.Button();
        }


    }
}
