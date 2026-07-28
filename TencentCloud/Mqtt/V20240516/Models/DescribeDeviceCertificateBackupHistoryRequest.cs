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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceCertificateBackupHistoryRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>腾讯云MQTT实例ID，从 <a href="https://cloud.tencent.com/document/api/1778/111029">DescribeInstanceList</a>接口或控制台获得。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>目标集群的集群ID</p>
        /// </summary>
        [JsonProperty("Destination")]
        public string Destination{ get; set; }

        /// <summary>
        /// <p>CA证书的SN</p>
        /// </summary>
        [JsonProperty("CaSn")]
        public string CaSn{ get; set; }

        /// <summary>
        /// <p>设备证书的SN</p>
        /// </summary>
        [JsonProperty("DeviceCertificateSn")]
        public string DeviceCertificateSn{ get; set; }

        /// <summary>
        /// <p>同步发生开始时间（毫秒级时间戳）</p>
        /// </summary>
        [JsonProperty("ModificationTimeStart")]
        public long? ModificationTimeStart{ get; set; }

        /// <summary>
        /// <p>同步结束时间（毫秒级时间戳）</p>
        /// </summary>
        [JsonProperty("ModificationTimeEnd")]
        public long? ModificationTimeEnd{ get; set; }

        /// <summary>
        /// <p>查询条数，默认20，最大1024</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Destination", this.Destination);
            this.SetParamSimple(map, prefix + "CaSn", this.CaSn);
            this.SetParamSimple(map, prefix + "DeviceCertificateSn", this.DeviceCertificateSn);
            this.SetParamSimple(map, prefix + "ModificationTimeStart", this.ModificationTimeStart);
            this.SetParamSimple(map, prefix + "ModificationTimeEnd", this.ModificationTimeEnd);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

