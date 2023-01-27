using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using m = Booking.Model;

namespace Booking.Controller
{
    public class Resort
    {
        public List<m.Resort> GetResorts()
        {
            List<m.Resort> resortsList = new List<m.Resort>();

            resortsList.Add(new m.Resort
            {
                Id = 1,
                Name = "Riu Guanacaste",
                Description = "Este hotel totalmente preparado para dar el mejor servicio a sus clientes dispone de piscina de agua dulce y terraza-solárium. En el Riu Resort encontrarás también jacuzzi, gimnasio, baño de vapor y un centro de wellness con diferentes tratamientos y masajes. Todo lo que necesitas para conseguir el máximo bienestar durante tu estancia.",
                Photo = "../Images/1.jpg",
                Price = 140
            });

            resortsList.Add(new m.Resort
            {
                Id = 2,
                Name = "Occidental Papagayo",
                Description = "El Golfo del Papagayo ha sido considerado desde principios de siglo la joya del Pacífico, y este resort ha sabido mimetizarse con el exuberante entorno natural. Por eso, los huéspedes pueden disfrutar a la vez de la comodidad del programa todo incluido y de la exótica fauna que habita en las inmediaciones.",
                Photo = "../Images/2.jpg",
                Price = 190
            });

            resortsList.Add(new m.Resort
            {
                Id = 3,
                Name = "Baldi San Carlos",
                Description = "El Golfo del Papagayo ha sido considerado desde principios de siglo la joya del Pacífico, y este resort ha sabido mimetizarse con el exuberante entorno natural. Por eso, los huéspedes pueden disfrutar a la vez de la comodidad del programa todo incluido y de la exótica fauna que habita en las inmediaciones.",
                Photo = "../Images/2.jpg",
                Price = 160
            });

            return resortsList;
        }
    }
}