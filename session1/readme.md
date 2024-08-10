# IDE

visualstudio 

                https://visualstudio.microsoft.com/vs/


visual code 

                https://code.visualstudio.com/download

                extension:
                
                c#, intelico,

# OS 

recommend Ubuntu, because mostly we deploy all to linux server


# git 

source code control 

                    Cấu hình Git:

                        git config --global user.name "Tên của bạn": Thiết lập tên người dùng.
                        git config --global user.email "email@example.com": Thiết lập email của bạn.
                        git config --global core.editor "code --wait": Thiết lập Visual Studio Code làm trình soạn thảo mặc định.

                    Khởi tạo kho Git:

                        git init: Khởi tạo một kho Git mới trong thư mục hiện tại.

                    Kiểm tra trạng thái:

                        git status: Kiểm tra trạng thái của các tệp trong kho Git.

                    Thêm tệp vào vùng chuẩn bị (staging area):

                        git add <tên_tệp>: Thêm một tệp vào vùng chuẩn bị.
                        git add .: Thêm tất cả các tệp thay đổi vào vùng chuẩn bị.

                    Lưu các thay đổi vào kho:

                        git commit -m "Thông điệp commit": Lưu các thay đổi trong vùng chuẩn bị vào kho với một thông điệp.

                    Kiểm tra lịch sử commit:

                        git log: Hiển thị lịch sử commit.

                    Kết nối với kho từ xa:

                        git remote add origin <url>: Kết nối kho Git cục bộ với một kho từ xa.
                        git remote -v: Kiểm tra các kho từ xa đã kết nối.

                    Đẩy code lên kho từ xa:

                        git push -u origin master: Đẩy nhánh master lên kho từ xa lần đầu tiên.
                        git push: Đẩy các thay đổi lên kho từ xa.

                    Cập nhật code từ kho từ xa:

                        git pull: Tải và tích hợp code từ kho từ xa về kho cục bộ.

                    Tạo nhánh mới:

                        git branch <tên_nhánh>: Tạo một nhánh mới.
                        git checkout -b <tên_nhánh>: Tạo và chuyển ngay sang nhánh mới.

                    Chuyển nhánh:

                        git checkout <tên_nhánh>: Chuyển sang nhánh khác.

                    Gộp nhánh:

                        git merge <tên_nhánh>: Gộp nhánh được chỉ định vào nhánh hiện tại.

                    Xóa nhánh:

                        git branch -d <tên_nhánh>: Xóa một nhánh đã được gộp.
                        git branch -D <tên_nhánh>: Buộc xóa một nhánh chưa được gộp.

                    Clone một kho từ xa:

                        git clone <url>: Tạo một bản sao của kho từ xa về máy tính của bạn.


                        1. Sử dụng git revert

                        Lệnh này tạo ra một commit mới để đảo ngược các thay đổi từ commit cần hoàn tác, giữ cho lịch sử commit an toàn và không thay đổi.

                            Hoàn tác commit cuối cùng:

                            bash

                        git revert HEAD

                        Lệnh này sẽ tạo một commit mới để hoàn tác các thay đổi từ commit cuối cùng.

                        Hoàn tác một commit cụ thể:

                        bash

                            git revert <commit_id>

                            Thay <commit_id> bằng mã hash của commit bạn muốn hoàn tác (bạn có thể tìm mã hash bằng cách chạy git log).

                        2. Sử dụng git reset

                        Lệnh này thay đổi lịch sử commit, vì vậy nó cần cẩn trọng khi sử dụng, đặc biệt là nếu bạn đã đẩy commit lên kho từ xa.

                            Quay lại commit trước đó mà không giữ lại thay đổi:

                            bash

                        git reset --hard HEAD~1

                        Lệnh này sẽ xóa commit cuối cùng và các thay đổi tương ứng trong thư mục làm việc.

                        Quay lại commit trước đó và giữ lại thay đổi trong thư mục làm việc (chuyển chúng vào vùng chuẩn bị):

                        bash

                        git reset --soft HEAD~1

                        Lệnh này sẽ xóa commit cuối cùng nhưng giữ lại các thay đổi trong thư mục làm việc.

                        Chỉ di chuyển HEAD đến commit trước đó mà không thay đổi các tệp (các thay đổi vẫn ở thư mục làm việc nhưng không được đưa vào vùng chuẩn bị):

                        bash

                            git reset --mixed HEAD~1

                        Khi nào nên dùng git revert hoặc git reset?

                            git revert phù hợp khi bạn muốn hoàn tác một commit nhưng vẫn giữ lại lịch sử commit đầy đủ và an toàn.
                            git reset phù hợp khi bạn muốn chỉnh sửa lịch sử commit, chẳng hạn như khi bạn chưa đẩy commit lên kho từ xa và muốn làm lại.

