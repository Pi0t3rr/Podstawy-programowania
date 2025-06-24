# Gra Wisielec – Windows Forms w C#

## Spis treści
1. Cel projektu
2. Technologie
3. Uruchomienie projektu]
4. Przykłady użycia
5. Status projektu

---

## Cel projektu

Celem projektu jest stworzenie klasycznej gry **Wisielec** z użyciem platformy **Windows Forms** w języku C#.  
Gracz zgaduje litery ukrytego hasła, mając ograniczoną liczbę prób. Program wizualnie pokazuje postęp rozgrywki, błędne litery oraz informuje o wygranej lub przegranej.

---

## Technologie

Projekt wykorzystuje następujące technologie:

-"Język programowania": C# (.NET)
-"Interfejs graficzny": Windows Forms
-"IDE/Edytor": Visual Studio Code

## Uruchomienie projektu

Aby uruchomić grę lokalnie:

1.Pobierz projekt jako folder lub archiwum `.zip`.
2. Upewnij się, że masz zainstalowane:
   - Rozszerzenie "C#" w Visual Studio Code.
3. Otwórz projekt w Visual Studio Code ("File > Open Folder).
4. Upewnij się, że plik `*.csproj` znajduje się w folderze głównym.
5. Rozpocznij projekt po jego kompilacji.

## Przykłady użycia:

- Gracz wpisuje literę i klika przycisk „Sprawdź”
- Jeśli litera jest poprawna – zostaje odkryta w haśle
- Jeśli litera jest błędna – pojawia się na liście błędnych liter, odejmuje się jedno życie.
- Litery już użyte nie powodują utraty życia przy ponownym wpisaniu
- Po zgadnięciu wszystkich liter – wyświetlany jest komunikat o wygranej
- Po utracie wszystkich żyć – wyświetlany jest komunikat o przegranej wraz z poprawnym hasłem

## Status projektu:

Projekt ukończony

Możliwość dalszego rozwoju:

- Wybór losowego hasła z listy
- Kilka poziomów trudności
- Obsługa dźwięków i animacji
