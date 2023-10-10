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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebHookRuleSummary : AbstractModel
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
        /// 机器人地址
        /// </summary>
        [JsonProperty("HookAddr")]
        public string HookAddr{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("RuleRemark")]
        public string RuleRemark{ get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("RuleItems")]
        public WebHookEventKv[] RuleItems{ get; set; }

        /// <summary>
        /// 主机范围
        /// </summary>
        [JsonProperty("HostLabels")]
        public WebHookHostLabel[] HostLabels{ get; set; }

        /// <summary>
        /// 是否启用[1:禁用|0:启用]
        /// </summary>
        [JsonProperty("IsDisabled")]
        public long? IsDisabled{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 主机数目
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "HookAddr", this.HookAddr);
            this.SetParamSimple(map, prefix + "RuleRemark", this.RuleRemark);
            this.SetParamArrayObj(map, prefix + "RuleItems.", this.RuleItems);
            this.SetParamArrayObj(map, prefix + "HostLabels.", this.HostLabels);
            this.SetParamSimple(map, prefix + "IsDisabled", this.IsDisabled);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
        }
    }
}

