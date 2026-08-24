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

    public class AIGWRerankMaxDocumentsConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>启用最大文档数限制</p>
        /// </summary>
        [JsonProperty("EnableMaxDocuments")]
        public bool? EnableMaxDocuments{ get; set; }

        /// <summary>
        /// <p>Rerank场景最大文档数限制</p>
        /// </summary>
        [JsonProperty("MaxDocumentValue")]
        public long? MaxDocumentValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableMaxDocuments", this.EnableMaxDocuments);
            this.SetParamSimple(map, prefix + "MaxDocumentValue", this.MaxDocumentValue);
        }
    }
}

