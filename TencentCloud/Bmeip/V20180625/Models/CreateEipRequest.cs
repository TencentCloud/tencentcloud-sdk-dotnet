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

namespace TencentCloud.Bmeip.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEipRequest : AbstractModel
    {
        
        /// <summary>
        /// 申请数量，默认为1, 最大 20
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// EIP计费方式，flow-流量计费；bandwidth-带宽计费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 带宽设定值（只在带宽计费时生效）
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// EIP模式，目前支持tunnel和fullnat
        /// </summary>
        [JsonProperty("SetType")]
        public string SetType{ get; set; }

        /// <summary>
        /// 是否使用独占集群，0：不使用，1：使用。默认为0
        /// </summary>
        [JsonProperty("Exclusive")]
        public ulong? Exclusive{ get; set; }

        /// <summary>
        /// EIP归属私有网络ID，例如vpc-k7j1t2x1
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 指定申请的IP列表
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "SetType", this.SetType);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
        }
    }
}

