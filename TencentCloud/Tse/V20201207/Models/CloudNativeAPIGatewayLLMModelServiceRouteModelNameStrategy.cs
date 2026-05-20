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

    public class CloudNativeAPIGatewayLLMModelServiceRouteModelNameStrategy : AbstractModel
    {
        
        /// <summary>
        /// 模型服务id
        /// </summary>
        [JsonProperty("ModelServiceId")]
        public string ModelServiceId{ get; set; }

        /// <summary>
        /// 匹配模型服务
        /// </summary>
        [JsonProperty("MatchModelName")]
        public string MatchModelName{ get; set; }

        /// <summary>
        /// 重写模型
        /// </summary>
        [JsonProperty("RewriteModelName")]
        public string RewriteModelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelServiceId", this.ModelServiceId);
            this.SetParamSimple(map, prefix + "MatchModelName", this.MatchModelName);
            this.SetParamSimple(map, prefix + "RewriteModelName", this.RewriteModelName);
        }
    }
}

