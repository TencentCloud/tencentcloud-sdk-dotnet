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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceFilter : AbstractModel
    {
        
        /// <summary>
        /// 过滤字段名，支持的列表如下：
        /// - type：主资源类型，CDN。
        /// - instanceId：IGTM实例ID。此为必传参数，未传将导致接口查询失败。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 过滤字段值。
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }

        /// <summary>
        /// 是否启用模糊查询，仅支持过滤字段名为domain。
        /// 模糊查询时，Value长度最大为1，否则Value长度最大为5。(预留字段，暂未使用)
        /// </summary>
        [JsonProperty("Fuzzy")]
        public bool? Fuzzy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
            this.SetParamSimple(map, prefix + "Fuzzy", this.Fuzzy);
        }
    }
}

