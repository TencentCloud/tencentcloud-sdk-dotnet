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

    public class CreateExternalSourceAIServiceTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品 ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 云存 AI 服务类型。可选值：
        /// - `RealtimeObjectDetect`：目标检测
        /// - `Highlight`：视频浓缩
        /// - `VideoToText`：视频语义理解
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 分析外部传入的视频 URL 列表，支持 HLS 点播（m3u8）及常见视频格式（mp4 等）
        /// </summary>
        [JsonProperty("VideoURLs")]
        public string[] VideoURLs{ get; set; }

        /// <summary>
        /// 自定义任务 ID
        /// </summary>
        [JsonProperty("CustomId")]
        public string CustomId{ get; set; }

        /// <summary>
        /// 视频分析配置参数
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 视频分析识别区域
        /// </summary>
        [JsonProperty("ROI")]
        public string ROI{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamArraySimple(map, prefix + "VideoURLs.", this.VideoURLs);
            this.SetParamSimple(map, prefix + "CustomId", this.CustomId);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "ROI", this.ROI);
        }
    }
}

