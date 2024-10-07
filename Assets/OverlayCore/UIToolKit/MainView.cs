using UnityEngine;
using UnityEngine.UIElements;
using static TCS.MainMenuStrings;
namespace TCS {
    public static class MainMenuStrings {
        public const string MENU_NAME = "Chunk-1";
        public const string BUTTON_MENU = "Chunk-2";
        public const string HIDE_MENU = "hide-menu";
        public const string HIDE_MENU_BUTTON = "close-menu";
        public const string SHOW_MENU_BUTTON = "open-menu";
        public const string RADIO_EFFECT_GROUP = "radio-effect-group";
    }

    public class MainView : MonoBehaviour { 
        UIDocument m_document;
        VisualElement m_root;

        VisualElement m_menu;
        Button m_hideMenuButton;

        //TODO Make this Element Draggable around the screen or make it so that it can be moved around the screen
        VisualElement m_buttonMenu;

        Button m_showMenuButton;
        
        RadioButtonGroup m_radioGroup;
        public int m_selectedGroup;
        [SerializeField] WizardConfig m_wizardConfig;

        void Start() {
            m_document = GetComponent<UIDocument>();
            m_root = m_document.rootVisualElement;
            m_menu = m_root.Q<VisualElement>(MENU_NAME);
            m_buttonMenu = m_root.Q<VisualElement>(BUTTON_MENU);

            m_hideMenuButton = m_menu.Q<Button>(HIDE_MENU_BUTTON);
            m_hideMenuButton.clicked += () => m_menu.AddToClassList(HIDE_MENU);

            m_showMenuButton = m_buttonMenu.Q<Button>(SHOW_MENU_BUTTON);
            m_showMenuButton.clicked += () => m_menu.RemoveFromClassList(HIDE_MENU);
            
            m_radioGroup = m_menu.Q<RadioButtonGroup>(RADIO_EFFECT_GROUP);
            m_radioGroup.RegisterCallback<ChangeEvent<int>>(OnRadioChange);
        }
        void OnRadioChange(ChangeEvent<int> evt) {
            m_selectedGroup = evt.newValue;
            m_wizardConfig.SetEffectType((EffectType)m_selectedGroup);
        }
    }
}