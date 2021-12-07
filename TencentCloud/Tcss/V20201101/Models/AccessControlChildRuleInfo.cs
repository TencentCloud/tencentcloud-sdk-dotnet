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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessControlChildRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 策略模式,  RULE_MODE_RELEASE: 放行
        ///    RULE_MODE_ALERT: 告警
        ///    RULE_MODE_HOLDUP:拦截
        /// </summary>
        [JsonProperty("RuleMode")]
        public string RuleMode{ get; set; }

        /// <summary>
        /// 进程路径
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 被访问文件路径，仅仅在访问控制生效
        /// </summary>
        [JsonProperty("TargetFilePath")]
        public string TargetFilePath{ get; set; }

        /// <summary>
        /// 子策略id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleMode", this.RuleMode);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "TargetFilePath", this.TargetFilePath);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

