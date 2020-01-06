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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveStreamAiRecognitionResultItem : AbstractModel
    {
        
        /// <summary>
        /// 结果的类型，取值范围：
        /// <li>FaceRecognition：人脸识别，</li>
        /// <li>AsrWordsRecognition：语音关键词识别，</li>
        /// <li>OcrWordsRecognition：文本关键词识别，</li>
        /// <li>AsrFullTextRecognition：语音全文识别，</li>
        /// <li>OcrFullTextRecognition：文本全文识别。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 人脸识别结果，当 Type 为
        /// FaceRecognition 时有效。
        /// </summary>
        [JsonProperty("FaceRecognitionResultSet")]
        public LiveStreamFaceRecognitionResult[] FaceRecognitionResultSet{ get; set; }

        /// <summary>
        /// 语音关键词识别结果，当 Type 为
        /// AsrWordsRecognition 时有效。
        /// </summary>
        [JsonProperty("AsrWordsRecognitionResultSet")]
        public LiveStreamAsrWordsRecognitionResult[] AsrWordsRecognitionResultSet{ get; set; }

        /// <summary>
        /// 文本关键词识别结果，当 Type 为
        /// OcrWordsRecognition 时有效。
        /// </summary>
        [JsonProperty("OcrWordsRecognitionResultSet")]
        public LiveStreamOcrWordsRecognitionResult[] OcrWordsRecognitionResultSet{ get; set; }

        /// <summary>
        /// 语音全文识别结果，当 Type 为
        /// AsrFullTextRecognition 时有效。
        /// </summary>
        [JsonProperty("AsrFullTextRecognitionResultSet")]
        public LiveStreamAsrFullTextRecognitionResult[] AsrFullTextRecognitionResultSet{ get; set; }

        /// <summary>
        /// 文本全文识别结果，当 Type 为
        /// OcrFullTextRecognition 时有效。
        /// </summary>
        [JsonProperty("OcrFullTextRecognitionResultSet")]
        public LiveStreamOcrFullTextRecognitionResult[] OcrFullTextRecognitionResultSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "FaceRecognitionResultSet.", this.FaceRecognitionResultSet);
            this.SetParamArrayObj(map, prefix + "AsrWordsRecognitionResultSet.", this.AsrWordsRecognitionResultSet);
            this.SetParamArrayObj(map, prefix + "OcrWordsRecognitionResultSet.", this.OcrWordsRecognitionResultSet);
            this.SetParamArrayObj(map, prefix + "AsrFullTextRecognitionResultSet.", this.AsrFullTextRecognitionResultSet);
            this.SetParamArrayObj(map, prefix + "OcrFullTextRecognitionResultSet.", this.OcrFullTextRecognitionResultSet);
        }
    }
}

