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

    public class GetEidResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 人脸核身识别结果及文本类信息。
        /// - 基于对敏感信息的保护，验证使用的姓名和身份证号统一通过加密后从EidInfo参数中返回。
        /// - 如需获取请在控制台申请返回身份信息，详见[E证通获取实名信息指引](https://cloud.tencent.com/document/product/1007/63370)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Text")]
        public DetectInfoText Text{ get; set; }

        /// <summary>
        /// 身份证照片信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardData")]
        public DetectInfoIdCardData IdCardData{ get; set; }

        /// <summary>
        /// 最佳帧信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BestFrame")]
        public DetectInfoBestFrame BestFrame{ get; set; }

        /// <summary>
        /// Eid信息。
        /// - EidInfo字段只有在人脸核身控制台完成“申请返回实名信息”之后返回，操作指引详见 [E证通获取实名信息指引](https://cloud.tencent.com/document/product/1007/63370)。
        /// - Eid信息包括商户下用户唯一标识以及加密后的姓名、身份证号信息。
        /// - 解密方式详见 [E证通获取实名信息指引](https://cloud.tencent.com/document/product/1007/63370)
        /// - 只有整个核验流程完成之后才能返回该字段信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EidInfo")]
        public EidInfo EidInfo{ get; set; }

        /// <summary>
        /// 意愿核身朗读模式相关信息。
        /// - 若未使用意愿核身朗读功能，该字段返回值可以不处理。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentionVerifyData")]
        public IntentionVerifyData IntentionVerifyData{ get; set; }

        /// <summary>
        /// 意愿核身问答模式相关信息。
        /// - 若未使用意愿核身问答模式功能，该字段返回值可以不处理。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentionQuestionResult")]
        public IntentionQuestionResult IntentionQuestionResult{ get; set; }

        /// <summary>
        /// 意愿核身点头确认模式的结果信息。
        /// - 若未使用该意愿核身功能，该字段返回值可以不处理。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentionActionResult")]
        public IntentionActionResult IntentionActionResult{ get; set; }

        /// <summary>
        /// 本次请求是否配置开启意愿校验。 
        /// false：未开启意愿校验 
        /// true：已开启意愿校验 
        /// 说明：若请求开启了意愿校验，可结合IntentionVerifyType中具体使用的校验模式从对应的出参Result中获取最终的核验结果；若请求没有开启意愿校验，则可在出参Text中获取最终的核验结果。
        /// </summary>
        [JsonProperty("IsVerifyIntention")]
        public bool? IsVerifyIntention{ get; set; }

        /// <summary>
        /// 本次请求意愿校验使用的具体模式。 
        /// 0：问答模式 
        /// 1：点头确认模式 
        /// 2：朗读模式 
        /// 若未使用意愿核身功能，该字段返回值可以不处理。 
        /// 注意：此字段可能返回 null，表示取不到有效值
        /// </summary>
        [JsonProperty("IntentionVerifyType")]
        public string IntentionVerifyType{ get; set; }

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
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamObj(map, prefix + "IdCardData.", this.IdCardData);
            this.SetParamObj(map, prefix + "BestFrame.", this.BestFrame);
            this.SetParamObj(map, prefix + "EidInfo.", this.EidInfo);
            this.SetParamObj(map, prefix + "IntentionVerifyData.", this.IntentionVerifyData);
            this.SetParamObj(map, prefix + "IntentionQuestionResult.", this.IntentionQuestionResult);
            this.SetParamObj(map, prefix + "IntentionActionResult.", this.IntentionActionResult);
            this.SetParamSimple(map, prefix + "IsVerifyIntention", this.IsVerifyIntention);
            this.SetParamSimple(map, prefix + "IntentionVerifyType", this.IntentionVerifyType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

