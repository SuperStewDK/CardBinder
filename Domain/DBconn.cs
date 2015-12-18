using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DBconn
    {
        // For local database
        String connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = CardBinder;Integrated Security = True";

        LinqToSQLDatacontext db;

        private int getCount()
        {
            db = new LinqToSQLDatacontext(connectionString);

            var count = db.cards.Count();

            return count;
        }

        private int getLast()
        {
            db = new LinqToSQLDatacontext(connectionString);

            cardbinder lastEntry = db.cardbinders.Last();

            return lastEntry.id;
        }

        public void createCard(string name, string imagepath, int friendship, int bravery, int humor, int starfactor)
        {
            db = new LinqToSQLDatacontext(connectionString);

            // Create new Card
            card newcard = new card();
            newcard.name = name;
            newcard.serialnumber = getCount()+1;
            newcard.imagepath = imagepath;
            newcard.friendship = friendship;
            newcard.bravery = bravery;
            newcard.humor = humor;
            newcard.starfactor = starfactor;

            // adds new card to  database
            db.cards.InsertOnSubmit(newcard);
            db.SubmitChanges();

        }

        public void removeCard(int serialNumber)
        {
            db = new LinqToSQLDatacontext(connectionString);

            // Get Card to remove
            // Lamda used!!!!!!!!!!!!!!!!!!!!!!!!!
            card removeCard = db.cards.FirstOrDefault(e => e.serialnumber.Equals(serialNumber));

            // Delete Card
            db.cards.DeleteOnSubmit(removeCard);
            db.SubmitChanges();
        }

        public void addCardToUser(string userName, int cardID)
        {
            db = new LinqToSQLDatacontext(connectionString);

            // Create new card in cardbinder
            cardbinder newcard = new cardbinder();
            newcard.id = getLast();
            newcard.userid = userName;
            newcard.cardid = cardID;

            //add new card til cardbinder table
            db.cardbinders.InsertOnSubmit(newcard);
            db.SubmitChanges();
        }

        public void removeCardFromUser(string userName, int serialNumber)
        {
            db = new LinqToSQLDatacontext(connectionString);

            // Get cardbinder and remove card
            cardbinder removeCard = db.cardbinders.FirstOrDefault(e => e.cardid.Equals(serialNumber) && e.userid.Equals(userName));

            // Delete card
            db.cardbinders.DeleteOnSubmit(removeCard);
            db.SubmitChanges();
        }

        public User findUser(string userName)
        {
            db = new LinqToSQLDatacontext(connectionString);

            user u = db.users.FirstOrDefault(e => e.name == userName);

            User foundUser = new User(u.name, u.password);

            return foundUser;
        }

        public void deleteUser(string userName)
        {
            db = new LinqToSQLDatacontext(connectionString);

            // Get cardbinder to delete
            db.cardbinders.DeleteAllOnSubmit(db.cardbinders.Where(e => e.userid == userName));

            db.SubmitChanges();

            // Get user to delete
            user removeUser = db.users.FirstOrDefault(e => e.name.Equals(userName));

            // Delete User
            db.users.DeleteOnSubmit(removeUser);
            db.SubmitChanges();
        }

        public void createUser(string userName, string password)
        {
            db = new LinqToSQLDatacontext(connectionString);

            user newUser = new user();
            newUser.name = userName;
            newUser.password = password;

            // Create User
            db.users.InsertOnSubmit(newUser);
            db.SubmitChanges();
        }

        public void editUsername(string userName, string newName)
        {
            db = new LinqToSQLDatacontext(connectionString);

            try
            {
                //Get cardbinder to edit
                var binderQuery = 
                    from b in db.cardbinders
                    where b.userid == userName
                    select b;

                foreach (cardbinder b in binderQuery)
                {
                    // create new cardbinder to replace old
                    cardbinder binder = new cardbinder();
                    binder.id = b.id;
                    binder.cardid = b.cardid;
                    binder.userid = newName;

                    db.cardbinders.DeleteOnSubmit(b);
                    db.cardbinders.InsertOnSubmit(binder);
                }

                //Get user to edit
                var query =
                    from u in db.users
                    where u.name == userName
                    select u;

                foreach (user u in query)
                {
                    // create new user and cardbinder to replace old
                    user uNew = new user();
                    uNew.name = newName;
                    uNew.password = u.password;

                    db.users.DeleteOnSubmit(u);
                    db.users.InsertOnSubmit(uNew);
                }

                // Save changes
                db.SubmitChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e); ;
            }
        }

        public Binder viewUser(string userName)
        {
            db = new LinqToSQLDatacontext(connectionString);

            // Binder for transerfering data to gui
            Binder userBinder = new Binder(userName);

            // users information consists of his cardbinder, Linq statement
            var query = (from t in db.cardbinders
                         where t.userid == userName
                         select t.cardid);

            // Adds required cards from db to cardbinders cardlist
            foreach (var id in query)
            {
                var cardQuery = (from c in db.cards
                                 where c.serialnumber == id
                                 select c);
               
                foreach (var e in cardQuery)
                {
                    userBinder.cardList.Add(e);
                    Console.WriteLine(e.name);
                }
            }

            // returns a binder with username and cardIDs
            return userBinder;
        }

        public List<card> getCards()
        {
            db = new LinqToSQLDatacontext(connectionString);

            List<card> allCards = new List<card>();

            var all = db.cards;

            foreach (var card in all)
                allCards.Add(card);

            return allCards;
        }

        //String connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = CardBinder;Integrated Security = True";
        //LinqToDB db;
        //SqlConnection connection;

        //public void cardToDB(string name, int serialnumber, string imagepath)
        //{
        //    db = new LinqToDB(connectionString);

        //    // Create new Card
        //    card newcard = new card();
        //    newcard.name = name;
        //    newcard.serialnumber = serialnumber;
        //    newcard.imagepath = imagepath;

        //    // adds new card to  database
        //    db.cards.InsertOnSubmit(newcard);
        //    db.SubmitChanges();

        //    using (connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("INSERT INTO card (name, serialnumber, imagepath) Values(@name, @serialnumber, @imagepath)");
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = connection;
        //        cmd.Parameters.AddWithValue("@name", newcard.Name);
        //        cmd.Parameters.AddWithValue("@serialnumber", newcard.SerialNumber);
        //        cmd.Parameters.AddWithValue("@imagepath", newcard.ImagePath);
        //        if (connection.State != ConnectionState.Open)
        //        { connection.Open(); }
        //        cmd.ExecuteNonQuery();

        //        Console.WriteLine("Card Saved!");
        //    }
        //}

        //public void removeCard(Card card)
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("DELETE FROM card WHERE serialnumber = @serialnumber");
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = connection;
        //        cmd.Parameters.AddWithValue("@serialnumber", card.SerialNumber);
        //        if (connection.State != ConnectionState.Open)
        //        { connection.Open(); }
        //        cmd.ExecuteNonQuery();

        //        Console.WriteLine("Card Deleted!");
        //    }
        //}

        //public void addCardToUser(Binder binder, User user, Card card)
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("INSERT INTO cardbinder(id, userid, cardid) VALUES (@id, @userid, @cardid)");
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = connection;
        //        cmd.Parameters.AddWithValue("@id", binder.binderId);
        //        cmd.Parameters.AddWithValue("@userid", user.Username);
        //        cmd.Parameters.AddWithValue("@cardid", card.SerialNumber);
        //        if (connection.State != ConnectionState.Open)
        //        { connection.Open(); }
        //        cmd.ExecuteNonQuery();

        //        Console.WriteLine("Card Added!");
        //    }
        //}

        //public void removeCardFromUser(Binder binder, Card card)
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("DELETE FROM cardbinder WHERE id = @id AND cardid = @cardid");
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = connection;
        //        cmd.Parameters.AddWithValue("@id", binder.binderId);
        //        cmd.Parameters.AddWithValue("@cardid", card.SerialNumber);
        //        if (connection.State != ConnectionState.Open)
        //        { connection.Open(); }
        //        cmd.ExecuteNonQuery();

        //        Console.WriteLine("Card Removed!");
        //    }
        //}

        //public void deleteUser(User user)
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("DELETE FROM [user] WHERE name = @name");
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = connection;
        //        cmd.Parameters.AddWithValue("@name", user.Username);
        //        if (connection.State != ConnectionState.Open)
        //        { connection.Open(); }
        //        cmd.ExecuteNonQuery();

        //        Console.WriteLine("User Deleted!");
        //    }
        //}

        //public void editUsername(User user)
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("UPDATE [user] SET name = @name2 WHERE name = @name");
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = connection;
        //        // Remember to connect this to a textfield
        //        cmd.Parameters.AddWithValue("@name2", "someName");
        //        cmd.Parameters.AddWithValue("@name", user.Username);
        //        if (connection.State != ConnectionState.Open)
        //        { connection.Open(); }
        //        cmd.ExecuteNonQuery();

        //        Console.WriteLine("Username Altered!");
        //    }
        //}

        //public Binder viewUser(User user)
        //{
        //    Binder binder = new Binder(user.Username);

        //    using (connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM cardbinder WHERE userid = @userid");
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = connection;
        //        // Remember to connect this to a textfield
        //        cmd.Parameters.AddWithValue("@userid", user.Username);

        //        if (connection.State != ConnectionState.Open)
        //        { connection.Open(); }

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                for (int i = 0; i < reader.FieldCount; i++)
        //                {
        //                    Console.WriteLine(reader.GetValue(i));
        //                }
        //            }
        //        }

        //        Console.WriteLine();
        //    }
        //    return binder;
        //}

        //public void addUser()
        //{

        //}

    }
}
