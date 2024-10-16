using System.Threading.Tasks;

namespace HW_9._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyException.MyEx();
            Console.WriteLine();


            ListSort sortLastNames = new ListSort();
            sortLastNames.SortEvent += ShowList.Show;
            try
            {
                sortLastNames.ReadSortType();
            }
            catch (NewException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
