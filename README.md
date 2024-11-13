# AutoUnion
The **Auto-Rickshaw Union Portal**, or **AutoUnion**, is a responsive, web-based solution designed to empower auto-rickshaw drivers by reducing complexities in organizing and managing their operations. Serving as a centralized hub, AutoUnion simplifies membership management, grievance handling, document storage, payment processing, and community engagement, enabling drivers to communicate effectively and advocate for their interests. The platform offers easy access to essential resources such as legal documents and financial management tools, fostering a supportive environment that strengthens the driver community. Built with HTML, CSS, PHP, and MySQL, AutoUnion provides a seamless user experience across devices, enhancing accessibility and operational efficiency for drivers.

## Auto-Rickshaw Union Portal
## Introduction
The Auto-Rickshaw Union Portal addresses the challenges faced by auto-rickshaw drivers and union administrators, offering a unified platform that fosters community building, transparency, and operational efficiency. Drivers can access critical resources, raise issues, and participate in union activities.

## Features

- **Seamless Registration and Membership Management**: Register new drivers, manage renewals, and track membership details.
- **Grievance Redressal**: Submit and track grievances for prompt resolution.
- **Document Management**: Access important documents like licenses and permits directly from the platform.
- **News & Announcements**: Receive timely updates on union activities and policies.
- **Payment Gateway**: Securely process union-related payments.
- **Community Forum**: Participate in discussions, post feedback, and connect with other members.

## Screenshots

- **Home Page**: Overview of union services.
- **Driver Dashboard**: Access to individual account features.
- **Admin Dashboard**: Control center for union administrators.
- **Grievance Submission**: Platform to report issues.
- **Document Center**: Access essential permits and documents.

## Installation

1. **Install XAMPP**: Install XAMPP for Apache server and MySQL database.
2. **Database Setup**:
   - Import the database schema from `/db/DB_AUTO_UNION.sql` into MySQL.
3. **Configuration**:
   - Update `config.php` with database credentials to ensure proper connection.
4. **Start the Application**:
   - Run Apache and MySQL through XAMPP.
   - Access the application at `http://localhost/auto-rickshaw-union-portal`.

## Usage

- **Drivers**: Register, access news, submit grievances, and manage membership.
- **Union Admins**: Oversee membership, resolve grievances, update documents, and make announcements.
- **Community Engagement**: Participate in discussions, feedback submissions, and community events.

## Project Structure

Auto-Rickshaw-Union-Portal/ ─ src/ ─ index.php, grievance.php, ... 
│ db/ ─ DB_AUTO_UNION.sql │ assets/ ─ images/, css/ │
docs/ ─ Documentation.pdf │ tests/ ─ test_cases.md │ README.md │ LICENSE

## Technologies Used

- **Frontend**: HTML, CSS, Bootstrap
- **Backend**: PHP
- **Database**: MySQL
- **Development Environment**: XAMPP

## Database Schema

- **tblDrivers**: Stores driver information and membership details.
- **tblGrievances**: Records grievances submitted by drivers.
- **tblAdmins**: Manages union administrators.
- **tblDocuments**: Stores documents accessible to drivers.

For detailed ER diagrams, refer to `/docs/Documentation.pdf`.

## Future Enhancements

- **Real-Time Chat**: Enable drivers to communicate with union representatives directly.
- **E-Learning Resources**: Training modules for skill development and safety protocols.
- **Driver Feedback System**: Allow passengers to provide feedback for service quality.
- **Expanded Payment Options**: Integrate additional digital payment gateways.
- **Multi-language Support**: Accommodate diverse language preferences for better accessibility.

## Contributing

1. Fork the repository.
2. Create a new branch for your feature (`git checkout -b feature-name`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Open a Pull Request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.
