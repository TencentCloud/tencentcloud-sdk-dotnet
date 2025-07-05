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

    public class ExportFileTamperEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>Status - String - 是否必填：否 - 处理状态  0 -- 待处理 1 -- 已加白 2 -- 已删除 3 - 已忽略</li>
        /// <li>ModifyTime - String - 是否必填：否 - 最近发生时间</li>
        /// <li>Uuid- String - 是否必填：否 - 主机uuid查询</li>
        /// <li>RuleCategory- string - 是否必填：否 - 规则类别 0 系统规则 1 自定义规则</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// 需要导出的字段
        /// </summary>
        [JsonProperty("Fileds")]
        [System.Obsolete]
        public string[] Fileds{ get; set; }

        /// <summary>
        /// 需要导出的字段
        /// </summary>
        [JsonProperty("Fields")]
        [System.Obsolete]
        public string Fields{ get; set; }

        /// <summary>
        /// 需要导出的字段
        /// </summary>
        [JsonProperty("Where")]
        public string[] Where{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "Fileds.", this.Fileds);
            this.SetParamSimple(map, prefix + "Fields", this.Fields);
            this.SetParamArraySimple(map, prefix + "Where.", this.Where);
        }
    }
}

