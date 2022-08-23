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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DimensionNew : AbstractModel
    {
        
        /// <summary>
        /// 维度 key 标示，后台英文名
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 维度 key 名称，中英文前台展示名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否必选
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }

        /// <summary>
        /// 支持的操作符列表
        /// </summary>
        [JsonProperty("Operators")]
        public Operator[] Operators{ get; set; }

        /// <summary>
        /// 是否支持多选
        /// </summary>
        [JsonProperty("IsMultiple")]
        public bool? IsMultiple{ get; set; }

        /// <summary>
        /// 创建后是否可以修改
        /// </summary>
        [JsonProperty("IsMutable")]
        public bool? IsMutable{ get; set; }

        /// <summary>
        /// 是否展示给用户
        /// </summary>
        [JsonProperty("IsVisible")]
        public bool? IsVisible{ get; set; }

        /// <summary>
        /// 能否用来过滤策略列表
        /// </summary>
        [JsonProperty("CanFilterPolicy")]
        public bool? CanFilterPolicy{ get; set; }

        /// <summary>
        /// 能否用来过滤告警历史
        /// </summary>
        [JsonProperty("CanFilterHistory")]
        public bool? CanFilterHistory{ get; set; }

        /// <summary>
        /// 能否作为聚合维度
        /// </summary>
        [JsonProperty("CanGroupBy")]
        public bool? CanGroupBy{ get; set; }

        /// <summary>
        /// 是否必须作为聚合维度
        /// </summary>
        [JsonProperty("MustGroupBy")]
        public bool? MustGroupBy{ get; set; }

        /// <summary>
        /// 前端翻译要替换的 key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowValueReplace")]
        public string ShowValueReplace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
            this.SetParamArrayObj(map, prefix + "Operators.", this.Operators);
            this.SetParamSimple(map, prefix + "IsMultiple", this.IsMultiple);
            this.SetParamSimple(map, prefix + "IsMutable", this.IsMutable);
            this.SetParamSimple(map, prefix + "IsVisible", this.IsVisible);
            this.SetParamSimple(map, prefix + "CanFilterPolicy", this.CanFilterPolicy);
            this.SetParamSimple(map, prefix + "CanFilterHistory", this.CanFilterHistory);
            this.SetParamSimple(map, prefix + "CanGroupBy", this.CanGroupBy);
            this.SetParamSimple(map, prefix + "MustGroupBy", this.MustGroupBy);
            this.SetParamSimple(map, prefix + "ShowValueReplace", this.ShowValueReplace);
        }
    }
}

