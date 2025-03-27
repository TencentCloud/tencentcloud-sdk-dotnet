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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClientSwitchTraTaskInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 客户UIN
        /// </summary>
        [JsonProperty("ClientUin")]
        public string ClientUin{ get; set; }

        /// <summary>
        /// 切换类型：代理,代采
        /// </summary>
        [JsonProperty("SwitchType")]
        public string SwitchType{ get; set; }

        /// <summary>
        /// ok，符合，fail，不符合
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 切换链接
        /// </summary>
        [JsonProperty("SwitchUrl")]
        public string SwitchUrl{ get; set; }

        /// <summary>
        /// 不符合的原因
        /// </summary>
        [JsonProperty("ResultMsg")]
        public string ResultMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "SwitchType", this.SwitchType);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "SwitchUrl", this.SwitchUrl);
            this.SetParamSimple(map, prefix + "ResultMsg", this.ResultMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

