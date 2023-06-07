using Engine.ConsoleManager;
using Engine.Mathmatics;
using Console = Engine.ConsoleManager.Console;

namespace Engine.Renderer
{
    public class Renderer
    {
        public Dictionary<Guid, CharData> characters { get; } = new Dictionary<Guid, CharData>();


        private Dictionary<Guid, CharData> Drawncharacters = new Dictionary<Guid, CharData>();
        public void registerForRender(CharData data)
        {
            if(!characters.ContainsKey(data.id))
            {
                characters.Add(data.id, data);
            }
        }

        public void Render()
        {
            foreach (var item in characters)
            {
                foreach(var charData2 in characters)
                {
                    if(item.Key == charData2.Key)
                    {
                        Draw(item);
                    }
                    else
                    {
                        if (item.Value.Position == charData2.Value.Position)
                        {
                            if(item.Value.layer.id > charData2.Value.layer.id)
                            {
                                Draw(item);
                                Drawncharacters.Remove(charData2.Key);
                            }
                            else
                            {
                                if(item.Value.layer.order > charData2.Value.layer.order)
                                {
                                    Draw(item);
                                    Drawncharacters.Remove(charData2.Key);
                                }
                                else
                                {

                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void Draw(KeyValuePair<Guid, CharData> item)
        {
            if (!Drawncharacters.ContainsKey(item.Value.id))
            {
                Console.Replace(item.Value.Char, item.Value.Color, item.Value.LastPosition, item.Value.Position);
                Drawncharacters.Add(item.Key, item.Value);
            }
            else
            {
                Drawncharacters.TryGetValue(item.Key, out CharData value);
                if (value.Position != value.LastPosition)
                {
                    Console.Replace(item.Value.Char, item.Value.Color, item.Value.LastPosition, item.Value.Position);
                }
            }
        }
    }

    public struct CharData
    {
        public CharData()
        {
            id = Guid.NewGuid();
        }
        public Guid id { get; }
        public int Char { get; set; } = 65533;
        public Layer layer { get; set; } = default;
        public ConsoleColor Color { get; set; } = ConsoleColor.White;
        public Vector2 Position { get; set; } = Vector2.Zero;
        public Vector2 LastPosition { get; set; } = Vector2.Zero;

    }

    public struct Layer
    {
        public Layer()
        {

        }
        public int id { get; set; } = 0;
        public int order { get; set; } = 0;

    }
}
