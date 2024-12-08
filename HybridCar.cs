using TestSkill.Enum;
namespace TestSkill
{
    class HybridCar : Car
    {
        public EnumTypeFuel TypeFuel;
        public HybridCar(EnumTypeFuel typeFuel)
        {
            TypeFuel = typeFuel;
        }

    }
}
