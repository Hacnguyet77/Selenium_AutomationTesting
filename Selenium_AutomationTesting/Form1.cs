using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium_AutomationTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntGoogle_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Navigate();
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Đại học Gia Định");
            IWebElement btnK = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));
            btnK.Click();



        }

        private void bntFacebook_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Navigate();
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("dinhhoanggia");

            IWebElement password = driver.FindElement(By.Name("pass"));
            password.SendKeys("dinhhoanggia");



            IWebElement enter = driver.FindElement(By.Name("login"));
            enter.Click();


            //



        }

        private void bntSourceDemo_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
            driver.Navigate();
            driver.Manage().Window.Maximize();
            IWebElement email = driver.FindElement(By.Name("user-name"));
            email.SendKeys("standard_user");

            Thread.Sleep(1000);
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("secret_sauce");

            Thread.Sleep(3000);

            IWebElement enter = driver.FindElement(By.XPath("//*[@id=\"login-button\"]"));
            enter.Click();



            IWebElement tshirt = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-bolt-t-shirt\"]"));
            tshirt.Click();
            Thread.Sleep(1000);

            IWebElement jacket = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-fleece-jacket\"]"));
            jacket.Click();
            Thread.Sleep(3000);

            IWebElement cart = driver.FindElement(By.ClassName("shopping_cart_link"));
            cart.Click();
            Thread.Sleep(3000);


            //continue-shopping

            IWebElement continueshopping = driver.FindElement(By.Id("continue-shopping"));
            continueshopping.Click();
            Thread.Sleep(2000);

            IWebElement selectopt = driver.FindElement(By.ClassName("product_sort_container"));
            var opts = new SelectElement(selectopt);
            opts.SelectByValue("hilo");
            Thread.Sleep(1000);

            IWebElement cart2 = driver.FindElement(By.ClassName("shopping_cart_link"));
            cart2.Click();
            Thread.Sleep(3000);

            //IWebElement checkout = driver.FindElement(By.Id("checkout"));
            //checkout.Click();
            //Thread.Sleep(1000);

            IWebElement menubtn = driver.FindElement(By.Id("react-burger-menu-btn"));
            menubtn.Click();
            Thread.Sleep(3000);

            IWebElement linkbnt = driver.FindElement(By.LinkText("About"));
            linkbnt.Click();
            //Thread.Sleep(1000);

            //react-burger-menu-btn


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo WebDriver sử dụng trình duyệt Chrome
            IWebDriver driver = new ChromeDriver();

            // Mở trang web bán sách
            driver.Url = "https://bookbuy.vn/";
            driver.Navigate();

            // Tạm dừng 3 giây để trang web tải đầy đủ
            Thread.Sleep(3000);

            // Mở rộng cửa sổ trình duyệt
            driver.Manage().Window.Maximize();

          /*  // Sử dụng JavaScript để tính chiều cao của trang web
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            long pageHeight = (long)js.ExecuteScript("return Math.max( document.body.scrollHeight, document.body.offsetHeight, " +
                "document.documentElement.clientHeight, document.documentElement.scrollHeight, document.documentElement.offsetHeight );");

            // Sử dụng vòng lặp để kéo từ đầu đến cuối trang
            for (int i = 0; i < pageHeight; i += 10) // Tăng 10 pixel mỗi lần
            {
                js.ExecuteScript($"window.scrollTo(0, {i});");
                Thread.Sleep(50); // Tạm dừng để trình duyệt xử lý
            }
*/
          
            IWebElement product0 = driver.FindElement(By.XPath("//*[@id=\"bb-body\"]/div/div[4]/div/div/div/ul/li[2]/div/div[2]/a"));

            // Cuộn trang đến sản phẩm 0
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", product0);

            // Sử dụng Actions để thực hiện thao tác click với hiệu ứng
            Actions actions = new Actions(driver);
            actions.MoveToElement(product0).Click().Perform();

            // Tạm dừng 3 giây
            Thread.Sleep(3000);

            // Thêm vào giỏ hàng
            IWebElement checkout0 = driver.FindElement(By.XPath("//*[@id=\"checkoutform\"]/div/div[2]/button"));
            checkout0.Click();

            // Tạm dừng 3 giây
            Thread.Sleep(3000);

            // Tiếp tục mua hàng
            IWebElement tiep = driver.FindElement(By.XPath("//*[@id=\"add-cart-success-dialog\"]/" +
                "div/div/div/div[1]/div[2]/div/div[3]/div/span[1]/a/span"));
            tiep.Click();

            // Tạm dừng 3 giây
            Thread.Sleep(3000);

            // Tìm ô nhập liệu và nhập từ khóa "vun dap tam hon"
            IWebElement find = driver.FindElement(By.Id("Term"));
            find.SendKeys(" vun dap tam hon");

            // Tìm và click nút tìm kiếm
            IWebElement search = driver.FindElement(By.XPath("//*[@id=\"bb-header\"]/div[3]/div/div/div[2]/div/div[1]/div/div[2]/button/span"));
            search.Click();
           

            //xem chi tiết sách
            IWebElement book = driver.FindElement(By.XPath("//*[@id=\"bb-body\"]/div/div/div/div[1]/div[28]/div[1]/a/img"));
            book.Click();
            Thread.Sleep(3000);

             //thêm vào giỏ hàng
            Thread.Sleep(5000);
            IWebElement checkout1 = driver.FindElement(By.XPath("//*[@id=\"checkoutform\"]/div/div[2]/button"));
            checkout1.Click();
            Thread.Sleep(3000); ;

            //tiep tuc mua hang
            IWebElement tiep1 = driver.FindElement(By.XPath("//*[@id=\"add-cart-success-dialog\"]/div/div/div/div[1]/div[2]/div/div[3]/" +
                "div/span[1]/a/span"));
            tiep1.Click();
            Thread.Sleep(3000);


            //mo danh muc san pham
            IWebElement product = driver.FindElement(By.XPath("//*[@id=\"bb-header\"]/div[4]/div/div[1]/div/a/span"));
            product.Click();
            Thread.Sleep(3000);

            //chon qua tang do choi
            IWebElement gift = driver.FindElement(By.XPath("//*[@id=\"bb-header\"]/div[4]/div/div[1]/div/div/ul/li[6]/a"));
            gift.Click();
            Thread.Sleep(3000);

            //xem chi tiet bao li xi
            IWebElement sp2 = driver.FindElement(By.XPath("//*[@id=\"bb-body\"]/div/div/div[4]/div[1]/div" +
                "[2]/div[2]/div/div[1]/data-owl-carousel/div[1]/div/div[1]/li/div/div[1]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", sp2);
            Thread.Sleep(2000);
            sp2.Click();
            Thread.Sleep(4000);

            //add to cast 2
            IWebElement checkout2 = driver.FindElement(By.XPath("//*[@id=\"checkoutform\"]/div/div[2]/button"));
            checkout2.Click();
            Thread.Sleep(3000);

            //dong thong bao
            IWebElement close = driver.FindElement(By.XPath("//*[@id=\"add-cart-success-dialog\"]/div/div/button"));
            close.Click();
            Thread.Sleep(3000);

            //xem gio hang
            IWebElement cast1 = driver.FindElement(By.XPath("//*[@id=\"bb-header\"]/div[3]/div/div/div[2]/div/div[3]/div[1]/a"));
            cast1.Click();
            Thread.Sleep(3000);

            //them so luong
            IWebElement soluong = driver.FindElement(By.XPath("//*[@id=\"rounded-corner\"]/tbody/tr[1]/td[4]/div/button[2]"));
            soluong.Click();
            Thread.Sleep(1000);
            soluong.Click();
            Thread.Sleep(3000);

            //xóa 1 sản phẩm
            IWebElement delete = driver.FindElement(By.XPath("//*[@id=\"rounded-corner\"]/tbody/tr[3]/td[2]/a[1]"));
            delete.Click();
            Thread.Sleep(3000);

            WebDriverWait alertWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            alertWait.Until(driver =>
            {
                try
                {
                    // Nếu có Alert, thực hiện Accept và trả về true
                    IAlert alert = driver.SwitchTo().Alert();
                    alert.Accept();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    // Nếu không có Alert, trả về false
                    return false;
                }
            });

         /*   //tới trang tin tức
            Thread.Sleep(3000);

            IWebElement news = driver.FindElement(By.XPath("//*[@id=\"btn-news-trigger\"]"));
            news.Click();
            Thread.Sleep(3000);

            //cuộn tới cuối trang
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            long pageHeight1 = (long)js.ExecuteScript("return Math.max( document.body.scrollHeight, document.body.offsetHeight, document.documentElement.clientHeight," +
                " document.documentElement.scrollHeight, document.documentElement.offsetHeight );");

            // Sử dụng vòng lặp để kéo từ đầu đến cuối trang
            for (int i = 0; i < pageHeight; i += 10) // Tăng 10 pixel mỗi lần
            {
                js.ExecuteScript($"window.scrollTo(0, {i});");
                Thread.Sleep(50); // Tạm dừng để trình duyệt xử lý*/
           // }

            //đóng trình duyệt
            driver.Quit();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}