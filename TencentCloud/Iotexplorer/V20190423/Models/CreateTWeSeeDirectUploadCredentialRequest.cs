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

    public class CreateTWeSeeDirectUploadCredentialRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品 ID</p><p>非 IoT 设备可传 <code>default</code></p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名称</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>算法类型</p><p>枚举值：</p><ul><li>VID_COMP： 视频理解（支持视频文件或多帧图片）</li><li>IMG_COMP： 图片理解（单帧图片）</li></ul>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>通道 ID</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// <p>回调目标 ID</p>
        /// </summary>
        [JsonProperty("CallbackId")]
        public string CallbackId{ get; set; }

        /// <summary>
        /// <p>视觉理解配置项</p>
        /// </summary>
        [JsonProperty("ComprehensionConfig")]
        public SeeComprehensionConfig ComprehensionConfig{ get; set; }

        /// <summary>
        /// <p>自定义事件 ID，会透传到任务元数据与回调中</p>
        /// </summary>
        [JsonProperty("CustomId")]
        public string CustomId{ get; set; }

        /// <summary>
        /// <p>临时密钥有效期，单位：秒。默认 300 秒，取值范围 5 到 86400。</p>
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public long? DurationSeconds{ get; set; }

        /// <summary>
        /// <p>该直传凭据最多可触发的分析次数</p><p>取值范围：[1, 10000]</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("MaxInvokeCount")]
        public long? MaxInvokeCount{ get; set; }

        /// <summary>
        /// <p>上传 COS 存储桶所在地域。不填时使用默认地域。</p>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p>上传方式</p><p>枚举值：</p><ul><li>single： 单文件上传</li><li>manifest： 上传源文件与 Manifest（先上传多个源文件，然后上传 Manifest JSON 触发分析）</li></ul><p>默认值：single</p>
        /// </summary>
        [JsonProperty("UploadMethod")]
        public string UploadMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "CallbackId", this.CallbackId);
            this.SetParamObj(map, prefix + "ComprehensionConfig.", this.ComprehensionConfig);
            this.SetParamSimple(map, prefix + "CustomId", this.CustomId);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
            this.SetParamSimple(map, prefix + "MaxInvokeCount", this.MaxInvokeCount);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "UploadMethod", this.UploadMethod);
        }
    }
}

