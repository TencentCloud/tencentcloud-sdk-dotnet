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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosToken : AbstractModel
    {
        
        /// <summary>
        /// 唯一请求 ID
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// 存储桶桶名
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 存储桶所在区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 临时密钥的SecretId
        /// </summary>
        [JsonProperty("TmpSecretId")]
        public string TmpSecretId{ get; set; }

        /// <summary>
        /// 临时密钥的SecretKey
        /// </summary>
        [JsonProperty("TmpSecretKey")]
        public string TmpSecretKey{ get; set; }

        /// <summary>
        /// 临时密钥的 sessionToken
        /// </summary>
        [JsonProperty("SessionToken")]
        public string SessionToken{ get; set; }

        /// <summary>
        /// 临时密钥获取的开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 临时密钥的 expiredTime
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 包完整路径
        /// </summary>
        [JsonProperty("FullPath")]
        public string FullPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "TmpSecretId", this.TmpSecretId);
            this.SetParamSimple(map, prefix + "TmpSecretKey", this.TmpSecretKey);
            this.SetParamSimple(map, prefix + "SessionToken", this.SessionToken);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "FullPath", this.FullPath);
        }
    }
}

