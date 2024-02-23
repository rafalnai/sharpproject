 public class BoundingFrustum : IEquatable<BoundingFrustum>
    {
        #region Private Fields

        private Matrix _matrix;
        private readonly Vector3[] _corners = new Vector3[CornerCount];
        private readonly Plane[] _planes = new Plane[PlaneCount];


 public Curve Clone()
        {
            Curve curve = new Curve();

            curve._keys = this._keys.Clone();
            curve._preLoop = this._preLoop;
            curve._postLoop = this._postLoop;

            return curve;
        }

     //need more here   
        public int UpdateOrder
        {
            get { return _updateOrder; }
            set
            {
                if (_updateOrder != value)
                {
                    _updateOrder = value;
                    OnUpdateOrderChanged(this, EventArgs.Empty);
                }
            }
        }
