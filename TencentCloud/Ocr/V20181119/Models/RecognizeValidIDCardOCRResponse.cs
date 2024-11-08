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

    public class RecognizeValidIDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 卡证类型
        /// 身份证人像面
        /// 身份证国徽面
        /// 
        /// 临时身份证人像面
        /// 临时身份证人像面
        /// 
        /// 港澳台居住证人像面
        /// 港澳台居住证国徽面
        /// 
        /// 外国人永久居留证人像面
        /// 外国人永久居留证国徽面
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 身份证信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IDCardInfo")]
        public IDCardInfo IDCardInfo{ get; set; }

        /// <summary>
        /// 临时身份证信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemporaryIDCardInfo")]
        public TemporaryIDCardInfo TemporaryIDCardInfo{ get; set; }

        /// <summary>
        /// 港澳台居住证信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResidencePermitInfo")]
        public ResidencePermitInfo ResidencePermitInfo{ get; set; }

        /// <summary>
        /// 外国人永久居留证信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PermanentResidencePermitInfo")]
        public PermanentResidencePermitInfo PermanentResidencePermitInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "IDCardInfo.", this.IDCardInfo);
            this.SetParamObj(map, prefix + "TemporaryIDCardInfo.", this.TemporaryIDCardInfo);
            this.SetParamObj(map, prefix + "ResidencePermitInfo.", this.ResidencePermitInfo);
            this.SetParamObj(map, prefix + "PermanentResidencePermitInfo.", this.PermanentResidencePermitInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

