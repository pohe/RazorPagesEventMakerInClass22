using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Interfaces
{
    public interface IHotelRepository
    {
        
        List<Hotel> GetAllHotels();
        Hotel GetHotel(int id);

        void AddHotel(Hotel ho);

        void UpdateHotel();

    }
}
