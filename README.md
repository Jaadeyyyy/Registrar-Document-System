# Registrar Document Request System

Beginner-friendly VB.NET WinForms and MySQL project based on the Registrar Document Request System case study. The code uses simple forms, modules, SQL helpers, and event handlers so each part can be explained during a defense.

## Setup

1. In MySQL Workbench (or phpMyAdmin / MySQL CLI), import and execute `registrar_db.sql`. This creates the `registrar_db` database, all required tables, sequences, and sample data.
2. Open `RegistrarDocumentRequestSystem.slnx` in Visual Studio 2022 and allow NuGet to restore `MySql.Data`.
3. Start MySQL, build, and run the project.
4. Sign in with `admin` / `admin123` or `registrar1` / `staff123`.

## Database connection settings

The defaults are `localhost`, port `3306`, database `registrar_db`, user `root`, and a blank password. Nothing needs to change for that common classroom setup.

For another setup, define any of these Windows environment variables before starting Visual Studio:

```text
REGISTRAR_DB_SERVER
REGISTRAR_DB_PORT
REGISTRAR_DB_NAME
REGISTRAR_DB_USER
REGISTRAR_DB_PASSWORD
```

This keeps machine-specific connection details out of the source code. `Database.vb` builds and uses the connection consistently.

## Included functions

- Parameterized login for Administrator and Registrar Staff accounts
- Student add, edit, search, and activate/deactivate
- Inline messages directly below missing or invalid student, user, and sign-in fields
- Dropdown choices for Course, Year Level, and Section, including Afternoon (`A`) schedules such as `31A1`
- Exact validation for 12-digit LRN, 11-digit contact number, `####-##` Student ID, and sections such as `12E1` or `31A1`
- Database-driven document add, edit, search, fee, and activate/deactivate (Administrator maintenance)
- Multi-document request with quantity, fee snapshot, automatic total, and duplicate-item merging
- Searchable, scrollable active-student name selector with typed suggestions
- Required request purpose and a printable request slip after saving
- Request-slip access from Request List and the compact Recent Request Slips area on Documents
- Transaction-safe request header/details saving
- Yearly request sequence that does not depend on `COUNT(*)`
- Request search and item/detail view
- Payment recording that is automatically marked Paid when saved, plus the forward status flow:
  `Pending -> Processing -> Ready for Release -> Released`
- Cancellation before release; terminal Released/Cancelled records cannot be moved backward
- Date-filtered all, pending, released, and payments-collected reports
- Administrator-only user add, edit, search, password change, and activate/deactivate
- Centralized registrar-style colors and reusable control styling in `Theme.vb`
- EmpowerED-inspired navy, gold, white-card styling with lighter navigation, page markers, and color-coded statuses
- Content-sized tables that avoid large empty grid areas when only a few records exist

Student IDs use four randomized digits followed by the two-digit enrollment year, such as `1724-24`. Sections use year + semester + schedule (`E` or `M`) + section number, such as `12E1`.

The supplied 15 students use unique randomized `####-24` IDs. They are fixed sample values rather than being regenerated on every database reset, which keeps request foreign keys predictable and valid.

## Defense notes

- Document names and fees come from `tbldocuments`; they are not repeated in the request form code.
- A transaction saves the request, its details, and its generated number as one unit. On an error, all those changes roll back.
- `tblrequestsequence` prevents duplicate numbers when multiple staff members save at nearly the same time.
- Activate/deactivate is used instead of deleting referenced records, preserving request history.
- Parameters keep user-entered values separate from SQL commands.
- The generated request slip is printable or can be saved through Windows' Microsoft Print to PDF printer. It clearly states that it is not an official receipt.
- Plain-text sample passwords are retained only to match the classroom scope. A real deployed system should hash passwords and apply stronger security controls.
