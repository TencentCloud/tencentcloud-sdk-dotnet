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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInvokerRequest : AbstractModel
    {
        
        /// <summary>
        /// 待修改的执行器ID。
        /// 
        /// 可通过 [DescribeInvokers(查询执行器)](https://cloud.tencent.com/document/api/1340/61759) 接口获取。
        /// </summary>
        [JsonProperty("InvokerId")]
        public string InvokerId{ get; set; }

        /// <summary>
        /// 待修改的执行器名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 执行器类型，当前仅支持周期类型执行器，取值：`SCHEDULE` 。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 待修改的命令ID。
        /// 
        /// 可通过 [DescribeCommands(查询命令详情)](https://cloud.tencent.com/document/api/1340/52681) 接口获取。
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// 待修改的用户名。
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 待修改的自定义参数。
        /// 
        /// 仅在 CommandId 所指命令的 EnableParameter 为 true 时，才允许设置此参数。可通过 [DescribeCommands(查询命令详情)](https://cloud.tencent.com/document/api/1340/52681) 接口获取命令的 EnableParameter 设置。
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 待修改的实例ID列表。列表长度上限100。
        /// 
        /// 可通过对应云产品的查询实例接口获取实例 ID。目前支持实例类型：CVM、Lighthouse、TAT 托管实例。
        /// 
        /// 实例需要安装 TAT 客户端, 且客户端为 Online 状态。可通过 [DescribeAutomationAgentStatus(查询客户端状态)](https://cloud.tencent.com/document/api/1340/52682) 接口查询客户端状态。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 待修改的周期执行器设置。
        /// </summary>
        [JsonProperty("ScheduleSettings")]
        public ScheduleSettings ScheduleSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvokerId", this.InvokerId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "ScheduleSettings.", this.ScheduleSettings);
        }
    }
}

