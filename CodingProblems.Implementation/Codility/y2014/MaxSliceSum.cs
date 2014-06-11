using CodingProblems.Implementation.Codility.y2014;
namespace CodingProblems.Implementation.Codility.y2014.MaxSliceSum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Solution
    {
        public int solution(int[] A)
        {
            var sliceResults = CutIntoSlices(A);
            var result = GetMaxSliceWithSwap(sliceResults, A);
            return result;
        }

        private int GetMaxSliceWithSwap(SlicedArray sliceResults, int[] A)
        {
            var maxSwappedSum = int.MinValue;
            var maxSwappedLength = -1;

            Slice twoSlicesAgo = null;
            Slice lastSlice = null;
            foreach (var slice in sliceResults.Slices)
            {
                if (slice.Sum < 0)
                {
                    twoSlicesAgo = lastSlice;
                    lastSlice = slice;
                    continue;
                }

                int sum;
                int length;

                if (twoSlicesAgo != null
                    && twoSlicesAgo.Sum >= 0
                    && slice.Sum >= 0
                    && lastSlice.MinIndex == lastSlice.MaxIndex)
                {
                    var maxValueNotInSlices = GetMaxValueNotInSlice(sliceResults.SlicesWithTopThreeMaxValues, slice, twoSlicesAgo);

                    sum = slice.Sum + twoSlicesAgo.Sum +
                        ((maxValueNotInSlices > 0) ? maxValueNotInSlices : 0);
                    length = slice.MaxIndex - twoSlicesAgo.MinIndex;
                }
                else
                {
                    sum = slice.Sum;
                    length = slice.MaxIndex - slice.MinIndex + 1;
                }

                if (sum == maxSwappedLength && length > maxSwappedLength)
                {
                    maxSwappedLength = length;
                }
                else if (sum > maxSwappedSum)
                {
                    maxSwappedLength = length;
                    maxSwappedSum = sum;
                }

                twoSlicesAgo = lastSlice;
                lastSlice = slice;
            }

            return maxSwappedSum;
        }

        private int GetMaxValueNotInSlice(List<Slice> list, Slice slice1, Slice slice2)
        {
            return list
                .Except(new[] { slice1, slice2 })
                .OrderByDescending(x => x.MaxValueInSlice)
                .First()
                .MaxValueInSlice;
        }

        public static SlicedArray CutIntoSlices(int[] A)
        {
            var slices = new List<Slice>();
            var nextSliceStart = 0;

            var slicesWithTopThreeValues = new List<Slice>();
            Slice minTopValueSlice = null;

            do
            {
                var slice = GetNextSlice(A, nextSliceStart);

                if (slicesWithTopThreeValues.Count < 3)
                {
                    slicesWithTopThreeValues.Add(slice);
                    minTopValueSlice = slicesWithTopThreeValues.OrderBy(x => x.MaxValueInSlice).First();
                }
                else if (minTopValueSlice.MaxValueInSlice < slice.MaxValueInSlice)
                {
                    slicesWithTopThreeValues.Remove(minTopValueSlice);
                    slicesWithTopThreeValues.Add(slice);
                    minTopValueSlice = slice;
                }

                slices.Add(slice);
                nextSliceStart = slice.MaxIndex + 1;
            } while (nextSliceStart < A.Length);

            return new SlicedArray()
                {
                    Slices = slices,
                    SlicesWithTopThreeMaxValues = slicesWithTopThreeValues
                };
        }

        public static Slice GetNextSlice(int[] A, int nextSliceStart)
        {
            var currentSum = 0;
            var currentIndex = nextSliceStart;
            var maxSliceSum = 0;
            var maxSliceSumIndex = nextSliceStart;
            var maxValueInSlice = A[nextSliceStart];

            do
            {
                if (maxValueInSlice < A[currentIndex])
                {
                    maxValueInSlice = A[currentIndex];
                }

                currentSum += A[currentIndex];

                if (currentSum >= maxSliceSum)
                {
                    maxSliceSum = currentSum;
                    maxSliceSumIndex = currentIndex;
                }

                currentIndex++;

            } while (currentSum >= 0 && currentIndex < A.Length);

            if (currentSum == maxSliceSum)
                return new Slice()
                {
                    MinIndex = nextSliceStart,
                    MaxIndex = currentIndex - 1,
                    SliceLength = currentIndex - nextSliceStart,
                    Sum = maxSliceSum,
                    MaxValueInSlice = maxValueInSlice,
                    //MaxValueIndexInSlice = maxValueIndexInSlice
                };
            else
                return new Slice()
                {
                    MinIndex = nextSliceStart,
                    MaxIndex = maxSliceSumIndex,
                    SliceLength = maxSliceSumIndex - nextSliceStart + 1,
                    Sum = (nextSliceStart == maxSliceSumIndex) ? currentSum : maxSliceSum,
                    MaxValueInSlice = maxValueInSlice,
                    //MaxValueIndexInSlice = maxValueIndexInSlice
                };
        }

        public class Slice
        {
            public int MinIndex { get; set; }
            public int MaxIndex { get; set; }
            public int SliceLength { get; set; }
            public int Sum { get; set; }
            public int MaxValueInSlice { get; set; }
            //public int MaxValueIndexInSlice { get; set; }
        }

        public class SlicedArray
        {
            public List<Slice> Slices { get; set; }
            public List<Slice> SlicesWithTopThreeMaxValues { get; set; }
        }

    }




}
