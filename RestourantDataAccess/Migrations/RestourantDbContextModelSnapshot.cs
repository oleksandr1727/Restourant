﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestourantDataAccess;

#nullable disable

namespace RestourantDataAccess.Migrations
{
    [DbContext(typeof(RestourantDbContext))]
    partial class RestourantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RestourantDataAccess.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Перша страва"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Піца"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Закуска"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Гарнір"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Десерт"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Напій"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Алкогольний напій"
                        });
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNukmber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "вул Чорновола, буд. 1, кв. 5",
                            Email = "ivanseluhov@gmail.com",
                            FirstName = "Іван",
                            LastName = "Шелухов",
                            Login = "ivan123",
                            Password = "password123",
                            PhoneNukmber = "+380984145258"
                        });
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Liter")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 6,
                            Liter = 0.29999999999999999,
                            Name = "Чай",
                            Price = 20m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 6,
                            Liter = 0.25,
                            Name = "Кава",
                            Price = 30m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 6,
                            Liter = 0.5,
                            Name = "Пепсі",
                            Price = 30m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 6,
                            Liter = 1.0,
                            Name = "Сік Sandora Яблуко виноград/Банан/Апельсин/Томатний",
                            Price = 68m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 6,
                            Liter = 1.0,
                            Name = "Мінеральна вода Buvete 7",
                            Price = 40m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 7,
                            Liter = 1.0,
                            Name = "Водка Pervak",
                            Price = 265m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            Liter = 0.5,
                            Name = "Віскі Jack Daniels ",
                            Price = 850m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 7,
                            Liter = 0.25,
                            Name = "Кава з коньяком Aznauri",
                            Price = 55m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 7,
                            Liter = 0.5,
                            Name = "Пиво Львівське світле",
                            Price = 60m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 7,
                            Liter = 0.5,
                            Name = "Пиво Льввівське темне",
                            Price = 60m
                        });
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Recipe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 34,
                            CategoryId = 1,
                            Mass = 400.0,
                            Name = "Борщ",
                            Price = 80m,
                            Recipe = "з пампушками, цибуля синя, кріп, бочок, сметана"
                        },
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Mass = 400.0,
                            Name = "Недорамен",
                            Price = 80m,
                            Recipe = "Якось в Одесі 5 програмістів плавуючі в морі захотіли їсти, зловили криветок з мідіями, взяли китайські гриби та лапшу, кинули в казан і ось так народилася ця страв"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Mass = 400.0,
                            Name = "Солянка",
                            Price = 80m,
                            Recipe = "Мисливські ковбаси, картопля, картопля, салямі, сосиски, морква, мариновані огірки, лимон"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Mass = 400.0,
                            Name = "Пельмені з бульйоном",
                            Price = 80m,
                            Recipe = "(Відміно смакує з похміля)"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Mass = 400.0,
                            Name = "Нельсон",
                            Price = 200m,
                            Recipe = "Бортик з молочною ковбаскою, вершковий соус, сир блакитний, моцарела, українська салямі, шинка, сушений ореган, рукола, карамелізована цибуля"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Mass = 490.0,
                            Name = "Мисливська",
                            Price = 260m,
                            Recipe = "Мисливські ковбаски, українська салямі, бочок копчений, помідор, моцарела, часник, соус із тертих томатів, рукола"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Mass = 490.0,
                            Name = "Палерма",
                            Price = 200m,
                            Recipe = "Баварські ковбаси, прошуто, українська сирокопчена пепероні, моцарела, свіжий базилік, соус із тертих томатів, маслини, сушений ореган"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Mass = 450.0,
                            Name = "Чотири сири",
                            Price = 249m,
                            Recipe = "Моцарела, чеддер, блакитний сир, пармезан, вершковий соус"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Mass = 500.0,
                            Name = "Каракатиця",
                            Price = 270m,
                            Recipe = "Чорне тісто на основі чорнила морської каракатиці, солений лосось, вершковий соус, оливки, моцарела, лимон, пармезан, італійські трави, свіжий базилік"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Mass = 400.0,
                            Name = "Капрічоза",
                            Price = 190m,
                            Recipe = "Мариновані печериці, помідори чері, оливки, шинка, пармезан, моцарела, соус із тертих томатів, сушений ореган, рукола"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Mass = 490.0,
                            Name = "Мексика",
                            Price = 200m,
                            Recipe = "Закарпатська сирокопчена пепероні, українська салямі, болгарський перець, маринований чілі переці, сушений каєнський перець, сушений чілі перець, зелена цибуля, моцарела, соус із тертих томатів, соус шрірача"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Mass = 490.0,
                            Name = "Папероні",
                            Price = 230m,
                            Recipe = "українське салямі, моцарела, соус з терттих томатів"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Mass = 660.0,
                            Name = "Дошка 'Антипасто' ",
                            Price = 520m,
                            Recipe = "Прошуто, грісіні фует, оливки, сир з голубою пліснявою, камамбер, листкові закуски, перець чілі та халапеньо, соус із вишень та вина"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Mass = 410.0,
                            Name = "Дошка 'Вішайся'",
                            Price = 210m,
                            Recipe = "маринований у спеціях бочок, сало перекручене з часником, файне сало на мотузках, моцний хрін, асорті пивних грінок, пікантний корнішон"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Mass = 550.0,
                            Name = "Дошка 'Чисто по-людськи'",
                            Price = 390m,
                            Recipe = "мікс в'яленого м'яса, курячі чіпси, смажені чіпси з лаваша, сухарі з бородинського хліба з часником, мікс горіхів та соуси"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Mass = 250.0,
                            Name = "В'ялене м'ясо 'Made in Garage'",
                            Price = 225m,
                            Recipe = "Телятина/Свинина/Курка"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Mass = 200.0,
                            Name = "Курячі нагетси",
                            Price = 105m,
                            Recipe = "з сойсом на рибі"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Mass = 100.0,
                            Name = "Цибулеві кільці з соусом",
                            Price = 87m,
                            Recipe = "'Вставте текст'"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Mass = 180.0,
                            Name = "Сир фрі",
                            Price = 95m,
                            Recipe = "просто сир"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            Mass = 80.0,
                            Name = "Свинні копчені вушка",
                            Price = 57m,
                            Recipe = "з цибулею"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Mass = 250.0,
                            Name = "Чіпси начос",
                            Price = 155m,
                            Recipe = "Сир чеддер, ковбаси, саслини, соус гуакамоле"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            Mass = 50.0,
                            Name = "Чіпси `Garage`",
                            Price = 47m,
                            Recipe = "+ соус на вибір"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 3,
                            Mass = 100.0,
                            Name = "Сухарики 'Інь Янь'",
                            Price = 47m,
                            Recipe = "Грінкі з білого хлібу, грінкі з бородиснького хлібу + соус на вибір"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Mass = 400.0,
                            Name = "Молода картопля з копченими сосиками",
                            Price = 115m,
                            Recipe = "Поливаємо сирним соусом з паприкою та укропом і карамелізованою цибулею"
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 4,
                            Mass = 130.0,
                            Name = "Картопля фрі",
                            Price = 50m,
                            Recipe = "з соусом з тертих томатів"
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 4,
                            Mass = 250.0,
                            Name = "Картопля по домашньому",
                            Price = 50m,
                            Recipe = "смажена на пательні в олії з часником та цибулею"
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 4,
                            Mass = 255.0,
                            Name = "Печена картопля по селянськи",
                            Price = 85m,
                            Recipe = "з бочком та маринованим домашнім огірком"
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 5,
                            Mass = 250.0,
                            Name = "Коктейль 'Рай солодкоїжки'",
                            Price = 120m,
                            Recipe = "Бланкшеровні фрукти з мандариновим лікером, бельгійські вафлі, шоколад, вафельні труьочки з кремом"
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 5,
                            Mass = 120.0,
                            Name = "Маленька прикрість",
                            Price = 85m,
                            Recipe = "шоколадний горщик, вершкове морозиво, печиво, какао, гранат, м'ята"
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 5,
                            Mass = 150.0,
                            Name = "Сирники",
                            Price = 77m,
                            Recipe = "з сметаною або згущеним молоком"
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 5,
                            Mass = 150.0,
                            Name = "Вершки 'Garage'",
                            Price = 60m,
                            Recipe = "шоколад, печиво, банан, топ"
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 5,
                            Mass = 180.0,
                            Name = "Морозиво Sundae",
                            Price = 97m,
                            Recipe = "Три кульки різного морозива, ягоди харібо, орео, топінг"
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 5,
                            Mass = 150.0,
                            Name = "Морозиво `Garage`",
                            Price = 67m,
                            Recipe = "Моризиво, вафлі, згущене молоко, арахіс"
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 5,
                            Mass = 180.0,
                            Name = "Морозиво з лісовими ягодами",
                            Price = 97m,
                            Recipe = "Вершки, лісові ягоди:малина, чорниця, ожині, полуничний топінг, тертий шоколад"
                        });
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Кухар"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Кур'єр"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Офіціант"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Прибиральник"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Бармнен"
                        });
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AbillityToWork")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("YearsOfWorking")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AbillityToWork = true,
                            FirstName = "Василь",
                            LastName = "Сидоров",
                            PositionId = 1,
                            Salary = 12000m,
                            YearsOfWorking = 5
                        },
                        new
                        {
                            Id = 2,
                            AbillityToWork = true,
                            FirstName = "Олесь",
                            LastName = "Снігур",
                            PositionId = 1,
                            Salary = 10000m,
                            YearsOfWorking = 1
                        },
                        new
                        {
                            Id = 3,
                            AbillityToWork = true,
                            FirstName = "Марина",
                            LastName = "Коновалець",
                            PositionId = 1,
                            Salary = 12000m,
                            YearsOfWorking = 10
                        },
                        new
                        {
                            Id = 4,
                            AbillityToWork = true,
                            FirstName = "Олена",
                            LastName = "Петренко",
                            PositionId = 2,
                            Salary = 6500m,
                            YearsOfWorking = 8
                        },
                        new
                        {
                            Id = 5,
                            AbillityToWork = true,
                            FirstName = "Юля",
                            LastName = "Гончаренко",
                            PositionId = 3,
                            Salary = 6500m,
                            YearsOfWorking = 2
                        },
                        new
                        {
                            Id = 6,
                            AbillityToWork = true,
                            FirstName = "Олександр",
                            LastName = "Даванков",
                            PositionId = 3,
                            Salary = 6500m,
                            YearsOfWorking = 8
                        },
                        new
                        {
                            Id = 7,
                            AbillityToWork = true,
                            FirstName = "Євген",
                            LastName = "Півгеняо",
                            PositionId = 5,
                            Salary = 6500m,
                            YearsOfWorking = 3
                        },
                        new
                        {
                            Id = 8,
                            AbillityToWork = true,
                            FirstName = "Галина",
                            LastName = "Прокопівна",
                            PositionId = 4,
                            Salary = 6500m,
                            YearsOfWorking = 4
                        },
                        new
                        {
                            Id = 9,
                            AbillityToWork = true,
                            FirstName = "Олег",
                            LastName = "Ляшко",
                            PositionId = 2,
                            Salary = 6500m,
                            YearsOfWorking = 8
                        });
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Drink", b =>
                {
                    b.HasOne("RestourantDataAccess.Entities.Category", "Category")
                        .WithMany("Drinks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestourantDataAccess.Entities.Order", null)
                        .WithMany("Drinks")
                        .HasForeignKey("OrderId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Food", b =>
                {
                    b.HasOne("RestourantDataAccess.Entities.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestourantDataAccess.Entities.Order", null)
                        .WithMany("Foods")
                        .HasForeignKey("OrderId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Order", b =>
                {
                    b.HasOne("RestourantDataAccess.Entities.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestourantDataAccess.Entities.Worker", "Worker")
                        .WithMany("Orders")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Worker", b =>
                {
                    b.HasOne("RestourantDataAccess.Entities.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Category", b =>
                {
                    b.Navigation("Drinks");

                    b.Navigation("Foods");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Order", b =>
                {
                    b.Navigation("Drinks");

                    b.Navigation("Foods");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Position", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("RestourantDataAccess.Entities.Worker", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
