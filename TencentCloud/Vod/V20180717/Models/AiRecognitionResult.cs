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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiRecognitionResult : AbstractModel
    {
        
        /// <summary>
        /// 任务的类型，取值范围：
        /// <li>FaceRecognition：人脸识别，</li>
        /// <li>AsrWordsRecognition：语音关键词识别，</li>
        /// <li>OcrWordsRecognition：文本关键词识别，</li>
        /// <li>AsrFullTextRecognition：语音全文识别，</li>
        /// <li>OcrFullTextRecognition：文本全文识别，</li>
        /// <li>HeadTailRecognition：视频片头片尾识别，</li>
        /// <li>ObjectRecognition：物体识别。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 视频片头片尾识别结果，当 Type 为
        ///  HeadTailRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeadTailTask")]
        public AiRecognitionTaskHeadTailResult HeadTailTask{ get; set; }

        /// <summary>
        /// 视频拆条识别结果，当 Type 为
        ///  SegmentRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SegmentTask")]
        public AiRecognitionTaskSegmentResult SegmentTask{ get; set; }

        /// <summary>
        /// 人脸识别结果，当 Type 为 
        ///  FaceRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FaceTask")]
        public AiRecognitionTaskFaceResult FaceTask{ get; set; }

        /// <summary>
        /// 语音关键词识别结果，当 Type 为
        ///  AsrWordsRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrWordsTask")]
        public AiRecognitionTaskAsrWordsResult AsrWordsTask{ get; set; }

        /// <summary>
        /// 语音全文识别结果，当 Type 为
        ///  AsrFullTextRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrFullTextTask")]
        public AiRecognitionTaskAsrFullTextResult AsrFullTextTask{ get; set; }

        /// <summary>
        /// 文本关键词识别结果，当 Type 为
        ///  OcrWordsRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrWordsTask")]
        public AiRecognitionTaskOcrWordsResult OcrWordsTask{ get; set; }

        /// <summary>
        /// 文本全文识别结果，当 Type 为
        ///  OcrFullTextRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrFullTextTask")]
        public AiRecognitionTaskOcrFullTextResult OcrFullTextTask{ get; set; }

        /// <summary>
        /// 物体识别结果，当 Type 为
        ///  ObjectRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectTask")]
        public AiRecognitionTaskObjectResult ObjectTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "HeadTailTask.", this.HeadTailTask);
            this.SetParamObj(map, prefix + "SegmentTask.", this.SegmentTask);
            this.SetParamObj(map, prefix + "FaceTask.", this.FaceTask);
            this.SetParamObj(map, prefix + "AsrWordsTask.", this.AsrWordsTask);
            this.SetParamObj(map, prefix + "AsrFullTextTask.", this.AsrFullTextTask);
            this.SetParamObj(map, prefix + "OcrWordsTask.", this.OcrWordsTask);
            this.SetParamObj(map, prefix + "OcrFullTextTask.", this.OcrFullTextTask);
            this.SetParamObj(map, prefix + "ObjectTask.", this.ObjectTask);
        }
    }
}

