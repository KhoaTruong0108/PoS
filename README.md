# PoS
Pos window application using for management a store or shop.
This project was developed based on mainly C#, window form and Entity Framework.

Deloyment instruction

Requirements:

    .Net framework 4.5
    MSSQL Server
    Window XP, Vista, 7, 8, 10.

Setup environment

    Install .Net framework 4.5
    Install MSSQL server experess

Configure project

    Change connectionString in config files for appropriate roles: Manager & Staff
    (..\lhk.Pos.Manager\App.config  && ..\lhk.Pos\App.config).

Run App

    Run Application files (.exe) and make sure connectionString is correct
    Database will be created automatically.

Notes:

    Add new features in next version:
      Develop server to communicate with multiple POS.
      Add more reports.
