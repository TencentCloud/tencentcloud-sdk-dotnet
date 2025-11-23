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

    public class ModifyBotIdRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [JsonProperty("SceneId")]
        public string SceneId{ get; set; }

        /// <summary>
        /// 配置信息，支持批量
        /// </summary>
        [JsonProperty("Data")]
        public BotIdConfig[] Data{ get; set; }

        /// <summary>
        /// 0-全局设置不生效 1-全局开关配置字段生效 2-全局动作配置字段生效 3-全局开关和动作字段都生效 4-只修改全局重定向路径 5-只修改全局防护等级
        /// </summary>
        [JsonProperty("GlobalSwitch")]
        public long? GlobalSwitch{ get; set; }

        /// <summary>
        /// 全局开关
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 全局动作
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 全局重定向路径
        /// </summary>
        [JsonProperty("GlobalRedirect")]
        public string GlobalRedirect{ get; set; }

        /// <summary>
        /// 防护等级：normal-正常；strict-严格
        /// </summary>
        [JsonProperty("ProtectLevel")]
        public string ProtectLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "GlobalSwitch", this.GlobalSwitch);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "GlobalRedirect", this.GlobalRedirect);
            this.SetParamSimple(map, prefix + "ProtectLevel", this.ProtectLevel);
        }
    }
}

