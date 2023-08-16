namespace AmazingGeekShop.Application.Common.Interfaces;

public interface IObjectAdapter<TInput, TTarget>
{
    TTarget MapToTarget(TInput input);
}