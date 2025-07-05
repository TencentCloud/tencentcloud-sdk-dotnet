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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SchedulingDomain : AbstractModel
    {
        
        /// <summary>
        /// 调度域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// BGP线路IP列表
        /// </summary>
        [JsonProperty("BGPIpList")]
        public string[] BGPIpList{ get; set; }

        /// <summary>
        /// 电信线路IP列表
        /// </summary>
        [JsonProperty("CTCCIpList")]
        public string[] CTCCIpList{ get; set; }

        /// <summary>
        /// 联通线路IP列表
        /// </summary>
        [JsonProperty("CUCCIpList")]
        public string[] CUCCIpList{ get; set; }

        /// <summary>
        /// 移动线路IP列表
        /// </summary>
        [JsonProperty("CMCCIpList")]
        public string[] CMCCIpList{ get; set; }

        /// <summary>
        /// 海外线路IP列表
        /// </summary>
        [JsonProperty("OverseaIpList")]
        public string[] OverseaIpList{ get; set; }

        /// <summary>
        /// 调度方式，当前仅支持优先级, 取值为priority
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// ttl
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "BGPIpList.", this.BGPIpList);
            this.SetParamArraySimple(map, prefix + "CTCCIpList.", this.CTCCIpList);
            this.SetParamArraySimple(map, prefix + "CUCCIpList.", this.CUCCIpList);
            this.SetParamArraySimple(map, prefix + "CMCCIpList.", this.CMCCIpList);
            this.SetParamArraySimple(map, prefix + "OverseaIpList.", this.OverseaIpList);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

