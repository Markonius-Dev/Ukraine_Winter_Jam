using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Dialogue
{
    public class DialogPrototype : MonoBehaviour
    {
        private string StringToType;
        [SerializeField] private TMP_Text _dialogBox;

        private float DeltaTime;
        private float SecPerCharacterUpdate;

        private int StringCounter;
        private bool IsTypingComplete;

        private List<string> Chapter;
        private int ChapterCounter;

        private void Awake()
        {
            _dialogBox.text = "";
            SecPerCharacterUpdate = 0.025f;

            StringCounter = 0;
            IsTypingComplete = false;

            Chapter = DialogueDatabase.GetChapterOne();
            ChapterCounter = 0;
        }

        private void Start()
        {
            InitializeChapter();
        }

        private void Update()
        {
            if (!IsTypingComplete)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    ShortcutDialogueTyping();
                    return;
                }

                if (UpdateDeltaTime(Time.deltaTime))
                {
                    AddCharacter();
                }
            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (IsLastPage())
                {
                    Debug.Log("Proceeding to next phase");
                }
                else
                {
                    ProceedToNextPage();
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
                IsTypingComplete = true;
            }
        }

        private void ShortcutDialogueTyping()
        {
            IsTypingComplete = true;
            _dialogBox.text = StringToType;
            StringCounter = StringToType.Length;
        }

        private void InitializeChapter()
        {
            ChapterCounter = 0;
            StringToType = Chapter[ChapterCounter];

            IsTypingComplete = false;
            StringCounter = 0;
        }

        private void ProceedToNextPage()
        {
            _dialogBox.text = "";
            ChapterCounter++;
            
            if (ChapterCounter < Chapter.Count)
            {
                StringToType = Chapter[ChapterCounter];
                IsTypingComplete = false;
                StringCounter = 0;

            }

        }

        private bool IsLastPage()
        {
            if (ChapterCounter >= Chapter.Count - 1)
            {
                return true;
            }

            return false;
        }
    }

}
