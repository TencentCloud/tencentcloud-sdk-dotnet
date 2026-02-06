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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCcnRequest : AbstractModel
    {
        
        /// <summary>
        /// CCN名称，最大长度不能超过60个字节。
        /// </summary>
        [JsonProperty("CcnName")]
        public string CcnName{ get; set; }

        /// <summary>
        /// CCN描述信息，最大长度不能超过100个字节。
        /// </summary>
        [JsonProperty("CcnDescription")]
        public string CcnDescription{ get; set; }

        /// <summary>
        /// CCN服务质量，`PT`：白金，`AU`：金，`AG`：银，默认为`AU`。
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// 计费模式，`PREPAID`：表示预付费，即包年包月，`POSTPAID`：表示后付费，即按量计费。默认：`POSTPAID`。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 计量模式
        /// </summary>
        [JsonProperty("InstanceMeteringType")]
        public string InstanceMeteringType{ get; set; }

        /// <summary>
        /// 限速类型，`OUTER_REGION_LIMIT`表示地域出口限速，`INTER_REGION_LIMIT`为地域间限速，默认为`OUTER_REGION_LIMIT`。预付费模式仅支持地域间限速，后付费模式支持地域间限速和地域出口限速。
        /// </summary>
        [JsonProperty("BandwidthLimitType")]
        public string BandwidthLimitType{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnName", this.CcnName);
            this.SetParamSimple(map, prefix + "CcnDescription", this.CcnDescription);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "InstanceMeteringType", this.InstanceMeteringType);
            this.SetParamSimple(map, prefix + "BandwidthLimitType", this.BandwidthLimitType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

