using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PDF_Data
{
    public class FieldModel
    {
        [JsonIgnore]
        public string Id { get; set; }
        public enum DataTypes { ROWS, FIXED }
        public string Name { get; set; }
        public DataTypes Type { get; set; }
        [JsonIgnore]
        public Rectangle DataRegion { get; set; }
        [JsonIgnore]
        public string[] Data { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public static string[] GetTypes()
        {
            return Enum.GetNames(typeof(DataTypes));
        }

        public static string GetFieldsjason(List<FieldModel> fields)
        {
            return JsonSerializer.Serialize(fields);
        }

        public static List<FieldModel> GetListFromJson(string json)
        {
            return JsonSerializer.Deserialize<List<FieldModel>>(json);
        }

        [JsonConstructor]
        public FieldModel(string name, int x, int y, int width, int height, DataTypes type, int firstPage = 1, int lastPage = -1)
        {
            Name = name;
            FirstPage = firstPage;
            LastPage = lastPage;
            Type = type;
            X = x;
            Y = y;
            Width = width;
            Height = height;
            DataRegion = new Rectangle(x, y, width, height);
        }

        public FieldModel(string name, Rectangle rect , DataTypes type, string[] data, string id, int firstPage = 1, int lastPage = -1)
        {
            Name = name;
            FirstPage = firstPage;
            LastPage = lastPage;
            Type = type;
            X = rect.X;
            Y = rect.Y;
            Width = rect.Width;
            Height = rect.Height;
            DataRegion = rect;
            Data = data;
            Id = id;
        }
    }
}
