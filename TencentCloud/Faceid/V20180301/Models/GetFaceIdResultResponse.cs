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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFaceIdResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 身份证。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 姓名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 业务核验结果。
        /// - 参考：https://cloud.tencent.com/document/product/1007/47912。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 业务核验描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 相似度。
        /// - 取值：0-100。
        /// - 数值越大相似度越高。
        /// </summary>
        [JsonProperty("Similarity")]
        public float? Similarity{ get; set; }

        /// <summary>
        /// 用户核验的视频base64。
        /// - 如果选择了使用cos，返回完整cos地址，如https://bucket.cos.ap-guangzhou.myqcloud.com/objectKey。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoBase64")]
        public string VideoBase64{ get; set; }

        /// <summary>
        /// 用户核验视频的截帧base64。
        /// - 如果选择了使用cos，返回完整cos地址如https://bucket.cos.ap-guangzhou.myqcloud.com/objectKey。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BestFrameBase64")]
        public string BestFrameBase64{ get; set; }

        /// <summary>
        /// 获取token时透传的信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// plus版：描述当前请求所在设备的风险标签。
        /// - 详情如下：
        /// 06-疑似黑产设备。
        /// null-无设备风险。
        /// - 增强版：此字段不生效，默认为null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceInfoTag")]
        public string DeviceInfoTag{ get; set; }

        /// <summary>
        /// 行为风险标签。
        /// - 仅错误码返回1007（设备疑似被劫持）时返回风险标签。
        /// - 标签说明：
        /// 02：攻击风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskInfoTag")]
        public string RiskInfoTag{ get; set; }

        /// <summary>
        /// plus版：描述当前请求活体阶段被拒绝的详细原因。
        /// - 详情如下：
        /// 01-用户全程闭眼。
        /// 02-用户未完成指定动作。
        /// 03-疑似翻拍攻击。
        /// 04-疑似合成图片。
        /// 05-疑似合成视频。
        /// 06-疑似合成动作。
        /// 07-疑似黑产模板。
        /// 08-疑似存在水印。
        /// 09-反光校验未通过。
        /// 10-最佳帧校验未通过。
        /// 11-人脸质量过差。
        /// 12-人脸距离不匹配。
        /// 13-疑似对抗样本攻击。
        /// null-无。
        /// - 增强版：此字段不生效，默认为null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessInfoTag")]
        public string LivenessInfoTag{ get; set; }

        /// <summary>
        /// plus版：描述当前请求所在设备的风险等级，共4级。
        /// - 详情如下：
        /// 1 - 安全。
        /// 2 - 低风险。
        /// 3 - 中风险。
        /// 4 - 高危。
        /// null - 未获取到风险等级。
        /// - 增强版：此字段不生效，默认为null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceInfoLevel")]
        public string DeviceInfoLevel{ get; set; }

        /// <summary>
        /// 敏感数据加密信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// 加密后的数据。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptedBody")]
        public string EncryptedBody{ get; set; }

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
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Similarity", this.Similarity);
            this.SetParamSimple(map, prefix + "VideoBase64", this.VideoBase64);
            this.SetParamSimple(map, prefix + "BestFrameBase64", this.BestFrameBase64);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "DeviceInfoTag", this.DeviceInfoTag);
            this.SetParamSimple(map, prefix + "RiskInfoTag", this.RiskInfoTag);
            this.SetParamSimple(map, prefix + "LivenessInfoTag", this.LivenessInfoTag);
            this.SetParamSimple(map, prefix + "DeviceInfoLevel", this.DeviceInfoLevel);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamSimple(map, prefix + "EncryptedBody", this.EncryptedBody);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

