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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyIsolateTableRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>操作动作，仅接受精确值 edit 或 delete。ButtonAction 为 edit 时修改该资产所有匹配隔离记录的有效期，需传 StartTime 和 EndTime；ButtonAction 为 delete 时解除该资产的全部匹配隔离，StartTime 和 EndTime 可省略。</p>
        /// </summary>
        [JsonProperty("ButtonAction")]
        public string ButtonAction{ get; set; }

        /// <summary>
        /// <p>必填的资产实例 ID。调用 DescribeCfwRules，传 RuleType=intrusion_prevention、ListType=isolate 和目标 InstanceId，并使用完全匹配的 rules[].instance_id。edit 或 delete 作用于该实例的全部隔离记录。</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>隔离结束时间。ButtonAction 为 edit 时必填，格式为 YYYY-MM-DD HH:MM:SS，且不得早于 StartTime；除永久隔离值 3000-01-01 00:00:00 外，必须晚于当前时间。ButtonAction 为 delete 时可省略。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>隔离起始时间。ButtonAction 为 edit 时必填，格式为 YYYY-MM-DD HH:MM:SS，且不得晚于 EndTime；该时间将应用于该实例的全部匹配隔离记录。ButtonAction 为 delete 时可省略。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ButtonAction", this.ButtonAction);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

