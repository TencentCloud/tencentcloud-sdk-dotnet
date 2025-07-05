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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetServiceStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// true表示服务已开通，false 表示服务尚未开通。
        /// </summary>
        [JsonProperty("ServiceEnabled")]
        public bool? ServiceEnabled{ get; set; }

        /// <summary>
        /// 服务不可用类型： 0-未购买，1-正常， 2-欠费停服， 3-资源释放。
        /// </summary>
        [JsonProperty("InvalidType")]
        public long? InvalidType{ get; set; }

        /// <summary>
        /// true表示用户已经可以使用密钥安全托管功能，
        /// false表示用户暂时不能使用密钥安全托管功能。
        /// </summary>
        [JsonProperty("AccessKeyEscrowEnabled")]
        public bool? AccessKeyEscrowEnabled{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 计算性能限制
        /// </summary>
        [JsonProperty("QPSLimit")]
        public long? QPSLimit{ get; set; }

        /// <summary>
        /// 凭据个数限制
        /// </summary>
        [JsonProperty("SecretLimit")]
        public long? SecretLimit{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("PayModel")]
        public string PayModel{ get; set; }

        /// <summary>
        /// 自动续费标识，0:手动续费 1:自动续费 2:到期不续
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 已托管凭据个数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ServiceEnabled", this.ServiceEnabled);
            this.SetParamSimple(map, prefix + "InvalidType", this.InvalidType);
            this.SetParamSimple(map, prefix + "AccessKeyEscrowEnabled", this.AccessKeyEscrowEnabled);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "QPSLimit", this.QPSLimit);
            this.SetParamSimple(map, prefix + "SecretLimit", this.SecretLimit);
            this.SetParamSimple(map, prefix + "PayModel", this.PayModel);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

