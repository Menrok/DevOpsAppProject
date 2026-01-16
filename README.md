# DevOpsAppProject

## Opis projektu

Projekt demonstracyjny z zakresu **DevOps**, prezentujący kompletny proces  
**Continuous Integration (CI)** oraz **Continuous Deployment (CD)** w środowisku **Microsoft Azure**.

Celem projektu jest zaprezentowanie automatyzacji procesów DevOps, obejmujących:
- zarządzanie kodem źródłowym,
- automatyczne testy,
- kontrolę jakości kodu,
- konteneryzację,
- bezpieczne zarządzanie sekretami,
- automatyczne wdrożenie aplikacji do chmury.

Aplikacja posiada uproszczoną logikę biznesową i służy wyłącznie jako projekt demonstracyjny.

---

## Technologie

W projekcie wykorzystano:

- **GitHub** – repozytorium kodu
- **GitHub Projects** – zarządzanie backlogiem zadań
- **GitHub Actions** – pipeline CI/CD
- **Docker** – konteneryzacja aplikacji
- **Azure App Service** – środowisko wdrożeniowe
- **ASP.NET Core Web API (.NET 9)** – aplikacja backendowa

---

## Opis aplikacji

Projekt jest aplikacją **ASP.NET Core Web API** opartą o **Minimal API**.  
Udostępnia proste endpointy HTTP, które są wykorzystywane w testach oraz pipeline CI.

### Endpointy

- `GET /`  
  Zwraca informacje o stanie aplikacji, środowisku oraz aktualnym czasie serwera

- `GET /products`  
  Zwraca przykładową listę produktów w formacie JSON

---

## CI / CD

### Continuous Integration (CI)

Pipeline CI został zrealizowany przy użyciu **GitHub Actions** i uruchamia się:

- automatycznie przy **Pull Request do gałęzi `main`**
- ręcznie za pomocą **workflow_dispatch**

Etapy pipeline CI:
1. Checkout repozytorium
2. Konfiguracja środowiska .NET
3. Przywrócenie zależności
4. Build aplikacji
5. Uruchomienie testów jednostkowych
6. Weryfikacja poprawności budowy obrazu Docker

#### Quality Gate

Pipeline CI pełni rolę **Quality Gate**:
- nieudany build lub testy blokują dalsze etapy
- kod niespełniający wymagań jakościowych nie powinien zostać wdrożony

---

### Continuous Deployment (CD)

Pipeline CD uruchamia się automatycznie po **merge Pull Requesta do gałęzi `main`**.

Etapy pipeline CD:
1. Build aplikacji w konfiguracji produkcyjnej
2. Publikacja artefaktów
3. Automatyczne wdrożenie aplikacji do **Azure App Service**

Proces wdrożenia jest w pełni zautomatyzowany.

---

## Konteneryzacja

Aplikacja została skonteneryzowana przy użyciu **Dockera**.

---

## Bezpieczeństwo

Wrażliwe dane konfiguracyjne nie są przechowywane w repozytorium.

Zastosowane rozwiązania:
- **GitHub Secrets** do przechowywania sekretów
- przekazywanie sekretów jako zmienne środowiskowe
- wykorzystywanie sekretów w pipeline CI/CD

---