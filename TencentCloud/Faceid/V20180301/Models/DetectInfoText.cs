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
        /// 本次流程最终验证结果。
        /// - 取值范围：0为成功。
        /// - 仅包含活体人脸核身结果，不包含意愿核身结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// 本次流程最终验证结果描述。
        /// - 仅描述用，文案更新时不会通知。
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
        /// 用户认证时使用的证件号码类型。
        /// - 取值范围：
        ///     0：二代身份证的证件号码。
        ///     1：港澳台居住证的证件号码。
        ///     2：其他（核验使用的证件号码非合法身份号码）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseIDType")]
        public ulong? UseIDType{ get; set; }

        /// <summary>
        /// 本次验证使用的姓名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 身份校验环节识别结果：民族。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrNation")]
        public string OcrNation{ get; set; }

        /// <summary>
        /// 身份校验环节识别结果：家庭住址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrAddress")]
        public string OcrAddress{ get; set; }

        /// <summary>
        /// 身份校验环节识别结果：生日。
        /// - 格式为：YYYY/M/D
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrBirth")]
        public string OcrBirth{ get; set; }

        /// <summary>
        /// 身份校验环节识别结果：签发机关。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrAuthority")]
        public string OcrAuthority{ get; set; }

        /// <summary>
        /// 身份校验环节识别结果：有效日期。
        /// - 格式为：YYYY.MM.DD-YYYY.MM.DD。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrValidDate")]
        public string OcrValidDate{ get; set; }

        /// <summary>
        /// 身份校验环节识别结果：姓名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrName")]
        public string OcrName{ get; set; }

        /// <summary>
        /// 身份校验环节识别结果：身份证号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrIdCard")]
        public string OcrIdCard{ get; set; }

        /// <summary>
        /// 身份校验环节识别结果：性别。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrGender")]
        public string OcrGender{ get; set; }

        /// <summary>
        /// 身份校验环节采用的信息上传方式。
        /// - 取值有"NFC"、"OCR"、"手动输入"、"其他"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdInfoFrom")]
        public string IdInfoFrom{ get; set; }

        /// <summary>
        /// 本次流程最终活体结果。
        /// - 0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveStatus")]
        public long? LiveStatus{ get; set; }

        /// <summary>
        /// 本次流程最终活体结果描述。
        /// - 仅描述用，文案更新时不会通知。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveMsg")]
        public string LiveMsg{ get; set; }

        /// <summary>
        /// 本次流程最终一比一结果。
        /// - 0为成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comparestatus")]
        public long? Comparestatus{ get; set; }

        /// <summary>
        /// 本次流程最终一比一结果描述。
        /// - 仅描述用，文案更新时不会通知。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comparemsg")]
        public string Comparemsg{ get; set; }

        /// <summary>
        /// 本次流程活体一比一的分数。
        /// - 取值范围 [0.00, 100.00]。
        /// - 相似度大于等于70时才判断为同一人，也可根据具体场景自行调整阈值。
        /// - 阈值70的误通过率为千分之一，阈值80的误通过率是万分之一。
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
        /// 描述当前请求活体阶段被拒绝的详细原因，该参数仅限PLUS版本核身服务返回。
        /// - 详情如下：
        ///     01-用户全程闭眼
        ///     02-用户未完成指定动作
        ///     03-疑似翻拍攻击
        ///     04-疑似合成攻击
        ///     05-疑似黑产模版
        ///     06-疑似存在水印
        ///     07-反光校验未通过
        ///     08-疑似中途换人
        ///     09-人脸质量过差
        ///     10-距离校验不通过
        ///     11-疑似对抗样本攻击
        ///     12-嘴巴区域疑似存在攻击痕迹
        ///     13-眼睛区域疑似存在攻击痕迹
        ///     14-眼睛或嘴巴被遮挡
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessInfoTag")]
        public string[] LivenessInfoTag{ get; set; }

        /// <summary>
        /// 手机号码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 本次流程最终比对库源类型。
        /// - 取值范围：
        ///     权威库。
        ///     业务方自有库（用户上传照片、客户的混合库、混合部署库）。
        ///     二次验证库。
        ///     人工审核库。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareLibType")]
        public string CompareLibType{ get; set; }

        /// <summary>
        /// 本次流程最终活体类型。
        /// - 取值范围：
        ///     0：未知
        ///     1：数字活体
        ///     2：动作活体
        ///     3：静默活体
        ///     4：一闪活体（动作+光线）
        ///     5：远近活体
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessMode")]
        public ulong? LivenessMode{ get; set; }

        /// <summary>
        /// nfc重复计费requestId列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NFCRequestIds")]
        public string[] NFCRequestIds{ get; set; }

        /// <summary>
        /// nfc重复计费计数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NFCBillingCounts")]
        public long? NFCBillingCounts{ get; set; }

        /// <summary>
        /// 港澳台居住证通行证号码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassNo")]
        public string PassNo{ get; set; }

        /// <summary>
        /// 港澳台居住证签发次数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VisaNum")]
        public string VisaNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "UseIDType", this.UseIDType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "OcrNation", this.OcrNation);
            this.SetParamSimple(map, prefix + "OcrAddress", this.OcrAddress);
            this.SetParamSimple(map, prefix + "OcrBirth", this.OcrBirth);
            this.SetParamSimple(map, prefix + "OcrAuthority", this.OcrAuthority);
            this.SetParamSimple(map, prefix + "OcrValidDate", this.OcrValidDate);
            this.SetParamSimple(map, prefix + "OcrName", this.OcrName);
            this.SetParamSimple(map, prefix + "OcrIdCard", this.OcrIdCard);
            this.SetParamSimple(map, prefix + "OcrGender", this.OcrGender);
            this.SetParamSimple(map, prefix + "IdInfoFrom", this.IdInfoFrom);
            this.SetParamSimple(map, prefix + "LiveStatus", this.LiveStatus);
            this.SetParamSimple(map, prefix + "LiveMsg", this.LiveMsg);
            this.SetParamSimple(map, prefix + "Comparestatus", this.Comparestatus);
            this.SetParamSimple(map, prefix + "Comparemsg", this.Comparemsg);
            this.SetParamSimple(map, prefix + "Sim", this.Sim);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamArrayObj(map, prefix + "LivenessDetail.", this.LivenessDetail);
            this.SetParamArraySimple(map, prefix + "LivenessInfoTag.", this.LivenessInfoTag);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "CompareLibType", this.CompareLibType);
            this.SetParamSimple(map, prefix + "LivenessMode", this.LivenessMode);
            this.SetParamArraySimple(map, prefix + "NFCRequestIds.", this.NFCRequestIds);
            this.SetParamSimple(map, prefix + "NFCBillingCounts", this.NFCBillingCounts);
            this.SetParamSimple(map, prefix + "PassNo", this.PassNo);
            this.SetParamSimple(map, prefix + "VisaNum", this.VisaNum);
        }
    }
}

