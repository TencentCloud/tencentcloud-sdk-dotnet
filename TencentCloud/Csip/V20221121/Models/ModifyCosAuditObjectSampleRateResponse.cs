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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCosAuditObjectSampleRateResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>本次是否实际提交了默认采样率</p>
        /// </summary>
        [JsonProperty("DefaultSampleRateUpdated")]
        public bool? DefaultSampleRateUpdated{ get; set; }

        /// <summary>
        /// <p>DefaultSampleRateUpdated=true 时返回修改后的值</p>
        /// </summary>
        [JsonProperty("DefaultSampleRate")]
        public float? DefaultSampleRate{ get; set; }

        /// <summary>
        /// <p>本次成功提交的已有桶数量</p>
        /// </summary>
        [JsonProperty("UpdatedBucketCount")]
        public ulong? UpdatedBucketCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "DefaultSampleRateUpdated", this.DefaultSampleRateUpdated);
            this.SetParamSimple(map, prefix + "DefaultSampleRate", this.DefaultSampleRate);
            this.SetParamSimple(map, prefix + "UpdatedBucketCount", this.UpdatedBucketCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

