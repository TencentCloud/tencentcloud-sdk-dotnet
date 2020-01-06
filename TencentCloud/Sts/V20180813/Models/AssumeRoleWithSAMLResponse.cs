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

namespace TencentCloud.Sts.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssumeRoleWithSAMLResponse : AbstractModel
    {
        
        /// <summary>
        /// 对象里面包含 Token，TmpSecretId，TmpSecretKey 三元组
        /// </summary>
        [JsonProperty("Credentials")]
        public Credentials Credentials{ get; set; }

        /// <summary>
        /// 证书无效的时间，返回 Unix 时间戳，精确到秒
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public ulong? ExpiredTime{ get; set; }

        /// <summary>
        /// 证书无效的时间，以 ISO8601 格式的 UTC 时间表示
        /// </summary>
        [JsonProperty("Expiration")]
        public string Expiration{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Credentials.", this.Credentials);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "Expiration", this.Expiration);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

