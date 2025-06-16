# Solutions to Problems Encountered During Development

## Week 1: Database Setup and Initial Queries
- **Problem:** Difficulty in defining relationships between tables.
  - **Solution:** Utilized foreign keys to establish relationships between Payments, Customers, and Products. Ensured referential integrity by enforcing constraints.

- **Problem:** Inserting sample data was cumbersome.
  - **Solution:** Created a script (`insert_sample_data.sql`) that automates the insertion of sample records into the database, making it easier to test queries.

## Week 2: CRUD Operations and Complex Queries
- **Problem:** Basic CRUD operations were not functioning as expected.
  - **Solution:** Reviewed SQL syntax and ensured that all necessary fields were included in the INSERT, UPDATE, and DELETE statements. Implemented error handling to catch and log issues.

- **Problem:** Complex joins were returning unexpected results.
  - **Solution:** Analyzed the join conditions and adjusted them to ensure proper linking of tables. Created a separate SQL file (`complex_joins.sql`) to test and validate these queries.

## Week 3: Stored Procedures and Views
- **Problem:** Performance issues with frequently run queries.
  - **Solution:** Developed stored procedures to encapsulate complex logic and reduce the number of calls to the database. This improved performance and maintainability.

- **Problem:** Difficulty in accessing aggregated data.
  - **Solution:** Created views (`payment_views.sql`) that simplify access to aggregated data, allowing for easier reporting and analysis.

## Week 4: Optimization and Documentation
- **Problem:** Queries were running slowly, leading to timeouts.
  - **Solution:** Analyzed execution plans and identified missing indexes. Created an indexing strategy in `payment_indexes.sql` to enhance query performance.

- **Problem:** Lack of documentation for solutions implemented.
  - **Solution:** Documented all solutions and optimizations in this file to provide a reference for future development and maintenance.