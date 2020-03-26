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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TriggerLogResp : AbstractModel
    {
        
        /// <summary>
        /// 仓库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// Tag名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagName")]
        public string TagName{ get; set; }

        /// <summary>
        /// 触发器名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// 触发方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeSource")]
        public string InvokeSource{ get; set; }

        /// <summary>
        /// 触发动作
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeAction")]
        public string InvokeAction{ get; set; }

        /// <summary>
        /// 触发时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeTime")]
        public string InvokeTime{ get; set; }

        /// <summary>
        /// 触发条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeCondition")]
        public TriggerInvokeCondition InvokeCondition{ get; set; }

        /// <summary>
        /// 触发参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokePara")]
        public TriggerInvokePara InvokePara{ get; set; }

        /// <summary>
        /// 触发结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvokeResult")]
        public TriggerInvokeResult InvokeResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "TagName", this.TagName);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "InvokeSource", this.InvokeSource);
            this.SetParamSimple(map, prefix + "InvokeAction", this.InvokeAction);
            this.SetParamSimple(map, prefix + "InvokeTime", this.InvokeTime);
            this.SetParamObj(map, prefix + "InvokeCondition.", this.InvokeCondition);
            this.SetParamObj(map, prefix + "InvokePara.", this.InvokePara);
            this.SetParamObj(map, prefix + "InvokeResult.", this.InvokeResult);
        }
    }
}

