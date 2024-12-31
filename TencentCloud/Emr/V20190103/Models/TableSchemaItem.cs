/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableSchemaItem : AbstractModel
    {
        
        /// <summary>
        /// 列标识
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否可按该列排序
        /// </summary>
        [JsonProperty("Sortable")]
        public bool? Sortable{ get; set; }

        /// <summary>
        /// 是否可筛选
        /// </summary>
        [JsonProperty("WithFilter")]
        public bool? WithFilter{ get; set; }

        /// <summary>
        /// 筛选的候选集
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Candidates")]
        public string[] Candidates{ get; set; }

        /// <summary>
        /// 是否可点击
        /// </summary>
        [JsonProperty("Clickable")]
        public bool? Clickable{ get; set; }

        /// <summary>
        /// 展示的名字
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sortable", this.Sortable);
            this.SetParamSimple(map, prefix + "WithFilter", this.WithFilter);
            this.SetParamArraySimple(map, prefix + "Candidates.", this.Candidates);
            this.SetParamSimple(map, prefix + "Clickable", this.Clickable);
            this.SetParamSimple(map, prefix + "Title", this.Title);
        }
    }
}

