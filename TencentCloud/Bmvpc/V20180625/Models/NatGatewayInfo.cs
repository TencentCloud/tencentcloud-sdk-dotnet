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

namespace TencentCloud.Bmvpc.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NatGatewayInfo : AbstractModel
    {
        
        /// <summary>
        /// NAT网关ID
        /// </summary>
        [JsonProperty("NatId")]
        public string NatId{ get; set; }

        /// <summary>
        /// 网关名称
        /// </summary>
        [JsonProperty("NatName")]
        public string NatName{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 网关状态，其中0表示创建中，1表示运行中，2表示创建失败
        /// </summary>
        [JsonProperty("ProductionStatus")]
        public ulong? ProductionStatus{ get; set; }

        /// <summary>
        /// EIP列表
        /// </summary>
        [JsonProperty("Eips")]
        public string[] Eips{ get; set; }

        /// <summary>
        /// 并发连接数规格，取值为1000000, 3000000, 10000000
        /// </summary>
        [JsonProperty("MaxConcurrent")]
        public ulong? MaxConcurrent{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 独占标识，其中0表示共享，1表示独占，默认值为0
        /// </summary>
        [JsonProperty("Exclusive")]
        public ulong? Exclusive{ get; set; }

        /// <summary>
        /// 转发模式，其中0表示IP方式，1表示网段方式
        /// </summary>
        [JsonProperty("ForwardMode")]
        public ulong? ForwardMode{ get; set; }

        /// <summary>
        /// 私有网络网段
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 网关类型，取值为 small，middle，big，分别对应小型、中型、大型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamSimple(map, prefix + "NatName", this.NatName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "ProductionStatus", this.ProductionStatus);
            this.SetParamArraySimple(map, prefix + "Eips.", this.Eips);
            this.SetParamSimple(map, prefix + "MaxConcurrent", this.MaxConcurrent);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "ForwardMode", this.ForwardMode);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

