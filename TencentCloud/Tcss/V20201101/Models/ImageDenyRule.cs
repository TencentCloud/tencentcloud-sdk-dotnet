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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageDenyRule : AbstractModel
    {
        
        /// <summary>
        /// 规则RuleID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则类型 RULE_RISK：风险， RULE_PRIVILEGE：特权
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 生效的镜像数量
        /// </summary>
        [JsonProperty("EffectImageCount")]
        public long? EffectImageCount{ get; set; }

        /// <summary>
        /// 是否对全部扫描镜像生效。0:全选镜像，1:自选镜像
        /// </summary>
        [JsonProperty("IsEffectAllImage")]
        public long? IsEffectAllImage{ get; set; }

        /// <summary>
        /// 规则开始生效时间
        /// </summary>
        [JsonProperty("EffectTime")]
        public string EffectTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 操作用户
        /// </summary>
        [JsonProperty("OperationUin")]
        public string OperationUin{ get; set; }

        /// <summary>
        /// 启用状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 生效状态 IN_THE_TEST ：观察中，IN_EFFECT：生效中
        /// </summary>
        [JsonProperty("EffectStatus")]
        public string EffectStatus{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "EffectImageCount", this.EffectImageCount);
            this.SetParamSimple(map, prefix + "IsEffectAllImage", this.IsEffectAllImage);
            this.SetParamSimple(map, prefix + "EffectTime", this.EffectTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OperationUin", this.OperationUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EffectStatus", this.EffectStatus);
            this.SetParamSimple(map, prefix + "ID", this.ID);
        }
    }
}

