
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

namespace Tool.Localization.Examples
{
    public class ChangeLanguege : MonoBehaviour
{
        private const int EnglishIndex = 0;
        private const int FrenchIndex = 1;
        private const int RussianIndex = 2;

        [Header("Scene Components")]
        [SerializeField] private Button _changeLanguegeButton;
        private int currentLanguageIndex;



        private void Start()
        {
            _changeLanguegeButton.onClick.AddListener(() => ChangeLanguage());
            ChangeLanguage(0);
        }

        private void OnDestroy()
        {
            _changeLanguegeButton.onClick.RemoveAllListeners();;
        }

        private void ChangeLanguage()
        {
            if(currentLanguageIndex==0)
                ChangeLanguage(2);
            else
                ChangeLanguage(0);
        }
        private void ChangeLanguage(int index)
        {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
            currentLanguageIndex = index;
        }
    }
}
