[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=22547981)
# Ejercicios de C# - Bucles y Control de Flujo

Este proyecto contiene 4 ejercicios prácticos para aprender sobre bucles (`for`, `while`, `do-while`) en C#.

## 📋 Estructura del Proyecto

```
Tarea_dia_3_c/
├── EjerciciosCSharp/              # Proyecto principal con los ejercicios
│   ├── Ejercicios.cs              # Archivo con las funciones a completar
│   └── Program.cs                 # Programa principal para probar
└── EjerciciosCSharp.Tests/        # Proyecto de pruebas
    └── EjerciciosTests.cs         # Tests automáticos para verificar
```

## 🎯 Ejercicios a Realizar

### Ejercicio 1: La Tabla de Multiplicar (Usuario Elige)
- **Concepto:** Bucle `for`
- **Archivo:** `Ejercicios.cs` → Método `TablaDeMultiplicar()`
- **Objetivo:** Imprimir la tabla de multiplicar del 1 al 12 de un número dado
- **Formato esperado:** `"5 x 1 = 5\n5 x 2 = 10\n..."`

### Ejercicio 2: Validador de Contraseña
- **Concepto:** Bucle `do-while`
- **Archivo:** `Ejercicios.cs` → Método `ValidarContrasena()`
- **Objetivo:** Pedir contraseña repetidamente hasta que el usuario escriba "1234"
- **Pista:** Un `do-while` ejecuta el código AL MENOS una vez

### Ejercicio 3: Suma Acumulativa
- **Concepto:** Bucle `while`
- **Archivo:** `Ejercicios.cs` → Método `SumaAcumulativa()`
- **Objetivo:** Sumar números hasta que se encuentre un 0
- **Pista:** Necesitas una variable acumulador inicializada en 0

### Ejercicio 4: El Contador de Pares
- **Concepto:** Bucle `for` con incremento personalizado
- **Archivo:** `Ejercicios.cs` → Método `ContadorDePares()`
- **Objetivo:** Imprimir todos los números pares del 0 al 50
- **Reto:** Usa `i+=2` en lugar de `i++` para saltar directamente a los pares

## 🚀 Cómo Empezar

### 1. Abrir el archivo de ejercicios
```bash
code EjerciciosCSharp/Ejercicios.cs
```

### 2. Completar las funciones
Cada función tiene:
- ✅ Una descripción de qué debe hacer
- ✅ Pistas en comentarios para ayudarte
- ✅ La estructura básica ya lista

**Busca los comentarios `// TU CÓDIGO AQUÍ`** y completa la lógica.

### 3. Probar tus soluciones

#### Opción A: Usar el Program.cs
```bash
cd EjerciciosCSharp
dotnet run
```

Descomenta las líneas en `Program.cs` para probar cada ejercicio manualmente.

#### Opción B: Ejecutar los Tests Automáticos ⭐ (Recomendado)
```bash
cd EjerciciosCSharp.Tests
dotnet test
```

Los tests te dirán exactamente qué funciona y qué no. ¡Todos deben pasar! ✅

### 4. Ver resultados detallados de los tests
```bash
cd EjerciciosCSharp.Tests
dotnet test --verbosity normal
```

## ✅ Verificación

Para saber si completaste los ejercicios correctamente:

```bash
cd EjerciciosCSharp.Tests
dotnet test
```

**Resultado esperado:**
```
Passed! - Failed: 0, Passed: 14, Skipped: 0
```

Si todos los tests pasan (✅), ¡lo hiciste perfecto!

## 📝 Ejemplos de Salida Esperada

### Ejercicio 1 - Tabla del 5:
```
5 x 1 = 5
5 x 2 = 10
5 x 3 = 15
...
5 x 12 = 60
```

### Ejercicio 2 - Validador:
```
Usuario: 1111  → Intento 1 ❌
Usuario: 9999  → Intento 2 ❌
Usuario: 1234  → Intento 3 ✅ (retorna 3)
```

### Ejercicio 3 - Suma:
```
Entrada: [10, 20, 30, 0, 100]
Resultado: 60  (no suma el 0 ni lo que viene después)
```

### Ejercicio 4 - Pares:
```
0, 2, 4, 6, 8, 10, ..., 48, 50
```

## 🎓 Conceptos Clave

- **`for`**: Cuando sabes exactamente cuántas veces iterar
- **`while`**: Cuando no sabes cuántas veces, pero verificas la condición ANTES
- **`do-while`**: Como `while`, pero ejecuta AL MENOS una vez (verifica DESPUÉS)
- **Acumulador**: Variable que va sumando o concatenando valores en cada iteración

## 💡 Tips

1. Lee las pistas en los comentarios de cada función
2. Empieza por el ejercicio 1 (es el más simple)
3. Prueba tu código frecuentemente con `dotnet test`
4. Si un test falla, lee el mensaje de error - te dice exactamente qué esperaba
5. Recuerda: `\n` es el salto de línea en strings

## 🐛 ¿Problemas?

- **"La solución no compila"**: Verifica tu sintaxis, probablemente falta un `;` o `}`
- **"Los tests fallan"**: Lee el mensaje de error y compara con el formato esperado
- **"No sé cómo empezar"**: Lee las pistas en los comentarios, ¡están ahí para ayudarte!

---

¡Buena suerte! 🚀 Si todos los tests pasan, has dominado los bucles en C#.
