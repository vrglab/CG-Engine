using System;
using System.Collections;
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

        public void Render()
        {
            foreach (var item in Layers)
            {
                item.Value.Render();
            }
        }
    }

    public struct Layer
    {
        public SortedDictionary<int, CharData> charsToBeDrawn = new SortedDictionary<int, CharData>();

        public Layer()
        {
        }

        public Dictionary<int, CharData> GetSortedLayer()
        {
            Dictionary<int, CharData> dict = new Dictionary<int, CharData>();
            foreach (KeyValuePair<int, CharData> charr in charsToBeDrawn.OrderBy(key => key.Key))
            {
                dict.Add(charr.Key, charr.Value);
            }
            return dict;
        }

        public void Render()
        {
            Dictionary<int, CharData> dict1 = GetSortedLayer();
            Dictionary<int, CharData> dict2 = GetSortedLayer();
            Dictionary<Vector2, OverlayerResult> DrawnPositions = new Dictionary<Vector2, OverlayerResult>();
            foreach (var item in dict1)
            {
                foreach (var item2 in dict2)
                {
                    if(item.Value.LastPosition == item2.Value.LastPosition)
                    {
                        if(item.Key > item2.Key)
                        {
                            Console.Replace(item.Value.Char, item.Value.Color, item2.Value.LateLastPosition, item.Value.LastPosition);
                        }
                        else
                        {
                            Console.Replace(item2.Value.Char, item2.Value.Color, item2.Value.LateLastPosition, item2.Value.LastPosition);
                        }
                        try
                        {
                            DrawnPositions.Add(item.Value.LastPosition, new OverlayerResult()
                            {
                                cd1 = item.Value,
                                cd2 = item2.Value
                            });
                        } catch(Exception ex)
                        {

                        }
                        
                    }
                    else
                    {
                        Console.Replace(item.Value.Char, item.Value.Color, item2.Value.LateLastPosition, item.Value.LastPosition);
                        try
                        {
                            DrawnPositions.Add(item.Value.LastPosition, new OverlayerResult()
                            {
                                cd1 = item.Value
                            });
                        } catch (Exception e)
                        {

                        }
                        
                    }
                }
            }
        }
    }

    public struct CharData
    {
        public CharData()
        {
        }

        public int Char { get; init; } = 65533;
        public ConsoleColor Color { get; init; } = ConsoleColor.White;
        public Vector2 LastPosition { get; init; } = Vector2.Zero;
        public Vector2 LateLastPosition { get; init; } = Vector2.Zero;

    }

    public struct OverlayerResult
    {
        public CharData cd1;
        public CharData cd2;
    }
}
