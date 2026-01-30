using System;

namespace EjerciciosCSharp
{
    public class Ejercicios
    {
        /// <summary>
        /// Ejercicio 1: La Tabla de Multiplicar
        /// Muestra la tabla de multiplicar del número especificado del 1 al 12
        /// </summary>
        /// <param name="numero">El número del cual se quiere ver la tabla</param>
        /// <returns>Un string con la tabla de multiplicar completa</returns>
        public static string TablaDeMultiplicar(int numero)
        {
            // TODO: Implementar esta función
            // PISTAS:
            // 1. Usa un bucle 'for' que vaya de 1 a 12
            // 2. En cada iteración, multiplica el número por el contador (i)
            // 3. Usa string.Concat o += para ir construyendo el resultado
            // 4. El formato de cada línea debe ser: "numero x i = resultado\n"
            // Ejemplo: Si numero = 5, una línea sería: "5 x 1 = 5\n"
            
            string resultado = "";
            
            // TU CÓDIGO AQUÍ
            
            return resultado;
        }

        /// <summary>
        /// Ejercicio 2: Validador de Contraseña
        /// Valida que la contraseña ingresada sea correcta
        /// Debe seguir pidiendo hasta que sea "1234"
        /// </summary>
        /// <param name="obtenerInput">Función que simula Console.ReadLine()</param>
        /// <returns>El número de intentos que tomó acertar</returns>
        public static int ValidarContrasena(Func<string> obtenerInput)
        {
            // TODO: Implementar esta función
            // PISTAS:
            // 1. Crea una variable: string claveSecreta = "1234";
            // 2. Usa un bucle 'do-while' para repetir hasta que acierte
            // 3. La condición del while debe verificar si la entrada NO es igual a claveSecreta
            // 4. Cuenta los intentos con una variable contador
            // 5. El bucle debe ejecutarse AL MENOS una vez (por eso es do-while)
            
            string claveSecreta = "1234";
            int intentos = 0;
            string entrada = "";
            
            // TU CÓDIGO AQUÍ (usa do-while)
            
            return intentos;
        }

        /// <summary>
        /// Ejercicio 3: Suma Acumulativa
        /// Suma números hasta que el usuario ingrese 0
        /// </summary>
        /// <param name="numeros">Lista de números que el usuario ingresará</param>
        /// <returns>La suma total de todos los números (sin contar el 0 final)</returns>
        public static int SumaAcumulativa(int[] numeros)
        {
            // TODO: Implementar esta función
            // PISTAS:
            // 1. Crea una variable acumulador inicializada en 0
            // 2. Usa un bucle 'foreach' para recorrer los números ya que es una lista
            // osea tendra numero diversos numeros aleatorios ejemplo: 50, 10, 30, 44 ...
            // 3. Si encuentras un 0, detén el bucle (usa 'break')
            // 4. Suma cada número al acumulador antes de verificar si es 0
            // 5. Retorna el acumulador al final
            
            int suma = 0;
            
            // TU CÓDIGO AQUÍ (usa while o foreach con break)
            
            return suma;
        }

        /// <summary>
        /// Ejercicio 4: El Contador de Pares
        /// Retorna todos los números pares entre 0 y 50
        /// </summary>
        /// <returns>Un string con todos los pares separados por comas</returns>
        public static string ContadorDePares()
        {
            // TODO: Implementar esta función
            // PISTAS:
            // 1. Usa un bucle 'for' que empiece en 0
            // 2. RETO: En lugar de incrementar de 1 en 1 (i++), 
            //    incrementa de 2 en 2 (i+=2) para saltar directamente a los pares
            // 3. Ve agregando cada número al string resultado
            // 4. Separa los números con comas (excepto el último)
            // Formato esperado: "0, 2, 4, 6, 8, ..."
            
            string resultado = "";
            
            // TU CÓDIGO AQUÍ (usa for con i+=2)
            
            return resultado;
        }
    }
}
