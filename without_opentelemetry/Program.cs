using System;
using System.Diagnostics;
using System.Linq;

namespace without_opentelemetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(DiagnosticSource);

			var assemblies = AppDomain.CurrentDomain.GetAssemblies()
				.Where(a => a.GetName().Name.Equals("System.Diagnostics.DiagnosticSource", StringComparison.Ordinal))
				.ToList();
				
			Console.WriteLine($"Assemblies loaded:{Environment.NewLine}{string.Join(Environment.NewLine, assemblies.Select(a => a.GetName()))}");
        }
    }
}
