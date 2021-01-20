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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// API 请求参数
        /// </summary>
        [JsonProperty("Request")]
        public ApiRequestDescr[] Request{ get; set; }

        /// <summary>
        /// API 响应参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Response")]
        public ApiResponseDescr[] Response{ get; set; }

        /// <summary>
        /// API 复杂结构定义
        /// </summary>
        [JsonProperty("Definitions")]
        public ApiDefinitionDescr[] Definitions{ get; set; }

        /// <summary>
        /// API 的 content type
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestContentType")]
        public string RequestContentType{ get; set; }

        /// <summary>
        /// API  能否调试
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanRun")]
        public bool? CanRun{ get; set; }

        /// <summary>
        /// API 状态 0:离线 1:在线，默认0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// API 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Request.", this.Request);
            this.SetParamArrayObj(map, prefix + "Response.", this.Response);
            this.SetParamArrayObj(map, prefix + "Definitions.", this.Definitions);
            this.SetParamSimple(map, prefix + "RequestContentType", this.RequestContentType);
            this.SetParamSimple(map, prefix + "CanRun", this.CanRun);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

