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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWAuthModelScopeItem : AbstractModel
    {
        
        /// <summary>
        /// <p>授权主体 ID，如消费者组、消费者</p>
        /// </summary>
        [JsonProperty("PrincipalId")]
        public string PrincipalId{ get; set; }

        /// <summary>
        /// <p>授权主体名称，如消费者组、消费者</p>
        /// </summary>
        [JsonProperty("PrincipalName")]
        public string PrincipalName{ get; set; }

        /// <summary>
        /// <p>模型范围原始配置</p>
        /// </summary>
        [JsonProperty("ModelScope")]
        public AIGWModelScope ModelScope{ get; set; }

        /// <summary>
        /// <p>MAG 已展开、保序去重后的可用模型名称列表</p>
        /// </summary>
        [JsonProperty("EffectiveModelNames")]
        public string[] EffectiveModelNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrincipalId", this.PrincipalId);
            this.SetParamSimple(map, prefix + "PrincipalName", this.PrincipalName);
            this.SetParamObj(map, prefix + "ModelScope.", this.ModelScope);
            this.SetParamArraySimple(map, prefix + "EffectiveModelNames.", this.EffectiveModelNames);
        }
    }
}

