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

    public class ModifyBaselineRuleIgnoreRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 资产类型[0:所有专业版旗舰版|1:id|2:ip]
        /// </summary>
        [JsonProperty("AssetType")]
        public long? AssetType{ get; set; }

        /// <summary>
        /// 规则Id
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 关联项
        /// </summary>
        [JsonProperty("ItemIds")]
        public long?[] ItemIds{ get; set; }

        /// <summary>
        /// 主机Id
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }

        /// <summary>
        /// 主机Ip
        /// </summary>
        [JsonProperty("HostIps")]
        public string[] HostIps{ get; set; }

        /// <summary>
        /// 是否全选过滤
        /// </summary>
        [JsonProperty("SelectAll")]
        public long? SelectAll{ get; set; }

        /// <summary>
        /// <li>ItemName - string - 是否必填：否 - 项名称</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArraySimple(map, prefix + "ItemIds.", this.ItemIds);
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
            this.SetParamArraySimple(map, prefix + "HostIps.", this.HostIps);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

