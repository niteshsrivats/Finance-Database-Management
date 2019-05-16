CREATE TABLE scholarship_type(
    scholarship_id VARCHAR(9) PRIMARY KEY,
    scholarship_name VARCHAR(255) NOT NULL
);

CREATE TABLE student_info(
    usn VARCHAR(10) PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    dob DATE NOT NULL,
    graduation_year INT NOT NULL,
    hostel_id INT DEFAULT NULL
);

CREATE TABLE student_transaction(
    usn VARCHAR(10),
    type VARCHAR(255) NOT NULL,
    time TIMESTAMP NOT NULL,
    amount INT NOT NULL,
    transaction_id INT PRIMARY KEY,
    FOREIGN KEY(usn) REFERENCES student_info(usn)
);

CREATE TABLE scholarship_transaction(
    scholarship_id VARCHAR(9),
    usn VARCHAR(10),
    transaction_id INT PRIMARY KEY,
    time TIMESTAMP NOT NULL,
    amount INT NOT NULL,
    FOREIGN KEY(scholarship_id) REFERENCES scholarship_type(scholarship_id),
    FOREIGN KEY (usn) REFERENCES student_info(usn)
);

CREATE TABLE staff_info(
    employee_id VARCHAR(7) PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    type VARCHAR(255) NOT NULL,
    join_date DATE NOT NULL,
    designation VARCHAR(255) NOT NULL
);

CREATE TABLE staff_transaction(
    employee_id VARCHAR(7) NOT NULL,
    type VARCHAR(255) NOT NULL,
    time TIMESTAMP NOT NULL,
    amount INT NOT NULL,
    transaction_id INT PRIMARY KEY,
    FOREIGN KEY(employee_id) REFERENCES staff_info(employee_id)
);

CREATE SEQUENCE transaction_id_sequence
  START WITH 1
  INCREMENT BY 1
  CACHE 100;

CREATE SEQUENCE hostel_id_sequence
  START WITH 1
  INCREMENT BY 1
  CACHE 10;

CREATE OR REPLACE TRIGGER student_transaction_trigger
  BEFORE INSERT ON student_transaction
  FOR EACH ROW
BEGIN
  :new.transaction_id := transaction_id_sequence.nextval;
END;
/

CREATE OR REPLACE TRIGGER staff_transaction_trigger
  BEFORE INSERT ON staff_transaction
  FOR EACH ROW
BEGIN
  :new.transaction_id := transaction_id_sequence.nextval;
END;
/

CREATE OR REPLACE TRIGGER scholar_transaction_trigger
  BEFORE INSERT ON scholarship_transaction
  FOR EACH ROW
BEGIN
  :new.transaction_id := transaction_id_sequence.nextval;
END;
/
