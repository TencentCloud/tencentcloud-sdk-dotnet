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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Item : AbstractModel
    {
        
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("ItemId")]
        public long? ItemId{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("ItemName")]
        public string ItemName{ get; set; }

        /// <summary>
        /// 自定义阈值
        /// </summary>
        [JsonProperty("CustomItemValues")]
        public ulong?[] CustomItemValues{ get; set; }

        /// <summary>
        /// 检测项所属分类
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "ItemName", this.ItemName);
            this.SetParamArraySimple(map, prefix + "CustomItemValues.", this.CustomItemValues);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
        }
    }
}

