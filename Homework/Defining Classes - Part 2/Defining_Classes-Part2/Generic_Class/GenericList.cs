using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part2.Generic_Class
{
    public class GenericList <T> where T: IComparable
    {
        private int count;
        private int size;
        private T[] elementsContainer;
       public GenericList(int size)
        {
            this.Size = size;
            this.elementsContainer = new T[size];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Array size must be a positive value!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public T[] ElementsContainer
        {
            get
            {
                return this.elementsContainer;
            }
        }

        public T this[int index]
        {
            get
            {
                IndexValidation(index);

                T currentElement = elementsContainer[index];
                return currentElement;
            }
        }

        public void AddElement(T element)
        {
            CapacityValidation();

            this.elementsContainer[count] = element;
            count++;
        }

        public void RemoveElementAtIndex(int index)
        {
            IndexValidation(index);

            T[] temp = new T[elementsContainer.Length];
            this.elementsContainer.CopyTo(temp, 0);
            this.elementsContainer = new T[temp.Length - 1];
            for (int i = 0, j=0; i < temp.Length; i++, j++)
            {
                if (i == index)
                {
                    j--;
                    continue;
                }
                this.elementsContainer[j] = temp[i];
            }

            this.count--; 
        }

        public void InsertElementAtIndex(int index, T element)
        {
            IndexValidation(index);
            CapacityValidation();

            T[] temp = new T[this.elementsContainer.Length];
            this.elementsContainer.CopyTo(temp, 0);
            this.elementsContainer = new T[temp.Length + 1];
            bool inserted = false;
            for (int i = 0, j = 0; i < temp.Length; i++, j++)
            {
                if (i == index&&!inserted)
                {
                    this.elementsContainer[j] = element;
                    i--;
                    inserted = true;
                    continue;
                }
                this.elementsContainer[j] = temp[i];
            }

            this.count++;
        }

        public void Clear()
        {
            T[] temp = new T[this.elementsContainer.Length];
            this.elementsContainer = temp;

            this.count = 0;
        }

        public int FindElementByValue(T value)
        {
            int index = -1;
            for (int i = 0; i < this.elementsContainer.Length; i++)
            {
                if (this.elementsContainer[i].CompareTo(value) == 0)
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }

        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                result.Append(elementsContainer[i] + ", ");
            }
            return result.ToString().Trim(',',' ');
        }

        public void IndexValidation(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Trying to reach an element that does not exist");
            }
        }

        public void CapacityValidation()
        {
            if (this.count >= this.size)
            {
                this.Size *= 2;
                T[] temp = new T[size];
                this.elementsContainer.CopyTo(temp, 0);
                this.elementsContainer = temp;
            }
        }

        public T Min()
        {
            T minElement = this.elementsContainer[0];
            for (int i = 0; i < this.count; i++)
            {
                if (minElement.CompareTo(elementsContainer[i]) > 0)
                {
                    minElement = elementsContainer[i];
                }
            }
            return minElement;
        }

        public T Max()
        {
            T maxElement = this.elementsContainer[0];
            for (int i = 0; i < this.count; i++)
            {
                if (maxElement.CompareTo(elementsContainer[i]) < 0)
                {
                    maxElement = elementsContainer[i];
                }
            }
            return maxElement;
        }
    }
}
