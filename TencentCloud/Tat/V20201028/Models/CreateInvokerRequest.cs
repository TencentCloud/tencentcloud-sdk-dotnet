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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInvokerRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行器名称。长度不超过 120 字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 执行器类型。
        /// 
        /// 可选取值（当前仅支持一种）：
        /// 
        /// - `SCHEDULE`：周期类型执行器。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 远程命令ID。
        /// 
        /// 可通过 [DescribeCommands(查询命令详情)](https://cloud.tencent.com/document/api/1340/52681) 接口获取。
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// 触发器关联的实例ID。列表上限 100。
        /// 
        /// 可通过对应云产品的查询实例接口获取实例 ID。目前支持实例类型：CVM、Lighthouse、TAT 托管实例。
        /// 
        /// 实例需要安装 TAT 客户端, 且客户端为 Online 状态。可通过 [DescribeAutomationAgentStatus(查询客户端状态)](https://cloud.tencent.com/document/api/1340/52682) 接口查询客户端状态。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 命令执行用户。长度不超过 256 字符。
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 命令自定义参数。字段类型为 JSON encode string。
        /// 
        /// 仅在 CommandId 所指命令的 EnableParameter 为 true 时，才允许设置此参数。可通过 [DescribeCommands(查询命令详情)](https://cloud.tencent.com/document/api/1340/52681) 接口获取命令的 EnableParameter 设置。
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 周期执行器设置。
        /// 
        /// 当执行器类型为 `SCHEDULE` 时，必须指定此参数。
        /// </summary>
        [JsonProperty("ScheduleSettings")]
        public ScheduleSettings ScheduleSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamObj(map, prefix + "ScheduleSettings.", this.ScheduleSettings);
        }
    }
}

