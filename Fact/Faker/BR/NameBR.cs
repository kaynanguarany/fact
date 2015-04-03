using Fact.Faker.Utils;

namespace Fact.Faker.BR
{
    public class NameBR
    {
        public static string Prefix => "Sr. Sra. Srta.".Rand();
        public static string FirstName => FIRST_NAMES.Rand();
        public static string LasttName => LAST_NAMES.Rand();
        public static string Name => string.Format("{0} {1}", FirstName, LasttName);
        public static string NameWithPrefix => string.Format("{0} {1} {2}", Prefix, FirstName, LasttName);


        private static string[] FIRST_NAMES = { "Alessandro", "Alessandra", "Alexandre", "Aline", "Antônio",
            "Breno", "Bruna", "Carlos", "Carla", "Célia", "Cecília", "César", "Danilo", "Dalila", "Deneval",
            "Eduardo", "Eduarda", "Esther", "Elísio", "Fábio", "Fabrício", "Fabrícia", "Félix", "Felícia",
            "Feliciano", "Frederico", "Fabiano", "Gustavo", "Guilherme", "Gúbio", "Heitor", "Hélio", "Hugo",
            "Isabel", "Isabela", "Ígor", "João", "Joana", "Júlio César", "Júlio", "Júlia", "Janaína", "Karla",
            "Kléber", "Lucas", "Lorena", "Lorraine", "Larissa", "Ladislau", "Marcos", "Meire", "Marcelo", "Marcela",
            "Margarida", "Mércia", "Márcia", "Marli", "Morgana", "Maria", "Norberto", "Natália", "Nataniel", "Núbia",
            "Ofélia", "Paulo", "Paula", "Pablo", "Pedro", "Raul", "Rafael", "Rafaela", "Ricardo", "Roberto", "Roberta",
            "Sílvia", "Sílvia", "Silas", "Suélen", "Sara", "Salvador", "Sirineu", "Talita", "Tertuliano", "Vicente",
            "Víctor", "Vitória", "Yango", "Yago", "Yuri", "Washington", "Warley" };


        private static string[] LAST_NAMES = { "Albuquerque", "Barros", "Batista", "Braga", "Brito", "Carvalho", "Cavalcante",
            "Costa", "Franco", "Gomes", "Macedo", "Martins", "Melo", "Moraes", "Moreira", "Nogueira", "Oliveira", "Pereira",
            "Pinheiro", "Reis", "Santos", "Saraiva", "Silva", "Souza", "Xavier" };
    }
}
