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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceCertificateResponse : AbstractModel
    {
        
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// 上次更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 证书失效日期
        /// </summary>
        [JsonProperty("NotAfterTime")]
        public long? NotAfterTime{ get; set; }

        /// <summary>
        /// 上次激活时间
        /// </summary>
        [JsonProperty("LastActivationTime")]
        public long? LastActivationTime{ get; set; }

        /// <summary>
        /// 上次取消激活时间
        /// </summary>
        [JsonProperty("LastInactivationTime")]
        public long? LastInactivationTime{ get; set; }

        /// <summary>
        /// 证书状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Ca证书序列号
        /// </summary>
        [JsonProperty("CaSn")]
        public string CaSn{ get; set; }

        /// <summary>
        /// 设备证书序列号
        /// </summary>
        [JsonProperty("DeviceCertificateSn")]
        public string DeviceCertificateSn{ get; set; }

        /// <summary>
        /// 设备证书内容
        /// </summary>
        [JsonProperty("DeviceCertificate")]
        public string DeviceCertificate{ get; set; }

        /// <summary>
        /// 设备证书common name
        /// </summary>
        [JsonProperty("DeviceCertificateCn")]
        public string DeviceCertificateCn{ get; set; }

        /// <summary>
        /// 证书格式
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 客户端id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        ///     API, 手动注册   
        ///     JITP 自动注册
        /// </summary>
        [JsonProperty("CertificateSource")]
        public string CertificateSource{ get; set; }

        /// <summary>
        /// 证书生效开始时间
        /// </summary>
        [JsonProperty("NotBeforeTime")]
        public long? NotBeforeTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "NotAfterTime", this.NotAfterTime);
            this.SetParamSimple(map, prefix + "LastActivationTime", this.LastActivationTime);
            this.SetParamSimple(map, prefix + "LastInactivationTime", this.LastInactivationTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CaSn", this.CaSn);
            this.SetParamSimple(map, prefix + "DeviceCertificateSn", this.DeviceCertificateSn);
            this.SetParamSimple(map, prefix + "DeviceCertificate", this.DeviceCertificate);
            this.SetParamSimple(map, prefix + "DeviceCertificateCn", this.DeviceCertificateCn);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "CertificateSource", this.CertificateSource);
            this.SetParamSimple(map, prefix + "NotBeforeTime", this.NotBeforeTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

