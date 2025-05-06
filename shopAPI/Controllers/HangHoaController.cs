using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using shopAPI.Models;

namespace shopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<HangHoa> hh = new List<HangHoa>();



[HttpGet]
        public IActionResult GetAll()
        {
            hh.Add(new HangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHH = "Bút bi Thiên Long",
                DonGia = "5000"
            });

            hh.Add(new HangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHH = "Vở 200 trang",
                DonGia = "12000"
            });

            hh.Add(new HangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHH = "Thước kẻ 30cm",
                DonGia = "7500"
            });
            return Ok(hh);
        }
        [HttpPost]
        public IActionResult Create(HangHoaM hh2)
        {
            var hanghoa = new HangHoa {
                MaHangHoa = Guid.NewGuid(),
                TenHH = hh2.TenHH,
                DonGia = hh2.DonGia,

            };
            hh.Add(hanghoa);
            return Ok(new
            {
                Success = true,
                Data = hh
            });
        }
        [HttpPut("{id}")]
        public IActionResult delete(String id)
        {
            try
            {
                var hanghoa = hh.SingleOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hanghoa == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(hanghoa);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
