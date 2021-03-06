namespace HlslTools.Binding.BoundNodes
{
    internal sealed class BoundTypeDeclaration : BoundNode
    {
        public BoundType BoundType { get; }

        public BoundTypeDeclaration(BoundType boundType)
            : base(BoundNodeKind.TypeDeclaration)
        {
            BoundType = boundType;
        }
    }
}