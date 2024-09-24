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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageAuthorizedInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 总共有效的镜像授权数
        /// </summary>
        [JsonProperty("TotalAuthorizedCnt")]
        public ulong? TotalAuthorizedCnt{ get; set; }

        /// <summary>
        /// 已使用镜像授权数
        /// </summary>
        [JsonProperty("UsedAuthorizedCnt")]
        public ulong? UsedAuthorizedCnt{ get; set; }

        /// <summary>
        /// 已开启扫描镜像数
        /// </summary>
        [JsonProperty("ScannedImageCnt")]
        public ulong? ScannedImageCnt{ get; set; }

        /// <summary>
        /// 未开启扫描镜像数
        /// </summary>
        [JsonProperty("NotScannedImageCnt")]
        public ulong? NotScannedImageCnt{ get; set; }

        /// <summary>
        /// 本地未开启扫描镜像数
        /// </summary>
        [JsonProperty("NotScannedLocalImageCnt")]
        public ulong? NotScannedLocalImageCnt{ get; set; }

        /// <summary>
        /// 试用镜像授权数
        /// </summary>
        [JsonProperty("TrialAuthorizedCnt")]
        public ulong? TrialAuthorizedCnt{ get; set; }

        /// <summary>
        /// 已使用试用镜像授权数
        /// </summary>
        [JsonProperty("UsedTrialAuthorizedCnt")]
        public ulong? UsedTrialAuthorizedCnt{ get; set; }

        /// <summary>
        /// 已购镜像授权数
        /// </summary>
        [JsonProperty("PurchasedAuthorizedCnt")]
        public ulong? PurchasedAuthorizedCnt{ get; set; }

        /// <summary>
        /// 已使用已购镜像授权数
        /// </summary>
        [JsonProperty("UsedPurchasedAuthorizedCnt")]
        public ulong? UsedPurchasedAuthorizedCnt{ get; set; }

        /// <summary>
        /// 是否可免费领取镜像授权数
        /// </summary>
        [JsonProperty("CanApplyFreeImageAuthorize")]
        public bool? CanApplyFreeImageAuthorize{ get; set; }

        /// <summary>
        /// 镜像扫描计费信息
        /// </summary>
        [JsonProperty("ImageScanInquireInfo")]
        public ImageScanInquireInfo ImageScanInquireInfo{ get; set; }

        /// <summary>
        /// 重复镜像数(本地镜像和仓库镜像)
        /// </summary>
        [JsonProperty("RepeatImageIdCnt")]
        public ulong? RepeatImageIdCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalAuthorizedCnt", this.TotalAuthorizedCnt);
            this.SetParamSimple(map, prefix + "UsedAuthorizedCnt", this.UsedAuthorizedCnt);
            this.SetParamSimple(map, prefix + "ScannedImageCnt", this.ScannedImageCnt);
            this.SetParamSimple(map, prefix + "NotScannedImageCnt", this.NotScannedImageCnt);
            this.SetParamSimple(map, prefix + "NotScannedLocalImageCnt", this.NotScannedLocalImageCnt);
            this.SetParamSimple(map, prefix + "TrialAuthorizedCnt", this.TrialAuthorizedCnt);
            this.SetParamSimple(map, prefix + "UsedTrialAuthorizedCnt", this.UsedTrialAuthorizedCnt);
            this.SetParamSimple(map, prefix + "PurchasedAuthorizedCnt", this.PurchasedAuthorizedCnt);
            this.SetParamSimple(map, prefix + "UsedPurchasedAuthorizedCnt", this.UsedPurchasedAuthorizedCnt);
            this.SetParamSimple(map, prefix + "CanApplyFreeImageAuthorize", this.CanApplyFreeImageAuthorize);
            this.SetParamObj(map, prefix + "ImageScanInquireInfo.", this.ImageScanInquireInfo);
            this.SetParamSimple(map, prefix + "RepeatImageIdCnt", this.RepeatImageIdCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

