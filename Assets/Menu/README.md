## Краткое описание папки

- **Меню** — Папка содержит все компоненты главного меню и связанные с ним подсистемы, обеспечивающие навигацию между режимами игры, настройку уровней сложности, анимацию индикаторов взгляда и воспроизведение звуковых эффектов.  
    _Обеспечивает интуитивное взаимодействие пользователя с приложением и быстрый переход к различным игровым режимам._

## Структура папки

```
Menu/
│
├── Scenes/
│   ├── <сцены Unity (главное меню, меню тренировки, меню выбора режима, настройки)>
│
└── Scripts/
    ├── GameMenuTraining.cs — <управляет переходом в тренировочный режим и возвратом в главное меню>
    ├── MenuManager.cs — <обеспечивает навигацию по основным меню (тренировка, внимание, логика, память, настройки, выход из игры)>
    ├── DifficultyLevelMenuManager.cs — <определяет уровень сложности, устанавливает параметры игры и запускает выбранный режим>
    ├── GameMenuManager.cs — <обеспечивает переход от главного меню к меню выбора уровня сложности>
    ├── IndicatorAnimation.cs — <отвечает за анимацию индикатора, отслеживающего движения взгляда>
    ├── SoundManager.cs — <воспроизводит звуковые эффекты при взаимодействии с элементами меню>
    └── LevelMenuMemory.cs — <управляет разблокировкой и выбором уровней в режиме Memory>
```