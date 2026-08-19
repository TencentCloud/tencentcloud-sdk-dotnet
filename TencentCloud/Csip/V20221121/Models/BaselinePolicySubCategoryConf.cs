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

    public class BaselinePolicySubCategoryConf : AbstractModel
    {
        
        /// <summary>
        /// <p>基线子分类 ID。</p>
        /// </summary>
        [JsonProperty("CategoryID")]
        public ulong? CategoryID{ get; set; }

        /// <summary>
        /// <p>是否全选该子分类下所有检测项。true 全选，false 按 ItemIDList 明细生效。</p>
        /// </summary>
        [JsonProperty("AllSelect")]
        public bool? AllSelect{ get; set; }

        /// <summary>
        /// <p>已选的检测项 ID 列表，AllSelect=false 时按此明细生效。</p>
        /// </summary>
        [JsonProperty("ItemIDList")]
        public ulong?[] ItemIDList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryID", this.CategoryID);
            this.SetParamSimple(map, prefix + "AllSelect", this.AllSelect);
            this.SetParamArraySimple(map, prefix + "ItemIDList.", this.ItemIDList);
        }
    }
}

