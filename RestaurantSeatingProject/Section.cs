
namespace RestaurantSeatingProject
{
    public class Section
    {
        public int sectionNum { get; set; }
 
        public Section()
        {
            
        }

        public Section(string SectionNum, string tableNum)
        {
            this.sectionNum = SectionNum;
        }

    }
}
