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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCFWAssetStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// 网络资产总数
        /// </summary>
        [JsonProperty("NetworkTotal")]
        public long? NetworkTotal{ get; set; }

        /// <summary>
        /// 资产clb数量
        /// </summary>
        [JsonProperty("ClbTotal")]
        public long? ClbTotal{ get; set; }

        /// <summary>
        /// nat数量
        /// </summary>
        [JsonProperty("NatTotal")]
        public long? NatTotal{ get; set; }

        /// <summary>
        /// 公网ip数量
        /// </summary>
        [JsonProperty("PublicAssetTotal")]
        public long? PublicAssetTotal{ get; set; }

        /// <summary>
        /// 主机数量
        /// </summary>
        [JsonProperty("CVMAssetTotal")]
        public long? CVMAssetTotal{ get; set; }

        /// <summary>
        /// 配置风险
        /// </summary>
        [JsonProperty("CFGTotal")]
        public long? CFGTotal{ get; set; }

        /// <summary>
        /// 端口风险
        /// </summary>
        [JsonProperty("PortTotal")]
        public long? PortTotal{ get; set; }

        /// <summary>
        /// 内容风险
        /// </summary>
        [JsonProperty("WebsiteTotal")]
        public long? WebsiteTotal{ get; set; }

        /// <summary>
        /// 风险服务暴露
        /// </summary>
        [JsonProperty("ServerTotal")]
        public long? ServerTotal{ get; set; }

        /// <summary>
        /// 弱口令风险
        /// </summary>
        [JsonProperty("WeakPasswordTotal")]
        public long? WeakPasswordTotal{ get; set; }

        /// <summary>
        /// 漏洞风险
        /// </summary>
        [JsonProperty("VULTotal")]
        public long? VULTotal{ get; set; }

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
            this.SetParamSimple(map, prefix + "NetworkTotal", this.NetworkTotal);
            this.SetParamSimple(map, prefix + "ClbTotal", this.ClbTotal);
            this.SetParamSimple(map, prefix + "NatTotal", this.NatTotal);
            this.SetParamSimple(map, prefix + "PublicAssetTotal", this.PublicAssetTotal);
            this.SetParamSimple(map, prefix + "CVMAssetTotal", this.CVMAssetTotal);
            this.SetParamSimple(map, prefix + "CFGTotal", this.CFGTotal);
            this.SetParamSimple(map, prefix + "PortTotal", this.PortTotal);
            this.SetParamSimple(map, prefix + "WebsiteTotal", this.WebsiteTotal);
            this.SetParamSimple(map, prefix + "ServerTotal", this.ServerTotal);
            this.SetParamSimple(map, prefix + "WeakPasswordTotal", this.WeakPasswordTotal);
            this.SetParamSimple(map, prefix + "VULTotal", this.VULTotal);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

