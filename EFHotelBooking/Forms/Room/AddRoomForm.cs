using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFHotelBooking.Models;
using EFHotelBooking.Services;

namespace EFHotelBooking.Forms.Room;
public partial class AddRoomForm : Form
{
    public AddRoomForm()
    {
        InitializeComponent();
    }

    private void AddRoomForm_Load(object sender, EventArgs e)
    {
        LoadData();

    }

    private void LoadData()
    {
        RoomServices roomServices = new RoomServices();
        List<EFHotelBooking.Models.Room> rooms = roomServices.GetAllRooms();
        dgvRooms.DataSource = rooms;
        lblTotal.Text = rooms.Count.ToString() + " Oda Listeleniyor";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            EFHotelBooking.Models.Room room = new EFHotelBooking.Models.Room();
            room.Name = txtName.Text.Trim();
            room.Description = txtDescription.Text.Trim();
            room.Price = Convert.ToDecimal(txtPrice.Text.Trim());
            room.Capacity = Convert.ToInt32(txtCapacity.Text.Trim());

            RoomServices roomServices = new RoomServices();
            roomServices.AddRoom(room);
            MessageBox.Show(room.Name + " " + "Room Added succesfully");
        }
        catch (Exception ex)
        {

            MessageBox.Show("oda eklerken bir hata oluştu");
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        int selectedId = Convert.ToInt32(dgvRooms.CurrentRow.Cells["id"].Value);

        RoomServices roomServices = new RoomServices();
        roomServices.DeleteRoom(selectedId);

        // roomServices.DeleteRoom(selectedCell);

        LoadData();
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
        decimal min = Convert.ToDecimal(txtMin.Text.Trim());
        decimal max = Convert.ToDecimal(txtMax.Text.Trim());

        RoomServices roomServices = new RoomServices();
        List<EFHotelBooking.Models.Room> rooms = roomServices.GetRoomsByPricesRate(min, max);

        dgvRooms.DataSource = rooms;
        lblTotal.Text = rooms.Count.ToString() + " Oda Listeleniyor ";
    }

    private void radioAll_CheckedChanged(object sender, EventArgs e)
    {
        LoadData();

    }

    private void radioAvailable_CheckedChanged(object sender, EventArgs e)
    {
        RoomServices roomServices = new RoomServices();
        List<EFHotelBooking.Models.Room> rooms = roomServices.GetRoomsByStatus(true);
        dgvRooms.DataSource=rooms;
        lblTotal.Text = rooms.Count.ToString() + " Oda Listeleniyor ";


    }

    private void radioNotAvailable_CheckedChanged(object sender, EventArgs e)
    {

        RoomServices roomServices = new RoomServices();
        List<EFHotelBooking.Models.Room> rooms = roomServices.GetRoomsByStatus(false);

        dgvRooms.DataSource = rooms;
        lblTotal.Text = rooms.Count.ToString() + " Oda Listeleniyor ";

    }
}
