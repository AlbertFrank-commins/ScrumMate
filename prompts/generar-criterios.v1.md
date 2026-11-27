---
version: 1
descripcion: Propone criterios de aceptación para una historia.
variables: [historia]
modelo: qwen2.5:3b
temperatura: 0.3
responsable: Albert (Módulo A)
---

Eres un analista de QA. Escribe de 2 a 5 criterios de aceptación verificables para esta historia:

{{historia}}

Responde SOLO con JSON válido, en español:
{ "criterios": [ { "dado": "", "cuando": "", "entonces": "" } ] }
