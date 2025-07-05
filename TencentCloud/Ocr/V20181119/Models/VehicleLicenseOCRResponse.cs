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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VehicleLicenseOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 行驶证主页正面的识别结果，CardSide 为 FRONT。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrontInfo")]
        public TextVehicleFront FrontInfo{ get; set; }

        /// <summary>
        /// 行驶证副页正面的识别结果，CardSide 为 BACK。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackInfo")]
        public TextVehicleBack BackInfo{ get; set; }

        /// <summary>
        /// Code 告警码列表和释义：
        /// -9102  复印件告警
        /// -9103  翻拍件告警
        /// -9104  反光告警
        /// -9105  模糊告警
        /// -9106  边框不完整告警
        /// 注：告警码可以同时存在多个
        /// </summary>
        [JsonProperty("RecognizeWarnCode")]
        public long?[] RecognizeWarnCode{ get; set; }

        /// <summary>
        /// 告警码说明：
        /// WARN_DRIVER_LICENSE_COPY_CARD 复印件告警
        /// WARN_DRIVER_LICENSE_SCREENED_CARD 翻拍件告警
        /// WARN_DRIVER_LICENSE_REFLECTION 反光告警
        /// WARN_DRIVER_LICENSE_BLUR 模糊告警
        /// WARN_DRIVER_LICENSE_BORDER_INCOMPLETE 边框不完整告警
        /// 注：告警信息可以同时存在多个
        /// </summary>
        [JsonProperty("RecognizeWarnMsg")]
        public string[] RecognizeWarnMsg{ get; set; }

        /// <summary>
        /// 行驶证类型 电子行驶证：Electronic 普通行驶证：Normal
        /// </summary>
        [JsonProperty("VehicleLicenseType")]
        public string VehicleLicenseType{ get; set; }

        /// <summary>
        /// 拖拉机行驶证副页正面的识别结果，CardSide 为 BACK。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TractorBackInfo")]
        public TextTractorVehicleBack TractorBackInfo{ get; set; }

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
            this.SetParamObj(map, prefix + "FrontInfo.", this.FrontInfo);
            this.SetParamObj(map, prefix + "BackInfo.", this.BackInfo);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnCode.", this.RecognizeWarnCode);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnMsg.", this.RecognizeWarnMsg);
            this.SetParamSimple(map, prefix + "VehicleLicenseType", this.VehicleLicenseType);
            this.SetParamObj(map, prefix + "TractorBackInfo.", this.TractorBackInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

