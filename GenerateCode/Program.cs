using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.IO;
using lhk.POS.Core.Domain;

namespace GenerateCode
{
    public class CodeDomSample
    {
        // Generate code for a particular provider and compile it
        static void GenerateCode(CodeCompileUnit ccu)
        {
            CompilerParameters cp = new CompilerParameters();
            String sourceFile;
            CompilerResults cr;

            // Generate Code from Compile Unit using CSharp code provider
            //
            CSharpCodeProvider csharpcodeprovider = new CSharpCodeProvider();

            if (csharpcodeprovider.FileExtension[0] == '.')
            {
                sourceFile = "CSharpSample" + csharpcodeprovider.FileExtension;
            }
            else
            {
                sourceFile = "CSharpSample." + csharpcodeprovider.FileExtension;
            }
            IndentedTextWriter tw1 = new IndentedTextWriter(new StreamWriter(sourceFile, false), "    ");
            csharpcodeprovider.GenerateCodeFromCompileUnit(ccu, tw1, new CodeGeneratorOptions());
            tw1.Close();
            cp.GenerateExecutable = true;
            cp.OutputAssembly = "CSharpSample.exe";
            cp.GenerateInMemory = false;
            cr = csharpcodeprovider.CompileAssemblyFromDom(cp, ccu);

            return;
        }

        static public void Main()
        {
            ModelGenerater<Customer> cds = new ModelGenerater<Customer>();
            CodeCompileUnit ccu = cds.Generate("Customer");
            GenerateCode(ccu);
        }
    }
}