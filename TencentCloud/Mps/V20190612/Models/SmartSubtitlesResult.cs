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

    public class SmartSubtitlesResult : AbstractModel
    {
        
        /// <summary>
        /// 任务的类型，取值范围：
        /// - AsrFullTextRecognition：语音全文识别
        /// - TransTextRecognition：语音翻译
        /// - PureSubtitleTrans:   纯字幕翻译
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 语音全文识别结果，当 Type 为
        ///  AsrFullTextRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrFullTextTask")]
        public SmartSubtitleTaskAsrFullTextResult AsrFullTextTask{ get; set; }

        /// <summary>
        /// 翻译结果，当 Type 为
        /// 
        /// TransTextRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransTextTask")]
        public SmartSubtitleTaskTransTextResult TransTextTask{ get; set; }

        /// <summary>
        /// 当翻译类型为：PureSubtitleTrans 是返回纯字幕文件翻译结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PureSubtitleTransTask")]
        public PureSubtitleTransResult PureSubtitleTransTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "AsrFullTextTask.", this.AsrFullTextTask);
            this.SetParamObj(map, prefix + "TransTextTask.", this.TransTextTask);
            this.SetParamObj(map, prefix + "PureSubtitleTransTask.", this.PureSubtitleTransTask);
        }
    }
}

