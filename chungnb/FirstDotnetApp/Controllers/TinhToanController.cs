using Microsoft.AspNetCore.Mvc;
using TinhToan.Models;
using TinhToan.Helpers;

namespace TinhToan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TinhToanController: ControllerBase
    {
        // 210: Tính tổng các giá trị có chữ số đầu tiên là chữ số chẵn
        [HttpPost("tong-dau-chan")]
        public ActionResult<string> TinhTongDauChan([FromBody] NumberArrayRequest request)
        {
            if (request.Numbers == null || request.Numbers.Length == 0)
            {
                return BadRequest("Mảng không được để trống.");
            }

            int tong = 0;
            foreach (var number in request.Numbers)
            {
                int firstDigit = TinhToanHelpers.LayChuSoDauTien(Math.Abs(number));
                if (firstDigit % 2 == 0)
                {
                    tong += number;
                }
            }

            string result = $"Tổng các giá trị có chữ số đầu tiên là chẵn: {tong}";
            return Ok(result);
        }

        // 211: Tính trung bình cộng các số nguyên tố trong mảng
        [HttpPost("trung-binh-nguyen-to")]
        public ActionResult<string> TinhTrungBinhNguyenTo([FromBody] NumberArrayRequest request)
        {
            if (request.Numbers == null || request.Numbers.Length == 0)
            {
                return BadRequest("Mảng không được để trống.");
            }

            var primes = request.Numbers.Where(TinhToanHelpers.IsPrime).ToArray();
            if (primes.Length == 0)
            {
                return Ok(0);
            }

            double tbNguyenTo = primes.Average();
            string result = $"Trung bình các số nguyên tố là: {tbNguyenTo}";
            return Ok(result);
        }

        // 212: Tính trung bình cộng các số dương
        [HttpPost("trung-binh-cong-cac-so-duong")]
        public ActionResult<string> TinhTrungBinhCong([FromBody] NumberArrayRequest request)
        {
            if (request.Numbers == null || request.Numbers.Length == 0)
            {
                return BadRequest("Mảng không được để trống.");
            }

            var duong = request.Numbers.Where(n => n > 0).ToArray();
            if (duong.Length == 0)
            {
                return Ok(0);
            }

            double tbcDuong = duong.Average();
            string result = $"Trung bình cộng các số dương: {tbcDuong}";
            return Ok(result);
        }

        // 213: Tính trung bình cộng các giá trị lớn hơn giá trị x
        [HttpPost("trung-binh-cong-lon-hon-x")]
        public ActionResult<string> TinhTrungBinhLonHonX([FromBody] NumberArrayWithXRequest request)
        {
            if (request.Numbers == null || request.Numbers.Length == 0)
            {
                return BadRequest("Mảng không được để trống.");
            }

            var lonHonX = request.Numbers.Where(n => n > request.X).ToArray();
            if (lonHonX.Length == 0)
            {
                return Ok(0);
            }

            double tbcLonHonX = lonHonX.Average();
            string result = $"Trung bình cộng các giá trị lớn hơn {request.X}: {tbcLonHonX}";
            return Ok(result);
        }

        // 214: Tính trung bình nhân các giá trị dương
        [HttpPost("trung-binh-nhan-cac-so-duong")]
        public ActionResult<double> TinhTrungBinhNhan([FromBody] NumberArrayRequest request)
        {
            if (request.Numbers == null || request.Numbers.Length == 0)
            {
                return BadRequest("Mảng không được để trống.");
            }

            var duong = request.Numbers.Where(n => n > 0).ToArray();
            if (duong.Length == 0)
            {
                return Ok("Trung bình nhân các số dương: 0");
            }

            double product = duong.Aggregate(1.0, (acc, n) => acc * n);
            double trungBinhNhan = Math.Pow(product, 1.0 / duong.Length);
            string result = $"Trung bình nhân các số dương: {trungBinhNhan}";
            return Ok(result);
        }
    }
}
