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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranscodeTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 视频转码模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 视频转码自定义参数，当 Definition 填 0 时有效。
        /// 该参数用于高度定制场景，建议您优先使用 Definition 指定转码参数。
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawTranscodeParameter RawParameter{ get; set; }

        /// <summary>
        /// 视频转码自定义参数，当 Definition 不填 0 时有效。
        /// 当填写了该结构中的部分转码参数时，将使用填写的参数覆盖转码模板中的参数。
        /// 该参数用于高度定制场景，建议您仅使用 Definition 指定转码参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OverrideParameter")]
        public OverrideTranscodeParameter OverrideParameter{ get; set; }

        /// <summary>
        /// 水印列表，支持多张图片或文字水印，最大可支持 10 张。
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// 数字水印参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlindWatermark")]
        public BlindWatermarkInput BlindWatermark{ get; set; }

        /// <summary>
        /// 马赛克列表，最大可支持 10 张。
        /// </summary>
        [JsonProperty("MosaicSet")]
        public MosaicInput[] MosaicSet{ get; set; }

        /// <summary>
        /// 转码后的视频的起始时间偏移，单位：秒。
        /// <li>不填或填0，表示转码后的视频从原始视频的起始位置开始；</li>
        /// <li>当数值大于0时（假设为 n），表示转码后的视频从原始视频的第 n 秒位置开始；</li>
        /// <li>当数值小于0时（假设为 -n），表示转码后的视频从原始视频结束 n 秒前的位置开始。</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 转码后视频的终止时间偏移，单位：秒。
        /// <li>不填或填0，表示转码后的视频持续到原始视频的末尾终止；</li>
        /// <li>当数值大于0时（假设为 n），表示转码后的视频持续到原始视频第 n 秒时终止；</li>
        /// <li>当数值小于0时（假设为 -n），表示转码后的视频持续到原始视频结束 n 秒前终止。</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// 转码后文件的目标存储，不填则继承上层的 OutputStorage 值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 转码后主文件的输出路径，可以为相对路径或者绝对路径。
        /// 若需定义输出路径，路径需以`.{format}`结尾。变量名请参考 [文件名变量说明](https://cloud.tencent.com/document/product/862/37039)。
        /// 相对路径示例：
        /// <li>文件名_{变量名}.{format}</li>
        /// <li>文件名.{format}</li>
        /// 绝对路径示例：
        /// <li>/自定义路径/文件名_{变量名}.{format}</li>
        /// 如果不填，则默认为相对路径：`{inputName}_transcode_{definition}.{format}`。
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// 转码后分片文件的输出路径（转码 HLS 时 ts 的路径），只能为相对路径。如果不填，则默认为：`{inputName}_transcode_{definition}_{number}.{format}`。
        /// </summary>
        [JsonProperty("SegmentObjectName")]
        public string SegmentObjectName{ get; set; }

        /// <summary>
        /// 转码后输出路径中的`{number}`变量的规则。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectNumberFormat")]
        public NumberFormat ObjectNumberFormat{ get; set; }

        /// <summary>
        /// 片头片尾参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeadTailParameter")]
        public HeadTailParameter HeadTailParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "RawParameter.", this.RawParameter);
            this.SetParamObj(map, prefix + "OverrideParameter.", this.OverrideParameter);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
            this.SetParamObj(map, prefix + "BlindWatermark.", this.BlindWatermark);
            this.SetParamArrayObj(map, prefix + "MosaicSet.", this.MosaicSet);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
            this.SetParamSimple(map, prefix + "SegmentObjectName", this.SegmentObjectName);
            this.SetParamObj(map, prefix + "ObjectNumberFormat.", this.ObjectNumberFormat);
            this.SetParamObj(map, prefix + "HeadTailParameter.", this.HeadTailParameter);
        }
    }
}

