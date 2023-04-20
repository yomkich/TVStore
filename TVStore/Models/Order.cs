﻿using Microsoft.EntityFrameworkCore.Infrastructure;

public class Order
{
    public int OrderId { get; set; }
    public string User { get; set; } // имя фамилия покупателя
    public string Address { get; set; } // адрес покупателя
    public string ContactPhone { get; set; } // контактный телефон покупателя

    public int PhoneId { get; set; } // ссылка на связанную модель Phone
    public TVStore.Models.TV TV { get; set; }
}