# DevOpsAppProject

## Cel projektu
Celem projektu jest stworzenie aplikacji webowej wraz z kompletnym procesem CI/CD
z wykorzystaniem GitHub Projects, Git, pipeline CI oraz CD w Azure.

## Zakres
- Repozytorium Git
- Aplikacja webowa (2 endpointy)
- Testy jednostkowe
- Pipeline CI
- Pipeline CD
- Publiczny deployment aplikacji

## Metodyka
Projekt realizowany jest w oparciu o GitHub Projects.
Każdy etap projektu posiada osobne Issue oraz dedykowaną gałąź Git.
Commity oraz Pull Requesty są powiązane z Issue i zamykają je automatycznie.

## Status
Backlog utworzony i podzielony na etapy.

## Bezpieczeństwo
Wrażliwe dane konfiguracyjne nie są przechowywane w repozytorium.
Sekrety aplikacji są zarządzane za pomocą GitHub Secrets
i wykorzystywane w pipeline CI.

## Continuous Integration
Pipeline CI uruchamia się automatycznie przy:
- Pull Request do gałęzi main
- Push do gałęzi main

Proces CI obejmuje:
- przywrócenie zależności
- build aplikacji
- uruchomienie testów jednostkowych
