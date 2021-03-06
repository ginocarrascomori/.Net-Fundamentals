﻿
namespace SOLID._5._Dependency_inversion.Before
{
    namespace HighLevel.Important
    {
        using SOLID._5._Dependency_inversion.Before.LowLevel.Plugin;

        class HighLevelClass
        {
            void Execute()
            {
                ILowLevel lowLevel = new LowLevelClass();
                var param = lowLevel.Get(1);

                //CODE

                lowLevel.Save(param);
            }
        }
    }

    namespace LowLevel.Plugin
    {
        class LowLevelClass : ILowLevel
        {
            public object Get(int id) { return null; }
            public void Save(object value) { }
        }

        public interface ILowLevel
        {
            object Get(int id);
            void Save(object value);
        }
    }
}
