using Nest;

namespace PipelineClass
{
    public class MyPipeline : Pipeline
    {
        public override IList<IPipelineStep> 
        {
            get {
                return new List<IPipelineStep>() {
                    new MostCommonWordStep(),
                    new CountCharactersStep(),
                    new IsOddStep(),
                }
            }
        }
    }
}