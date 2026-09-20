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

    public class DescribeTWeSeeDirectUploadInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>TWeSee 直传目录的 COS URI</p>
        /// </summary>
        [JsonProperty("COSURI")]
        public string COSURI{ get; set; }

        /// <summary>
        /// <p>TWeSee 直传存储桶</p>
        /// </summary>
        [JsonProperty("StorageBucket")]
        public string StorageBucket{ get; set; }

        /// <summary>
        /// <p>TWeSee 直传目录路径</p>
        /// </summary>
        [JsonProperty("StoragePath")]
        public string StoragePath{ get; set; }

        /// <summary>
        /// <p>TWeSee 直传存储地域</p>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

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
            this.SetParamSimple(map, prefix + "COSURI", this.COSURI);
            this.SetParamSimple(map, prefix + "StorageBucket", this.StorageBucket);
            this.SetParamSimple(map, prefix + "StoragePath", this.StoragePath);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

