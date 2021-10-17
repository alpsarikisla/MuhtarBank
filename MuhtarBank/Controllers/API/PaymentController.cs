using MuhtarBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MuhtarBank.Controllers.API
{
    public class PaymentPostData
    {
        public string KartNumarasi { get; set; }
        public string SonKullanmaAy { get; set; }
        public string SonKullanmaYil { get; set; }
        public string CCV { get; set; }
        public decimal Bakiye { get; set; }

        #region Sanal Pos Kullanıcı Bilgileri
        public string KullaniciKodu { get; set; }
        public string KullaniciSifre { get; set; }

        #endregion

    }
    public class PaymentController : ApiController
    {
        MuhtarBank_DB db = new MuhtarBank_DB();
        // GET: api/Payment
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Payment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Payment
        public HttpResponseMessage Post(PaymentPostData value)
        {

            if (db.SanalPosMusterilers.Count(x => x.MusteriKodu == value.KullaniciKodu && x.MusteriSifre == value.KullaniciSifre) == 1)
            {
                if (db.Hesaplars.Count(x => x.KartNo == value.KartNumarasi && x.SonKullanmaAy == value.SonKullanmaAy && x.SonKullanmaYil == value.SonKullanmaYil && x.CCV == value.CCV) == 1)
                {
                    Hesap h = db.Hesaplars.FirstOrDefault(x => x.KartNo == value.KartNumarasi && x.SonKullanmaAy == value.SonKullanmaAy && x.SonKullanmaYil == value.SonKullanmaYil && x.CCV == value.CCV);
                    if (h.Bakiye >= value.Bakiye)
                    {
                        try
                        {
                            h.Bakiye = h.Bakiye - value.Bakiye;
                            db.SaveChanges();
                            return Request.CreateResponse(HttpStatusCode.OK);
                        }
                        catch
                        {
                            return Request.CreateResponse(HttpStatusCode.BadRequest);
                        }
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.PaymentRequired);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
        }

        // PUT: api/Payment/5
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpGet]
        // DELETE: api/Payment/5
        public void Delete(int id)
        {
        }

    }
}
