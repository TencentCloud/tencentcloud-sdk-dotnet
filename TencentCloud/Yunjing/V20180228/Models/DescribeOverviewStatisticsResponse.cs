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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOverviewStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// 服务器在线数。
        /// </summary>
        [JsonProperty("OnlineMachineNum")]
        public ulong? OnlineMachineNum{ get; set; }

        /// <summary>
        /// 专业服务器数。
        /// </summary>
        [JsonProperty("ProVersionMachineNum")]
        public ulong? ProVersionMachineNum{ get; set; }

        /// <summary>
        /// 木马文件数。
        /// </summary>
        [JsonProperty("MalwareNum")]
        public ulong? MalwareNum{ get; set; }

        /// <summary>
        /// 异地登录数。
        /// </summary>
        [JsonProperty("NonlocalLoginNum")]
        public ulong? NonlocalLoginNum{ get; set; }

        /// <summary>
        /// 暴力破解成功数。
        /// </summary>
        [JsonProperty("BruteAttackSuccessNum")]
        public ulong? BruteAttackSuccessNum{ get; set; }

        /// <summary>
        /// 漏洞数。
        /// </summary>
        [JsonProperty("VulNum")]
        public ulong? VulNum{ get; set; }

        /// <summary>
        /// 安全基线数。
        /// </summary>
        [JsonProperty("BaseLineNum")]
        public ulong? BaseLineNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OnlineMachineNum", this.OnlineMachineNum);
            this.SetParamSimple(map, prefix + "ProVersionMachineNum", this.ProVersionMachineNum);
            this.SetParamSimple(map, prefix + "MalwareNum", this.MalwareNum);
            this.SetParamSimple(map, prefix + "NonlocalLoginNum", this.NonlocalLoginNum);
            this.SetParamSimple(map, prefix + "BruteAttackSuccessNum", this.BruteAttackSuccessNum);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "BaseLineNum", this.BaseLineNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

