using TelephoneDirectory.Data.Models;

namespace TelephoneDirectory.Data
{
    public class DbObjects
    {
        static List<City> cities = new List<City>()
        {
            new City() {CityName = "Almaty"},
            new City() {CityName = "Nur-Sultan"},
            new City() {CityName = "Shymkent"},
            new City() {CityName = "Karaganda"},
            new City() {CityName = "Aktobe"},
            new City() {CityName = "Taraz"},
            new City() {CityName = "Pavlodar"},
            new City() {CityName = "Ust-Kamenogorsk"},
            new City() {CityName = "Semey"},
            new City() {CityName = "Oral"},
            new City() {CityName = "Kostanay"},
            new City() {CityName = "Kyzylorda"},
            new City() {CityName = "Petropavl"},
            new City() {CityName = "Atyrau"},
            new City() {CityName = "Temirtau"},
        };

        public static void Initial(ApplicationDbContext context)
        {
            if(!context.People.Any())
            {
                context.People.AddRange(new List<Person>()
                {
                    new Person() { Phone = "+77252525252", Surname = "Senov", Initials = "S.S.", House = 13, Building = 2, Flat = 23, City = cities[1] },
                    new Person() { Phone = "+77212121212", Surname = "Abdirov", Initials = "A.A.", House = 15, Flat = 22, City = cities[1] },
                    new Person() { Phone = "+77222222211", Surname = "Zhumabekov", Initials = "Z.Z.", House = 15, Building = 1, Flat = 10, City = cities[0] },
                    new Person() { Phone = "+77222222222", Surname = "Zhumabekov", Initials = "A.Z.", House = 15, Building = 1, Flat = 10, City = cities[0] },
                    new Person() { Phone = "+77222222233", Surname = "Zhumabekov", Initials = "S.Z.", House = 15, Building = 1, Flat = 10, City = cities[0] },
                    new Person() { Phone = "+77222222244", Surname = "Zhumabekov", Initials = "Z.P.", House = 15, Building = 1, Flat = 10, City = cities[0] },
                    new Person() { Phone = "+77232323232", Surname = "Temirtayev", Initials = "T.T.", House = 67, Building = 4, Flat = 10, City = cities[0] },
                    new Person() { Phone = "+77242424242", Surname = "Seitkhanov", Initials = "S.S.", House = 35, Building = 3, Flat = 10, City = cities[0] },
                    new Person() { Phone = "+77011111111", Surname = "Ismailov", Initials = "I.I.", House = 12, City = cities[1] },
                    new Person() { Phone = "+77022222222", Surname = "Sharipov", Initials = "S.L.", House = 2, City = cities[2] },
                    new Person() { Phone = "+77033333333", Surname = "Amirov", Initials = "A.A.", House = 3, City = cities[2] },
                    new Person() { Phone = "+77044444444", Surname = "Abdiev", Initials = "A.A.", House = 4, City = cities[2] },
                    new Person() { Phone = "+77055555555", Surname = "Mukhtarov", Initials = "M.M.", House = 5, City = cities[3] },
                    new Person() { Phone = "+77066666666", Surname = "Madegeriev", Initials = "M.M.", House = 6, City = cities[4] },
                    new Person() { Phone = "+77098989898", Surname = "Zhanserik", Initials = "Z.Z.", House = 50, City = cities[3] },
                    new Person() { Phone = "+77077777777", Surname = "Orazbayev", Initials = "O.O.", House = 58, Flat = 35, City = cities[4] },
                    new Person() { Phone = "+77088888888", Surname = "Akhmetov", Initials = "A.A.", House = 29, Building = 6, Flat = 23, City = cities[5] },
                    new Person() { Phone = "+77099999999", Surname = "Beisebekov", Initials = "B.P.", House = 83, Building = 2, Flat = 45, City = cities[6] },
                    new Person() { Phone = "+77101010101", Surname = "Kuanyshev", Initials = "I.K.", House = 24, Building = 3, Flat = 23, City = cities[7] },
                    new Person() { Phone = "+77111111111", Surname = "Otegenov", Initials = "O.O.", House = 13, Building = 1, Flat = 62, City = cities[8] },
                    new Person() { Phone = "+77121212121", Surname = "Nurdaulet", Initials = "N.N.", House = 34, Flat = 45, City = cities[9] },
                    new Person() { Phone = "+77131313131", Surname = "Toleutaev", Initials = "T.T.", House = 13, Building = 3, Flat = 1, City = cities[10] },
                    new Person() { Phone = "+77141414141", Surname = "Kurmanbekov", Initials = "K.K.", House = 23, Building = 2, Flat = 10, City = cities[11] },
                    new Person() { Phone = "+77151515151", Surname = "Sultanov", Initials = "S.S.", House = 39, Building = 3, Flat = 6, City = cities[12] },
                    new Person() { Phone = "+77161616161", Surname = "Zhunisek", Initials = "Z.Z.", House = 2, Building = 6, Flat = 4, City = cities[13] },
                    new Person() { Phone = "+77171717171", Surname = "Maratov", Initials = "M.M.", House = 46, Flat = 12, City = cities[14] },
                    new Person() { Phone = "+77171717171", Surname = "Rakhmetov", Initials = "R.R.", House = 93, Building = 3, Flat = 14, City = cities[14] },
                    new Person() { Phone = "+77181818181", Surname = "Alibekov", Initials = "A.F.", House = 25, Building = 1, Flat = 24, City = cities[13] },
                    new Person() { Phone = "+77191919191", Surname = "Zholdasov", Initials = "I.P.", House = 73, Building = 3, Flat = 36, City = cities[12] },
                    new Person() { Phone = "+77303030303", Surname = "Akzhol", Initials = "P.O.", House = 43, Flat = 7, City = cities[11] },
                    new Person() { Phone = "+77292929292", Surname = "Dauletov", Initials = "D.K.", House = 24, Building = 2, Flat = 1, City = cities[10] },
                    new Person() { Phone = "+77282828282", Surname = "Bekbolov", Initials = "Y.H.", House = 13, Building = 2, Flat = 9, City = cities[9] },
                    new Person() { Phone = "+77272727272", Surname = "Ertayev", Initials = "E.U.", House = 4, Building = 5, Flat = 34, City = cities[8] },
                    new Person() { Phone = "+77262626262", Surname = "Suleimenov", Initials = "I.L.", House = 3, Building = 5, Flat = 2, City = cities[7] },
                });

                if(!context.City.Any())
                {
                    context.City.AddRange(cities);
                }
            }

            context.SaveChanges();
        }
    }
}