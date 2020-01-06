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
        /// 告警码	告警码消息	                                                告警码说明
        /// -9102	WARN_DRIVER_LICENSE_COPY_CARD	        复印件告警
        /// -9103	WARN_DRIVER_LICENSE_SCREENED_CARD	翻拍件告警
        /// -9106	WARN_DRIVER_LICENSE_PS_CARD	                ps告警
        /// 注：告警码可以同时存在多个
        /// </summary>
        [JsonProperty("RecognizeWarnCode")]
        public long?[] RecognizeWarnCode{ get; set; }

        /// <summary>
        /// 告警码说明
        /// 注：告警信息可以同时存在多个
        /// </summary>
        [JsonProperty("RecognizeWarnMsg")]
        public string[] RecognizeWarnMsg{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FrontInfo.", this.FrontInfo);
            this.SetParamObj(map, prefix + "BackInfo.", this.BackInfo);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnCode.", this.RecognizeWarnCode);
            this.SetParamArraySimple(map, prefix + "RecognizeWarnMsg.", this.RecognizeWarnMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

