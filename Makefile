# Atajos (en Windows: usar Git Bash o ejecutar los comandos a mano)
.PHONY: up down logs test test-api test-web build deploy-demo

up:
	docker compose up -d

down:
	docker compose down

logs:
	docker compose logs -f api

test: test-api test-web

test-api:
	dotnet test backend/ScrumMate.sln

test-web:
	cd frontend && npm test

build:
	docker compose build

deploy-demo:
	kubectl apply -k k8s/overlays/demo
