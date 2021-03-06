﻿using System.Linq;
using Newtonsoft.Json;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils;

namespace VkNet.Model.RequestParams
{
    /// <summary>
    /// Параметры запроса Video.GetCatalog
    /// </summary>
    public class VideoGetCatalogParams
    {
        /// <summary>
        /// Число блоков каталога, информацию о которых необходимо вернуть.
        /// Обратите внимание, параметр распространяется только на блоки other. 
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }
        
        /// <summary>
        /// Число видеозаписей в каждом блоке. 
        /// </summary>
        [JsonProperty("items_count")]
        public long? ItemsCount { get; set; }
        
        /// <summary>
        /// Параметр для получения следующей страницы результатов.
        /// Значение, необходимое для передачи в этом параметре, возвращается в поле ответа next.
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }
        
        /// <summary>
        /// 1 — в ответе будут возвращены дополнительные поля profiles и groups,
        /// содержащие информацию о пользователях и сообществах.
        /// По умолчанию: 0. 
        /// </summary>
        [JsonProperty("extended")]
        public bool? Extended { get; set; }
        
        /// <summary>
        /// id блоков, которые необходимо вернуть в ответе. 
        /// </summary>
        [JsonProperty("filters")]
        public VideoCatalogFilters Filters { get; set; }
        
        /// <summary>
        /// Привести к типу VkParameters.
        /// </summary>
        /// <param name="p">Параметры.</param>
        /// <returns></returns>
        public static VkParameters ToVkParameters(VideoGetCatalogParams p)
        {
            var parameters = new VkParameters
            {
                {"items_count", p.ItemsCount},
                { "count", p.Count },
                { "extended", p.Extended },
                {"from", p.From},
                {"filters", p.Filters}
            };

            return parameters;
        }
    }
}