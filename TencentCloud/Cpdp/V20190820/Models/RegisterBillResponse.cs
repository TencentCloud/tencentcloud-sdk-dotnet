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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterBillResponse : AbstractModel
    {
        
        /// <summary>
        /// 银行流水号
        /// </summary>
        [JsonProperty("FrontSeqNo")]
        public string FrontSeqNo{ get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [JsonProperty("ReservedMessage")]
        public string ReservedMessage{ get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType{ get; set; }

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
            this.SetParamSimple(map, prefix + "FrontSeqNo", this.FrontSeqNo);
            this.SetParamSimple(map, prefix + "ReservedMessage", this.ReservedMessage);
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

