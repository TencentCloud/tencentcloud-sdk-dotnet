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

namespace TencentCloud.Vm.V20210922.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>该字段用于返回创建视频审核任务后返回的任务ID（在Results参数中），用于标识需要查询任务详情的审核任务。</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>该字段用于返回调用视频审核接口时传入的数据ID参数，方便数据的辨别和管理。</p>
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// <p>该字段用于返回调用视频审核接口时传入的BizType参数，方便数据的辨别和管理。</p>
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// <p>该字段用于返回调用视频审核接口时传入的TaskInput参数中的任务名称，方便任务的识别与管理。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>该字段用于返回所查询内容的任务状态。<br><br>取值：<strong>FINISH</strong>（任务已完成）、<strong>PENDING</strong> （任务等待中）、<strong>RUNNING</strong> （任务进行中）、<strong>ERROR</strong> （任务出错）、<strong>CANCELLED</strong> （任务已取消）。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>该字段用于返回调用视频审核接口时输入的视频审核类型，取值为：<strong>VIDEO</strong>（点播视频）、<strong>LIVE_VIDEO</strong>（直播视频）和<strong>VIDEO_AIGC</strong>（AI生成检测），默认值为VIDEO。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>该字段用于返回基于恶意标签的后续操作建议。当您获取到判定结果后，返回值表示系统推荐的后续操作；建议您按照业务所需，对不同违规类型与建议值进行处理。<br>返回值：<strong>Block</strong>：建议屏蔽，<strong>Review</strong> ：建议人工复审，<strong>Pass</strong>：建议通过</p>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// <p>该字段用于返回检测结果所对应的恶意标签。<br>返回值：<strong>Porn</strong>：色情，<strong>Abuse</strong>：谩骂，<strong>Ad</strong>：广告，<strong>Custom</strong>：自定义违规；以及其他令人反感、不安全或不适宜的内容类型。</p>
        /// </summary>
        [JsonProperty("Labels")]
        public TaskLabel[] Labels{ get; set; }

        /// <summary>
        /// <p>该字段用于返回输入媒体文件的详细信息，包括编解码格式、分片时长等信息。详细内容敬请参考MediaInfo数据结构的描述。</p>
        /// </summary>
        [JsonProperty("MediaInfo")]
        public MediaInfo MediaInfo{ get; set; }

        /// <summary>
        /// <p>该字段用于返回审核服务的媒体内容信息，主要包括传入文件类型和访问地址。</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public InputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>该字段用于返回被查询任务创建的时间，格式采用 ISO 8601标准。</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>该字段用于返回被查询任务最后更新时间，格式采用 ISO 8601标准。</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// <p>在秒后重试</p>
        /// </summary>
        [JsonProperty("TryInSeconds")]
        public long? TryInSeconds{ get; set; }

        /// <summary>
        /// <p>该字段用于返回视频中截帧审核的结果，详细返回内容敬请参考ImageSegments数据结构的描述。</p>
        /// </summary>
        [JsonProperty("ImageSegments")]
        public ImageSegments[] ImageSegments{ get; set; }

        /// <summary>
        /// <p>该字段用于返回视频中音频审核的结果，详细返回内容敬请参考AudioSegments数据结构的描述。</p>
        /// </summary>
        [JsonProperty("AudioSegments")]
        public AudioSegments[] AudioSegments{ get; set; }

        /// <summary>
        /// <p>当任务状态为Error时，返回对应错误的类型，取值：<br><strong>DECODE_ERROR</strong>: 解码失败。（输入资源中可能包含无法解码的视频）<br><strong>URL_ERROR</strong>：下载地址验证失败。<br><strong>TIMEOUT_ERROR</strong>：处理超时。<br><strong>CALLBACK_ERRORR</strong>：回调错误。<br><strong>MODERATION_ERROR</strong>：审核失败。<br><strong>URL_NOT_SUPPORTED</strong>：源文件太大或没有图片音频帧<br>任务状态非Error时默认返回为空。</p>
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// <p>当任务状态为Error时，该字段用于返回对应错误的详细描述，任务状态非Error时默认返回为空。</p>
        /// </summary>
        [JsonProperty("ErrorDescription")]
        public string ErrorDescription{ get; set; }

        /// <summary>
        /// <p>该字段用于返回检测结果所对应的标签。如果未命中恶意，返回Normal，如果命中恶意，则返回Labels中优先级最高的标签</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// <p>该字段用于返回音频文件识别出的对应文本内容，最大支持<strong>前1000个字符</strong>。</p>
        /// </summary>
        [JsonProperty("AudioText")]
        public string AudioText{ get; set; }

        /// <summary>
        /// <p>该字段用于返回音频文件识别出的对应文本内容。</p>
        /// </summary>
        [JsonProperty("Asrs")]
        public RcbAsr[] Asrs{ get; set; }

        /// <summary>
        /// <p>该字段用于返回检测结果明细数据相关的cos url</p>
        /// </summary>
        [JsonProperty("SegmentCosUrlList")]
        public SegmentCosUrlList SegmentCosUrlList{ get; set; }

        /// <summary>
        /// <p>该字段用于返回视频中视频切片审核的结果</p>
        /// </summary>
        [JsonProperty("VideoSegments")]
        public VideoSegment[] VideoSegments{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamObj(map, prefix + "MediaInfo.", this.MediaInfo);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "TryInSeconds", this.TryInSeconds);
            this.SetParamArrayObj(map, prefix + "ImageSegments.", this.ImageSegments);
            this.SetParamArrayObj(map, prefix + "AudioSegments.", this.AudioSegments);
            this.SetParamSimple(map, prefix + "ErrorType", this.ErrorType);
            this.SetParamSimple(map, prefix + "ErrorDescription", this.ErrorDescription);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "AudioText", this.AudioText);
            this.SetParamArrayObj(map, prefix + "Asrs.", this.Asrs);
            this.SetParamObj(map, prefix + "SegmentCosUrlList.", this.SegmentCosUrlList);
            this.SetParamArrayObj(map, prefix + "VideoSegments.", this.VideoSegments);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

