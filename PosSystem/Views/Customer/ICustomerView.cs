//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ICustomerView.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using lhk.POS.Presentation.Models;
namespace lhk.POS.Presentation.Views
{
    public interface ICustomerView
    {
        void InitView(CustomerModel model);
    }
}
