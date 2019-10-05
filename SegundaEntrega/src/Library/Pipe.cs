using Library;
using ExerciseOne;

namespace CompAndDel.Pipes
{
    public class PipeConditional : IPipe
    {
        IPipe truePipe, falsePipe;
        IFilterConditional filter;
        public PipeConditional(IFilterConditional filter, IPipe truePipe, IPipe falsePipe)
        {
            this.truePipe = truePipe;
            this.falsePipe = falsePipe;
            this.filter = filter;
        }
        public Tag Send(Tag tag)
        {
            Tag filteredTag = filter.Filter(tag);
            Tag resultTag;
            if (filter.Result)
            {
                resultTag = truePipe.Send(filteredTag);
            }
            else 
            {
                resultTag = falsePipe.Send(tag);
            }
            return resultTag;
        }
    }
}