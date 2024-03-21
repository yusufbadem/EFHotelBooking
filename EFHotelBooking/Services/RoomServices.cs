using EFHotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHotelBooking.Services;
public class RoomServices
{
    public Room AddRoom(Room room)
    {
        EFAcademyHotelContext context = new EFAcademyHotelContext();
        context.Rooms.Add(room);
        context.SaveChanges();
        
        return room;
    }

    public List<Room> GetAllRooms()
    {
        EFAcademyHotelContext context=new EFAcademyHotelContext();
        //List<Room> rooms = context.Rooms.ToList(); burada tüm listeyi getiryoruz
        List<Room> rooms = context.Rooms.Where(x=>x.IsDeleted==false).ToList();

        return rooms;
    }

    public void DeleteRoom(int id)
    {
        EFAcademyHotelContext context = new EFAcademyHotelContext();
        //once silinecek oda bulunur
        //Room room=context.Rooms.Find(id);

        Room room=context.Rooms.FirstOrDefault(x=>x.Id==id);

        //context.Rooms.Remove(room);
        room.IsDeleted = true; // aslında burda update işlemi yapıyıoruz
        context.SaveChanges();
    }

    public List<Room> GetRoomsByPricesRate(decimal minPrice,decimal MaxPrice)
    {
        EFAcademyHotelContext context = new EFAcademyHotelContext();

        List<Room> rooms=context.Rooms.Where(x=>x.Price >= minPrice && x.Price <=MaxPrice).ToList();
       
        return rooms;
    }

     public List<Room> GetRoomsByStatus(bool status)
    {
        EFAcademyHotelContext context = new EFAcademyHotelContext();

        List<Room> rooms=context.Rooms.Where(x=>x.IsAvailable==status && x.IsDeleted==false).ToList();

        return rooms;
    }
}
