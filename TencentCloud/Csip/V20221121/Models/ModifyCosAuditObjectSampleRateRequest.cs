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

    public class ModifyCosAuditObjectSampleRateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>存储桶资产id集合</p>
        /// </summary>
        [JsonProperty("BucketIdSet")]
        public ulong?[] BucketIdSet{ get; set; }

        /// <summary>
        /// <p>采样率集合</p>
        /// </summary>
        [JsonProperty("SampleRateSet")]
        public float?[] SampleRateSet{ get; set; }

        /// <summary>
        /// <p>appid；传 DefaultSampleRate 时必填；只修改已有桶时可选</p>
        /// </summary>
        [JsonProperty("TargetAppId")]
        public ulong? TargetAppId{ get; set; }

        /// <summary>
        /// <p>传入时修改 TargetAppId 的新增桶默认值； 不传时不修改默认值</p><p>取值范围：[0.001, 1]</p>
        /// </summary>
        [JsonProperty("DefaultSampleRate")]
        public float? DefaultSampleRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BucketIdSet.", this.BucketIdSet);
            this.SetParamArraySimple(map, prefix + "SampleRateSet.", this.SampleRateSet);
            this.SetParamSimple(map, prefix + "TargetAppId", this.TargetAppId);
            this.SetParamSimple(map, prefix + "DefaultSampleRate", this.DefaultSampleRate);
        }
    }
}

