// 移除直接注册 IDbConnection
// services.AddTransient<IDbConnection>(sp => new SqlConnection(configuration.GetConnectionString("DefaultConnection")));

// 改为注册连接字符串
services.AddSingleton<string>(sp => configuration.GetConnectionString("DefaultConnection"));