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

    public class GetWebVerificationResultResponse : AbstractModel
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
        /// 视频流中采集的最佳人脸照片临时地址，下载有效时间10分钟，如果需要存储请及时下载。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoBestFrameUrl")]
        public string VideoBestFrameUrl{ get; set; }

        /// <summary>
        /// 视频流中采集的最佳人脸照片内容MD5散列值，可以使用此值校验文件内容是否一致。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoBestFrameMd5")]
        public string VideoBestFrameMd5{ get; set; }

        /// <summary>
        /// 本次核验流程的详细信息列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerificationDetailList")]
        public VerificationDetail[] VerificationDetailList{ get; set; }

        /// <summary>
        /// 视频流中采集的视频临时地址，下载有效时间10分钟，如果需要存储请及时下载。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 视频流中采集的视频内容MD5散列值，可以使用此值校验文件内容是否一致。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoMd5")]
        public string VideoMd5{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "VideoBestFrameUrl", this.VideoBestFrameUrl);
            this.SetParamSimple(map, prefix + "VideoBestFrameMd5", this.VideoBestFrameMd5);
            this.SetParamArrayObj(map, prefix + "VerificationDetailList.", this.VerificationDetailList);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "VideoMd5", this.VideoMd5);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

