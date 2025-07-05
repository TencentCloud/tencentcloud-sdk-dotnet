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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KMSInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// 主密钥 ID。
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 主密钥名称。
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// 实例与密钥绑定时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 密钥状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 密钥用途。
        /// </summary>
        [JsonProperty("KeyUsage")]
        public string KeyUsage{ get; set; }

        /// <summary>
        /// 密钥来源。
        /// </summary>
        [JsonProperty("KeyOrigin")]
        public string KeyOrigin{ get; set; }

        /// <summary>
        /// kms所在地域。
        /// </summary>
        [JsonProperty("KmsRegion")]
        public string KmsRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "KeyUsage", this.KeyUsage);
            this.SetParamSimple(map, prefix + "KeyOrigin", this.KeyOrigin);
            this.SetParamSimple(map, prefix + "KmsRegion", this.KmsRegion);
        }
    }
}

