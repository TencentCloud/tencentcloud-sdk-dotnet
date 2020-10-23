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

    public class DetectInfoText : AbstractModel
    {
        
        /// <summary>
        /// 本次流程最终验证结果。0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// 本次流程最终验证结果描述。（仅描述用，文案更新时不会通知。）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 本次验证使用的身份证号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 本次验证使用的姓名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Ocr识别结果。民族。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrNation")]
        public string OcrNation{ get; set; }

        /// <summary>
        /// Ocr识别结果。家庭住址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrAddress")]
        public string OcrAddress{ get; set; }

        /// <summary>
        /// Ocr识别结果。生日。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrBirth")]
        public string OcrBirth{ get; set; }

        /// <summary>
        /// Ocr识别结果。签发机关。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrAuthority")]
        public string OcrAuthority{ get; set; }

        /// <summary>
        /// Ocr识别结果。有效日期。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrValidDate")]
        public string OcrValidDate{ get; set; }

        /// <summary>
        /// Ocr识别结果。姓名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrName")]
        public string OcrName{ get; set; }

        /// <summary>
        /// Ocr识别结果。身份证号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrIdCard")]
        public string OcrIdCard{ get; set; }

        /// <summary>
        /// Ocr识别结果。性别。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrGender")]
        public string OcrGender{ get; set; }

        /// <summary>
        /// 本次流程最终活体结果。0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveStatus")]
        public long? LiveStatus{ get; set; }

        /// <summary>
        /// 本次流程最终活体结果描述。（仅描述用，文案更新时不会通知。）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveMsg")]
        public string LiveMsg{ get; set; }

        /// <summary>
        /// 本次流程最终一比一结果。0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comparestatus")]
        public long? Comparestatus{ get; set; }

        /// <summary>
        /// 本次流程最终一比一结果描述。（仅描述用，文案更新时不会通知。）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comparemsg")]
        public string Comparemsg{ get; set; }

        /// <summary>
        /// 本次流程活体一比一的分数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sim")]
        public string Sim{ get; set; }

        /// <summary>
        /// 地理位置经纬度。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Auth接口带入额外信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 本次流程进行的活体一比一流水。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessDetail")]
        public DetectDetail[] LivenessDetail{ get; set; }

        /// <summary>
        /// 手机号码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "OcrNation", this.OcrNation);
            this.SetParamSimple(map, prefix + "OcrAddress", this.OcrAddress);
            this.SetParamSimple(map, prefix + "OcrBirth", this.OcrBirth);
            this.SetParamSimple(map, prefix + "OcrAuthority", this.OcrAuthority);
            this.SetParamSimple(map, prefix + "OcrValidDate", this.OcrValidDate);
            this.SetParamSimple(map, prefix + "OcrName", this.OcrName);
            this.SetParamSimple(map, prefix + "OcrIdCard", this.OcrIdCard);
            this.SetParamSimple(map, prefix + "OcrGender", this.OcrGender);
            this.SetParamSimple(map, prefix + "LiveStatus", this.LiveStatus);
            this.SetParamSimple(map, prefix + "LiveMsg", this.LiveMsg);
            this.SetParamSimple(map, prefix + "Comparestatus", this.Comparestatus);
            this.SetParamSimple(map, prefix + "Comparemsg", this.Comparemsg);
            this.SetParamSimple(map, prefix + "Sim", this.Sim);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamArrayObj(map, prefix + "LivenessDetail.", this.LivenessDetail);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
        }
    }
}

