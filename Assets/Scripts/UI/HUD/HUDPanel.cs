using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class HUDPanel : View
{
    [SerializeField]
    private Image img_currentHp;

    public HUDViewModel ViewModel { get; private set; }

    private void Awake()
    {
        Init();
    }

    public void Init()
    {
        if (ViewModel == null)
        {
            ViewModel = new HUDViewModel();
            ViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }
    }

    private void LateUpdate()
    {
        UpdateUI();
    }


    public override void UpdateUI()
    {
        var characterObj = ViewModel.CharacterObject;

        if (characterObj != null)
        {
            // 현재 HP 업데이트
            SetCurrentHP(characterObj.Character.StatAbility.MaxHp, characterObj.Character.StatAbility.CurrentHp);
        }
    }

    public void SetCurrentHP(float maxHp, float currentHp)
    {
        img_currentHp.fillAmount = currentHp / maxHp;
    }

    public void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "CharacterObject")
        {
            ViewModel.CharacterObject = PlayerManager.Instance.CharacterObject;
        }
    }
}
    