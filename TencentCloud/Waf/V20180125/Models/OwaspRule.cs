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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OwaspRule : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 规则开关，0：关闭、1：开启、2：只观察
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 规则的防护等级，100：宽松、200：正常、300：严格、400：超严格
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 威胁等级，0：未知，100：低危，200：中危，300：高危，400：危急
        /// </summary>
        [JsonProperty("VulLevel")]
        public long? VulLevel{ get; set; }

        /// <summary>
        /// CVE ID
        /// </summary>
        [JsonProperty("CveID")]
        public string CveID{ get; set; }

        /// <summary>
        /// 规则所属的类型ID
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 是否被锁定
        /// </summary>
        [JsonProperty("Locked")]
        public long? Locked{ get; set; }

        /// <summary>
        /// 修改原因
        /// 0：无(兼容记录为空)
        /// 1：业务自身特性误报避免
        /// 2：规则误报上报
        /// 3：核心业务规则灰度
        /// 4：其它
        /// </summary>
        [JsonProperty("Reason")]
        public long? Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "VulLevel", this.VulLevel);
            this.SetParamSimple(map, prefix + "CveID", this.CveID);
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Locked", this.Locked);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

