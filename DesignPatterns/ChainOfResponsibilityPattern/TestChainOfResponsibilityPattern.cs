using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class TestChainOfResponsibilityPattern : ITestState, ITestMainState, ITestProblemState, ITestSolutionState
    {
        public void Test()
        {
            TestDesignPatternMain();
            TestDesignPatternProblem();
            TestDesignPatternSolution();
        }

        public void TestDesignPatternMain()
        {
            throw new NotImplementedException();
        }

        public void TestDesignPatternProblem()
        {
            throw new NotImplementedException();
        }

        public void TestDesignPatternSolution()
        {
            throw new NotImplementedException();
        }
    }
}
