using Xunit;
using System;

namespace EjerciciosCSharp.Tests
{
    public class EjerciciosTests
    {
        #region Ejercicio 1: Tabla de Multiplicar

        [Fact]
        public void TablaDeMultiplicar_Numero5_RetornaTablaCorrecta()
        {
            // Arrange
            int numero = 5;
            string esperado = "5 x 1 = 5\n5 x 2 = 10\n5 x 3 = 15\n5 x 4 = 20\n5 x 5 = 25\n" +
                              "5 x 6 = 30\n5 x 7 = 35\n5 x 8 = 40\n5 x 9 = 45\n5 x 10 = 50\n" +
                              "5 x 11 = 55\n5 x 12 = 60\n";

            // Act
            string resultado = Ejercicios.TablaDeMultiplicar(numero);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TablaDeMultiplicar_Numero3_RetornaTablaCorrecta()
        {
            // Arrange
            int numero = 3;
            string esperado = "3 x 1 = 3\n3 x 2 = 6\n3 x 3 = 9\n3 x 4 = 12\n3 x 5 = 15\n" +
                              "3 x 6 = 18\n3 x 7 = 21\n3 x 8 = 24\n3 x 9 = 27\n3 x 10 = 30\n" +
                              "3 x 11 = 33\n3 x 12 = 36\n";

            // Act
            string resultado = Ejercicios.TablaDeMultiplicar(numero);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TablaDeMultiplicar_Numero10_RetornaTablaCorrecta()
        {
            // Arrange
            int numero = 10;
            
            // Act
            string resultado = Ejercicios.TablaDeMultiplicar(numero);

            // Assert
            Assert.Contains("10 x 1 = 10", resultado);
            Assert.Contains("10 x 12 = 120", resultado);
            // Verificar que tiene exactamente 12 líneas
            Assert.Equal(12, resultado.Split('\n', StringSplitOptions.RemoveEmptyEntries).Length);
        }

        #endregion

        #region Ejercicio 2: Validador de Contraseña

        [Fact]
        public void ValidarContrasena_PrimeraVezCorrecta_Retorna1Intento()
        {
            // Arrange
            var intentos = 0;
            Func<string> input = () => "1234";

            // Act
            int resultado = Ejercicios.ValidarContrasena(input);

            // Assert
            Assert.Equal(1, resultado);
        }

        [Fact]
        public void ValidarContrasena_TresIntentosIncorrectos_Retorna4Intentos()
        {
            // Arrange
            var intentos = 0;
            string[] respuestas = { "1111", "2222", "3333", "1234" };
            Func<string> input = () => respuestas[intentos++];

            // Act
            int resultado = Ejercicios.ValidarContrasena(input);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void ValidarContrasena_CincoIntentosIncorrectos_Retorna6Intentos()
        {
            // Arrange
            var intentos = 0;
            string[] respuestas = { "0000", "1111", "2222", "3333", "4444", "1234" };
            Func<string> input = () => respuestas[intentos++];

            // Act
            int resultado = Ejercicios.ValidarContrasena(input);

            // Assert
            Assert.Equal(6, resultado);
        }

        #endregion

        #region Ejercicio 3: Suma Acumulativa

        [Fact]
        public void SumaAcumulativa_SumaSimple_RetornaSumaCorrecta()
        {
            // Arrange
            int[] numeros = { 10, 20, 30, 0 };

            // Act
            int resultado = Ejercicios.SumaAcumulativa(numeros);

            // Assert
            Assert.Equal(60, resultado);
        }

        [Fact]
        public void SumaAcumulativa_ConNumerosCero_NoSumaLosDespuesDelPrimerCero()
        {
            // Arrange
            int[] numeros = { 5, 10, 15, 0, 100, 200 };

            // Act
            int resultado = Ejercicios.SumaAcumulativa(numeros);

            // Assert
            Assert.Equal(30, resultado); // Solo suma 5+10+15, ignora lo después del 0
        }

        [Fact]
        public void SumaAcumulativa_SoloUnCero_RetornaCero()
        {
            // Arrange
            int[] numeros = { 0 };

            // Act
            int resultado = Ejercicios.SumaAcumulativa(numeros);

            // Assert
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void SumaAcumulativa_NumerosNegativos_SumaCorrectamente()
        {
            // Arrange
            int[] numeros = { 10, -5, 20, -10, 0 };

            // Act
            int resultado = Ejercicios.SumaAcumulativa(numeros);

            // Assert
            Assert.Equal(15, resultado); // 10-5+20-10 = 15
        }

        #endregion

        #region Ejercicio 4: Contador de Pares

        [Fact]
        public void ContadorDePares_RetornaTodosLosPares()
        {
            // Act
            string resultado = Ejercicios.ContadorDePares();

            // Assert
            Assert.Contains("0", resultado);
            Assert.Contains("2", resultado);
            Assert.Contains("50", resultado);
        }

        [Fact]
        public void ContadorDePares_NoContieneImpares()
        {
            // Act
            string resultado = Ejercicios.ContadorDePares();

            // Assert
            // Verificar que no contiene números impares
            Assert.DoesNotContain(" 1,", resultado);
            Assert.DoesNotContain(" 3,", resultado);
            Assert.DoesNotContain(" 49,", resultado);
        }

        [Fact]
        public void ContadorDePares_TieneCantidadCorrectaDeNumeros()
        {
            // Act
            string resultado = Ejercicios.ContadorDePares();

            // Assert
            // Del 0 al 50 hay 26 números pares (0,2,4,...,50)
            var numeros = resultado.Split(',', StringSplitOptions.RemoveEmptyEntries);
            Assert.Equal(26, numeros.Length);
        }

        [Fact]
        public void ContadorDePares_FormatoConComas()
        {
            // Act
            string resultado = Ejercicios.ContadorDePares();

            // Assert
            // Verificar que usa el formato correcto con comas
            Assert.Contains(", ", resultado);
            Assert.StartsWith("0", resultado.Trim());
            Assert.EndsWith("50", resultado.Trim());
        }

        #endregion
    }
}
