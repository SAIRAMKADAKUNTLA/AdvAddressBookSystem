create database AddressBookService;
use AddressBookService;
create table Address_Book
(
first_name varchar(255),
last_name varchar(255),
address varchar(255),
city varchar(255),
state varchar(255),
zipcode int,
phone_number varchar(255),
email_id varchar(255),
);
insert into Address_Book
values('Ranjith','Kumar','Nehuru street','Mumbai','Maharastra','400768','7546637878','ranjith@gmail.com'),
('Mohan','Reddy','Balaji Street','Vizag','Andhrapradesh','500036','7644566278','mohan@gmail.com'),
('Madhu','Reddy','abc Street','Vizayawada','Andhrapradesh','500056','7644565778','madhu@gmail.com'),
('John','Wick','def Street','Banglore','Karnataka','500066','7645676278','john@gmail.com'),
('Martin','Guptill','hij Street','Indore','Punjab','505536','7644564568','martin@gmail.com')
select * from Address_Book
update Address_Book set first_name='Raj'where first_name='Ranjith';
delete from Address_Book where first_name='Raj';

select * from Address_Book where city='Banglore' or state='Karnataka';

select count(city) from Address_Book;
SELECT count(state) from Address_Book;

select * from Address_Book where city='Banglore' order by first_name asc;
select * from Address_Book where city='Banglore' order by first_name desc;
