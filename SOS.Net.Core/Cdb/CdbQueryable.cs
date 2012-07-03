using System;

namespace SOS.Net.Core.Cdb
{
    public class CdbQueryable<T>
    {
        private T value;

        internal CdbProcess process;

        public T Value
        {
            get { return this.value; }
        }

        public CdbQueryable(T value, CdbProcess process)
        {
            this.process = process;
            this.value = value;
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return value == null;
            if (!(other is CdbQueryable<T>))
                return false;

            return Equals((CdbQueryable<T>)other);
        }

        bool Equals(CdbQueryable<T> other)
        {
            CdbQueryable<T> queryable = (CdbQueryable<T>)other;

            return object.Equals(queryable.value,value);
        }

        public override int GetHashCode()
        {
            if (value == null)
                return 0;

            return value.GetHashCode();
        }

        public override string ToString()
        {
            if (value != null)
                return value.ToString();
            else
                return String.Empty;
        }
        
        public static explicit operator T(CdbQueryable<T> value)
        {
            return value.value;
        }
    }
}
