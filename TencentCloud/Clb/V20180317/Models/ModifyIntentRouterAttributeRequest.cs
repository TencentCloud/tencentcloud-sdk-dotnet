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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyIntentRouterAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>意图路由ID（ir-xxx格式）。</p>
        /// </summary>
        [JsonProperty("IntentRouterId")]
        public string IntentRouterId{ get; set; }

        /// <summary>
        /// <p>模型路由实例ID。</p>
        /// </summary>
        [JsonProperty("ModelRouterId")]
        public string ModelRouterId{ get; set; }

        /// <summary>
        /// <p>新的路由名称。</p><p>选填；必须以"IntentRouter/"为前缀，后缀仅支持字母、数字、连字符和下划线，后缀长度1-128个字符。不传则不修改。</p>
        /// </summary>
        [JsonProperty("RouteName")]
        public string RouteName{ get; set; }

        /// <summary>
        /// <p>意图路由描述。</p>
        /// </summary>
        [JsonProperty("RouterDescribe")]
        public string RouterDescribe{ get; set; }

        /// <summary>
        /// <p>新的分层配置列表（全量替换）。</p><p>选填；不传则不修改。传入时必须为完整分层集合：复杂度分层须包含全部 4 个分层 SIMPLE/MEDIUM/COMPLEX/REASONING；语义分层须包含 default 及各语义 Tier（取决于实例所用协议，且不可跨协议变更）。每个分层至少包含一个模型，模型名称必须是已关联到该实例的模型。</p>
        /// </summary>
        [JsonProperty("Tiers")]
        public TierItem[] Tiers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntentRouterId", this.IntentRouterId);
            this.SetParamSimple(map, prefix + "ModelRouterId", this.ModelRouterId);
            this.SetParamSimple(map, prefix + "RouteName", this.RouteName);
            this.SetParamSimple(map, prefix + "RouterDescribe", this.RouterDescribe);
            this.SetParamArrayObj(map, prefix + "Tiers.", this.Tiers);
        }
    }
}

