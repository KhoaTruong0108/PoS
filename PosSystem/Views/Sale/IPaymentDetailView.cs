//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : IProductView.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using lhk.POS.Presentation.Models;
namespace lhk.POS.Presentation.Views{
    public interface IPaymentDetailView
    {
        void InitView(PaymentDetailModel model);
    }
}
