namespace LeetCode
{
    public class BinaryMatrix
    {
        public int Get(int row, int col) { return 1; }
        public IList<int> Dimensions()
        {
            return new List<int> { 1, 1 };
        }
    }

    public static class Q_1428_Leftmost_Column_with_at_Least_a_One
    {
        public static int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {

            // [rows, cols]
            var dim = binaryMatrix.Dimensions();
            var rowCount = dim[0];
            var colCount = dim[1];

            var minimum = Int32.MaxValue;

            for (int i = 0; i < rowCount; i++)
            {
                var local_minimum = CheckRow(binaryMatrix, i, 0, colCount - 1);
                minimum = Math.Min(minimum, local_minimum);
            }

            return minimum == Int32.MaxValue ? -1 : minimum;
        }

        private static int CheckRow(BinaryMatrix binaryMatrix, int row, int start, int end)
        {
            if (start > end)
                return Int32.MaxValue;

            if (end == start)
                return binaryMatrix.Get(row, start) == 1 ? start : Int32.MaxValue;

            var mid = start + (end - start) / 2;
            var midVal = binaryMatrix.Get(row, mid);

            if (midVal == 1)
            {
                // we need to check left of mid
                var left = CheckRow(binaryMatrix, row, start, mid - 1);
                if (left == Int32.MaxValue)
                    return mid;
                else
                    return left;
            }
            else
            {
                // we need to check right of mid
                var right = CheckRow(binaryMatrix, row, mid + 1, end);
                return right;
            }

        }
    }
}
