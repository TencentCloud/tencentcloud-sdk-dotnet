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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetImageScanStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 镜像个数
        /// </summary>
        [JsonProperty("ImageTotal")]
        public ulong? ImageTotal{ get; set; }

        /// <summary>
        /// 扫描镜像个数
        /// </summary>
        [JsonProperty("ImageScanCnt")]
        public ulong? ImageScanCnt{ get; set; }

        /// <summary>
        /// 扫描状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 扫描进度 ImageScanCnt/ImageTotal *100
        /// </summary>
        [JsonProperty("Schedule")]
        public ulong? Schedule{ get; set; }

        /// <summary>
        /// 安全个数
        /// </summary>
        [JsonProperty("SuccessCount")]
        public ulong? SuccessCount{ get; set; }

        /// <summary>
        /// 风险个数
        /// </summary>
        [JsonProperty("RiskCount")]
        public ulong? RiskCount{ get; set; }

        /// <summary>
        /// 剩余扫描时间
        /// </summary>
        [JsonProperty("LeftSeconds")]
        public ulong? LeftSeconds{ get; set; }

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
            this.SetParamSimple(map, prefix + "ImageTotal", this.ImageTotal);
            this.SetParamSimple(map, prefix + "ImageScanCnt", this.ImageScanCnt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "LeftSeconds", this.LeftSeconds);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

