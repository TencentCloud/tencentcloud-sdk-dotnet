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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobLogResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>日志行数据。</p>
        /// </summary>
        [JsonProperty("Lines")]
        public string[] Lines{ get; set; }

        /// <summary>
        /// <p>下一页游标（不透明令牌，原样透传回请求即可；无更多日志时不返回）。</p>
        /// </summary>
        [JsonProperty("Cursor")]
        public string Cursor{ get; set; }

        /// <summary>
        /// <p>是否还有更多日志。</p>
        /// </summary>
        [JsonProperty("HasMore")]
        public bool? HasMore{ get; set; }

        /// <summary>
        /// <p>日志条目列表。</p>
        /// </summary>
        [JsonProperty("Results")]
        public ClsLogEntry[] Results{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "Lines.", this.Lines);
            this.SetParamSimple(map, prefix + "Cursor", this.Cursor);
            this.SetParamSimple(map, prefix + "HasMore", this.HasMore);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

