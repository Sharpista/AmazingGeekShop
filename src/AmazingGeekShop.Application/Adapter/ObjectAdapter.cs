using AmazingGeekShop.Application.Common.Interfaces;

namespace AmazingGeekShop.Application.Adapter;

public class ObjectAdapter<TInput,TTarget> : IObjectAdapter<TInput, TTarget> where TTarget : new()
{
    public TTarget MapToTarget(TInput input)
    {
        var target = new TTarget();
        var inputType = typeof(TInput);
        var targetType = typeof(TTarget);

        foreach (var property in inputType.GetProperties())
        {
            var targetProperty = targetType.GetProperty(property.Name);
            if (targetProperty is null || !targetProperty.CanWrite) continue;
            var value = property.GetValue(input);
            targetProperty.SetValue(target, value);
        }

        return target;
    }

   
}