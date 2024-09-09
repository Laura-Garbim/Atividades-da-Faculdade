using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Informações dos países.
        var countryInfo = new Dictionary<string, CountryInfo>
        {
            {"Brasil", new CountryInfo("Brasília", "América do Sul", new List<string> {"Argentina", "Bolívia", "Colômbia", "Guiana", "Paraguai", "Peru", "Suriname", "Uruguai", "Venezuela"}, "Português", "Oceano Atlântico")},
           
            {"Estados Unidos", new CountryInfo("Washington, D.C.", "América do Norte", new List<string> {"Canadá", "México"}, "Inglês", "Oceano Atlântico e Oceano Pacífico")},
            
            {"França", new CountryInfo("Paris", "Europa", new List<string> {"Bélgica", "Luxemburgo", "Alemanha", "Suíça", "Itália", "Espanha"}, "Francês", "Oceano Atlântico e Mar Mediterrâneo")},
            
            {"Alemanha", new CountryInfo("Berlim", "Europa", new List<string> {"Dinamarca", "Polônia", "República Tcheca", "Áustria", "Suíça", "França", "Luxemburgo", "Bélgica", "Países Baixos"}, "Alemão", "Nenhum")},
            
            {"China", new CountryInfo("Pequim", "Ásia", new List<string> {"Rússia", "Mongólia", "Afeganistão", "Paquistão", "Índia", "Nepal", "Butão", "Birmania", "Laos", "Vietnã", "Hong Kong", "Macau"}, "Chinês", "Oceano Pacífico")},
            
            {"Japão", new CountryInfo("Tóquio", "Ásia", new List<string> {}, "Japonês", "Oceano Pacífico")},
            
            {"Argentina", new CountryInfo("Buenos Aires", "América do Sul", new List<string> {"Chile", "Bolívia", "Paraguai", "Brasil", "Uruguai"}, "Espanhol", "Oceano Atlântico")},
            
            {"Índia", new CountryInfo("Nova Délhi", "Ásia", new List<string> {"Paquistão", "China", "Nepal", "Butão", "Bangladesh", "Myanmar"}, "Hindi, Inglês", "Oceano Índico")},
            
            {"Canadá", new CountryInfo("Ottawa", "América do Norte", new List<string> {"Estados Unidos"}, "Inglês, Francês", "Oceano Atlântico e Oceano Pacífico")},
            
            {"México", new CountryInfo("Cidade do México", "América do Norte", new List<string> {"Estados Unidos", "Guatemala", "Belize"}, "Espanhol", "Oceano Pacífico e Oceano Atlântico")},
            
            {"Itália", new CountryInfo("Roma", "Europa", new List<string> {"França", "Suíça", "Áustria", "Eslovênia"}, "Italiano", "Mar Mediterrâneo")},
            
            {"Espanha", new CountryInfo("Madri", "Europa", new List<string> {"França", "Andorra", "Portugal"}, "Espanhol", "Oceano Atlântico e Mar Mediterrâneo")},
            
            {"Egito", new CountryInfo("Cairo", "África", new List<string> {"Líbia", "Sudão", "Palestina", "Israel"}, "Árabe", "Mar Mediterrâneo e Mar Vermelho")},
            
            {"Austrália", new CountryInfo("Canberra", "Oceania", new List<string> {}, "Inglês", "Oceano Pacífico e Oceano Índico")},
            
            {"Turquia", new CountryInfo("Ancara", "Ásia", new List<string> {"Grécia", "Bulgária", "Geórgia", "Armênia", "Azerbaijão", "Irã", "Iraque", "Síria"}, "Turco", "Mar Mediterrâneo, Mar Egeu e Mar Negro")},
            
            {"África do Sul", new CountryInfo("Pretória", "África", new List<string> {"Namíbia", "Botswana", "Zimbábue", "Moçambique", "Eswatini", "Lesoto"}, "Africâner, Inglês", "Oceano Atlântico e Oceano Índico")},
            
            {"Noruega", new CountryInfo("Oslo", "Europa", new List<string> {"Suécia", "Finlândia", "Rússia"}, "Norueguês", "Oceano Atlântico e Mar de Barents")},
            
            {"Suécia", new CountryInfo("Estocolmo", "Europa", new List<string> {"Noruega", "Finlândia"}, "Sueco", "Oceano Atlântico e Mar Báltico")}
        };

        // Solicita o país.
        Console.WriteLine("Digite o nome do país:");
        string countryName = Console.ReadLine();

        if (countryInfo.ContainsKey(countryName))
        {
            var info = countryInfo[countryName];
            Console.WriteLine($"Capital: {info.Capital}");
            Console.WriteLine($"Continente: {info.Continent}");
            Console.WriteLine($"Países que fazem fronteira: {string.Join(", ", info.Borders)}");
            Console.WriteLine($"Língua falada: {info.Language}");
            Console.WriteLine($"Oceano(s) que banha(m): {info.Ocean}");
        }
        else
        {
            Console.WriteLine("País não encontrado.");
        }
    }
}

class CountryInfo
{
    public string Capital { get; set; }
    public string Continent { get; set; }
    public List<string> Borders { get; set; }
    public string Language { get; set; }
    public string Ocean { get; set; }

    public CountryInfo(string capital, string continent, List<string> borders, string language, string ocean)
    {
        Capital = capital;
        Continent = continent;
        Borders = borders;
        Language = language;
        Ocean = ocean;
    }
}
