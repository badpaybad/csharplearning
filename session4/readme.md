# async

https://docs.google.com/drawings/d/19-E3ReQwbfu64FO0E03AlCG8boJPPVu6LfoUSc3jhVk/edit?usp=sharing

                C# Thường thì async để cho các IO (disk, network) là chính. Khái niệm CPU bound, IO bound 

                System.Threading.Task.TaskScheduler Đảm nhiệm việc các task được chạy trên CPU , CPU thread nào

Khi đã xài async await thì không được phép xài .Wait() or .Result or .GetAwaiter().GetReusult() or .WaitAll() Thread.Sleep ... sẽ có thể xảy ra deadlock và treo máy 

                C# xài async await. tuy vậy về nghiệp vụ thì rất rõ ràng về sync , async. còn khi nào mà IO bound thì tức là CPU sẽ free, và sẽ làm việc khác đc. async await sẽ cần nhiều RAM và tận dụng CPU free đc nhiều hơn. tuy vậy tổng số task start đồng thời 
                
không nên quá số CPU thread. vd có 2 CPU thì ko nên await Task.WhenAll([t1,.... t100]) 
. nên t1->t2 or t4 thôi. cần tìm hiều thêm ActionBlock, Slimlock , dataflow …
Thay vì xài Thead.Sleep thì xài await Task.Delay


# code design concept

https://drive.google.com/file/d/1tANDh8SvxsZaM9xBYI69cEZ378SEtEJH/view?usp=sharing 

Event bus: pub sub 

Queue: 

# linq 

Các chú ý

- Nếu tính toán được trước không để vào phần query

                nghiêm cấm vd 
                
                dbcontext.Items1.Where(i=>i.num > (100/3)  + a && i.created> DateTime.Now.AddDay(1)).Select (...) ...
                đúng 
                
                 var condi1= (100/3)+a ; var tommorow= DateTime.Now.AddDay(1) ; dbcontext.Itém1.Where(i=>i.num>condi1 && i.created > tommorow)...

- Nếu dùng partent repository thì repository phải trả ra là object đã đc instance : vd List, Object ... . Không được trả ra interface vd IQueryable<Class1> getlist()


# Bài tập:

Dùng các cấu trúc dữ liệu sẵn của c#: queue, dictionary , list ...
để triển khai pub sub