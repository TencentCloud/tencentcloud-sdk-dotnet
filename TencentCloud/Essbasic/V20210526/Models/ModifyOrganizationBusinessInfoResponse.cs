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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyOrganizationBusinessInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>业务状态码。<br>0 表示正常（无阻断）；非 0 表示存在阻断，例如企业名称变更且存在未完结合同时返回 1。</p><p>枚举值：</p><ul><li>0： 正常（无阻断）</li><li>1： 存在未完结合同</li></ul>
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// <p>提示文案。<br>例如企业名称变更且存在未完结合同时返回「存在 X 份未完结的合同，请先撤销或者完成合同」。</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>未完结合同总数。<br>仅当企业名称变更且存在未完结合同时有值。</p>
        /// </summary>
        [JsonProperty("UnfinishedCount")]
        public ulong? UnfinishedCount{ get; set; }

        /// <summary>
        /// <p>SaaS 企业下未完结合同的 flowId 列表。</p>
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// <p>渠道子客企业下未完结合同的 flowId 列表。</p>
        /// </summary>
        [JsonProperty("ChannelFlowIds")]
        public string[] ChannelFlowIds{ get; set; }

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
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "UnfinishedCount", this.UnfinishedCount);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamArraySimple(map, prefix + "ChannelFlowIds.", this.ChannelFlowIds);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

