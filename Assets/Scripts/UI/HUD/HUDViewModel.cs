using System.Collections.Generic;

public class HUDViewModel : ViewModel
{
    private CharacterObject characterObject;
    public CharacterObject CharacterObject 
    {
        get{ return characterObject;}
        set 
        {
            if (characterObject != value)
            {
                characterObject = value;

                OnPropertyChanged();
            }
        }
    }
}
