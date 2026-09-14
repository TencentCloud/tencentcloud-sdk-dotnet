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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeObjectListing : AbstractModel
    {
        
        /// <summary>
        /// <p>对象列表</p>
        /// </summary>
        [JsonProperty("Contents")]
        public SeeObjectSummary[] Contents{ get; set; }

        /// <summary>
        /// <p>子目录路径列表</p>
        /// </summary>
        [JsonProperty("CommonPrefixes")]
        public string[] CommonPrefixes{ get; set; }

        /// <summary>
        /// <p>本次列举使用的目录分隔符</p>
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// <p>是否还有后续分页数据</p>
        /// </summary>
        [JsonProperty("IsTruncated")]
        public bool? IsTruncated{ get; set; }

        /// <summary>
        /// <p>本次列举使用的分页标记</p>
        /// </summary>
        [JsonProperty("Marker")]
        public string Marker{ get; set; }

        /// <summary>
        /// <p>本次列举的最大对象数量</p>
        /// </summary>
        [JsonProperty("MaxKeys")]
        public long? MaxKeys{ get; set; }

        /// <summary>
        /// <p>下一页的分页标记</p>
        /// </summary>
        [JsonProperty("NextMarker")]
        public string NextMarker{ get; set; }

        /// <summary>
        /// <p>本次列举的对象路径前缀</p>
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Contents.", this.Contents);
            this.SetParamArraySimple(map, prefix + "CommonPrefixes.", this.CommonPrefixes);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "IsTruncated", this.IsTruncated);
            this.SetParamSimple(map, prefix + "Marker", this.Marker);
            this.SetParamSimple(map, prefix + "MaxKeys", this.MaxKeys);
            this.SetParamSimple(map, prefix + "NextMarker", this.NextMarker);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
        }
    }
}

