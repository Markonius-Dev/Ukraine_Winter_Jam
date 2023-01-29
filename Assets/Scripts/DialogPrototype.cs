using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogPrototype : MonoBehaviour
{
    private string StringToType;
    [SerializeField] private TMP_Text _dialogBox;

    private float DeltaTime;
    private float SecPerCharacterUpdate;

    private int StringCounter;
    private bool IsProcessCompleted;

    private void Awake()
    {
        _dialogBox.text = "";
        SecPerCharacterUpdate = 0.025f;

        StringCounter = 0;
        IsProcessCompleted = false;

        StringToType = "This is the text that will type in the dialog box";
    }

    private void Update()
    {
        if (!IsProcessCompleted)
        {
            if (UpdateDeltaTime(Time.deltaTime))
            {
                AddCharacter();
            }
        }

    }

    private bool UpdateDeltaTime(float deltaTime)
    {
        DeltaTime += deltaTime;

        if (DeltaTime >= SecPerCharacterUpdate)
        {
            DeltaTime = 0;
            return true;
        }

        return false;
    }

    private void AddCharacter()
    {
        if (StringCounter < StringToType.Length)
        {
            _dialogBox.text += StringToType[StringCounter];
            StringCounter++;
        }
        else
        {
            IsProcessCompleted = true;
        }
    }
}
