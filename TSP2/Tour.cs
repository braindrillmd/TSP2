using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP2
{
    public class Tour
    {
        private int[] tourIndexes;
        ThreadSafeRandom random;
        private int verticesNumber;
        public int VerticesNumber
        {
            get
            {
                return verticesNumber;
            }
        }

        /*public bool ContainsUnwantedCycle()
        {
            for (int i = 0; i < verticesNumber; i++)
            {
                int currentIndex = i;
                int verticesPassed = 0;
                for(int j = 0; i < verticesNumber; j++)
                {
                    if (currentIndex != -1)
                    {
                        currentIndex = tourIndexes[currentIndex];
                        verticesPassed++;
                    }
                    else
                    {
                        break;
                    }

                    if(verticesPassed != verticesNumber && currentIndex != -1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }*/

        public Tour(int verticesNumber)
        {
            this.verticesNumber = verticesNumber;
            tourIndexes = new int[verticesNumber];
            random = new ThreadSafeRandom();
        }

        public void CopyTour(Tour that)
        {
            for (int i = 0; i < verticesNumber; i++)
            {
                this.tourIndexes[i] = that.IndexAt(i);
            }
        }

        public Tour CrossingOver(Tour that)
        {
            Tour child = new Tour(verticesNumber);
            bool[] verticeIsUsed = new bool[verticesNumber];

            for(int i = 0; i < verticesNumber; i++)
            {
                child.tourIndexes[i] = -1;
                verticeIsUsed[i] = false;
            }

            int currentIndex = 0;
            for (int i = 0; i < verticesNumber; i++)
            {
                Tour parent1;
                Tour parent2;
                
                if (i % 2 == 0)
                {
                    parent1 = this;
                    parent2 = that;
                }
                else
                {
                    parent1 = that;
                    parent2 = this;
                }

                int linkFromParent1 = parent1.IndexAt(currentIndex);
                int linkFromParent2 = parent2.IndexAt(currentIndex);
                if (!verticeIsUsed[linkFromParent1] && child.tourIndexes[linkFromParent1] == -1 && linkFromParent1 != 0)
                {
                    verticeIsUsed[linkFromParent1] = true;
                    child.tourIndexes[currentIndex] = linkFromParent1;
                    currentIndex = linkFromParent1;
                }
                else
                {
                    if(!verticeIsUsed[linkFromParent2] && child.tourIndexes[linkFromParent2] == -1 && linkFromParent2 != 0)
                    {
                        verticeIsUsed[linkFromParent2] = true;
                        child.tourIndexes[currentIndex] = linkFromParent2;
                        currentIndex = linkFromParent2;
                    }
                    else
                    {
                        for(int j = 1; j < verticesNumber; j++)
                        {
                            if(!verticeIsUsed[j] && child.tourIndexes[j] == -1)
                            {
                                verticeIsUsed[j] = true;
                                child.tourIndexes[currentIndex] = j;
                                currentIndex = j;
                            }
                        }
                    }
                }
            }

            child.tourIndexes[currentIndex] = 0;

            return child;
        }

        public void FillRandomData()
        {
            bool[] verticeIsUsed = new bool[VerticesNumber];
            for (int i = 0; i < verticesNumber; i++)
            {
                verticeIsUsed[i] = false;
                tourIndexes[i] = -1;
            }

            int currentVertice = 0;
            int index = random.Next(verticesNumber);
            for (int i = 0; i < verticesNumber - 1; i++)
            {
                while (index == 0 || verticeIsUsed[index] || tourIndexes[index] != -1)
                {
                    index = random.Next(verticesNumber);
                }

                tourIndexes[currentVertice] = index;
                verticeIsUsed[index] = true;
                currentVertice = index;
            }

            for (int i = 0; i < verticesNumber; i++)
            {
                if (tourIndexes[i] == -1)
                {
                    tourIndexes[i] = 0;
                    break;
                }
            }
        }

        public int IndexAt(int index)
        {
            return tourIndexes[index];
        }

        public void Mutate()
        {
            int indexMutated = random.Next(verticesNumber);
            indexMutated = random.Next(verticesNumber);


            int indexBeforeMutated = -1;
            for (int i = 0; i < verticesNumber; i++)
            {
                if (tourIndexes[i] == indexMutated)
                {
                    indexBeforeMutated = i;
                }
            }

            int indexOfInsertion = random.Next(verticesNumber);
            while (indexOfInsertion == indexMutated || tourIndexes[indexOfInsertion] == indexMutated)
            {
                indexOfInsertion = random.Next(verticesNumber);
            }
            int indexAfterInsertion = tourIndexes[indexOfInsertion];

            tourIndexes[indexBeforeMutated] = tourIndexes[indexMutated];
            tourIndexes[indexMutated] = indexAfterInsertion;
            tourIndexes[indexOfInsertion] = indexMutated;
        }

        
        public void ShowMessage()
        {
            string message = "{";

            for(int i = 0; i < verticesNumber; i++)
            {
                message += "(" + i.ToString() + ", " + tourIndexes[i].ToString() + ")";
                if (i != verticesNumber - 1)
                {
                    message += ", ";
                }
            }

            message += "}";

            MessageBox.Show(message);
        }
    }
}
