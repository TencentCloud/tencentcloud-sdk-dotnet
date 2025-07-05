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

    public class BaselineRuleDetect : AbstractModel
    {
        
        /// <summary>
        /// 规则Id
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("RuleDesc")]
        public string RuleDesc{ get; set; }

        /// <summary>
        /// 关联项数
        /// </summary>
        [JsonProperty("ItemCount")]
        public long? ItemCount{ get; set; }

        /// <summary>
        /// 关联主机数
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 首次检测时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// string
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 0:未通过 1:忽略 3:通过 5:检测中
        /// </summary>
        [JsonProperty("DetectStatus")]
        public long? DetectStatus{ get; set; }

        /// <summary>
        /// ItemID集合
        /// </summary>
        [JsonProperty("ItemIds")]
        public long?[] ItemIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleDesc", this.RuleDesc);
            this.SetParamSimple(map, prefix + "ItemCount", this.ItemCount);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "DetectStatus", this.DetectStatus);
            this.SetParamArraySimple(map, prefix + "ItemIds.", this.ItemIds);
        }
    }
}

