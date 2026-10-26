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

    public class CloudNativeAPIGatewayLLMModelServiceRouteModelNameStrategy : AbstractModel
    {
        
        /// <summary>
        /// <p>模型服务id</p>
        /// </summary>
        [JsonProperty("ModelServiceId")]
        public string ModelServiceId{ get; set; }

        /// <summary>
        /// <p>匹配模型服务</p>
        /// </summary>
        [JsonProperty("MatchModelName")]
        public string MatchModelName{ get; set; }

        /// <summary>
        /// <p>重写模型</p>
        /// </summary>
        [JsonProperty("RewriteModelName")]
        public string RewriteModelName{ get; set; }

        /// <summary>
        /// <p>当前模型名称匹配路由条目中 ModelServiceId 对应的标准模型名称；为空表示未配置。仅对应 TIONE 模型服务时可配置。非空值最长 256 字节，支持中文、英文、数字、下划线和短横线，须以中文、英文或数字开头。同一网关内不同模型 API 不得使用相同的标准模型名称；同一模型 API 内同一模型服务在多处配置时须保持一致。</p>
        /// </summary>
        [JsonProperty("StandardModelName")]
        public string StandardModelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelServiceId", this.ModelServiceId);
            this.SetParamSimple(map, prefix + "MatchModelName", this.MatchModelName);
            this.SetParamSimple(map, prefix + "RewriteModelName", this.RewriteModelName);
            this.SetParamSimple(map, prefix + "StandardModelName", this.StandardModelName);
        }
    }
}

