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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWebPageServiceInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否已购服务：true-是，false-否
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 已使用授权数
        /// </summary>
        [JsonProperty("UsedNum")]
        public ulong? UsedNum{ get; set; }

        /// <summary>
        /// 剩余授权数
        /// </summary>
        [JsonProperty("ResidueNum")]
        public ulong? ResidueNum{ get; set; }

        /// <summary>
        /// 已购授权数
        /// </summary>
        [JsonProperty("BuyNum")]
        public ulong? BuyNum{ get; set; }

        /// <summary>
        /// 临近到期数量
        /// </summary>
        [JsonProperty("ExpireNum")]
        public ulong? ExpireNum{ get; set; }

        /// <summary>
        /// 所有授权机器信息
        /// </summary>
        [JsonProperty("AllAuthorizedMachines")]
        public ProtectMachineInfo[] AllAuthorizedMachines{ get; set; }

        /// <summary>
        /// 临近到期授权机器信息
        /// </summary>
        [JsonProperty("ExpireAuthorizedMachines")]
        public ProtectMachine[] ExpireAuthorizedMachines{ get; set; }

        /// <summary>
        /// 已过期授权数
        /// </summary>
        [JsonProperty("ExpiredNum")]
        public ulong? ExpiredNum{ get; set; }

        /// <summary>
        /// 防护目录数
        /// </summary>
        [JsonProperty("ProtectDirNum")]
        public ulong? ProtectDirNum{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UsedNum", this.UsedNum);
            this.SetParamSimple(map, prefix + "ResidueNum", this.ResidueNum);
            this.SetParamSimple(map, prefix + "BuyNum", this.BuyNum);
            this.SetParamSimple(map, prefix + "ExpireNum", this.ExpireNum);
            this.SetParamArrayObj(map, prefix + "AllAuthorizedMachines.", this.AllAuthorizedMachines);
            this.SetParamArrayObj(map, prefix + "ExpireAuthorizedMachines.", this.ExpireAuthorizedMachines);
            this.SetParamSimple(map, prefix + "ExpiredNum", this.ExpiredNum);
            this.SetParamSimple(map, prefix + "ProtectDirNum", this.ProtectDirNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

