using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace GameDefenderKiller
{
    public static class LanguageHelper
    {
        public static string CurrentLanguage { get; private set; } = "ru";

        // Событие для обновления интерфейса при смене языка
        public static event Action LanguageChanged;

        static LanguageHelper()
        {
            // Определяем язык системы при запуске
            string culture = CultureInfo.InstalledUICulture.Name.ToLower();
            CurrentLanguage = culture.StartsWith("ru") ? "ru" : "en";
        }

        public static void SetLanguage(string lang)
        {
            if (CurrentLanguage != lang)
            {
                CurrentLanguage = lang;
                LanguageChanged?.Invoke();
            }
        }

        // ============ ТЕКСТЫ ДЛЯ ГЛАВНОГО ОКНА ============
        public static string GetMainFormTitle()
        {
            return CurrentLanguage == "ru"
                ? "GameDefenderKiller v2.0 | CC BY-NC-ND 4.0"
                : "GameDefenderKiller v2.0 | CC BY-NC-ND 4.0";
        }

        public static string GetBtnOffText()
        {
            return CurrentLanguage == "ru"
                ? "🔴 ОТКЛЮЧИТЬ\r\nЗащиту"
                : "🔴 DISABLE\r\nProtection";
        }

        public static string GetBtnOnText()
        {
            return CurrentLanguage == "ru"
                ? "🟢 ВКЛЮЧИТЬ\r\nЗащиту"
                : "🟢 ENABLE\r\nProtection";
        }

        public static string GetBtnLicenseText()
        {
            return CurrentLanguage == "ru"
                ? "📜 CC\r\nЛицензия"
                : "📜 CC\r\nLicense";
        }

        public static string GetBtnLangText()
        {
            return CurrentLanguage == "ru"
                ? "🌐 EN"
                : "🌐 RU";
        }

        public static string GetStatusReady()
        {
            return CurrentLanguage == "ru"
                ? "Готов к работе. Запусти от имени Администратора!"
                : "Ready to work. Run as Administrator!";
        }

        public static string GetStatusOff()
        {
            return CurrentLanguage == "ru"
                ? "✅ ЗАЩИТА ОТКЛЮЧЕНА!"
                : "✅ PROTECTION DISABLED!";
        }

        public static string GetStatusOn()
        {
            return CurrentLanguage == "ru"
                ? "✅ ЗАЩИТА ВОССТАНОВЛЕНА!"
                : "✅ PROTECTION RESTORED!";
        }

        // ============ СООБЩЕНИЯ (MessageBox) ============
        public static string GetMsgNeedAdmin_Title()
        {
            return CurrentLanguage == "ru" ? "Ошибка" : "Error";
        }

        public static string GetMsgNeedAdmin_Text()
        {
            return CurrentLanguage == "ru"
                ? "Запусти программу от имени Администратора!"
                : "Run the program as Administrator!";
        }

        public static string GetMsgSuccessOff_Title()
        {
            return CurrentLanguage == "ru" ? "Успех" : "Success";
        }

        public static string GetMsgSuccessOff_Text()
        {
            return CurrentLanguage == "ru"
                ? "Защитник и Брандмауэр выключены.\nНе забудь включить обратно!"
                : "Defender and Firewall are disabled.\nDon't forget to turn them back on!";
        }

        public static string GetMsgSuccessOn_Title()
        {
            return CurrentLanguage == "ru" ? "Готово" : "Done";
        }

        public static string GetMsgSuccessOn_Text()
        {
            return CurrentLanguage == "ru"
                ? "Защита включена обратно!"
                : "Protection is back on!";
        }

        public static string GetMsgError_Title()
        {
            return CurrentLanguage == "ru" ? "Сбой" : "Error";
        }

        public static string GetMsgOpenLinkError_Text()
        {
            return CurrentLanguage == "ru"
                ? "Не удалось открыть ссылку: "
                : "Failed to open link: ";
        }

        // ============ ТЕКСТЫ ДЛЯ ОКНА ЛИЦЕНЗИИ ============
        public static string GetLicenseFormTitle()
        {
            return CurrentLanguage == "ru"
                ? "Лицензия CC BY-NC-ND 4.0"
                : "CC BY-NC-ND 4.0 License";
        }

        public static string GetLicenseTitle()
        {
            return CurrentLanguage == "ru"
                ? "📄 Лицензия Creative Commons"
                : "📄 Creative Commons License";
        }

        public static string GetLicenseBody()
        {
            if (CurrentLanguage == "ru")
            {
                return
                    "Это программное обеспечение распространяется на условиях\n" +
                    "Creative Commons «Attribution-NonCommercial-NoDerivatives» (CC BY-NC-ND 4.0).\n\n" +
                    "Вы можете:\n" +
                    "✅ Свободно скачивать и использовать программу в личных целях\n" +
                    "✅ Делиться ссылкой на оригинальную страницу загрузки\n\n" +
                    "Запрещается:\n" +
                    "❌ Использовать в коммерческих целях (продавать, встраивать в платные продукты)\n" +
                    "❌ Изменять, модифицировать или создавать производные работы\n" +
                    "❌ Распространять программу без указания автора (Pavel_Daily)\n\n" +
                    "Подробнее об условиях лицензии:";
            }
            else
            {
                return
                    "This software is distributed under the terms of the\n" +
                    "Creative Commons «Attribution-NonCommercial-NoDerivatives» (CC BY-NC-ND 4.0).\n\n" +
                    "You may:\n" +
                    "✅ Freely download and use the software for personal purposes\n" +
                    "✅ Share a link to the original download page\n\n" +
                    "You may NOT:\n" +
                    "❌ Use for commercial purposes (sell, integrate into paid products)\n" +
                    "❌ Modify, adapt, or create derivative works\n" +
                    "❌ Distribute the software without crediting the author (Pavel_Daily)\n\n" +
                    "Learn more about the license terms:";
            }
        }

        public static string GetPrivacyText()
        {
            return CurrentLanguage == "ru"
                ? "🔒 БЕЗОПАСНОСТЬ ДАННЫХ:\nПрограмма НЕ собирает и НЕ передает личные данные.\nВся информация хранится локально на вашем устройстве."
                : "🔒 DATA SECURITY:\nThe program does NOT collect or transmit personal data.\nAll information is stored locally on your device.";
        }

        public static string GetBtnCloseText()
        {
            return CurrentLanguage == "ru" ? "Закрыть" : "Close";
        }
    }
}