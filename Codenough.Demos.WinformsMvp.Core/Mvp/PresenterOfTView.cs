
namespace Codenough.Demos.WinformsMvp.Core.Mvp
{
    public abstract class Presenter<TView> : IPresenter
        where TView : IView
    {
        private readonly TView view;

        public TView View
        {
            get { return this.view; }
        }

        public Presenter(TView view)
        {
            this.view = view;
        }
    }
}
