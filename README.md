Zgadnij Liczbę – gra w Windows Forms
Projekt zaliczeniowy z programowania w języku C# (.NET Framework, Windows Forms). Gra polega na zgadnięciu liczby wylosowanej przez komputer w maksymalnie 10 próbach.
Spis treści
- Opis
- Jak działa gra
- Technologie
- Funkcjonalności
- Uruchomienie projektu
- Zrzuty ekranu
- Autor
Opis
Program losuje liczbę z zakresu 1–100. Gracz ma 10 prób na jej odgadnięcie. Po każdej próbie gra informuje, czy wpisana liczba jest za mała, za duża oraz daje podpowiedź: „ciepło / zimno”. Wynik (jeśli gracz zgadnie) zostaje zapisany do pliku wynik.txt.
Jak działa gra
1. Włącz aplikację
2. Wpisz liczbę w pole tekstowe
3. Kliknij Sprawdź
4. Otrzymujesz informację:
   - Za mało / za dużo
   - Zimno / Ciepło / Gorąco (kolor tła zmienia się)
5. Masz maksymalnie 10 prób
6. Po wygranej wynik trafia do pliku wynik.txt
7. Możesz kliknąć Restart, aby zagrać ponownie
Technologie
- Język: C#
- Platforma: .NET Framework
- Interfejs: Windows Forms (WinForms)
- Środowisko: Visual Studio 2022
Funkcjonalności
- Losowanie liczby z zakresu 1–100
- Licznik prób (aktualizowany na bieżąco)
- Tablica prób z pętlą for
- Kolorowe podpowiedzi: Zimno / Ciepło / Gorąco
- Zapis wyniku do pliku tekstowego
- Rekurencyjny restart gry po 10 próbach
- Interfejs oparty na Visual Studio Designer
Uruchomienie projektu
1. Otwórz plik ZgadnijLiczbe.sln w Visual Studio 2022
2. Upewnij się, że domyślny formularz to Form1
3. Kliknij przycisk ▶ Uruchom (F5)
Zrzuty ekranu
*(Dodaj zrzuty okna gry tutaj, jeśli robisz prezentację)*
Autor
Projekt wykonany przez [Twoje imię i nazwisko] w ramach zaliczenia przedmiotu „Programowanie”. Zawiera wszystkie wymagane elementy: zmienne, pętle, if, tablice, metody, rekurencję i pliki.
Plik zapisywany
Program tworzy plik wynik.txt z informacją o poprawnej odpowiedzi i czasie.
