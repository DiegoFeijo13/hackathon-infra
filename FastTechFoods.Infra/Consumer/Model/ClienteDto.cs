﻿namespace Consumer.Model;

public class ClienteDto : BaseEntityDto
{
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
}
