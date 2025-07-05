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

namespace TencentCloud.Vcube.V20220410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSTSResponse : AbstractModel
    {
        
        /// <summary>
        /// 桶名称
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 开始生效时间
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 临时token过期时间
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public ulong? ExpiredTime{ get; set; }

        /// <summary>
        /// 临时token
        /// </summary>
        [JsonProperty("SessionToken")]
        public string SessionToken{ get; set; }

        /// <summary>
        /// 临时SecretId
        /// </summary>
        [JsonProperty("TmpSecretId")]
        public string TmpSecretId{ get; set; }

        /// <summary>
        /// 临时秘钥
        /// </summary>
        [JsonProperty("TmpSecretKey")]
        public string TmpSecretKey{ get; set; }

        /// <summary>
        /// 上传的根路径，底下可以多层
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

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
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "SessionToken", this.SessionToken);
            this.SetParamSimple(map, prefix + "TmpSecretId", this.TmpSecretId);
            this.SetParamSimple(map, prefix + "TmpSecretKey", this.TmpSecretKey);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

