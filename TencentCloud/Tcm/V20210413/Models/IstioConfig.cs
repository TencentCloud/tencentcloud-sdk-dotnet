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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IstioConfig : AbstractModel
    {
        
        /// <summary>
        /// 外部流量策略
        /// </summary>
        [JsonProperty("OutboundTrafficPolicy")]
        public string OutboundTrafficPolicy{ get; set; }

        /// <summary>
        /// 调用链配置（Deprecated，请使用 MeshConfig.Tracing 进行配置）
        /// </summary>
        [JsonProperty("Tracing")]
        public TracingConfig Tracing{ get; set; }

        /// <summary>
        /// 禁用策略检查功能
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisablePolicyChecks")]
        public bool? DisablePolicyChecks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutboundTrafficPolicy", this.OutboundTrafficPolicy);
            this.SetParamObj(map, prefix + "Tracing.", this.Tracing);
            this.SetParamSimple(map, prefix + "DisablePolicyChecks", this.DisablePolicyChecks);
        }
    }
}

