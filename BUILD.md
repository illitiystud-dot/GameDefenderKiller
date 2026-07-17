Сборка из исходного кода
Требования
- Windows 10/11
- Visual Studio 2022 (Community Edition бесплатно)
- .NET Framework 4.7.2 или выше

Шаги: Установите Visual Studio
1. Скачайте Visual Studio 2022 Community: https://visualstudio.microsoft.com/
2. При установке выберите компонент ".NET desktop development"

2. Клонируйте репозиторий
```bash
git clone https://github.com/YourName/GameDefenderKiller.git
cd GameDefenderKiller
3. Откройте проект
•	Дважды кликните по GameDefenderKiller.sln
•	Visual Studio откроет проект
4. Соберите программу
•	В верхней панели выберите Release вместо Debug
•	Нажмите Build → Build Solution
5. Где искать результат
Готовый EXE-файл будет в папке:
text
bin\Release\GameDefenderKiller.exe
6. Создайте установщик (опционально)
1.	Скачайте Inno Setup: https://jrsoftware.org/isdl.php
2.	Используйте скрипт GameDefenderKiller_Setup.iss из папки проекта
3.	Откройте скрипт в Inno Setup и нажмите Compile
Альтернативная сборка через командную строку
cmd
msbuild GameDefenderKiller.sln /p:Configuration=Release
text
