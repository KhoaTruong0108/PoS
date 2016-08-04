using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lhk.POS.Core.Domain;

namespace GenerateCode
{
    public class PresenterGenerater<T> where T : BaseEntity
    {
        public CodeCompileUnit Generate(string objectName)
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();

            // Create a NameSpace - "namespace CodeDomSampleNS"
            CodeNamespace codeNameSpace = new CodeNamespace("lhk.POS.Presentation.Models");

            //codeNameSpace.Comments.Add(new CodeCommentStatement(""))

            // Add the using statement to the namespace -
            codeNameSpace.Imports.AddRange(new List<CodeNamespaceImport>() { 
                new CodeNamespaceImport("System.Collections.Generic"),
                new CodeNamespaceImport("System.ComponentModel"),
                new CodeNamespaceImport("lhk.POS.Core.Domain"),
                new CodeNamespaceImport("lhk.POS.Core.Util")
            }.ToArray());

            // Create a type inside the namespace - public class CodeDomSample
            //
            CodeTypeDeclaration newType = new CodeTypeDeclaration(objectName + "Model");
            newType.Attributes = MemberAttributes.Public;
            newType.BaseTypes.Add(typeof(INotifyPropertyChanged));

            //Variable
            CodeMemberField field = new CodeMemberField();
            field.Name = "_" + typeof(T).Name;
            field.Type = new CodeTypeReference(typeof(T));
            field.Attributes = MemberAttributes.Private;
            newType.Members.Add(field);


            // At the end of the CodeStatements we should have constructed the following
            CodeConstructor constructor = new CodeConstructor();
            constructor.Attributes = MemberAttributes.Public;
            constructor.Parameters.Add(new CodeParameterDeclarationExpression(typeof(T), typeof(T).Name.ToLower()));
            newType.Members.Add(constructor);

            //CodeStatement cs = new CodeAssignStatement(new CodeVariableReferenceExpression(field.Name), new CodePrimitiveExpression(typeof(T).Name.ToLower()));
            //constructor.Statements.Add(cs);

            CodeFieldReferenceExpression widthReference = new CodeFieldReferenceExpression(
                                                            new CodeThisReferenceExpression(), field.Name);
            constructor.Statements.Add(new CodeAssignStatement(widthReference,
                new CodeArgumentReferenceExpression(typeof(T).Name.ToLower())));

            //get - set section

            #region Properties section
            foreach (var property in typeof(T).GetProperties())
            {
                string fieldProperty = string.Format("{0}.{1}",field.Name,property.Name);

                // Declares a property.
                CodeMemberProperty memberProperty = new CodeMemberProperty();
                // Declares a property get statement to return the value of the integer field.
                memberProperty.GetStatements.Add(new CodeSnippetStatement(string.Format("return {0}; ",fieldProperty)));
                //property1.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "integerField")));
                // Declares a property set statement to set the value to the integer field. 
                memberProperty.SetStatements.Add(new CodeSnippetStatement(string.Format(" {0} = value; InvokePropertyChanged(new PropertyChangedEventArgs(\"{1}\"));", fieldProperty, property.Name)));
                memberProperty.Attributes = MemberAttributes.Public | MemberAttributes.Final ;
                memberProperty.Name = property.Name;

                newType.Members.Add(memberProperty);
            }
            #endregion

            // Add constructor and mainmethod to type

            #region InotifyChange
            var ev = new CodeSnippetTypeMember("public event PropertyChangedEventHandler PropertyChanged;");
            newType.Members.Add(ev);

            CodeMemberMethod notifyMethod = new CodeMemberMethod();
            notifyMethod.Name = "InvokePropertyChanged";
            notifyMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(PropertyChangedEventArgs), "e"));

            CodeSnippetStatement statment = new CodeSnippetStatement();
            statment.Value = "PropertyChangedEventHandler handler = PropertyChanged;\n if (handler != null) handler(this, e);";
            notifyMethod.Statements.Add(statment);
            newType.Members.Add(notifyMethod);
            #endregion

            // Add the type to the namespace
            codeNameSpace.Types.Add(newType);

            // Add the NameSpace to the CodeCompileUnit
            compileUnit.Namespaces.Add(codeNameSpace);

            // Return the CompileUnit
            return compileUnit;
        }
    }
}
