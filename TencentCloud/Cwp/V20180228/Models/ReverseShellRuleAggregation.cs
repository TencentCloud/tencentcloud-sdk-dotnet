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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReverseShellRuleAggregation : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("UuidHostips")]
        public UuidHostip[] UuidHostips{ get; set; }

        /// <summary>
        /// 进程名称
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// 目标IP
        /// </summary>
        [JsonProperty("DestIp")]
        public string DestIp{ get; set; }

        /// <summary>
        /// 目标端口
        /// </summary>
        [JsonProperty("DestPort")]
        public string DestPort{ get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 是否全局规则
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// 状态 (0: 有效 1: 无效)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 加白方式， 0:常规加白 1:正则加白
        /// </summary>
        [JsonProperty("WhiteType")]
        public ulong? WhiteType{ get; set; }

        /// <summary>
        /// 正则表达式
        /// </summary>
        [JsonProperty("RuleRegexp")]
        public string RuleRegexp{ get; set; }

        /// <summary>
        /// 处理历史事件， 0:不处理 1:处理
        /// </summary>
        [JsonProperty("HandleHistory")]
        public ulong? HandleHistory{ get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [JsonProperty("GroupID")]
        public string GroupID{ get; set; }

        /// <summary>
        /// 应用资产，描述服务器数量，全局时候为：全部服务器
        /// </summary>
        [JsonProperty("MachinesNums")]
        public string MachinesNums{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "UuidHostips.", this.UuidHostips);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "DestIp", this.DestIp);
            this.SetParamSimple(map, prefix + "DestPort", this.DestPort);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "WhiteType", this.WhiteType);
            this.SetParamSimple(map, prefix + "RuleRegexp", this.RuleRegexp);
            this.SetParamSimple(map, prefix + "HandleHistory", this.HandleHistory);
            this.SetParamSimple(map, prefix + "GroupID", this.GroupID);
            this.SetParamSimple(map, prefix + "MachinesNums", this.MachinesNums);
        }
    }
}

