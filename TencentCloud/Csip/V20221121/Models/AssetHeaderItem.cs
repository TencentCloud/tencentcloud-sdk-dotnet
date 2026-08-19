/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetHeaderItem : AbstractModel
    {
        
        /// <summary>
        /// <p>类型</p>
        /// </summary>
        [JsonProperty("ItemType")]
        public string ItemType{ get; set; }

        /// <summary>
        /// <p>展示</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// <p>是否支持复制</p>
        /// </summary>
        [JsonProperty("Copy")]
        public ulong? Copy{ get; set; }

        /// <summary>
        /// <p>值对应字段键</p>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// <p>跳转URL</p>
        /// </summary>
        [JsonProperty("LinkURL")]
        public string LinkURL{ get; set; }

        /// <summary>
        /// <p>过滤器</p>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilterConfig[] Filters{ get; set; }

        /// <summary>
        /// <p>是否支持排序</p>
        /// </summary>
        [JsonProperty("Sort")]
        public ulong? Sort{ get; set; }

        /// <summary>
        /// <p>字段展示样式</p>
        /// </summary>
        [JsonProperty("ValueStyle")]
        public string ValueStyle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemType", this.ItemType);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Copy", this.Copy);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "LinkURL", this.LinkURL);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "ValueStyle", this.ValueStyle);
        }
    }
}

