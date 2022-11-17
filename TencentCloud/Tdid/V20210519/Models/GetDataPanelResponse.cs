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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetDataPanelResponse : AbstractModel
    {
        
        /// <summary>
        /// 区块链网络数量
        /// </summary>
        [JsonProperty("BlockNetworkCount")]
        public long? BlockNetworkCount{ get; set; }

        /// <summary>
        /// 区块链网络名称
        /// </summary>
        [JsonProperty("BlockNetworkName")]
        public string BlockNetworkName{ get; set; }

        /// <summary>
        /// 当前区块高度
        /// </summary>
        [JsonProperty("BlockHeight")]
        public long? BlockHeight{ get; set; }

        /// <summary>
        /// 区块链网络类型
        /// </summary>
        [JsonProperty("BlockNetworkType")]
        public long? BlockNetworkType{ get; set; }

        /// <summary>
        /// did数量
        /// </summary>
        [JsonProperty("DidCount")]
        public long? DidCount{ get; set; }

        /// <summary>
        /// 凭证模版数量
        /// </summary>
        [JsonProperty("CptCount")]
        public long? CptCount{ get; set; }

        /// <summary>
        /// 已认证权威机构数量
        /// </summary>
        [JsonProperty("CertificatedAuthCount")]
        public long? CertificatedAuthCount{ get; set; }

        /// <summary>
        /// 颁发凭证数量
        /// </summary>
        [JsonProperty("IssueCptCount")]
        public long? IssueCptCount{ get; set; }

        /// <summary>
        /// 本周新增DID数量
        /// </summary>
        [JsonProperty("NewDidCount")]
        public long? NewDidCount{ get; set; }

        /// <summary>
        /// BCOS网络类型数量
        /// </summary>
        [JsonProperty("BcosCount")]
        public long? BcosCount{ get; set; }

        /// <summary>
        /// Fabric网络类型数量
        /// </summary>
        [JsonProperty("FabricCount")]
        public long? FabricCount{ get; set; }

        /// <summary>
        /// 长安链网络类型数量
        /// </summary>
        [JsonProperty("ChainMakerCount")]
        public long? ChainMakerCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "BlockNetworkCount", this.BlockNetworkCount);
            this.SetParamSimple(map, prefix + "BlockNetworkName", this.BlockNetworkName);
            this.SetParamSimple(map, prefix + "BlockHeight", this.BlockHeight);
            this.SetParamSimple(map, prefix + "BlockNetworkType", this.BlockNetworkType);
            this.SetParamSimple(map, prefix + "DidCount", this.DidCount);
            this.SetParamSimple(map, prefix + "CptCount", this.CptCount);
            this.SetParamSimple(map, prefix + "CertificatedAuthCount", this.CertificatedAuthCount);
            this.SetParamSimple(map, prefix + "IssueCptCount", this.IssueCptCount);
            this.SetParamSimple(map, prefix + "NewDidCount", this.NewDidCount);
            this.SetParamSimple(map, prefix + "BcosCount", this.BcosCount);
            this.SetParamSimple(map, prefix + "FabricCount", this.FabricCount);
            this.SetParamSimple(map, prefix + "ChainMakerCount", this.ChainMakerCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

