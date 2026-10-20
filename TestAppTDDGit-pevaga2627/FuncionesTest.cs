

// Autor: Pedro Valles Gambín - pevaga2627

using AppTDDGit_pevaga2627;

namespace TestAppTDDGit_pevaga2627
{
	[TestClass]
	public sealed class FuncionesTest
	{
		[TestMethod]
		[DataRow(-1, -1L)]   // negativo
		[DataRow(-5, -1L)]   // negativo
		[DataRow(0, 1L)]     // el factorial de 0 es 1
		[DataRow(1, 1L)]
		[DataRow(5, 120L)]
		[DataRow(10, 3628800L)]
		public void CalcularFactorial_VariosCasos(int n, long esperado)
		{
			long result = Funciones.CalcularFactorial(n);
			Assert.AreEqual(esperado, result);
		}
	}
}
