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

    public class ModifyExposureAutoTagRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>规则名称</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// <p>规则ID</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public ulong? RuleID{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>规则描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>开启状态</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>资产类型</p>
        /// </summary>
        [JsonProperty("AssetTypes")]
        public string[] AssetTypes{ get; set; }

        /// <summary>
        /// <p>端口</p>
        /// </summary>
        [JsonProperty("Ports")]
        public string[] Ports{ get; set; }

        /// <summary>
        /// <p>开放状态</p>
        /// </summary>
        [JsonProperty("OpenStatuses")]
        public string[] OpenStatuses{ get; set; }

        /// <summary>
        /// <p>是否立即执行打标</p>
        /// </summary>
        [JsonProperty("ApplyNow")]
        public bool? ApplyNow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamArraySimple(map, prefix + "AssetTypes.", this.AssetTypes);
            this.SetParamArraySimple(map, prefix + "Ports.", this.Ports);
            this.SetParamArraySimple(map, prefix + "OpenStatuses.", this.OpenStatuses);
            this.SetParamSimple(map, prefix + "ApplyNow", this.ApplyNow);
        }
    }
}

