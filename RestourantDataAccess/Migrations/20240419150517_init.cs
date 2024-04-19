using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestourantDataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNukmber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbillityToWork = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearsOfWorking = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workers_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Liter = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drinks_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drinks_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mass = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Перша страва" },
                    { 2, "Піца" },
                    { 3, "Закуска" },
                    { 4, "Гарнір" },
                    { 5, "Десерт" },
                    { 6, "Напій" },
                    { 7, "Алкогольний напій" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNukmber" },
                values: new object[] { 1, "вул Чорновола, буд. 1, кв. 5", "ivanseluhov@gmail.com", "Іван", "Шелухов", "ivan123", "password123", "+380984145258" });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Кухар" },
                    { 2, "Кур'єр" },
                    { 3, "Офіціант" },
                    { 4, "Прибиральник" },
                    { 5, "Бармнен" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "CategoryId", "Liter", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { 1, 6, 0.29999999999999999, "Чай", null, 20m },
                    { 2, 6, 0.25, "Кава", null, 30m },
                    { 3, 6, 0.5, "Пепсі", null, 30m },
                    { 4, 6, 1.0, "Сік Sandora Яблуко виноград/Банан/Апельсин/Томатний", null, 68m },
                    { 5, 6, 1.0, "Мінеральна вода Buvete 7", null, 40m },
                    { 6, 7, 1.0, "Водка Pervak", null, 265m },
                    { 7, 7, 0.5, "Віскі Jack Daniels ", null, 850m },
                    { 8, 7, 0.25, "Кава з коньяком Aznauri", null, 55m },
                    { 9, 7, 0.5, "Пиво Львівське світле", null, 60m },
                    { 10, 7, 0.5, "Пиво Льввівське темне", null, 60m }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CategoryId", "Mass", "Name", "OrderId", "Price", "Recipe" },
                values: new object[,]
                {
                    { 1, 1, 400.0, "Недорамен", null, 80m, "Якось в Одесі 5 програмістів плавуючі в морі захотіли їсти, зловили криветок з мідіями, взяли китайські гриби та лапшу, кинули в казан і ось так народилася ця страв" },
                    { 2, 1, 400.0, "Солянка", null, 80m, "Мисливські ковбаси, картопля, картопля, салямі, сосиски, морква, мариновані огірки, лимон" },
                    { 3, 1, 400.0, "Пельмені з бульйоном", null, 80m, "(Відміно смакує з похміля)" },
                    { 4, 2, 400.0, "Нельсон", null, 200m, "Бортик з молочною ковбаскою, вершковий соус, сир блакитний, моцарела, українська салямі, шинка, сушений ореган, рукола, карамелізована цибуля" },
                    { 5, 2, 490.0, "Мисливська", null, 260m, "Мисливські ковбаски, українська салямі, бочок копчений, помідор, моцарела, часник, соус із тертих томатів, рукола" },
                    { 6, 2, 490.0, "Палерма", null, 200m, "Баварські ковбаси, прошуто, українська сирокопчена пепероні, моцарела, свіжий базилік, соус із тертих томатів, маслини, сушений ореган" },
                    { 7, 2, 450.0, "Чотири сири", null, 249m, "Моцарела, чеддер, блакитний сир, пармезан, вершковий соус" },
                    { 8, 2, 500.0, "Каракатиця", null, 270m, "Чорне тісто на основі чорнила морської каракатиці, солений лосось, вершковий соус, оливки, моцарела, лимон, пармезан, італійські трави, свіжий базилік" },
                    { 9, 2, 400.0, "Капрічоза", null, 190m, "Мариновані печериці, помідори чері, оливки, шинка, пармезан, моцарела, соус із тертих томатів, сушений ореган, рукола" },
                    { 10, 2, 490.0, "Мексика", null, 200m, "Закарпатська сирокопчена пепероні, українська салямі, болгарський перець, маринований чілі переці, сушений каєнський перець, сушений чілі перець, зелена цибуля, моцарела, соус із тертих томатів, соус шрірача" },
                    { 11, 2, 490.0, "Папероні", null, 230m, "українське салямі, моцарела, соус з терттих томатів" },
                    { 12, 3, 660.0, "Дошка 'Антипасто' ", null, 520m, "Прошуто, грісіні фует, оливки, сир з голубою пліснявою, камамбер, листкові закуски, перець чілі та халапеньо, соус із вишень та вина" },
                    { 13, 3, 410.0, "Дошка 'Вішайся'", null, 210m, "маринований у спеціях бочок, сало перекручене з часником, файне сало на мотузках, моцний хрін, асорті пивних грінок, пікантний корнішон" },
                    { 14, 3, 550.0, "Дошка 'Чисто по-людськи'", null, 390m, "мікс в'яленого м'яса, курячі чіпси, смажені чіпси з лаваша, сухарі з бородинського хліба з часником, мікс горіхів та соуси" },
                    { 15, 3, 250.0, "В'ялене м'ясо 'Made in Garage'", null, 225m, "Телятина/Свинина/Курка" },
                    { 16, 3, 200.0, "Курячі нагетси", null, 105m, "з сойсом на рибі" },
                    { 17, 3, 100.0, "Цибулеві кільці з соусом", null, 87m, "'Вставте текст'" },
                    { 18, 3, 180.0, "Сир фрі", null, 95m, "просто сир" },
                    { 19, 3, 80.0, "Свинні копчені вушка", null, 57m, "з цибулею" },
                    { 20, 3, 250.0, "Чіпси начос", null, 155m, "Сир чеддер, ковбаси, саслини, соус гуакамоле" },
                    { 21, 3, 50.0, "Чіпси `Garage`", null, 47m, "+ соус на вибір" },
                    { 22, 3, 100.0, "Сухарики 'Інь Янь'", null, 47m, "Грінкі з білого хлібу, грінкі з бородиснького хлібу + соус на вибір" },
                    { 23, 4, 400.0, "Молода картопля з копченими сосиками", null, 115m, "Поливаємо сирним соусом з паприкою та укропом і карамелізованою цибулею" },
                    { 24, 4, 130.0, "Картопля фрі", null, 50m, "з соусом з тертих томатів" },
                    { 25, 4, 250.0, "Картопля по домашньому", null, 50m, "смажена на пательні в олії з часником та цибулею" },
                    { 26, 4, 255.0, "Печена картопля по селянськи", null, 85m, "з бочком та маринованим домашнім огірком" },
                    { 27, 5, 250.0, "Коктейль 'Рай солодкоїжки'", null, 120m, "Бланкшеровні фрукти з мандариновим лікером, бельгійські вафлі, шоколад, вафельні труьочки з кремом" },
                    { 28, 5, 120.0, "Маленька прикрість", null, 85m, "шоколадний горщик, вершкове морозиво, печиво, какао, гранат, м'ята" },
                    { 29, 5, 150.0, "Сирники", null, 77m, "з сметаною або згущеним молоком" },
                    { 30, 5, 150.0, "Вершки 'Garage'", null, 60m, "шоколад, печиво, банан, топ" },
                    { 31, 5, 180.0, "Морозиво Sundae", null, 97m, "Три кульки різного морозива, ягоди харібо, орео, топінг" },
                    { 32, 5, 150.0, "Морозиво `Garage`", null, 67m, "Моризиво, вафлі, згущене молоко, арахіс" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CategoryId", "Mass", "Name", "OrderId", "Price", "Recipe" },
                values: new object[,]
                {
                    { 33, 5, 180.0, "Морозиво з лісовими ягодами", null, 97m, "Вершки, лісові ягоди:малина, чорниця, ожині, полуничний топінг, тертий шоколад" },
                    { 34, 1, 400.0, "Борщ", null, 80m, "з пампушками, цибуля синя, кріп, бочок, сметана" }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "AbillityToWork", "FirstName", "LastName", "PositionId", "Salary", "YearsOfWorking" },
                values: new object[,]
                {
                    { 1, true, "Василь", "Сидоров", 1, 12000m, 5 },
                    { 2, true, "Олесь", "Снігур", 1, 10000m, 1 },
                    { 3, true, "Марина", "Коновалець", 1, 12000m, 10 },
                    { 4, true, "Олена", "Петренко", 2, 6500m, 8 },
                    { 5, true, "Юля", "Гончаренко", 3, 6500m, 2 },
                    { 6, true, "Олександр", "Даванков", 3, 6500m, 8 },
                    { 7, true, "Євген", "Півгеняо", 5, 6500m, 3 },
                    { 8, true, "Галина", "Прокопівна", 4, 6500m, 4 },
                    { 9, true, "Олег", "Ляшко", 2, 6500m, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_CategoryId",
                table: "Drinks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_OrderId",
                table: "Drinks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_OrderId",
                table: "Foods",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_WorkerId",
                table: "Order",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_PositionId",
                table: "Workers",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
