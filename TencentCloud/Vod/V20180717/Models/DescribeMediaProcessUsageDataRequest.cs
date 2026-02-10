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

    public class DescribeMediaProcessUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始日期。使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#52)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束日期，需大于等于起始日期。使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#52)。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 查询视频处理任务类型，目前支持的任务类型包括：
        /// <li> Transcoding: 普通转码</li>
        /// <li> Transcoding-TESHD: 极速高清转码</li>
        /// <li> Editing: 视频编辑</li>
        /// <li> Editing-TESHD: 极速高清视频编辑</li>
        /// <li> AdaptiveBitrateStreaming: 自适应码流</li>
        /// <li> ContentAudit: 内容审核</li>
        /// <li> ContentRecognition: 内容识别</li>
        /// <li> RemoveWatermark: 去除水印</li>
        /// <li> ExtractTraceWatermark: 提取水印</li>
        /// <li> AddTraceWatermark: 添加水印</li>
        /// <li> RebuildMedia: 音画质重生</li>
        /// <li> QualityInspect: 音画质检测</li>
        /// <li> VideoHighlight: 视频智能集锦</li>
        /// <li> VideoTag: 视频智能标签</li>
        /// <li> VideoClassification:  视频智能分类</li>
        /// <li> VideoCover: 视频智能封面</li>
        /// <li> VideoSegment: 视频智能拆条</li>
        /// <li> VideoProduce: 视频制作</li>
        /// <li> MediaCast: 媒体转推</li>
        /// <li>Transcode: 转码，包含普通转码、极速高清和视频编辑（不推荐使用）</li>
        /// <li>VoiceTranslation: 语音翻译</li>
        /// <li>JITTranscoding: 即时转码</li>
        /// <li>VideoSnapshot: 视频截图</li>
        /// <li>JITEncryption: 即时加密</li>
        /// <li>MediaEnhancement: 音视频增强</li>
        /// <li>ImageCompression: 图片压缩</li>
        /// <li>ImageEnhancement: 图片增强</li>
        /// <li>ImageSuperResolution: 图片超分</li>
        /// <li>ImageAdvanceCompression: 图片高级压缩</li>
        /// <li>ImageUnderstanding: 图片理解</li>
        /// <li>AddTraceWatermark: 添加溯源水印</li>
        /// <li>AddBlindWatermark: 添加盲水印</li>
        /// <li>AddNagraWatermark: 添加NAGRA数字水印</li>
        /// <li>ExtractTraceWatermark: 提取溯源水印</li>
        /// <li>ExtractBlindWatermark: 提取盲水印</li>
        /// <li>ExtractNagraWatermark: 提取NAGRA数字水印</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

