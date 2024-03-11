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

namespace TencentCloud.Tbaas.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryFabricChaincodeResponse : AbstractModel
    {
        
        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonProperty("TxId")]
        public string TxId{ get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonProperty("TxStatus")]
        public string TxStatus{ get; set; }

        /// <summary>
        /// 交易结果
        /// </summary>
        [JsonProperty("TxResult")]
        public string TxResult{ get; set; }

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
            this.SetParamSimple(map, prefix + "TxId", this.TxId);
            this.SetParamSimple(map, prefix + "TxStatus", this.TxStatus);
            this.SetParamSimple(map, prefix + "TxResult", this.TxResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

