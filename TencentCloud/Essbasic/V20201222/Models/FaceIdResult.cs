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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceIdResult : AbstractModel
    {
        
        /// <summary>
        /// 核身结果：
        /// 0 - 通过；
        /// 1 - 未通过
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }

        /// <summary>
        /// 核身失败描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 订单号 (orderNo)
        /// </summary>
        [JsonProperty("OrderNumber")]
        public string OrderNumber{ get; set; }

        /// <summary>
        /// 姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 身份证件类型： 
        /// ID_CARD - 居民身份证
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 身份证件号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 活体检测得分 (百分制)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveRate")]
        public long? LiveRate{ get; set; }

        /// <summary>
        /// 人脸检测得分 (百分制)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Similarity")]
        public float? Similarity{ get; set; }

        /// <summary>
        /// 刷脸时间 (UNIX时间戳)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OccurredTime")]
        public long? OccurredTime{ get; set; }

        /// <summary>
        /// 照片数据 (base64编码, 一般为JPG或PNG)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Photo")]
        public string Photo{ get; set; }

        /// <summary>
        /// 视频数据 (base64编码, 一般为MP4)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Video")]
        public string Video{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OrderNumber", this.OrderNumber);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "LiveRate", this.LiveRate);
            this.SetParamSimple(map, prefix + "Similarity", this.Similarity);
            this.SetParamSimple(map, prefix + "OccurredTime", this.OccurredTime);
            this.SetParamSimple(map, prefix + "Photo", this.Photo);
            this.SetParamSimple(map, prefix + "Video", this.Video);
        }
    }
}

