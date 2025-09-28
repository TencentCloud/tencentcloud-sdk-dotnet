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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlashbackCollection : AbstractModel
    {
        
        /// <summary>
        /// 指定按 Key 闪回源数据库集合名。
        /// </summary>
        [JsonProperty("CollectionName")]
        public string CollectionName{ get; set; }

        /// <summary>
        /// 指定按 Key 闪回目标数据库集合名。
        /// </summary>
        [JsonProperty("TargetResultCollectionName")]
        public string TargetResultCollectionName{ get; set; }

        /// <summary>
        /// 指定用于过滤按 Key 闪回的 Key（键）。
        /// </summary>
        [JsonProperty("FilterKey")]
        public string FilterKey{ get; set; }

        /// <summary>
        /// 指定用于按 Key 闪回的键值对。数组元素最大限制为 50000。
        /// </summary>
        [JsonProperty("KeyValues")]
        public FBKeyValue[] KeyValues{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CollectionName", this.CollectionName);
            this.SetParamSimple(map, prefix + "TargetResultCollectionName", this.TargetResultCollectionName);
            this.SetParamSimple(map, prefix + "FilterKey", this.FilterKey);
            this.SetParamArrayObj(map, prefix + "KeyValues.", this.KeyValues);
        }
    }
}

