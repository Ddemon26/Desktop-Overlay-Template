/*using System.Collections.Generic;
namespace TCS.OverlayCore.Simple {
    public struct Location {
        public Location(double latitude, double longitude) {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; }
        public double Longitude { get; }
    }

    public struct Point {
        public Point(double x, double y) {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }
    }

    public struct Size {
        public Size(double width, double height) {
            Width = width;
            Height = height;
        }

        public double Width { get; }
        public double Height { get; }
    }

    public struct Rectangle {
        public Rectangle(double x, double y, double width, double height) {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public double X { get; }
        public double Y { get; }
        public double Width { get; }
        public double Height { get; }
    }

    public struct DateTime {
        public DateTime(int year, int month, int day, int hour, int minute, int second) {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Year { get; }
        public int Month { get; }
        public int Day { get; }
        public int Hour { get; }
        public int Minute { get; }
        public int Second { get; }
    }

    public struct Circle {
        public Circle(double centerX, double centerY, double radius) {
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
        }

        public double CenterX { get; }
        public double CenterY { get; }
        public double Radius { get; }
    }

    public struct Velocity {
        public Velocity(double speed, double direction) {
            Speed = speed;
            Direction = direction;
        }

        public double Speed { get; }
        public double Direction { get; }
    }

    public struct Dimensions {
        public Dimensions(double length, double width, double height) {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length { get; }
        public double Width { get; }
        public double Height { get; }
    }

    public struct RGBColor {
        public RGBColor(int red, int green, int blue) {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }
    }

    public struct Currency {
        public Currency(decimal amount, string currencyCode) {
            Amount = amount;
            CurrencyCode = currencyCode;
        }

        public decimal Amount { get; }
        public string CurrencyCode { get; }
    }

    public struct TimeSpan {
        public TimeSpan(int hours, int minutes, int seconds) {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }
    }

    public struct GeoCoordinate {
        public GeoCoordinate(double latitude, double longitude, double altitude) {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }

        public double Latitude { get; }
        public double Longitude { get; }
        public double Altitude { get; }
    }

    public struct PolarCoordinate {
        public PolarCoordinate(double radius, double theta) {
            Radius = radius;
            Theta = theta;
        }

        public double Radius { get; }
        public double Theta { get; }
    }

    public struct Time {
        public Time(int hours, int minutes, int seconds) {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }
    }

    public struct Date {
        public Date(int year, int month, int day) {
            Year = year;
            Month = month;
            Day = day;
        }

        public int Year { get; }
        public int Month { get; }
        public int Day { get; }
    }

    public struct Address {
        public Address(string street, string city, string state, string zipCode) {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
    }

    public struct PersonName {
        public PersonName(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }

    public struct PhoneNumber {
        public PhoneNumber(string countryCode, string areaCode, string number) {
            CountryCode = countryCode;
            AreaCode = areaCode;
            Number = number;
        }

        public string CountryCode { get; }
        public string AreaCode { get; }
        public string Number { get; }
    }

    public struct EmailAddress {
        public EmailAddress(string username, string domain) {
            Username = username;
            Domain = domain;
        }

        public string Username { get; }
        public string Domain { get; }
    }

    public struct Fraction {
        public Fraction(int numerator, int denominator) {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; }
        public int Denominator { get; }
    }

    public struct Measurement {
        public Measurement(double value, string unit) {
            Value = value;
            Unit = unit;
        }

        public double Value { get; }
        public string Unit { get; }
    }

    public struct ColorRgba {
        public ColorRgba(int red, int green, int blue, int alpha) {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }
        public int Alpha { get; }
    }

    public struct TimeInterval {
        public TimeInterval(DateTime startTime, DateTime endTime) {
            StartTime = startTime;
            EndTime = endTime;
        }

        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
    }

    public struct Line {
        public Line(double slope, double intercept) {
            Slope = slope;
            Intercept = intercept;
        }

        public double Slope { get; }
        public double Intercept { get; }
    }

    public struct PolynomialTerm {
        public PolynomialTerm(double coefficient, int exponent) {
            Coefficient = coefficient;
            Exponent = exponent;
        }

        public double Coefficient { get; }
        public int Exponent { get; }
    }

    public struct GPSData {
        public GPSData(double latitude, double longitude, double elevation, DateTime timestamp) {
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
            Timestamp = timestamp;
        }

        public double Latitude { get; }
        public double Longitude { get; }
        public double Elevation { get; }
        public DateTime Timestamp { get; }
    }

    public struct UserCredentials {
        public UserCredentials(string username, string password) {
            Username = username;
            Password = password;
        }

        public string Username { get; }
        public string Password { get; }
    }

    public struct AccountBalance {
        public AccountBalance(decimal amount, string currencyCode, DateTime timestamp) {
            Amount = amount;
            CurrencyCode = currencyCode;
            Timestamp = timestamp;
        }

        public decimal Amount { get; }
        public string CurrencyCode { get; }
        public DateTime Timestamp { get; }
    }

    public struct Car {
        public Car(string make, string model, int year) {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
    }

    public struct Book {
        public Book(string title, string author, string isbn) {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
    }

    public struct WeatherData {
        public WeatherData(double temperature, double humidity, double pressure) {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

        public double Temperature { get; }
        public double Humidity { get; }
        public double Pressure { get; }
    }

    public struct LocationEvent {
        public LocationEvent(string name, string location, DateTime startTime, DateTime endTime) {
            Name = name;
            Location = location;
            StartTime = startTime;
            EndTime = endTime;
        }

        public string Name { get; }
        public string Location { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
    }

    public struct Card {
        public Card(string suit, string rank) {
            Suit = suit;
            Rank = rank;
        }

        public string Suit { get; }
        public string Rank { get; }
    }

    public struct Contact {
        public Contact(string name, string phoneNumber, string email) {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
    }

    public struct Interval {
        public Interval(double start, double end) {
            Start = start;
            End = end;
        }

        public double Start { get; }
        public double End { get; }
    }

    public struct Range {
        public Range(int start, int end) {
            Start = start;
            End = end;
        }

        public int Start { get; }
        public int End { get; }
    }

    public struct KeyValuePair {
        public KeyValuePair(string key, string value) {
            Key = key;
            Value = value;
        }

        public string Key { get; }
        public string Value { get; }
    }

    public struct ScoreEntry {
        public ScoreEntry(string playerName, int score, DateTime date) {
            PlayerName = playerName;
            Score = score;
            Date = date;
        }

        public string PlayerName { get; }
        public int Score { get; }
        public DateTime Date { get; }
    }

    public struct TemperatureRange {
        public TemperatureRange(double minCelsius, double maxCelsius) {
            MinCelsius = minCelsius;
            MaxCelsius = maxCelsius;
        }

        public double MinCelsius { get; }
        public double MaxCelsius { get; }
    }

    public struct FrequencyRange {
        public FrequencyRange(double minHertz, double maxHertz) {
            MinHertz = minHertz;
            MaxHertz = maxHertz;
        }

        public double MinHertz { get; }
        public double MaxHertz { get; }
    }

    public struct Student {
        public Student(string name, int age, string studentID) {
            Name = name;
            Age = age;
            StudentID = studentID;
        }

        public string Name { get; }
        public int Age { get; }
        public string StudentID { get; }
    }

    public struct Employee {
        public Employee(string name, int employeeID, string department) {
            Name = name;
            EmployeeID = employeeID;
            Department = department;
        }

        public string Name { get; }
        public int EmployeeID { get; }
        public string Department { get; }
    }

    public struct AddressBookEntry {
        public AddressBookEntry(string name, string address, string phoneNumber, string email) {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public string Address { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
    }

    public struct Product {
        public Product(string productName, string productID, decimal price) {
            ProductName = productName;
            ProductID = productID;
            Price = price;
        }

        public string ProductName { get; }
        public string ProductID { get; }
        public decimal Price { get; }
    }

    public struct OrderItem {
        public OrderItem(string productID, int quantity, decimal unitPrice) {
            ProductID = productID;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public string ProductID { get; }
        public int Quantity { get; }
        public decimal UnitPrice { get; }
    }

    public struct Transaction {
        public Transaction(string transactionID, decimal amount, DateTime date) {
            TransactionID = transactionID;
            Amount = amount;
            Date = date;
        }

        public string TransactionID { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
    }

    public struct BankAccount {
        public BankAccount(string accountNumber, string accountHolderName, decimal balance) {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public string AccountNumber { get; }
        public string AccountHolderName { get; }
        public decimal Balance { get; }
    }

    public struct StockQuote {
        public StockQuote(string symbol, decimal price, DateTime timestamp) {
            Symbol = symbol;
            Price = price;
            Timestamp = timestamp;
        }

        public string Symbol { get; }
        public decimal Price { get; }
        public DateTime Timestamp { get; }
    }

    public struct UserProfile {
        public UserProfile(string username, string fullName, string email, DateTime dateOfBirth) {
            Username = username;
            FullName = fullName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        public string Username { get; }
        public string FullName { get; }
        public string Email { get; }
        public DateTime DateOfBirth { get; }
    }

    public struct Movie {
        public Movie(string title, string director, int releaseYear, double rating) {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        public string Title { get; }
        public string Director { get; }
        public int ReleaseYear { get; }
        public double Rating { get; }
    }

    public struct FlightInfo {
        public FlightInfo(string flightNumber, string origin, string destination, DateTime departureTime, DateTime arrivalTime) {
            FlightNumber = flightNumber;
            Origin = origin;
            Destination = destination;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
        }

        public string FlightNumber { get; }
        public string Origin { get; }
        public string Destination { get; }
        public DateTime DepartureTime { get; }
        public DateTime ArrivalTime { get; }
    }

    public struct Appointment {
        public Appointment(string title, Date date, Time time, string location) {
            Title = title;
            Date = date;
            Time = time;
            Location = location;
        }

        public string Title { get; }
        public Date Date { get; }
        public Time Time { get; }
        public string Location { get; }
    }

    public struct TaskItem {
        public TaskItem(string description, bool isCompleted, Date dueDate) {
            Description = description;
            IsCompleted = isCompleted;
            DueDate = dueDate;
        }

        public string Description { get; }
        public bool IsCompleted { get; }
        public Date DueDate { get; }
    }

    public struct ShoppingCartItem {
        public ShoppingCartItem(string productName, int quantity, decimal unitPrice) {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public string ProductName { get; }
        public int Quantity { get; }
        public decimal UnitPrice { get; }
    }

    public struct Payment {
        public Payment(decimal amount, string method, Date date) {
            Amount = amount;
            Method = method;
            Date = date;
        }

        public decimal Amount { get; }
        public string Method { get; }
        public Date Date { get; }
    }

    public struct Note {
        public Note(string title, string content, Date dateCreated) {
            Title = title;
            Content = content;
            DateCreated = dateCreated;
        }

        public string Title { get; }
        public string Content { get; }
        public Date DateCreated { get; }
    }

    public struct EmailMessage {
        public EmailMessage(string from, string to, string subject, string body, DateTime dateSent) {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
            DateSent = dateSent;
        }

        public string From { get; }
        public string To { get; }
        public string Subject { get; }
        public string Body { get; }
        public DateTime DateSent { get; }
    }

    public struct BankTransaction {
        public BankTransaction(decimal amount, string description, Date date) {
            Amount = amount;
            Description = description;
            Date = date;
        }

        public decimal Amount { get; }
        public string Description { get; }
        public Date Date { get; }
    }

    public struct CreditCard {
        public CreditCard(string cardNumber, string cardHolderName, Date expirationDate) {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpirationDate = expirationDate;
        }

        public string CardNumber { get; }
        public string CardHolderName { get; }
        public Date ExpirationDate { get; }
    }

    public struct SocialMediaPost {
        public SocialMediaPost(string content, string author, DateTime timestamp, int likes, int shares) {
            Content = content;
            Author = author;
            Timestamp = timestamp;
            Likes = likes;
            Shares = shares;
        }

        public string Content { get; }
        public string Author { get; }
        public DateTime Timestamp { get; }
        public int Likes { get; }
        public int Shares { get; }
    }

    public struct ChatMessage {
        public ChatMessage(string sender, string message, DateTime sentTime) {
            Sender = sender;
            Message = message;
            SentTime = sentTime;
        }

        public string Sender { get; }
        public string Message { get; }
        public DateTime SentTime { get; }
    }


    public struct MusicTrack {
        public MusicTrack(string title, string artist, string album) {
            Title = title;
            Artist = artist;
            Album = album;
        }

        public string Title { get; }
        public string Artist { get; }
        public string Album { get; }
    }


    public struct Prescription {
        public Prescription(string medicationName, string dosage, string frequency, string doctorName) {
            MedicationName = medicationName;
            Dosage = dosage;
            Frequency = frequency;
            DoctorName = doctorName;
        }

        public string MedicationName { get; }
        public string Dosage { get; }
        public string Frequency { get; }
        public string DoctorName { get; }
    }

    public struct InsurancePolicy {
        public InsurancePolicy(string policyNumber, string insuredName, Date startDate, Date endDate, decimal coverageAmount) {
            PolicyNumber = policyNumber;
            InsuredName = insuredName;
            StartDate = startDate;
            EndDate = endDate;
            CoverageAmount = coverageAmount;
        }

        public string PolicyNumber { get; }
        public string InsuredName { get; }
        public Date StartDate { get; }
        public Date EndDate { get; }
        public decimal CoverageAmount { get; }
    }

    public struct Loan {
        public Loan(decimal loanAmount, double interestRate, int termMonths, decimal monthlyPayment) {
            LoanAmount = loanAmount;
            InterestRate = interestRate;
            TermMonths = termMonths;
            MonthlyPayment = monthlyPayment;
        }

        public decimal LoanAmount { get; }
        public double InterestRate { get; }
        public int TermMonths { get; }
        public decimal MonthlyPayment { get; }
    }

    public struct Ticket {
        public Ticket(string eventName, string venue, Date eventDate, string seatNumber) {
            EventName = eventName;
            Venue = venue;
            EventDate = eventDate;
            SeatNumber = seatNumber;
        }

        public string EventName { get; }
        public string Venue { get; }
        public Date EventDate { get; }
        public string SeatNumber { get; }
    }

    public struct WeatherForecast {
        public WeatherForecast(Date date, double temperatureHigh, double temperatureLow, string conditions) {
            Date = date;
            TemperatureHigh = temperatureHigh;
            TemperatureLow = temperatureLow;
            Conditions = conditions;
        }

        public Date Date { get; }
        public double TemperatureHigh { get; }
        public double TemperatureLow { get; }
        public string Conditions { get; }
    }

    public struct Review {
        public Review(string reviewerName, int rating, string comment) {
            ReviewerName = reviewerName;
            Rating = rating;
            Comment = comment;
        }

        public string ReviewerName { get; }
        public int Rating { get; }
        public string Comment { get; }
    }

    public struct Notification {
        public Notification(string title, string message, DateTime timestamp, bool isRead) {
            Title = title;
            Message = message;
            Timestamp = timestamp;
            IsRead = isRead;
        }

        public string Title { get; }
        public string Message { get; }
        public DateTime Timestamp { get; }
        public bool IsRead { get; }
    }

    public struct ExerciseRoutine {
        public ExerciseRoutine(string name, string[] exercises, TimeSpan totalDuration) {
            Name = name;
            Exercises = exercises;
            TotalDuration = totalDuration;
        }

        public string Name { get; }
        public string[] Exercises { get; }
        public TimeSpan TotalDuration { get; }
    }

    public struct MediaFile {
        public MediaFile(string fileName, string fileType, long fileSize) {
            FileName = fileName;
            FileType = fileType;
            FileSize = fileSize;
        }

        public string FileName { get; }
        public string FileType { get; }
        public long FileSize { get; }
    }

    public struct VideoFile {
        public VideoFile(string title, int year) {
            Title = title;
            Year = year;
        }

        public string Title { get; }
        public int Year { get; }
    }

    public struct Route {
        public Route(string startLocation, string endLocation, double distance) {
            StartLocation = startLocation;
            EndLocation = endLocation;
            Distance = distance;
        }

        public string StartLocation { get; }
        public string EndLocation { get; }
        public double Distance { get; }
    }

    public struct RentalProperty {
        public RentalProperty(string address, decimal monthlyRent, int bedrooms, int bathrooms) {
            Address = address;
            MonthlyRent = monthlyRent;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
        }

        public string Address { get; }
        public decimal MonthlyRent { get; }
        public int Bedrooms { get; }
        public int Bathrooms { get; }
    }

    public struct Meeting {
        public Meeting(string subject, DateTime startTime, DateTime endTime, string[] participants) {
            Subject = subject;
            StartTime = startTime;
            EndTime = endTime;
            Participants = participants;
        }

        public string Subject { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public string[] Participants { get; }
    }

    public struct PodcastEpisode {
        public PodcastEpisode(string title, string host, TimeSpan duration, Date releaseDate) {
            Title = title;
            Host = host;
            Duration = duration;
            ReleaseDate = releaseDate;
        }

        public string Title { get; }
        public string Host { get; }
        public TimeSpan Duration { get; }
        public Date ReleaseDate { get; }
    }

    public struct Gift {
        public Gift(string giverName, string recipientName, string description, Date dateGiven) {
            GiverName = giverName;
            RecipientName = recipientName;
            Description = description;
            DateGiven = dateGiven;
        }

        public string GiverName { get; }
        public string RecipientName { get; }
        public string Description { get; }
        public Date DateGiven { get; }
    }

    public struct AppointmentReminder {
        public AppointmentReminder(Appointment appointment, TimeSpan reminderBefore) {
            Appointment = appointment;
            ReminderBefore = reminderBefore;
        }

        public Appointment Appointment { get; }
        public TimeSpan ReminderBefore { get; }
    }

    public struct ProductOrder {
        public ProductOrder(string orderID, OrderItem[] items, decimal totalAmount, Date orderDate) {
            OrderID = orderID;
            Items = items;
            TotalAmount = totalAmount;
            OrderDate = orderDate;
        }

        public string OrderID { get; }
        public OrderItem[] Items { get; }
        public decimal TotalAmount { get; }
        public Date OrderDate { get; }
    }

    public struct Person {
        public Person(string firstName, string lastName, Date dateOfBirth) {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public Date DateOfBirth { get; }
    }

    public struct ContactInfo {
        public ContactInfo(string email, string phoneNumber) {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string Email { get; }
        public string PhoneNumber { get; }
    }

    public struct Order {
        public Order(string orderId, List<OrderItem> items, decimal totalAmount, DateTime orderDate) {
            OrderID = orderId;
            Items = items;
            TotalAmount = totalAmount;
            OrderDate = orderDate;
        }

        public string OrderID { get; }
        public List<OrderItem> Items { get; }
        public decimal TotalAmount { get; }
        public DateTime OrderDate { get; }
    }

    public struct HealthProfile {
        public HealthProfile(double heightCm, double weightKg, Date dateOfBirth) {
            HeightCm = heightCm;
            WeightKg = weightKg;
            DateOfBirth = dateOfBirth;
        }

        public double HeightCm { get; }
        public double WeightKg { get; }
        public Date DateOfBirth { get; }
    }

    public struct PaymentInfo {
        public PaymentInfo(decimal amount, string method, DateTime date) {
            Amount = amount;
            Method = method;
            Date = date;
        }

        public decimal Amount { get; }
        public string Method { get; }
        public DateTime Date { get; }
    }

    public struct CreditCardInfo {
        public CreditCardInfo(string cardNumber, string cardHolderName, Date expirationDate, int cvv) {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpirationDate = expirationDate;
            Cvv = cvv;
        }

        public string CardNumber { get; }
        public string CardHolderName { get; }
        public Date ExpirationDate { get; }
        public int Cvv { get; }
    }

    public struct InventoryItem {
        public InventoryItem(string itemId, string name, int quantity) {
            ItemId = itemId;
            Name = name;
            Quantity = quantity;
        }

        public string ItemId { get; }
        public string Name { get; }
        public int Quantity { get; }
    }

    public struct GameSettings {
        public GameSettings(int resolutionWidth, int resolutionHeight, bool isFullScreen, int volumeLevel) {
            ResolutionWidth = resolutionWidth;
            ResolutionHeight = resolutionHeight;
            IsFullScreen = isFullScreen;
            VolumeLevel = volumeLevel;
        }

        public int ResolutionWidth { get; }
        public int ResolutionHeight { get; }
        public bool IsFullScreen { get; }
        public int VolumeLevel { get; }
    }

    public struct PlayerStats {
        public PlayerStats(int level, int health, int mana, int experience) {
            Level = level;
            Health = health;
            Mana = mana;
            Experience = experience;
        }

        public int Level { get; }
        public int Health { get; }
        public int Mana { get; }
        public int Experience { get; }
    }

    public struct Achievement {
        public Achievement(string achievementId, string name, string description, bool isUnlocked) {
            AchievementId = achievementId;
            Name = name;
            Description = description;
            IsUnlocked = isUnlocked;
        }

        public string AchievementId { get; }
        public string Name { get; }
        public string Description { get; }
        public bool IsUnlocked { get; }
    }

    public struct Enemy {
        public Enemy(string name, int health, int attackPower) {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Position = position;
        }

        public string Name { get; }
        public int Health { get; }
        public int AttackPower { get; }
    }

    public struct NPC {
        public NPC(string name, string role, string[] dialogue) {
            Name = name;
            Role = role;
            Dialogue = dialogue;
        }

        public string Name { get; }
        public string Role { get; }
        public string[] Dialogue { get; }
    }

    public struct Quest {
        public Quest(string questId, string title, string description, bool isCompleted) {
            QuestId = questId;
            Title = title;
            Description = description;
            IsCompleted = isCompleted;
        }

        public string QuestId { get; }
        public string Title { get; }
        public string Description { get; }
        public bool IsCompleted { get; }
    }

    public struct DialogueLine {
        public DialogueLine(string speaker, string content) {
            Speaker = speaker;
            Content = content;
        }

        public string Speaker { get; }
        public string Content { get; }
    }

    public struct SocialMediaProfile {
        public SocialMediaProfile(string username, int followers, int following, string bio) {
            Username = username;
            Followers = followers;
            Following = following;
            Bio = bio;
        }

        public string Username { get; }
        public int Followers { get; }
        public int Following { get; }
        public string Bio { get; }
    }

    public struct FitnessActivity {
        public FitnessActivity(string activityType, TimeSpan duration, double caloriesBurned, double distanceKm) {
            ActivityType = activityType;
            Duration = duration;
            CaloriesBurned = caloriesBurned;
            DistanceKm = distanceKm;
        }

        public string ActivityType { get; }
        public TimeSpan Duration { get; }
        public double CaloriesBurned { get; }
        public double DistanceKm { get; }
    }

    public struct Expense {
        public Expense(string category, decimal amount, DateTime date, string description) {
            Category = category;
            Amount = amount;
            Date = date;
            Description = description;
        }

        public string Category { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Description { get; }
    }

    public struct Income {
        public Income(string source, decimal amount, DateTime date) {
            Source = source;
            Amount = amount;
            Date = date;
        }

        public string Source { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
    }

    public struct BudgetItem {
        public BudgetItem(string category, decimal allocatedAmount, decimal spentAmount) {
            Category = category;
            AllocatedAmount = allocatedAmount;
            SpentAmount = spentAmount;
        }

        public string Category { get; }
        public decimal AllocatedAmount { get; }
        public decimal SpentAmount { get; }
    }

    public struct Recipe {
        public Recipe(string name, List<Ingredient> ingredients, string instructions) {
            Name = name;
            Ingredients = ingredients;
            Instructions = instructions;
        }

        public string Name { get; }
        public List<Ingredient> Ingredients { get; }
        public string Instructions { get; }
    }

    public struct Ingredient {
        public Ingredient(string name, double quantity, string unit) {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        public string Name { get; }
        public double Quantity { get; }
        public string Unit { get; }
    }

    public struct Alarm {
        public Alarm(TimeSpan time, bool isEnabled, string label) {
            Time = time;
            IsEnabled = isEnabled;
            Label = label;
        }

        public TimeSpan Time { get; }
        public bool IsEnabled { get; }
        public string Label { get; }
    }

    public struct Vehicle {
        public Vehicle(string make, string model, int year, string licensePlate) {
            Make = make;
            Model = model;
            Year = year;
            LicensePlate = licensePlate;
        }

        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public string LicensePlate { get; }
    }

    public struct Pet {
        public Pet(string name, string species, int age) {
            Name = name;
            Species = species;
            Age = age;
        }

        public string Name { get; }
        public string Species { get; }
        public int Age { get; }
    }

    public struct Song {
        public Song(string title, string artist, string album, TimeSpan duration) {
            Title = title;
            Artist = artist;
            Album = album;
            Duration = duration;
        }

        public string Title { get; }
        public string Artist { get; }
        public string Album { get; }
        public TimeSpan Duration { get; }
    }

    public struct Photo {
        public Photo(string fileName, DateTime dateTaken, string location, string description) {
            FileName = fileName;
            DateTaken = dateTaken;
            Location = location;
            Description = description;
        }

        public string FileName { get; }
        public DateTime DateTaken { get; }
        public string Location { get; }
        public string Description { get; }
    }

    public struct Video {
        public Video(string fileName, TimeSpan duration, DateTime dateRecorded, string description) {
            FileName = fileName;
            Duration = duration;
            DateRecorded = dateRecorded;
            Description = description;
        }

        public string FileName { get; }
        public TimeSpan Duration { get; }
        public DateTime DateRecorded { get; }
        public string Description { get; }
    }

    public struct ExpenseReport {
        public ExpenseReport(string reportId, List<Expense> expenses, decimal totalAmount, DateTime submissionDate) {
            ReportId = reportId;
            Expenses = expenses;
            TotalAmount = totalAmount;
            SubmissionDate = submissionDate;
        }

        public string ReportId { get; }
        public List<Expense> Expenses { get; }
        public decimal TotalAmount { get; }
        public DateTime SubmissionDate { get; }
    }

    public struct HealthRecord {
        public HealthRecord(Person person, List<MedicalCondition> conditions, List<Medication> medications) {
            Person = person;
            Conditions = conditions;
            Medications = medications;
        }

        public Person Person { get; }
        public List<MedicalCondition> Conditions { get; }
        public List<Medication> Medications { get; }
    }

    public struct MedicalCondition {
        public MedicalCondition(string name, string description, DateTime diagnosisDate) {
            Name = name;
            Description = description;
            DiagnosisDate = diagnosisDate;
        }

        public string Name { get; }
        public string Description { get; }
        public DateTime DiagnosisDate { get; }
    }

    public struct Medication {
        public Medication(string name, string dosage, string frequency) {
            Name = name;
            Dosage = dosage;
            Frequency = frequency;
        }

        public string Name { get; }
        public string Dosage { get; }
        public string Frequency { get; }
    }

    public struct ToDoItem {
        public ToDoItem(string task, bool isCompleted) {
            Task = task;
            IsCompleted = isCompleted;
        }

        public string Task { get; }
        public bool IsCompleted { get; }
    }

    public struct ShoppingListItem {
        public ShoppingListItem(string itemName, int quantity) {
            ItemName = itemName;
            Quantity = quantity;
        }

        public string ItemName { get; }
        public int Quantity { get; }
    }

    public struct SurveyQuestion {
        public SurveyQuestion(string questionText, string[] options) {
            QuestionText = questionText;
            Options = options;
        }

        public string QuestionText { get; }
        public string[] Options { get; }
    }

    public struct SurveyResponse {
        public SurveyResponse(string respondentId, Dictionary<string, string> answers, DateTime submittedAt) {
            RespondentId = respondentId;
            Answers = answers;
            SubmittedAt = submittedAt;
        }

        public string RespondentId { get; }
        public Dictionary<string, string> Answers { get; }
        public DateTime SubmittedAt { get; }
    }

    public struct Feedback {
        public Feedback(string userId, string comments, int rating) {
            UserId = userId;
            Comments = comments;
            Rating = rating;
        }

        public string UserId { get; }
        public string Comments { get; }
        public int Rating { get; }
    }
}*/