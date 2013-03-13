
namespace Codenough.Demos.WinformsMvp.Core.Mvp
{
    public interface IView<TModel> : IView
    {
        TModel Model { get; }
    }
}
