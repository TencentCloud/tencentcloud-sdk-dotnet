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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartPredictReqData : AbstractModel
    {
        
        /// <summary>
        /// 病历和处方信息
        /// </summary>
        [JsonProperty("RequestCase")]
        public RequestCase RequestCase{ get; set; }

        /// <summary>
        /// 0--默认值，同时返回**疾病预测**和**用药审查**结果<br>1--仅返回**疾病预测**结果<br>2--仅返回**用药审查**结果<br>已同时激活两个模块时，可按需使用 
        /// </summary>
        [JsonProperty("RequestType")]
        public long? RequestType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RequestCase.", this.RequestCase);
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
        }
    }
}

