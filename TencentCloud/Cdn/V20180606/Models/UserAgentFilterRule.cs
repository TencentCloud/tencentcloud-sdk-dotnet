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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserAgentFilterRule : AbstractModel
    {
        
        /// <summary>
        /// 访问路径生效类型
        /// all: 所有访问路径生效
        /// file: 根据文件后缀类型生效
        /// directory: 根据目录生效
        /// path: 根据完整访问路径生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 访问路径生效内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// UserAgent列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAgents")]
        public string[] UserAgents{ get; set; }

        /// <summary>
        /// 黑名单或白名单，blacklist或whitelist
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamArraySimple(map, prefix + "UserAgents.", this.UserAgents);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
        }
    }
}

