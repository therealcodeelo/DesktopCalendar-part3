using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace DesktopCalendar
{
    class CodeeloSQL
    {
        public static readonly string CONNECTION_STRING = @"Data Source = " + Environment.CurrentDirectory
            + @"\Calendar.db; Version=3;";
        private static SQLiteConnection _connection;
        private static SQLiteCommand _command;

        public static List<Appointment> GetAppointments(DateTime date)
        {
            var appointments = new List<Appointment>();
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                _command.CommandText = $"Select * from Appointments where EndDate like '{date.ToString("yyyy-MM-dd")}'";
                var reader = _command.ExecuteReader();
                while(reader.Read())
                {
                    var appointment = new Appointment();

                    appointment.ID = int.Parse(reader["ID"].ToString());
                    appointment.Title = reader["Title"].ToString();
                    appointment.Description = reader["Description"].ToString();
                    appointment.EndDate = Convert.ToDateTime(reader["EndDate"].ToString());
                    appointment.IsCompleted = Convert.ToBoolean(reader["IsCompleted"]);
                    appointment.Result = reader["ID"].ToString();
                    appointments.Add(appointment);
                }
            }
            return appointments;
        }

        public static void AddAppointment(Appointment appointment)
        {
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                _command.CommandText = "Insert into Appointments(Title,Description,EndDate,IsCompleted)" +
                    $"values('{appointment.Title}','{appointment.Description}','{appointment.EndDate.ToString("yyyy-MM-dd")}',0)";
                _command.ExecuteNonQuery();
            }
        }
        public static void UpdateAppointment(Appointment appointment)
        {
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                if(appointment.IsCompleted)
                {
                    _command.CommandText = $"update Appointments set Title='{appointment.Title}',Description='{appointment.Description}'," +
                        $"EndDate='{appointment.EndDate.ToString("yyyy-MM-dd")}',IsCompleted=1, Result = '{appointment.Result}' where ID={appointment.ID}";
                }
                else
                {
                    _command.CommandText = $"update Appointments set Title='{appointment.Title}',Description='{appointment.Description}'," +
                        $"EndDate='{appointment.EndDate.ToString("yyyy-MM-dd")}' where ID={appointment.ID}";
                }
                
                _command.ExecuteNonQuery();
            }
        }

        public static int GetNextAppointmentID()
        {
            using (_connection = new SQLiteConnection(CONNECTION_STRING))
            {
                _connection.Open();
                _command = new SQLiteCommand();
                _command.Connection = _connection;
                _command.CommandText = "select seq from sqlite_sequence where name like 'Appointments'";
                return (Convert.ToInt32(_command.ExecuteScalar()) + 1);
            }
        }
    }
}
