# ETV Book Library

A bilingual (English/Bangla) desktop library management system built for Ekushey Television's internal office library — cataloging books, managing categories, and tracking which staff member currently has each book checked out.

**Organization:** Ekushey Television Limited
**Tech Stack:** C# (WinForms, MDI application) · Microsoft SQL Server

---

## What it does

The office library needs to track its physical book collection and who currently has each book borrowed. This application covers that end-to-end:

- **Catalog books** with bilingual metadata (English and Bangla title/author), publisher, publish date, shelf location, and received date
- **Organize by category**, with bilingual category names
- **Search the catalog** by book name, author, or category (English or Bangla)
- **Track issue/return status** — mark a book as issued to a staff member and receive it back, with a running history of who has borrowed it and when
- **Look up staff directly from the company HR system** when issuing a book, rather than maintaining a duplicate employee list

---

## Features by Module

### 📚 Book Catalog (`frmBookList`, `frmEditor`)
- List and search all books, filterable by `BookName`, `BookNameBangla`, `BookAuthor`, `BookAuthorBangla`, or `BookCategory`
- Add/edit book records with auto-generated sequential Book IDs
- Bangla text fields render in the **Kalpurush** font for correct display

### 🏷️ Category Management (`frmCategory`)
- Add/edit book categories (English + Bangla name, remarks)
- Categories are referenced from the book editor via a `[CategoryID]CategoryName` combo-box format

### 🔄 Issue / Receive Workflow (`frmIssue`)
- Issue a book to a staff member or receive a returned book, with the current `BookStatus` (`Issued` / available) driving which action the form offers
- **Cross-database employee lookup:** typing a name queries the organization's separate HR database (`EmpInfo` table) directly — pulling `EmpID`, department, and designation — so the library system doesn't need its own duplicate staff directory
- Maintains a per-book issue history (`tblIssue`) shown alongside each book

### 🖥️ Application Shell
- MDI parent window (`mdiMain`) hosting each module as a child window, with a splash screen on startup
- Menu-driven navigation (View Book List, Add New Book, Category, Exit)

---

## Database

The application connects to two separate SQL Server databases:

| Database | Purpose |
|---|---|
| `ETVBookLibraryT` | The library system's own data — `tblBookList`, `tblCategory`, `tblIssue` |
| `hrnew` (shared HR database) | Read-only lookups against `EmpInfo` for staff name/department/designation during book issue |

**Known tables (inferred from the code):**

| Table | Key columns |
|---|---|
| `tblBookList` | `BookID`, `BookName`, `BookNameBangla`, `BookAuthor`, `BookAuthorBangla`, `Publisher`, `PublishDate`, `BookCategory`, `BookCategoryID`, `BookLocation`, `ReceivedDate`, `BookStatus`, `Remarks`, `InputDate`, `InputBy` |
| `tblCategory` | `CID`, `CategoryName`, `CategoryNameBangla`, `Remarks` |
| `tblIssue` | `IID`, `BookID`, `BookName`, `EmpID`, `EmpName`, `DeptName`, `Designation`, `Remarks`, `IssueDate`, `IssuedBy`, `InputBy`, `InputDate` |

> No `.sql` schema script is included in this repository — the tables above are reconstructed from the queries in the application code, not from a DDL script.

---

## Repository Contents

| Path | Description |
|---|---|
| `ETV Book Library C-Sherp/` | C# WinForms application source |
| `ETV Book Library C-Sherp/clsDBConn.cs` | Lightweight ADO.NET wrapper (`SqlConnection`/`SqlCommand`/`SqlDataAdapter`) used throughout the app for querying |
| `ETV Book Library C-Sherp/clsConnString.cs` | Static connection strings for the library DB and the shared HR DB |
| `ETV Book Library C-Sherp/frm*.cs` | One form per module: book list, editor, category, issue/receive, login, splash, MDI shell |
| `ETV Book Library C-Sherp.sln` | Visual Studio solution file |

## Getting Started

1. Provision an `ETVBookLibraryT` database with the tables described above (matching the columns referenced in `frmEditor.cs`, `frmCategory.cs`, and `frmIssue.cs`).
2. Update `clsConnString.cs` with your own SQL Server host, credentials, and (if used) HR database connection.
3. Open `ETV Book Library C-Sherp.sln` in Visual Studio and build.
4. Run the application — it starts on `mdiMain` with a splash screen, then use the menu to open **View Book List**, **Add New Book**, or **Category**.

---

## Notes for Future Development

This project reflects an early/internal-tool stage of development, worth being upfront about if you're extending it:

- **Connection strings are hardcoded in source** (`clsConnString.cs`, `clsDBConn.cs`) with a live host/credentials — before any public deployment or further sharing, these should move to `App.config`/a secrets store and be rotated.
- **Some queries build SQL by string concatenation** (e.g. the book/category search boxes, the HR employee lookup by name) rather than parameters, which is a SQL-injection risk; the insert/update paths elsewhere in the app already use parameterized `SqlCommand.Parameters`, so the fix is to bring the search paths in line with that pattern.
- **Login is currently a stub** — `frmLogin` has no authentication logic wired up yet, and the "current user" (`InputBy`/`IssuedBy`) is read directly from a textbox on the main form rather than a real session.
- **Issue ID generation** uses a `MAX(IID) + 1` read-then-insert pattern, which can collide under concurrent use; an `IDENTITY` column (as `tblBookList`/category tables likely already use) would be more robust.

---

## Author

**Ariful Islam Emon**
[Portfolio](https://www.arifulemon.com) · [LinkedIn](https://www.linkedin.com/in/ariful-islam-emon-b4134667/) · [GitHub](https://github.com/emonbd)
