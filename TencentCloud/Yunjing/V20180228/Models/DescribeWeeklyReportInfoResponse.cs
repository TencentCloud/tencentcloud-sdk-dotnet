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

    public class DescribeWeeklyReportInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 账号所属公司或个人名称。
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 机器总数。
        /// </summary>
        [JsonProperty("MachineNum")]
        public ulong? MachineNum{ get; set; }

        /// <summary>
        /// 云镜客户端在线数。
        /// </summary>
        [JsonProperty("OnlineMachineNum")]
        public ulong? OnlineMachineNum{ get; set; }

        /// <summary>
        /// 云镜客户端离线数。
        /// </summary>
        [JsonProperty("OfflineMachineNum")]
        public ulong? OfflineMachineNum{ get; set; }

        /// <summary>
        /// 开通云镜专业版数量。
        /// </summary>
        [JsonProperty("ProVersionMachineNum")]
        public ulong? ProVersionMachineNum{ get; set; }

        /// <summary>
        /// 周报开始时间。
        /// </summary>
        [JsonProperty("BeginDate")]
        public string BeginDate{ get; set; }

        /// <summary>
        /// 周报结束时间。
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 安全等级。
        /// <li>HIGH：高</li>
        /// <li>MIDDLE：中</li>
        /// <li>LOW：低</li>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 木马记录数。
        /// </summary>
        [JsonProperty("MalwareNum")]
        public ulong? MalwareNum{ get; set; }

        /// <summary>
        /// 异地登录数。
        /// </summary>
        [JsonProperty("NonlocalLoginNum")]
        public ulong? NonlocalLoginNum{ get; set; }

        /// <summary>
        /// 密码破解成功数。
        /// </summary>
        [JsonProperty("BruteAttackSuccessNum")]
        public ulong? BruteAttackSuccessNum{ get; set; }

        /// <summary>
        /// 漏洞数。
        /// </summary>
        [JsonProperty("VulNum")]
        public ulong? VulNum{ get; set; }

        /// <summary>
        /// 导出文件下载地址。
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "MachineNum", this.MachineNum);
            this.SetParamSimple(map, prefix + "OnlineMachineNum", this.OnlineMachineNum);
            this.SetParamSimple(map, prefix + "OfflineMachineNum", this.OfflineMachineNum);
            this.SetParamSimple(map, prefix + "ProVersionMachineNum", this.ProVersionMachineNum);
            this.SetParamSimple(map, prefix + "BeginDate", this.BeginDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "MalwareNum", this.MalwareNum);
            this.SetParamSimple(map, prefix + "NonlocalLoginNum", this.NonlocalLoginNum);
            this.SetParamSimple(map, prefix + "BruteAttackSuccessNum", this.BruteAttackSuccessNum);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

