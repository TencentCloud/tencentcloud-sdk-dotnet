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

    public class MPSAiMediaTask : AbstractModel
    {
        
        /// <summary>
        /// MPS智能任务的模板 ID
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// MPS智能任务输出文件集合
        /// </summary>
        [JsonProperty("OutputFile")]
        public MPSOutputFileInfo[] OutputFile{ get; set; }

        /// <summary>
        /// MPS智能任务返回的结果，该字段对应 MPS 任务返回中的Output结果，以 JSON 格式返回
        /// 不同MPS任务输出结果结构不同，具体返回内容参考MPS任务输出结构体
        /// [智能分类结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskClassificationOutput)
        /// [智能封面结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskCoverOutput)
        /// [智能标签结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskTagOutput)
        /// [智能按帧标签分类结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskFrameTagOutput)
        /// [智能高光结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskHighlightOutput)
        /// [智能拆条结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskSegmentOutput)
        /// [智能片头片尾结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskHeadTailOutput)
        /// [智能摘要结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskDescriptionOutput)
        /// [智能横转竖结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskHorizontalToVerticalOutput)
        /// [智能译制结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskDubbingOutput)
        /// [智能视频理解结果](https://cloud.tencent.com/document/product/862/37615#AiAnalysisTaskVideoComprehensionOutput)
        /// [智能字幕语音全文识别结果](https://cloud.tencent.com/document/product/862/37615#SmartSubtitleTaskAsrFullTextResultOutput)
        /// [智能字幕翻译结果](https://cloud.tencent.com/document/product/862/37615#SmartSubtitleTaskTransTextResultOutput)
        /// [智能字幕纯字幕文件翻译结果](https://cloud.tencent.com/document/product/862/37615#PureSubtitleTransResultOutput)
        /// [智能字幕文字提取字幕结果](https://cloud.tencent.com/document/product/862/37615#SmartSubtitleTaskTextResultOutput)
        /// 
        /// </summary>
        [JsonProperty("OutputText")]
        public string OutputText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArrayObj(map, prefix + "OutputFile.", this.OutputFile);
            this.SetParamSimple(map, prefix + "OutputText", this.OutputText);
        }
    }
}

