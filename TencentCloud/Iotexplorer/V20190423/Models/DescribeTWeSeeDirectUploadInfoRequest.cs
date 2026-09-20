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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTWeSeeDirectUploadInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品 ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名称</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>服务类型。</p><p>枚举值：</p><ul><li>VID_COMP： 视频理解</li><li>IMG_COMP： 图片理解</li></ul>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>上传方式。</p><p>枚举值：</p><ul><li>single： 单文件上传</li><li>manifest： 上传源文件与 Manifest（先上传多个源文件，然后上传 Manifest JSON 触发分析）</li></ul><p>默认值：single</p>
        /// </summary>
        [JsonProperty("UploadMethod")]
        public string UploadMethod{ get; set; }

        /// <summary>
        /// <p>上传目标，固定取值为 <code>stream</code>，不填时默认为 <code>stream</code></p><p>枚举值：</p><ul><li>stream： 上传到指定设备（加载对应设备的 ComprehensionConfig 等配置）</li></ul><p>默认值：stream</p>
        /// </summary>
        [JsonProperty("UploadTarget")]
        public string UploadTarget{ get; set; }

        /// <summary>
        /// <p>通道 ID，非 NVR 设备不填，NVR 设备必填</p>
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "UploadMethod", this.UploadMethod);
            this.SetParamSimple(map, prefix + "UploadTarget", this.UploadTarget);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
        }
    }
}

