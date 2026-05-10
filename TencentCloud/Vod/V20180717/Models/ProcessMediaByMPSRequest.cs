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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessMediaByMPSRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>媒体文件 ID，即该文件在云点播上的全局唯一标识符，在上传成功后由云点播后台分配。可以在 <a href="/document/product/266/7830">视频上传完成事件通知</a> 或 <a href="https://console.cloud.tencent.com/vod/media">云点播控制台</a> 获取该字段。</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p><b>点播<a href="/document/product/266/14574">应用</a> ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>可选参数，该参数用于透传至媒体处理服务（MPS），以便从云点播侧发起 MPS 视频处理任务。不同类型的视频处理参数详情请参考 <a href="https://cloud.tencent.com/document/product/266/131209">使用MPS 媒体 AI 能力</a>，可通过<a href="https://cloud.tencent.com/document/product/266/122580">CreateMPSTemplate</a> 接口创建自定义模板。</p>
        /// </summary>
        [JsonProperty("MPSProcessMediaParams")]
        public string MPSProcessMediaParams{ get; set; }

        /// <summary>
        /// <p>视频内容分析类型任务参数，MPSProcessMediaParams为空时有效。</p>
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public MPSAiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// <p>智能字幕类型任务参数，MPSProcessMediaParams为空时有效。</p>
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public MPSSmartSubtitlesTaskInput SmartSubtitlesTask{ get; set; }

        /// <summary>
        /// <p>智能擦除类型任务参数，MPSProcessMediaParams为空时有效。</p>
        /// </summary>
        [JsonProperty("SmartEraseTask")]
        public MPSSmartEraseTaskInput SmartEraseTask{ get; set; }

        /// <summary>
        /// <p>保留字段，特殊用途时使用。</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "MPSProcessMediaParams", this.MPSProcessMediaParams);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
            this.SetParamObj(map, prefix + "SmartEraseTask.", this.SmartEraseTask);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

