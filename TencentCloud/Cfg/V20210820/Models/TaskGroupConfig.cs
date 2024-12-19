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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupConfig : AbstractModel
    {
        
        /// <summary>
        /// 动作组所关联的实例对象
        /// CVM ins-xxx
        /// MySQL cdb-xxx
        /// CLB lb-xxx
        /// Redis crs-xxx
        /// NAT网关 nat-xxx
        /// 专线-独享专用通道 dcx-xxx
        /// 标准集群普通节点 {"ClusterId":"cls-xxx","InstanceId":"ins-xxx","LanIP":"1.1.1.1"}
        /// 标准集群Pod {"ClusterId":"cls-xxx","PodName":"podname","NodeName":"1.1.1.1","NameSpace":"ns","Workload":"workload"}
        /// TDSQL-MySQL(InnoDB) tdsqlshard-xxx
        /// TDSQL-C cynosdbmysql-xxx
        /// VPC子网 subnet-xxxx
        /// CKafka ckafka-xxx
        /// MariaDB tdsql-xxxx
        /// PostgreSQL postgres-xxx
        /// 云原生网关 gateway-xxx
        /// 标准集群超级节点 {"ClusterId":"cls-xxx","InstanceId":"eklet-xxx","LanIP":"1.1.1.1,"NodePoolId":"np-xxx"}
        /// Serverless集群超级节点 {"ClusterId":"cls-xxxx","InstanceId":"eklet-xxxx","LanIP":"1.1.1.1"}
        /// Elasticsearch集群 es-xxxx
        /// RabbitMQ amqp-xxxx
        /// </summary>
        [JsonProperty("TaskGroupInstances")]
        public string[] TaskGroupInstances{ get; set; }

        /// <summary>
        /// 动作组标题，不填默认取经验中的动作组名称
        /// </summary>
        [JsonProperty("TaskGroupTitle")]
        public string TaskGroupTitle{ get; set; }

        /// <summary>
        /// 动作组描述，不填默认取经验中的动作组描述
        /// </summary>
        [JsonProperty("TaskGroupDescription")]
        public string TaskGroupDescription{ get; set; }

        /// <summary>
        /// 动作执行模式。1 --- 顺序执行，2 --- 阶段执行, 不填默认取经验中的动作组执行模式
        /// </summary>
        [JsonProperty("TaskGroupMode")]
        public ulong? TaskGroupMode{ get; set; }

        /// <summary>
        /// 动作组中的动作参数，不填默认使用经验中的动作参数，配置时可以只指定想要修改参数的动作
        /// </summary>
        [JsonProperty("TaskGroupActionsConfig")]
        public TaskGroupActionConfig[] TaskGroupActionsConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskGroupInstances.", this.TaskGroupInstances);
            this.SetParamSimple(map, prefix + "TaskGroupTitle", this.TaskGroupTitle);
            this.SetParamSimple(map, prefix + "TaskGroupDescription", this.TaskGroupDescription);
            this.SetParamSimple(map, prefix + "TaskGroupMode", this.TaskGroupMode);
            this.SetParamArrayObj(map, prefix + "TaskGroupActionsConfig.", this.TaskGroupActionsConfig);
        }
    }
}

