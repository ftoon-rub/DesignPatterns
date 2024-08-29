using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class TestTemplate
    {
        public void DescribePattern()
        {
            PatternCategory();
            PatternDescription();
            PatternComponents();
            SolidUsedInPattern();
            OopUsedInPattern();
            TestDesignPatternMain();
            TestDesignPatternProblem();
            TestDesignPatternSolution();
        }
        protected abstract void PatternCategory();
        protected abstract void PatternDescription();
        protected abstract void PatternComponents();
        protected abstract void SolidUsedInPattern();
        protected abstract void OopUsedInPattern();
        protected abstract void TestDesignPatternMain();
        protected abstract void TestDesignPatternProblem();
        protected abstract void TestDesignPatternSolution();
    }
}
