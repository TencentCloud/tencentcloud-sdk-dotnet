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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceParameter : AbstractModel
    {
        
        /// <summary>
        /// API的后端服务参数名称。只有ServiceType是HTTP才会用到此参数。前后端参数名称可不同。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// API 的后端服务参数位置，如 head。只有 ServiceType 是 HTTP 才会用到此参数。前后端参数位置可配置不同。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// API 的后端服务参数对应的前端参数位置，如 head。只有 ServiceType 是 HTTP 才会用到此参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelevantRequestParameterPosition")]
        public string RelevantRequestParameterPosition{ get; set; }

        /// <summary>
        /// API 的后端服务参数对应的前端参数名称。只有 ServiceType 是 HTTP 才会用到此参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelevantRequestParameterName")]
        public string RelevantRequestParameterName{ get; set; }

        /// <summary>
        /// API 的后端服务参数默认值。只有 ServiceType 是 HTTP 才会用到此参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// API 的后端服务参数备注。只有 ServiceType 是 HTTP 才会用到此参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelevantRequestParameterDesc")]
        public string RelevantRequestParameterDesc{ get; set; }

        /// <summary>
        /// API 的后端服务参数类型。只有 ServiceType 是 HTTP 才会用到此参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelevantRequestParameterType")]
        public string RelevantRequestParameterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "RelevantRequestParameterPosition", this.RelevantRequestParameterPosition);
            this.SetParamSimple(map, prefix + "RelevantRequestParameterName", this.RelevantRequestParameterName);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "RelevantRequestParameterDesc", this.RelevantRequestParameterDesc);
            this.SetParamSimple(map, prefix + "RelevantRequestParameterType", this.RelevantRequestParameterType);
        }
    }
}

