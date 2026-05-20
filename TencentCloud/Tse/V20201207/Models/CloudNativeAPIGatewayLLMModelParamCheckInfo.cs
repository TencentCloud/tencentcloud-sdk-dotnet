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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudNativeAPIGatewayLLMModelParamCheckInfo : AbstractModel
    {
        
        /// <summary>
        /// 允许的模型列表。
        /// </summary>
        [JsonProperty("AllowModelList")]
        public string[] AllowModelList{ get; set; }

        /// <summary>
        /// 模型参数校验失败时的处理策略，选项：Return404（返回404）、FallBackToDefaultModel（使用默认模型降级）。
        /// </summary>
        [JsonProperty("ModelValidationFailureStrategy")]
        public string ModelValidationFailureStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AllowModelList.", this.AllowModelList);
            this.SetParamSimple(map, prefix + "ModelValidationFailureStrategy", this.ModelValidationFailureStrategy);
        }
    }
}

