# 🎮 Zgadnij Liczbę – gra w Windows Forms

Projekt zaliczeniowy z programowania w języku **C# (.NET Framework, Windows Forms)**.  
Gra polega na zgadnięciu liczby wylosowanej przez komputer w maksymalnie **10 próbach**.

---

## 📋 Spis treści
- [Opis](#opis)
- [Jak działa gra](#jak-działa-gra)
- [Technologie](#technologie)
- [Funkcjonalności](#funkcjonalności)
- [Uruchomienie projektu](#uruchomienie-projektu)
- [Zrzuty ekranu](#zrzuty-ekranu)
- [Autor](#autor)

---

## 📌 Opis

Program losuje liczbę z zakresu **1–100**. Gracz ma **10 prób**, by ją odgadnąć.  
Po każdej próbie gra informuje, czy wpisana liczba jest **za mała, za duża**, oraz daje podpowiedź:  
**„zimno ❄️ / ciepło 🌤 / gorąco 🔥”**.

Jeśli zgadniesz – wynik trafia do pliku `wynik.txt`.

---

## 🕹 Jak działa gra

1. Włącz aplikację
2. Wpisz liczbę w pole tekstowe
3. Kliknij **Sprawdź**
4. Otrzymujesz informację:
   - 🔽 Za mało / 🔼 Za dużo
   - ❄️ Zimno / 🌤 Ciepło / 🔥 Gorąco (kolorowe tło)
5. Masz **maksymalnie 10 prób**
6. Po wygranej wynik trafia do `wynik.txt`
7. Możesz kliknąć **Restart**, by zagrać ponownie

---

## 💻 Technologie

- Język: **C#**
- Platforma: **.NET Framework**
- Interfejs graficzny: **Windows Forms (WinForms)**
- Środowisko IDE: **Visual Studio 2022**

---

## ✅ Funkcjonalności

- 🔢 Losowanie liczby z zakresu 1–100
- 🔄 Licznik prób i kontrola limitu
- 🧠 Tablica prób (`int[]`) + pętla `for`
- 🎨 Podpowiedzi: **Zimno / Ciepło / Gorąco** (zmiana koloru tła)
- 📝 Zapis zgadniętej liczby do pliku `wynik.txt`
- 🔁 Rekurencyjny restart gry po przegranej
- 🖱 Interfejs zbudowany w Visual Studio Designer

---

## ▶ Uruchomienie projektu

1. Otwórz plik `ZgadnijLiczbe.sln` w **Visual Studio 2022**
2. Sprawdź, czy formularz startowy to `Form1.cs`
3. Kliknij **▶ Start (F5)**

---

## 👤 Autor

Projekt wykonany przez **[Jakub Szczepański]**  
Zawiera wszystkie wymagane elementy:  
**zmienne, instrukcje warunkowe, pętle `for` i `while`, tablice, metody, rekurencję, operacje na pliku tekstowym.**

---

## 📁 Plik zapisywany

Program tworzy plik `wynik.txt`, w którym zapisuje:  
`Zgadnięta liczba: XX | Data: YYYY-MM-DD HH:MM`

---


