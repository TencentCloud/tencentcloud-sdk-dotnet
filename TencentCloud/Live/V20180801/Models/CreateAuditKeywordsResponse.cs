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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAuditKeywordsResponse : AbstractModel
    {
        
        /// <summary>
        /// 添加成功的关键词 Id 列表。
        /// </summary>
        [JsonProperty("KeywordIds")]
        public string[] KeywordIds{ get; set; }

        /// <summary>
        /// 重复关键词列表。
        /// </summary>
        [JsonProperty("DupInfos")]
        public AuditKeywordInfo[] DupInfos{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "KeywordIds.", this.KeywordIds);
            this.SetParamArrayObj(map, prefix + "DupInfos.", this.DupInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

