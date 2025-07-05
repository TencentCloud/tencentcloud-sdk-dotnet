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

    public class APIDoc : AbstractModel
    {
        
        /// <summary>
        /// API文档ID
        /// </summary>
        [JsonProperty("ApiDocId")]
        public string ApiDocId{ get; set; }

        /// <summary>
        /// API文档名称
        /// </summary>
        [JsonProperty("ApiDocName")]
        public string ApiDocName{ get; set; }

        /// <summary>
        /// API文档构建状态
        /// </summary>
        [JsonProperty("ApiDocStatus")]
        public string ApiDocStatus{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiDocId", this.ApiDocId);
            this.SetParamSimple(map, prefix + "ApiDocName", this.ApiDocName);
            this.SetParamSimple(map, prefix + "ApiDocStatus", this.ApiDocStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

