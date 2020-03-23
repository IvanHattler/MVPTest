using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPTest.Models;
using MVPTest.Views;

namespace MVPTest.Presenters
{
    public class MainPresenter
    {
        private IView view;
        private IModel model;

        public MainPresenter(IView view)
        {
            this.view = view;
        }

        public void CalculateDiv()
        {
            model = new MainModel(uint.Parse(view.FirstNumText),
                uint.Parse(view.SecondNumText));
            model.Div();
            view.ResultText = model.Result.ToString();
        }
    }
}
