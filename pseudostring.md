Inicio

  Escribir "Introduce una operación (ejemplo: 5 + 3):"
  Leer entrada

  Intentar
    resultado ← EvaluarOperacion(entrada)
    Escribir "Resultado: " + resultado
  Capturar error ex
    Escribir "Error: " + ex.Mensaje
  FinIntentar

Fin

Funcion EvaluarOperacion(input)

  input ← quitar espacios al inicio y final de input

  Si input contiene "+"
    partes ← dividir input por "+"
    retorno ← convertir a número partes[0] + convertir a número partes[1]
    retornar retorno

  Sino si input contiene "-"
    partes ← dividir input por "-"
    retorno ← convertir a número partes[0] - convertir a número partes[1]
    retornar retorno

  Sino si input contiene "*"
    partes ← dividir input por "*"
    retorno ← convertir a número partes[0] * convertir a número partes[1]
    retornar retorno

  Sino si input contiene "/"
    partes ← dividir input por "/"
    divisor ← convertir a número partes[1]


  Sino
    lanzar error "Formato no válido. Usa operadores como +, -, *, /."

FinFuncion
