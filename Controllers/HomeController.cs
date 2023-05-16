using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ValyutaController : ControllerBase
    {
        [HttpPost("create")]
        public double Create(double value, string from, string to)
        {
            if (from == "azn")
            {
                if (to == "usd")
                {
                    return value / 1.7;
                }
                else if (to == "eur")
                {
                    return value / 2;
                }
                else if (to == "rub")
                {
                    return value / 0.0213;
                }
            }
            else if (from == "usd")
            {
                if (to == "azn")
                {
                    return value * 1.7;
                }
                else if (to == "eur")
                {
                    return value * 0.9198;
                }
                else if (to == "rub")
                {
                    return value * 79.8844;
                }
            }
            else if (from == "eur")
            {
                if (to == "azn")
                {
                    return value * 2;
                }
                else if (to == "rub")
                {
                    return value * 86.8498;
                }
                else if (to == "usd")
                {
                    return value * 1.0882;
                }

            }
            else if (from == "rub")
            {
                if (to == "azn")
                {
                    return value * 0.0213;
                }
                else if (to == "usd")
                {
                    return value * 0.0125;
                }
                else if (to == "eur")
                {
                    return value * 0.0115;
                }

            }

            

            

            return value;
        }
    }
}