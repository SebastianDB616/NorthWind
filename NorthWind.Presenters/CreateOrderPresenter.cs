using System;
using NorthWind.UseCasesPorts.CreateOrder;

namespace NorthWind.Presenters
{
    public class CreateOrderPresenter : ICreateOrderOutputPort, IPresenter<string>
    {
        public string Content { get; private set; }
        Task ICreateOrderOutputPort.Handle(int orderId)
        {
            Content = $"Order ID: {orderId}";
            return Task.CompletedTask;
        }
    }
}
