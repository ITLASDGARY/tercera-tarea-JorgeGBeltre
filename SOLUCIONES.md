# Soluciones - Ejercicios de C#

⚠️ **ADVERTENCIA:** Este archivo contiene las soluciones completas de los ejercicios. 
Intenta resolverlos por ti mismo primero antes de ver las respuestas.

---

## Ejercicio 1: La Tabla de Multiplicar

```csharp
public static string TablaDeMultiplicar(int numero)
{
    string resultado = "";
    
    for (int i = 1; i <= 12; i++)
    {
        resultado += $"{numero} x {i} = {numero * i}\n";
    }
    
    return resultado;
}
```

**Explicación:**
- El bucle `for` itera desde 1 hasta 12
- En cada iteración, multiplica el número por `i`
- Usa interpolación de strings (`$"{}"`) para formatear la salida
- Concatena cada línea al resultado con `+=`

---

## Ejercicio 2: Validador de Contraseña

```csharp
public static int ValidarContrasena(Func<string> obtenerInput)
{
    string claveSecreta = "1234";
    int intentos = 0;
    string entrada = "";
    
    do
    {
        entrada = obtenerInput();
        intentos++;
    } while (entrada != claveSecreta);
    
    return intentos;
}
```

**Explicación:**
- `do-while` ejecuta el bloque AL MENOS una vez
- Incrementa `intentos` en cada iteración
- La condición `entrada != claveSecreta` verifica si debe repetir
- Cuando entrada es "1234", el bucle termina

---

## Ejercicio 3: Suma Acumulativa

```csharp
public static int SumaAcumulativa(int[] numeros)
{
    int suma = 0;
    
    foreach (int numero in numeros)
    {
        if (numero == 0)
            break;
        suma += numero;
    }
    
    return suma;
}
```

**Alternativa con while:**
```csharp
public static int SumaAcumulativa(int[] numeros)
{
    int suma = 0;
    int i = 0;
    
    while (i < numeros.Length && numeros[i] != 0)
    {
        suma += numeros[i];
        i++;
    }
    
    return suma;
}
```

**Explicación:**
- El acumulador `suma` empieza en 0
- Recorre cada número del array
- Si encuentra un 0, usa `break` para salir del bucle
- Suma cada número antes de verificar si es 0

---

## Ejercicio 4: El Contador de Pares

```csharp
public static string ContadorDePares()
{
    string resultado = "";
    
    for (int i = 0; i <= 50; i += 2)
    {
        if (i > 0)
            resultado += ", ";
        resultado += i;
    }
    
    return resultado;
}
```

**Alternativa más simple:**
```csharp
public static string ContadorDePares()
{
    string resultado = "0";
    
    for (int i = 2; i <= 50; i += 2)
    {
        resultado += ", " + i;
    }
    
    return resultado;
}
```

**Explicación:**
- `i += 2` hace que el bucle salte de 2 en 2
- Empieza en 0 (primer número par)
- Agrega coma antes de cada número (excepto el primero)
- No necesita `if` para verificar si es par, porque `i+=2` solo itera sobre pares

---

## 🎯 Conceptos Aprendidos

1. **for**: Ideal cuando sabes el número exacto de iteraciones
2. **do-while**: Útil cuando necesitas ejecutar AL MENOS una vez
3. **while**: Para bucles con condición desconocida pero verificada ANTES
4. **break**: Rompe y sale del bucle inmediatamente
5. **Acumuladores**: Variables que van sumando/concatenando valores

---

## 💡 Tips de Optimización

### Ejercicio 1 - StringBuilder
Para mejor performance con muchas concatenaciones:
```csharp
var sb = new System.Text.StringBuilder();
for (int i = 1; i <= 12; i++)
{
    sb.AppendLine($"{numero} x {i} = {numero * i}");
}
return sb.ToString();
```

### Ejercicio 4 - String.Join
Forma más elegante:
```csharp
public static string ContadorDePares()
{
    var pares = new System.Collections.Generic.List<int>();
    for (int i = 0; i <= 50; i += 2)
    {
        pares.Add(i);
    }
    return string.Join(", ", pares);
}
```

---

¡Espero que estos ejercicios te hayan ayudado a dominar los bucles en C#! 🚀
