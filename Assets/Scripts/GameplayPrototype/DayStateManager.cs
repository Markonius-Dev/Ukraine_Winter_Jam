using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayStateManager : MonoBehaviour
{
    DayBaseState CurrentState;
    DayInitializeState InitializeState = new DayInitializeState();
    DayTerminateState TerminateState = new DayTerminateState();

    public float Exhaustion;
    public float Servings;

    public int Round;

    public CookingStyle CookingStyle;
    public MealStyle MealStyle;

    [SerializeField] public TMP_Text _cookingStyle, _mealStyle;

    private void Start()
    {
        CurrentState = InitializeState;
        CurrentState.EnterState(this);
    }

    public void SwitchState(DayBaseState state)
    {
        CurrentState = state;
        CurrentState.EnterState(this);
    }

    public void ChangeCookingStyle(string cookingStyle)
    {
        switch (cookingStyle) 
        {
            case "FineCooking":
                CookingStyle = CookingStyle.FineCooking;
                _cookingStyle.text = "Fine Cooking";
                break;

            case "MassCooking":
                CookingStyle = CookingStyle.MassCooking;
                _cookingStyle.text = "Mass Cooking";
                break;

            default:
                CookingStyle = CookingStyle.FineCooking;
                _cookingStyle.text = "Fine Cooking";
                break;
        }
    }

    public void ChangeMealStyle(string mealStyle)
    {
        switch (mealStyle)
        {
            case "Soup":
                MealStyle = MealStyle.Soup;
                _mealStyle.text = "Soup";
                break;

            case "Salad":
                MealStyle = MealStyle.Salad;
                _mealStyle.text = "Salad";
                break;

            case "Sandwich":
                MealStyle = MealStyle.Sandwich;
                _mealStyle.text = "Sandwich";
                break;

            case "Casserole":
                MealStyle = MealStyle.Casserole;
                _mealStyle.text = "Casserole";
                break;

            default:
                MealStyle = MealStyle.Soup;
                _mealStyle.text = "Soup";
                break;
        }
    }
}

public abstract class DayBaseState
{
    public abstract void EnterState(DayStateManager day);
    public abstract void Update(DayBaseState day);
    public abstract void ChangeCookingStyle(CookingStyle cookingStyle);
    public abstract void ChangeMealStyle(MealStyle mealStyle);
}

public class DayInitializeState : DayBaseState
{
    public override void EnterState(DayStateManager day)
    {
        day.Exhaustion = 0;
        day.Servings = 0;

        day.Round = 0;

        day.CookingStyle = CookingStyle.FineCooking;
        day.MealStyle = MealStyle.Soup;

        day._cookingStyle.text = "Fine Cooking";
        day._mealStyle.text = "Soup";
    }

    public override void Update(DayBaseState day)
    {
        throw new System.NotImplementedException();
    }

    public override void ChangeCookingStyle(CookingStyle cookingStyle)
    {
        throw new System.NotImplementedException();
    }

    public override void ChangeMealStyle(MealStyle mealStyle)
    {
        throw new System.NotImplementedException();
    }
}

public class DayRoundState : DayBaseState
{
    public override void EnterState(DayStateManager day)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(DayBaseState day)
    {
        throw new System.NotImplementedException();
    }

    public override void ChangeCookingStyle(CookingStyle cookingStyle)
    {
        throw new System.NotImplementedException();
    }

    public override void ChangeMealStyle(MealStyle mealStyle)
    {
        throw new System.NotImplementedException();
    }
}

public class DayTerminateState : DayBaseState
{
    public override void ChangeCookingStyle(CookingStyle cookingStyle)
    {
        throw new System.NotImplementedException();
    }

    public override void ChangeMealStyle(MealStyle mealStyle)
    {
        throw new System.NotImplementedException();
    }

    public override void EnterState(DayStateManager day)
    {

    }

    public override void Update(DayBaseState day)
    {
        throw new System.NotImplementedException();
    }
}

public enum CookingStyle
{
    FineCooking,
    MassCooking
}

public enum MealStyle
{
    Soup,
    Salad,
    Sandwich,
    Casserole
}