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

    public class VerificationDetail : AbstractModel
    {
        
        /// <summary>
        /// 本次核验最终结果。0为核验通过，是同一人。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// 本次核验最终结果描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// 本次核验活体结果。0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessErrorCode")]
        public long? LivenessErrorCode{ get; set; }

        /// <summary>
        /// 本次核验活体结果描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessErrorMsg")]
        public string LivenessErrorMsg{ get; set; }

        /// <summary>
        /// 本次核验比对结果。0为视频流中采集的最佳人脸照片和上传的比对照片是同一人。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareErrorCode")]
        public long? CompareErrorCode{ get; set; }

        /// <summary>
        /// 本次核验比对结果描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareErrorMsg")]
        public string CompareErrorMsg{ get; set; }

        /// <summary>
        /// 本次核验时间戳(毫秒)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReqTimestamp")]
        public ulong? ReqTimestamp{ get; set; }

        /// <summary>
        /// 本次核验视频流中采集的最佳人脸照片和上传的比对照片的相似度， 范围[0.00, 100.00]，默认大于等于70时判断为同一人。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Similarity")]
        public float? Similarity{ get; set; }

        /// <summary>
        /// 本次核验的唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Seq")]
        public string Seq{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "LivenessErrorCode", this.LivenessErrorCode);
            this.SetParamSimple(map, prefix + "LivenessErrorMsg", this.LivenessErrorMsg);
            this.SetParamSimple(map, prefix + "CompareErrorCode", this.CompareErrorCode);
            this.SetParamSimple(map, prefix + "CompareErrorMsg", this.CompareErrorMsg);
            this.SetParamSimple(map, prefix + "ReqTimestamp", this.ReqTimestamp);
            this.SetParamSimple(map, prefix + "Similarity", this.Similarity);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
        }
    }
}

