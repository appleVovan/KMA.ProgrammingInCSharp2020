using System.Windows.Controls;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.Navigation
{
    internal interface IContentOwner
    {
        INavigatable Content { get; set; }
    }
}
