using Microsoft.EntityFrameworkCore;
using RestourantDataAccess.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RestourantDataAccess
{
    public class RestourantDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Order { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"workstation id=Restourant.mssql.somee.com;packet size=4096;user id=Wiles_SQLLogin_1;pwd=9tdk5ikk9r;data source=Restourant.mssql.somee.com;persist security info=False;initial catalog=Restourant;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Create Fluent API
            modelBuilder.Entity<Client>().HasMany(c => c.Orders).WithOne(o => o.Client).HasForeignKey(o => o.ClientId);   
            modelBuilder.Entity<Category>().HasMany(c => c.Drinks).WithOne(d => d.Category).HasForeignKey(d => d.CategoryId);
            modelBuilder.Entity<Category>().HasMany(c => c.Foods).WithOne(f => f.Category).HasForeignKey(f => f.CategoryId);
            modelBuilder.Entity<Worker>().HasMany(c => c.Orders).WithOne(w => w.Worker).HasForeignKey(o => o.WorkerId);
            modelBuilder.Entity<Worker>().HasOne(w => w.Position).WithMany(p => p.Workers).HasForeignKey(w => w.PositionId);
            //Seeder
            modelBuilder.Entity<Client>().HasData(new Client[]
            {
                    new Client
                    {
                        Id = 1,
                    FirstName = "Іван",
                    LastName = "Шелухов",
                    PhoneNukmber="+380984145258",
                    Email = "ivanseluhov@gmail.com",
                    Address = "вул Чорновола, буд. 1, кв. 5",
                    Login = "ivan123",
                    Password = "password123"
                    }
        });
            modelBuilder.Entity<Position>().HasData(new Position[]
            {
                new Position
                {
                    Id=1,
                    Name="Кухар"
                },
                new Position
                {
                    Id=2,
                    Name="Кур'єр"
                },
                new Position
                {
                    Id=3,
                    Name="Офіціант"
                },
                new Position
                {
                    Id=4,
                    Name="Прибиральник"
                },
                new Position
                {
                    Id=5,
                    Name="Бармнен"
                },
            });
            modelBuilder.Entity<Worker>().HasData(new Worker[]
            {
                new Worker
            {
                    Id=1,
                AbillityToWork=true,
                FirstName = "Василь",
                LastName = "Сидоров",
                Salary = 12000,
                YearsOfWorking = 5,
                PositionId = 1
            },

            new Worker
            {
                Id=2,
                AbillityToWork=true,
                FirstName = "Олесь",
                LastName = "Снігур",
                Salary = 10000,
                YearsOfWorking = 1,
                PositionId=1
            },

            new Worker
            {
                Id=3,
                AbillityToWork=true,
                FirstName = "Марина",
                LastName = "Коновалець",
                Salary = 12000,
                YearsOfWorking = 10,
                PositionId=1
            },

            new Worker
            {
                Id=4,
                AbillityToWork = true,
                FirstName = "Олена",
                LastName = "Петренко",
                Salary = 6500,
                YearsOfWorking = 8,
                PositionId=2
            },

            new Worker
            {

                 Id =5,
                AbillityToWork=true,
                FirstName = "Юля",
                LastName = "Гончаренко",
                Salary = 6500,
                YearsOfWorking = 2,
                PositionId = 3
            },

            new Worker
            {

                Id=6,    
                AbillityToWork = true,
                FirstName = "Олександр",
                LastName = "Даванков",
                Salary = 6500,
                YearsOfWorking = 8,
                PositionId = 3
            },
            new Worker
            {
                Id = 7,
                AbillityToWork=true,
                FirstName = "Євген",
                LastName = "Півгеняо",
                Salary = 6500,
                YearsOfWorking = 3,
                PositionId = 5
            },
            new Worker
            {Id = 8,
                AbillityToWork=true,
                FirstName = "Галина",
                LastName = "Прокопівна",
                Salary = 6500,
                YearsOfWorking = 4,
                PositionId = 4
            },
            new Worker
            {Id = 9,
                AbillityToWork=true,
                FirstName = "Олег",
                LastName = "Ляшко",
                Salary = 6500,
                YearsOfWorking = 8,
                PositionId = 2
            }
        });
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
            new Category
            {
                Id=1,
                Name="Перша страва"
            },
            new Category
            {
                Id=2,
                Name="Піца"
            },
            new Category
            {
                Id=3,
                Name="Закуска"
            },
            new Category
            {
                Id=4,
                Name="Гарнір"
            },
            new Category
            {
                Id=5,
                Name="Десерт"
            },
            new Category
            {
                Id=6,
                Name="Напій"
            },
            new Category
            {
                Id=7,
                Name="Алкогольний напій"
            }
            });
            modelBuilder.Entity<Food>().HasData(new Food[]
            {
            new Food
            {
                Id=34,
                Name = "Борщ",
                Recipe = "з пампушками, цибуля синя, кріп, бочок, сметана",
                Mass = 400,
                Price = 80,
                CategoryId = 1
            },

            new Food
            {Id = 1,
                Name = "Недорамен",
                Recipe = "Якось в Одесі 5 програмістів плавуючі в морі захотіли їсти, зловили криветок з мідіями, взяли китайські гриби та лапшу, кинули в казан і ось так народилася ця страв",
                Mass = 400,
                Price = 80,
                CategoryId = 1
            },

            new Food
            {Id = 2,
                Name = "Солянка",
                Recipe = "Мисливські ковбаси, картопля, картопля, салямі, сосиски, морква, мариновані огірки, лимон",
                Mass = 400,
                Price = 80,
                CategoryId = 1
            },

            new Food
            {
                Id=3,
                Name = "Пельмені з бульйоном",
                Recipe = "(Відміно смакує з похміля)",
                Mass = 400,
                Price = 80,
                CategoryId = 1
            },

            new Food
            {
                Id=4,
                Name = "Нельсон",
                Recipe = "Бортик з молочною ковбаскою, вершковий соус, сир блакитний, моцарела, українська салямі, шинка, сушений ореган, рукола, карамелізована цибуля",
                Mass = 400,
                Price = 200,
                CategoryId = 2
            },

            new Food
            {
                Id = 5,
                Name = "Мисливська",
                Recipe = "Мисливські ковбаски, українська салямі, бочок копчений, помідор, моцарела, часник, соус із тертих томатів, рукола",
                Mass = 490,
                Price = 260,
                CategoryId = 2
            },

            new Food
            {
                Id = 6,
                Name = "Палерма",
                Recipe = "Баварські ковбаси, прошуто, українська сирокопчена пепероні, моцарела, свіжий базилік, соус із тертих томатів, маслини, сушений ореган",
                Mass = 490,
                Price = 200,
                CategoryId = 2
            },

            new Food
            {
                Id = 7,
                Name = "Чотири сири",
                Recipe = "Моцарела, чеддер, блакитний сир, пармезан, вершковий соус",
                Mass = 450,
                Price = 249,
                CategoryId = 2
            },

            new Food
            {
                Id = 8,
                Name = "Каракатиця",
                Recipe = "Чорне тісто на основі чорнила морської каракатиці, солений лосось, вершковий соус, оливки, моцарела, лимон, пармезан, італійські трави, свіжий базилік",
                Mass = 500,
                Price = 270,
                CategoryId = 2
            },

            new Food
            {
                Id = 9,
                Name = "Капрічоза",
                Recipe = "Мариновані печериці, помідори чері, оливки, шинка, пармезан, моцарела, соус із тертих томатів, сушений ореган, рукола",
                Mass = 400,
                Price = 190,
                CategoryId = 2
            },

            new Food
            {
                Id = 10,
                Name = "Мексика",
                Recipe = "Закарпатська сирокопчена пепероні, українська салямі, болгарський перець, маринований чілі переці, сушений каєнський перець, сушений чілі перець, зелена цибуля, моцарела, соус із тертих томатів, соус шрірача",
                Mass = 490,
                Price = 200,
                CategoryId = 2
            },

            new Food
            {
                Id = 11,
                Name = "Папероні",
                Recipe = "українське салямі, моцарела, соус з терттих томатів",
                Mass = 490,
                Price = 230,
                CategoryId = 2
            },

            new Food
            {
                Id = 12,
                Name = "Дошка 'Антипасто' ",
                Recipe = "Прошуто, грісіні фует, оливки, сир з голубою пліснявою, камамбер, листкові закуски, перець чілі та халапеньо, соус із вишень та вина",
                Mass = 660,
                Price = 520,
                CategoryId = 3
            },

            new Food
            {
                Id = 13,
                Name = "Дошка 'Вішайся'",
                Recipe = "маринований у спеціях бочок, сало перекручене з часником, файне сало на мотузках, моцний хрін, асорті пивних грінок, пікантний корнішон",
                Mass = 410,
                Price = 210,
                CategoryId = 3
            },

            new Food
            {
                Id = 14,
                Name = "Дошка 'Чисто по-людськи'",
                Recipe = "мікс в'яленого м'яса, курячі чіпси, смажені чіпси з лаваша, сухарі з бородинського хліба з часником, мікс горіхів та соуси",
                Mass = 550,
                Price = 390,
                CategoryId = 3
            },

            new Food
            {
                Id = 15,
                Name = "В'ялене м'ясо 'Made in Garage'",
                Recipe = "Телятина/Свинина/Курка",
                Mass = 250,
                Price = 225,
                CategoryId = 3
            },

            new Food
            {
                Id = 16,
                Name = "Курячі нагетси",
                Recipe = "з сойсом на рибі",
                Mass = 200,
                Price = 105,
                CategoryId = 3
            },

            new Food
            {
                Id = 17,
                Name = "Цибулеві кільці з соусом",
                Recipe = "'Вставте текст'",
                Mass = 100,
                Price = 87,
                CategoryId = 3
            },

            new Food
            {
                Id = 18,
                Name = "Сир фрі",
                Recipe = "просто сир",
                Mass = 180,
                Price = 95,
                CategoryId = 3
            },

            new Food
            {
                Id = 19,
                Name = "Свинні копчені вушка",
                Recipe = "з цибулею",
                Mass = 80,
                Price = 57,
                CategoryId = 3
            },

            new Food
            {
                Id = 20,
                Name = "Чіпси начос",
                Recipe = "Сир чеддер, ковбаси, саслини, соус гуакамоле",
                Mass = 250,
                Price = 155,
                CategoryId = 3
            },

            new Food
            {
                Id = 21,
                Name = "Чіпси `Garage`",
                Recipe = "+ соус на вибір",
                Mass = 50,
                Price = 47,
                CategoryId = 3
            },

            new Food
            {
                Id = 22,
                Name = "Сухарики 'Інь Янь'",
                Recipe = "Грінкі з білого хлібу, грінкі з бородиснького хлібу + соус на вибір",
                Mass = 100,
                Price = 47,
                CategoryId = 3
            },

            new Food
            {
                Id = 23,
                Name = "Молода картопля з копченими сосиками",
                Recipe = "Поливаємо сирним соусом з паприкою та укропом і карамелізованою цибулею",
                Mass = 400,
                Price = 115,
                CategoryId = 4
            },

            new Food
            {
                Id = 24,
                Name = "Картопля фрі",
                Recipe = "з соусом з тертих томатів",
                Mass = 130,
                Price = 50,
                CategoryId = 4
            },

            new Food
            {
                Id = 25,
                Name = "Картопля по домашньому",
                Recipe = "смажена на пательні в олії з часником та цибулею",
                Mass = 250,
                Price = 50,
                CategoryId=4
            },

            new Food
            {
                Id = 26,
                Name = "Печена картопля по селянськи",
                Recipe = "з бочком та маринованим домашнім огірком",
                Mass = 255,
                Price = 85,
                CategoryId = 4
            },

            new Food
            {
                Id = 27,
                Name = "Коктейль 'Рай солодкоїжки'",
                Recipe = "Бланкшеровні фрукти з мандариновим лікером, бельгійські вафлі, шоколад, вафельні труьочки з кремом",
                Mass = 250,
                Price = 120,
                CategoryId = 5
            },

            new Food
            {
                Id = 28,
                Name = "Маленька прикрість",
                Recipe = "шоколадний горщик, вершкове морозиво, печиво, какао, гранат, м'ята",
                Mass = 120,
                Price = 85,
                CategoryId = 5
            },

            new Food
            {
                Id = 29,
                Name = "Сирники",
                Recipe = "з сметаною або згущеним молоком",
                Mass = 150,
                Price = 77,
                CategoryId = 5
            },

            new Food
            {
                Id = 30,
                Name = "Вершки 'Garage'",
                Recipe = "шоколад, печиво, банан, топ",
                Mass = 150,
                Price = 60,
                CategoryId = 5
            },

            new Food
            {
                Id = 31,
                Name = "Морозиво Sundae",
                Recipe = "Три кульки різного морозива, ягоди харібо, орео, топінг",
                Mass = 180,
                Price = 97,
                CategoryId = 5
            },

            new Food
            {
                Id = 32,
                Name = "Морозиво `Garage`",
                Recipe = "Моризиво, вафлі, згущене молоко, арахіс",
                Mass = 150,
                Price = 67,
                CategoryId = 5
            },

            new Food
            {
                Id =33,
                Name = "Морозиво з лісовими ягодами",
                Recipe = "Вершки, лісові ягоди:малина, чорниця, ожині, полуничний топінг, тертий шоколад",
                Mass = 180,
                Price = 97,
                CategoryId = 5
            }
            });
            modelBuilder.Entity<Drink>().HasData(new Drink[]
            {
                new Drink
                {
                    Id =1,
                    Name = "Чай",
                    Liter = 0.3,
                    Price = 20,
                    CategoryId = 6
                },

            new Drink
            {
                Id = 2,
                Name = "Кава",
                Liter = 0.25,
                Price = 30,
                CategoryId = 6
            },

            new Drink
            {
                Id = 3,
                Name = "Пепсі",
                Liter = 0.5,
                Price = 30,
                CategoryId = 6
            },

            new Drink
            {
                Id = 4,          
                Name = "Сік Sandora Яблуко виноград/Банан/Апельсин/Томатний",
                Liter = 1,
                Price = 68,
                CategoryId = 6
            },

            new Drink
            {
                Id = 5,
                Name = "Мінеральна вода Buvete 7",
                Liter = 1,
                Price = 40,
                CategoryId = 6
            },

            new Drink
            {
                Id = 6,
                Name = "Водка Pervak",
                Liter = 1,
                Price = 265,
                CategoryId = 7
            },

            new Drink
            {
                Id = 7,
                Name = "Віскі Jack Daniels ",
                Liter = 0.5,
                Price = 850,
                CategoryId = 7
            },

            new Drink
            {
                Id = 8,
                Name = "Кава з коньяком Aznauri",
                Liter = 0.25,
                Price = 55,
                CategoryId = 7
            },

            new Drink
            {
                Id = 9,
                Name = "Пиво Львівське світле",
                Liter = 0.5,
                Price = 60,
                CategoryId = 7
            },

            new Drink
            {
                Id = 10,
                Name = "Пиво Льввівське темне",
                Liter = 0.5,
                Price = 60,
                CategoryId = 7
            }
            });
        }
    }
}
