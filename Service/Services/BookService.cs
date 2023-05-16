using Service.Dtos;
using Service.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BookService : IBookService
    {
        private const string image = "https://images.squarespace-cdn.com/content/5b80290bee1759a50e3a86b3/1655234687083-VUGUOH34O8P0069XAIF2/flatback-underwater-doug-perrine.jpg?format=1500w&content-type=image%2Fjpeg";

        public BookService()
        {
            
        }

        public async Task<BookDetailsDto> Get(int id)
        {
            return new BookDetailsDto() {
                Id = id,
                Title = "Doroftei",
                Price = 6969,
                Image = image,
                Description = "Lily si Doroftei si-au gasit, in cele din urma, echilibrul in viata si impart, in mod civilizat, custodia asupra fiicei lor, Emerson.\r\n\r\nAcum, la doi ani dupa ultima lor discutie, Lily il intalneste pe Atlas din intamplare. El e in culmea fericirii pentru ca, in sfarsit, pare sa fie momentul potrivit ca sentimentele dintre ei sa infloreasca intr-o relatie adevarata. Prin urmare, Atlas o invita pe Lily la o intalnire. Insa bucuria pe care o simte Lily se transforma in neliniste si groaza.\r\n\r\nDesi Doroftei nu-i mai este sot, el inca face parte din viata ei si ar avea resentimente fata de orice barbat cu care ea ar alege sa se intalneasca. Pur si simplu detesta gandul ca Atlas Corrigan ar putea face parte din viata lui Lily si a lui Emerson.\r\n\r\nScris din perspectiva lui Lily si a lui Atlas, romanul Totul incepe cu noi le ofera cititorilor o incursiune in trecutul lui Atlas, pe masura ce el si Lily isi redescopera legatura si reaprind\r\nflacara dragostei din adolescenta. In acelasi timp, sunt nevoiti sa aiba de-a face cu fostul sot al lui Lily. Doroftei, un barbat impulsiv, crede ca Atlas e unul dintre motivele destramarii\r\ncasniciei sale.\r\n\r\nRomanele semnate de Colleen Hoover domina topurile mondiale, cartile ei vanzandu-se in milioane de exemplare.\r\n\r\nCincisprezece titluri se afla momentan in topul USA Today bestseller list, fapt neegalat de niciun alt autor.",
                Author = "El Ludovicus Maximum Briliantus",
                Publisher = "Aura"
            };
        }

        public async Task<List<BookDto>> GetAll()
        {
            var idCt = 0;
            var rdm = new Random();
            

            var books = new List<BookDto>() {};

            for(int i = 0; i<40; i++)
            {
                books.Add(new BookDto() { Id = idCt++, Title = $"Doroftei partea {idCt}", Price = rdm.Next() % 1723489, Image = image, Recommended = false });
            }

            return books;
        }

        public async Task<List<BookDto>> GetRange(List<int> ids)
        {
            var books = new List<BookDto>();

            foreach (var id in ids)
            {
                books.Add(new BookDto() { Id = id, Price = 555, Title = $"Doroftei pt {id}", Image = image });
            }

            return books;
        }
    }
}
