using System.Runtime.InteropServices;
using System.Text.Json;
using ExemploMethodGroupConversion;

Console.WriteLine("***** Testes com C# 11 | Improved Method Group Conversion to Delegate *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine(
    $"{nameof(Testes.ListarNumerosImpares)} = {JsonSerializer.Serialize(Testes.ListarNumerosImpares())}");

Console.WriteLine(
    $"{nameof(Testes.ListarNumerosImparesV2)} = {JsonSerializer.Serialize(Testes.ListarNumerosImparesV2())}");