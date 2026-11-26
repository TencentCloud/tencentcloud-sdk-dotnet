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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAttackDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待查询的检测请求 ID，来自上游检测接口（如 <code>DetectAIFakeFaces</code>）返回的 <code>RequestId</code>。长度 32 ~ 64，仅支持数字、字母及短横线 <code>-</code>。检测结果保留期为 3 天，超期后将返回 <code>ResourceUnavailable.ResultExpired</code>。</p>
        /// </summary>
        [JsonProperty("SeqId")]
        public string SeqId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SeqId", this.SeqId);
        }
    }
}

