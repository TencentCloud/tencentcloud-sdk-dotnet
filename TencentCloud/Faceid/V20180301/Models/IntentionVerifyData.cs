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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntentionVerifyData : AbstractModel
    {
        
        /// <summary>
        /// 意愿确认环节中录制的视频（base64）。
        /// - 若不存在则为空字符串。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentionVerifyVideo")]
        public string IntentionVerifyVideo{ get; set; }

        /// <summary>
        /// 意愿确认环节中用户语音转文字的识别结果。
        /// - 若不存在则为空字符串。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrResult")]
        public string AsrResult{ get; set; }

        /// <summary>
        /// 意愿确认环节的结果码。
        /// - 当该结果码为0时，语音朗读的视频与语音识别结果才会返回。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// 意愿确认环节的结果信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 意愿确认环节中录制视频的最佳帧（base64）。
        /// - 若不存在则为空字符串。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentionVerifyBestFrame")]
        public string IntentionVerifyBestFrame{ get; set; }

        /// <summary>
        /// 本次流程用户语音与传入文本比对的相似度分值，取值范围 [0.00, 100.00]。只有配置了相似度阈值后才进行语音校验并返回相似度分值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrResultSimilarity")]
        [System.Obsolete]
        public string AsrResultSimilarity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntentionVerifyVideo", this.IntentionVerifyVideo);
            this.SetParamSimple(map, prefix + "AsrResult", this.AsrResult);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "IntentionVerifyBestFrame", this.IntentionVerifyBestFrame);
            this.SetParamSimple(map, prefix + "AsrResultSimilarity", this.AsrResultSimilarity);
        }
    }
}

