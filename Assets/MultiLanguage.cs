using Assets.SimpleLocalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiLanguage : MonoBehaviour
{

    private void Awake()
    {
        LocalizationManager.Read();

        switch (Application.systemLanguage)
        {
            case SystemLanguage.English:
                LocalizationManager.Language = "English";
                break;
            case SystemLanguage.French:
                LocalizationManager.Language = "French";
                break;
            case SystemLanguage.Turkish:
                LocalizationManager.Language = "Turkish";
                break;
        }
    }

    public void Language(string language)
    {
        LocalizationManager.Language = language;
    }
}
