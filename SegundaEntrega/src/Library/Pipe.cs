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
        public IXML Send(Tag tag)
        {
            IXML resultTag = filter.Filter(tag);
            if (filter.Result)
            {
                resultTag = truePipe.Send(resultTag);
            }
            else 
            {
                resultTag = falsePipe.Send(resultTag);
            }
            return resultTag;
        }
    }
}