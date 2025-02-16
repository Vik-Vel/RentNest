using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace RentNest.ModelBinders
{
    namespace AspNetCoreAdvancedDemo.ModelBinders
    {
        //This class is a "provider" of ModelBinders and determines what to use.
        public class DecimalModelBinderProvider : IModelBinderProvider
        {
            public IModelBinder? GetBinder(ModelBinderProviderContext context)
            {
                if (context == null)
                {
                    throw new ArgumentNullException(nameof(context));
                }

                //Checks if the model type is decimal
                if (context.Metadata.ModelType == typeof(decimal) || context.Metadata.ModelType == typeof(decimal))
                {
                    //If so, returns a new instance of DecimalModelBinder
                    return new DecimalModelBinder();
                }
                //Otherwise, returns null, allowing other providers to process the model
                return null;
            }
        }
    }

}
