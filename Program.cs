// �Ƴ�ֱ��ע�� IDbConnection
// services.AddTransient<IDbConnection>(sp => new SqlConnection(configuration.GetConnectionString("DefaultConnection")));

// ��Ϊע�������ַ���
services.AddSingleton<string>(sp => configuration.GetConnectionString("DefaultConnection"));