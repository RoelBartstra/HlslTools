using System.ComponentModel.Composition;
using HlslTools.Compilation;
using HlslTools.Syntax;

namespace HlslTools.VisualStudio.IntelliSense.QuickInfo.QuickInfoModelProviders
{
    [Export(typeof(IQuickInfoModelProvider))]
    internal sealed class FunctionDeclarationQuickInfoModelProvider : QuickInfoModelProvider<FunctionDeclarationSyntax>
    {
        protected override QuickInfoModel CreateModel(SemanticModel semanticModel, SourceLocation position, FunctionDeclarationSyntax node)
        {
            var actualName = node.Name.GetUnqualifiedName().Name;

            if (!actualName.SourceRange.ContainsOrTouches(position))
                return null;

            if (!actualName.Span.IsInRootFile)
                return null;

            var symbol = semanticModel.GetDeclaredSymbol(node);
            if (symbol == null)
                return null;

            return QuickInfoModel.ForSymbol(semanticModel, actualName.Span, symbol);
        }
    }
}