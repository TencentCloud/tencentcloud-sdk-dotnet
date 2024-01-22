/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetAccessible : AbstractModel
    {
        
        /// <summary>
        /// 带宽
        /// </summary>
        [JsonProperty("MaxBandwidthOut")]
        public long? MaxBandwidthOut{ get; set; }

        /// <summary>
        /// 网络计费方式
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 带宽包 ID
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxBandwidthOut", this.MaxBandwidthOut);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
        }
    }
}

