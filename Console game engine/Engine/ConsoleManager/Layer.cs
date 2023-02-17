using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mathmatics;

namespace Engine.ConsoleManager.Layering
{
    public class LayerManager
    {
        public int LayerCount { get; private set; }
        public Dictionary<int, Layer> Layers { get; private set; } = new Dictionary<int, Layer>();

        public LayerManager(int layerAmnt = 1)
        {
            LayerCount = layerAmnt;

            for (int i = 0; i < LayerCount; i++)
            {
                Layers.Add(i, new Layer());
            }
        }

        public void PutInLayer(int layer, DrawChar ch)
        {
            Layers.GetValueOrDefault(layer).DrawnChar.Add(ch);
        }

        public void RemoveFromLayer(int layer, Vector2 pos)
        {
            DrawChar toremove = new DrawChar();
            foreach (var chars in Layers.GetValueOrDefault(layer).DrawnChar)
            {
                if (chars.Pos == pos)
                {
                    toremove = chars;
                }
            }

            Layers.GetValueOrDefault(layer).DrawnChar.Remove(toremove);
        }

        public List<MatchResult> FindOverlays()
        {
            List<MatchResult> result = new List<MatchResult>();
            foreach (var layer in Layers)
            {
                foreach (var layer2 in Layers)
                {
                    foreach (var layer1Chars in layer.Value.DrawnChar)
                    {
                        foreach (var layer2Chars in layer2.Value.DrawnChar)
                        {
                            if (layer1Chars.Pos == layer2Chars.Pos)
                            {
                                result.Add(new MatchResult()
                                {
                                    Char1 = layer1Chars,
                                    Char2 = layer2Chars,
                                    SharedPos = layer1Chars.Pos
                                });
                            }
                        }
                    }
                }
            }

            return result;
        }

        public int GetCharAtPos(Vector2 pos, int layer)
        {
            foreach (var chars in Layers.GetValueOrDefault(layer).DrawnChar)
            {
                if (chars.Pos == pos)
                {
                    return chars.Char;
                }
            }

            return 65533;
        }

        public string GetTextAtPos(Vector2 pos, int layer)
        {
            foreach (var chars in Layers.GetValueOrDefault(layer).DrawnChar)
            {
                if (chars.Pos == pos)
                {
                    return chars.Text;
                }
            }

            return String.Empty;
        }

        public List<DrawChar> getTotalChar()
        {
            List<DrawChar> result = new List<DrawChar>();
            foreach (var layer in Layers)
            {
                foreach (var chars in layer.Value.DrawnChar)
                {
                    result.Add(chars);
                }
            }
            return result;
        }
    }

    public struct Layer
    {
        public List<DrawChar> DrawnChar = new List<DrawChar>();

        public Layer()
        {

        }
    }

    public struct DrawChar
    {
        public int Char { get; } //For UTF-16 based writer
        public string Text { get; } // For full text writer
        public Vector2 Pos { get; }
        public ConsoleColor Color { get;  }
        public int Layer { get; }

        public DrawChar(int Char, string text, Vector2 Pos, ConsoleColor color,int layer)
        {
            this.Char = Char;
            this.Text = text;
            this.Pos = Pos;
            Color = color;
            Layer = layer;
        }
    }

    public struct MatchResult
    {
        public DrawChar Char1;
        public DrawChar Char2;
        public Vector2 SharedPos;
    }
}
