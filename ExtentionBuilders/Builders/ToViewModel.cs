using System;
using System.Linq;
using System.Reflection;

namespace ExtentionBuilders.Builders
{
    public static class ToViewModel
    {
        public static Tout ToViewModelConv<Tout>(this object source) where Tout : class
        {
            Type type = typeof(Tout);
            Tout entity = Activator.CreateInstance(type) as Tout;
            PropertyInfo[] infoesOuts = entity.GetType().GetProperties();
            PropertyInfo[] infoes = source.GetType().GetProperties();
            foreach (PropertyInfo item in infoes)
            {
                var extracted = infoesOuts.Where(x => x.Name.EndsWith(item.Name)).FirstOrDefault();
                if (extracted != null)
                {
                    extracted.SetValue(entity,item.GetValue(source));
                }
            }

            return entity;
        }
    }
}