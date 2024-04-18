using NUnit.Framework;
using UnityEngine;

namespace ChanceEditor.Tests
{
    public class WrapperTests
    {
        [Test]
        public void WhenCalculate_AndChanseIs1_ThenReturnedValueShouldBeTrue()
        {
            var wrapper = new ChanceWrapper<GameObject>(GameObject.CreatePrimitive(PrimitiveType.Sphere), 1);

            var result = wrapper.Calculate();

            Assert.AreEqual(true, result);
        }

        [Test]
        public void WhenCalculate_AndChanseIs0_ThenReturnedValueShouldBeFalse()
        {
            var wrapper = new ChanceWrapper<GameObject>(GameObject.CreatePrimitive(PrimitiveType.Sphere), 0);

            var result = wrapper.Calculate();

            Assert.AreEqual(false, result);
        }
    }
}
