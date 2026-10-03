-- FRESH INSTALL / CLASSROOM RESET
-- This script recreates registrar_db and loads demonstration data.

CREATE DATABASE IF NOT EXISTS registrar_db
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;
USE registrar_db;

SET FOREIGN_KEY_CHECKS = 0;
DROP TABLE IF EXISTS tblrequestdetails;
DROP TABLE IF EXISTS tblrequest;
DROP TABLE IF EXISTS tblrequestsequence;
DROP TABLE IF EXISTS tbldocuments;
DROP TABLE IF EXISTS tblstudents;
DROP TABLE IF EXISTS tblusers;
SET FOREIGN_KEY_CHECKS = 1;

CREATE TABLE tblusers (
  UserID INT AUTO_INCREMENT PRIMARY KEY,
  Username VARCHAR(50) NOT NULL UNIQUE,
  Password VARCHAR(100) NOT NULL,
  FullName VARCHAR(100) NOT NULL,
  Role ENUM('Administrator','Registrar Staff') NOT NULL,
  Status ENUM('Active','Inactive') NOT NULL DEFAULT 'Active'
);

CREATE TABLE tblstudents (
  StudentID VARCHAR(7) PRIMARY KEY,
  LRN VARCHAR(20),
  LastName VARCHAR(50) NOT NULL,
  FirstName VARCHAR(50) NOT NULL,
  MiddleName VARCHAR(50),
  Course VARCHAR(80),
  YearLevel VARCHAR(20),
  Section VARCHAR(20),
  ContactNo VARCHAR(20),
  Status ENUM('Active','Inactive') NOT NULL DEFAULT 'Active',
  UNIQUE KEY uq_student_lrn (LRN),
  INDEX idx_student_name (LastName, FirstName),
  INDEX idx_student_status (Status)
);

CREATE TABLE tbldocuments (
  DocumentID INT AUTO_INCREMENT PRIMARY KEY,
  DocumentName VARCHAR(100) NOT NULL UNIQUE,
  Description VARCHAR(255),
  Fee DECIMAL(10,2) NOT NULL,
  Status ENUM('Active','Inactive') NOT NULL DEFAULT 'Active',
  CONSTRAINT chk_document_fee CHECK (Fee >= 0)
);

-- One locked row per year supplies request numbers safely.
-- It avoids COUNT(*), so deleted rows and simultaneous users do not duplicate numbers.
CREATE TABLE tblrequestsequence (
  RequestYear INT PRIMARY KEY,
  LastNumber INT NOT NULL DEFAULT 0
);

CREATE TABLE tblrequest (
  RequestID INT AUTO_INCREMENT PRIMARY KEY,
  RequestNo VARCHAR(25) NOT NULL UNIQUE,
  StudentID VARCHAR(7) NOT NULL,
  RequestDate DATE NOT NULL,
  Purpose VARCHAR(150) NOT NULL DEFAULT 'School Requirement',
  TotalAmount DECIMAL(10,2) NOT NULL,
  PaymentStatus ENUM('Unpaid','Paid') NOT NULL DEFAULT 'Unpaid',
  ORNo VARCHAR(50),
  ORDate DATE,
  Status ENUM('Pending','Processing','Ready for Release','Released','Cancelled') NOT NULL DEFAULT 'Pending',
  ReleasedDate DATE NULL,
  CreatedBy INT NOT NULL,
  CONSTRAINT fk_request_student FOREIGN KEY (StudentID) REFERENCES tblstudents(StudentID),
  CONSTRAINT fk_request_user FOREIGN KEY (CreatedBy) REFERENCES tblusers(UserID),
  CONSTRAINT chk_request_total CHECK (TotalAmount >= 0),
  UNIQUE KEY uq_request_orno (ORNo),
  INDEX idx_request_date (RequestDate),
  INDEX idx_request_status (Status),
  INDEX idx_request_payment (PaymentStatus)
);

CREATE TABLE tblrequestdetails (
  RequestDetailID INT AUTO_INCREMENT PRIMARY KEY,
  RequestID INT NOT NULL,
  DocumentID INT NOT NULL,
  Quantity INT NOT NULL,
  Amount DECIMAL(10,2) NOT NULL,
  SubTotal DECIMAL(10,2) NOT NULL,
  CONSTRAINT fk_detail_request FOREIGN KEY (RequestID) REFERENCES tblrequest(RequestID) ON DELETE CASCADE,
  CONSTRAINT fk_detail_document FOREIGN KEY (DocumentID) REFERENCES tbldocuments(DocumentID),
  CONSTRAINT chk_detail_quantity CHECK (Quantity > 0),
  CONSTRAINT chk_detail_amount CHECK (Amount >= 0 AND SubTotal >= 0),
  UNIQUE KEY uq_request_document (RequestID, DocumentID)
);

-- Plain-text passwords are retained only because this is a classroom case study.
INSERT INTO tblusers (Username,Password,FullName,Role) VALUES
('admin','admin123','System Administrator','Administrator'),
('registrar1','staff123','Maria Reyes','Registrar Staff'),
('registrar2','staff123','John Cruz','Registrar Staff');

INSERT INTO tblstudents
(StudentID,LRN,LastName,FirstName,MiddleName,Course,YearLevel,Section,ContactNo) VALUES
('1724-24','100000000001','Dela Cruz','Juan','Santos','BS Information Technology','3','32E1','09171234501'),
('2841-24','100000000002','Santos','Maria','Lopez','BS Information Technology','2','21M2','09171234502'),
('3965-24','100000000003','Garcia','Paolo','Reyes','BS Business Administration','1','12E3','09171234503'),
('4187-24','100000000004','Reyes','Angela','Torres','BS Education','4','42M1','09171234504'),
('5239-24','100000000005','Cruz','Mark','Dizon','BS Information Technology','3','31E2','09171234505'),
('6372-24','100000000006','Mendoza','Liza','Ramos','BS Accountancy','2','22M3','09171234506'),
('7416-24','100000000007','Ramos','Carlo','Diaz','BS Education','1','11M1','09171234507'),
('8563-24','100000000008','Torres','Anne','Lim','BS Information Technology','4','41E2','09171234508'),
('9028-24','100000000009','Lim','Kevin','Tan','BS Business Administration','2','22E1','09171234509'),
('1137-24','100000000010','Tan','Sheila','Go','BS Accountancy','3','32M2','09171234510'),
('2258-24','100000000011','Diaz','Paula','Cruz','BS Education','4','42E3','09171234511'),
('3349-24','100000000012','Go','Ryan','Chua','BS Information Technology','1','12M2','09171234512'),
('4471-24','100000000013','Chua','Erica','Yu','BS Business Administration','3','31M3','09171234513'),
('5684-24','100000000014','Yu','Daniel','Ong','BS Accountancy','4','41M1','09171234514'),
('6795-24','100000000015','Ong','Nina','Sy','BS Education','2','21E3','09171234515');

INSERT INTO tbldocuments (DocumentName,Description,Fee) VALUES
('Transcript of Records','Official academic record',150.00),
('Certificate of Enrollment','Proof of current enrollment',50.00),
('Certificate of Good Moral','Certificate of good moral character',100.00),
('Certification','General registrar certification',50.00),
('Honorable Dismissal','Transfer clearance document',100.00);

INSERT INTO tblrequest
(RequestNo,StudentID,RequestDate,TotalAmount,PaymentStatus,ORNo,ORDate,Status,CreatedBy) VALUES
('REQ-2026-00001','1724-24','2026-08-01',150,'Unpaid',NULL,NULL,'Pending',2),
('REQ-2026-00002','2841-24','2026-08-01',50,'Paid','OR-1002','2026-08-01','Processing',2),
('REQ-2026-00003','3965-24','2026-08-02',100,'Unpaid',NULL,NULL,'Pending',3),
('REQ-2026-00004','4187-24','2026-08-03',150,'Paid','OR-1004','2026-08-03','Processing',2),
('REQ-2026-00005','5239-24','2026-08-03',50,'Paid','OR-1005','2026-08-03','Ready for Release',3),
('REQ-2026-00006','6372-24','2026-08-04',100,'Unpaid',NULL,NULL,'Processing',2),
('REQ-2026-00007','7416-24','2026-08-05',150,'Paid','OR-1007','2026-08-05','Ready for Release',2),
('REQ-2026-00008','8563-24','2026-08-05',50,'Paid','OR-1008','2026-08-05','Ready for Release',3),
('REQ-2026-00009','9028-24','2026-08-06',100,'Paid','OR-1009','2026-08-06','Released',2),
('REQ-2026-00010','1137-24','2026-08-07',150,'Paid','OR-1010','2026-08-07','Released',2),
('REQ-2026-00011','2258-24','2026-08-07',50,'Paid','OR-1011','2026-08-07','Released',3),
('REQ-2026-00012','3349-24','2026-08-08',100,'Paid','OR-1012','2026-08-08','Released',2),
('REQ-2026-00013','4471-24','2026-08-09',150,'Unpaid',NULL,NULL,'Cancelled',3),
('REQ-2026-00014','5684-24','2026-08-09',50,'Unpaid',NULL,NULL,'Cancelled',2),
('REQ-2026-00015','6795-24','2026-08-10',100,'Unpaid',NULL,NULL,'Cancelled',3);

INSERT INTO tblrequestdetails (RequestID,DocumentID,Quantity,Amount,SubTotal)
SELECT RequestID,
       CASE WHEN TotalAmount=150 THEN 1 WHEN TotalAmount=50 THEN 2 ELSE 3 END,
       1, TotalAmount, TotalAmount
FROM tblrequest;

UPDATE tblrequest SET ReleasedDate=RequestDate
WHERE Status='Released' AND ReleasedDate IS NULL;

INSERT INTO tblrequestsequence (RequestYear, LastNumber) VALUES (2026, 15);
