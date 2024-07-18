using taskadodo;

User user1 = new User() { Login = "login1", Pswd = "pswd1"}; 
User user2 = new User() { Login = "login2", Pswd = "pswd2"}; 
Tag tag1 = new Tag() { TagText = "tag1" };
Tag tag2 = new Tag() { TagText = "tag2" };
Post post1 = new Post() { Date = DateTime.Now, ImgPath = "imgs/one.jpg", Text = "post1" };
Post post2 = new Post() { Date = DateTime.Now, ImgPath = "imgs/two.jpg", Text = "post2" };

tag1.Posts.Add(post1);
tag2.Posts.Add(post1);
tag2.Posts.Add(post2);
post1.Tags.Add(tag1);
post1.Tags.Add(tag2);
post2.Tags.Add(tag2);
user1.Posts.Add(post1);
user1.Posts.Add(post2);
user2.Posts.Add(post2);

using MiniInstaContext db = new MiniInstaContext();
db.Users.Add(user1);
db.Users.Add(user2);
db.Posts.Add(post1);
db.Posts.Add(post2);
db.Tags.Add(tag1);
db.Tags.Add(tag2);
db.SaveChanges();