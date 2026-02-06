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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListFilesResponse : AbstractModel
    {
        
        /// <summary>
        /// 响应条目是否被截断。
        /// </summary>
        [JsonProperty("IsTruncated")]
        public bool? IsTruncated{ get; set; }

        /// <summary>
        /// 仅当响应条目有截断（IsTruncated 为 true）才会返回该节点，该节点的值为当前响应条目中的最后一个对象键，当需要继续请求后续条目时，将该节点的值作为下一次请求的 marker 参数传入。
        /// </summary>
        [JsonProperty("NextMarker")]
        public string NextMarker{ get; set; }

        /// <summary>
        /// 从 prefix 或从头（如未指定 prefix）到首个 delimiter 之间相同的部分，定义为 Common Prefix。仅当请求中指定了 delimiter 参数才有可能返回该节点。
        /// </summary>
        [JsonProperty("CommonPrefixes")]
        public string[] CommonPrefixes{ get; set; }

        /// <summary>
        /// 对象条目。
        /// </summary>
        [JsonProperty("Contents")]
        public FileContent[] Contents{ get; set; }

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
            this.SetParamSimple(map, prefix + "IsTruncated", this.IsTruncated);
            this.SetParamSimple(map, prefix + "NextMarker", this.NextMarker);
            this.SetParamArraySimple(map, prefix + "CommonPrefixes.", this.CommonPrefixes);
            this.SetParamArrayObj(map, prefix + "Contents.", this.Contents);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

