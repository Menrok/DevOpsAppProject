# DevOpsAppProject

## Opis projektu
Projekt demonstracyjny z zakresu DevOps, prezentujący kompletny proces
Continuous Integration oraz Continuous Deployment w środowisku Azure.

## Technologie
- GitHub
- GitHub Projects
- GitHub Actions
- Azure App Service
- .NET 9

## Uruchomienie lokalne
Instrukcja uruchomienia aplikacji lokalnie zostanie dodana w kolejnym etapie.

## CI/CD
- CI: automatyczny build i testy uruchamiane przy Pull Request do `main`
- CI może być również uruchamiany ręcznie (`workflow_dispatch`)
- CD: automatyczne wdrożenie aplikacji do Azure po merge do `main`

## Bezpieczeństwo
Wrażliwe dane konfiguracyjne nie są przechowywane w repozytorium.
Sekrety aplikacji są zarządzane za pomocą GitHub Secrets
i wykorzystywane w pipeline CI/CD.

## Struktura repozytorium
- `.github/workflows` – definicje pipeline CI/CD
- `SklepAPI` – aplikacja webowa
- `SklepAPI.Tests` – testy jednostkowe
- `SklepDevOps.sln` – solution .NET