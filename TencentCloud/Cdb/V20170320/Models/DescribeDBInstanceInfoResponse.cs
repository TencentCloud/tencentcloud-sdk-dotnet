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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID 。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 是否开通加密，YES 已开通，NO 未开通。
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }

        /// <summary>
        /// 加密使用的密钥 ID 。
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 密钥所在地域。
        /// </summary>
        [JsonProperty("KeyRegion")]
        public string KeyRegion{ get; set; }

        /// <summary>
        /// 当前 CDB 后端服务使用的 KMS 服务的默认地域。
        /// </summary>
        [JsonProperty("DefaultKmsRegion")]
        public string DefaultKmsRegion{ get; set; }

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
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyRegion", this.KeyRegion);
            this.SetParamSimple(map, prefix + "DefaultKmsRegion", this.DefaultKmsRegion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

