namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitorRoute>
    {
        private VisitRouteMover _visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }
        private int currentIndex = 0;
        public VisitorRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if(currentIndex < _visitRouteMover.VisitRouteCount)
            {
                CurrentItem = _visitRouteMover.visitorRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
