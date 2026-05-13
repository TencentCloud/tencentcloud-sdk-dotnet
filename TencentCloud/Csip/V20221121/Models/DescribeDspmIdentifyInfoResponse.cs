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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDspmIdentifyInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 身份id
        /// </summary>
        [JsonProperty("IdentifyId")]
        public string IdentifyId{ get; set; }

        /// <summary>
        /// 身份统计信息
        /// </summary>
        [JsonProperty("IdentifyCount")]
        public DspmIdentifyCount[] IdentifyCount{ get; set; }

        /// <summary>
        /// 申请单个数
        /// </summary>
        [JsonProperty("ApplyOrderCount")]
        public long? ApplyOrderCount{ get; set; }

        /// <summary>
        /// 审批单个数
        /// </summary>
        [JsonProperty("ApproveOrderCount")]
        public long? ApproveOrderCount{ get; set; }

        /// <summary>
        /// 已审批个数
        /// </summary>
        [JsonProperty("ApproveHistoryCount")]
        public long? ApproveHistoryCount{ get; set; }

        /// <summary>
        /// 资产总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// 云账号总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UinAccountCount")]
        public long? UinAccountCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "IdentifyId", this.IdentifyId);
            this.SetParamArrayObj(map, prefix + "IdentifyCount.", this.IdentifyCount);
            this.SetParamSimple(map, prefix + "ApplyOrderCount", this.ApplyOrderCount);
            this.SetParamSimple(map, prefix + "ApproveOrderCount", this.ApproveOrderCount);
            this.SetParamSimple(map, prefix + "ApproveHistoryCount", this.ApproveHistoryCount);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "UinAccountCount", this.UinAccountCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

