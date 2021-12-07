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

    public class AbnormalProcessRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// true:策略启用，false:策略禁用
        /// </summary>
        [JsonProperty("IsEnable")]
        public bool? IsEnable{ get; set; }

        /// <summary>
        /// 生效镜像id，空数组代表全部镜像
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// 用户策略的子策略数组
        /// </summary>
        [JsonProperty("ChildRules")]
        public AbnormalProcessChildRuleInfo[] ChildRules{ get; set; }

        /// <summary>
        /// 策略名字
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 策略id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 系统策略的子策略数组
        /// </summary>
        [JsonProperty("SystemChildRules")]
        public AbnormalProcessSystemChildRuleInfo[] SystemChildRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamArrayObj(map, prefix + "ChildRules.", this.ChildRules);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArrayObj(map, prefix + "SystemChildRules.", this.SystemChildRules);
        }
    }
}

