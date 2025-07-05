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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DownloadHelmChartResponse : AbstractModel
    {
        
        /// <summary>
        /// 临时token
        /// </summary>
        [JsonProperty("TmpToken")]
        public string TmpToken{ get; set; }

        /// <summary>
        /// 临时的secretId
        /// </summary>
        [JsonProperty("TmpSecretId")]
        public string TmpSecretId{ get; set; }

        /// <summary>
        /// 临时的secretKey
        /// </summary>
        [JsonProperty("TmpSecretKey")]
        public string TmpSecretKey{ get; set; }

        /// <summary>
        /// 存储桶信息
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// chart信息
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 开始时间时间戳
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// token过期时间时间戳
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public long? ExpiredTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "TmpToken", this.TmpToken);
            this.SetParamSimple(map, prefix + "TmpSecretId", this.TmpSecretId);
            this.SetParamSimple(map, prefix + "TmpSecretKey", this.TmpSecretKey);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

