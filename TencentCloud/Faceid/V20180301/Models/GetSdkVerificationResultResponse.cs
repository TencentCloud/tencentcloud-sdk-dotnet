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

    public class GetSdkVerificationResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 整个核验结果
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 计费次数
        /// </summary>
        [JsonProperty("ChargeCount")]
        public long? ChargeCount{ get; set; }

        /// <summary>
        /// 多次证照识别的结果（有序），取最终一次结果为有效结果
        /// </summary>
        [JsonProperty("CardVerifyResults")]
        public CardVerifyResult[] CardVerifyResults{ get; set; }

        /// <summary>
        /// 多次活体认证的结果信息（有序），取最终一次结果为有效结果
        /// </summary>
        [JsonProperty("CompareResults")]
        public CompareResult[] CompareResults{ get; set; }

        /// <summary>
        /// 获取token时传入的
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

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
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ChargeCount", this.ChargeCount);
            this.SetParamArrayObj(map, prefix + "CardVerifyResults.", this.CardVerifyResults);
            this.SetParamArrayObj(map, prefix + "CompareResults.", this.CompareResults);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

