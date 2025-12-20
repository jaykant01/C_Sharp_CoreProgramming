namespace ArLevel1;

public class Problem9
{
    public void TwoDArray()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int[,] matrix = new int[row, col];
        int[] array = new int[row * col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int index = 0;
        for(int i=0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }

        for(int i=0; i<array.Length; i++)
        {
            Console.Write(array[i]+" ");
        }
        
    }
}
