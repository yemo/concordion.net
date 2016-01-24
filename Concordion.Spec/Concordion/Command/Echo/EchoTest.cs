﻿using Concordion.NET.Integration;
using Concordion.Spec.Support;

namespace Concordion.Spec.Concordion.Command.Echo
{
    [ConcordionTest]
    public class EchoTest
    {
        private string nextResult;

        public void setNextResult(string nextResult) 
        {
            this.nextResult = nextResult;
        }

        public string render(string fragment)
        {
            return new TestRig()
                .WithStubbedEvaluationResult(nextResult)
                .ProcessFragment(fragment)
                .GetOutputFragmentXML();
        }
    }
}
