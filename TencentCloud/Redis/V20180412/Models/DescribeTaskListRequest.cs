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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskListRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定实例 ID。例如：crs-xjhsdj****。请登录[Redis控制台](https://console.cloud.tencent.com/redis)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 每页输出的任务列表大小。默认为 20，最多输出100条。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量，取Limit整数倍。计算公式：offset=limit*(页码-1)。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 项目 ID。登录 [Redis 控制台](https://console.cloud.tencent.com/redis)，在右上角的账号信息下拉菜单中，选择**项目管理**，即可获取对应的项目 ID。
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 任务类型。
        /// - FLOW_CREATE：创建实例。
        /// - FLOW_MODIFYCONNECTIONCONFIG：调整带宽连接数。
        /// - FLOW_MODIFYINSTANCEPASSWORDFREE：免密变更流程。
        /// - FLOW_CLEARNETWORK：VPC退还中。
        /// - FLOW_SETPWD：设置访问密码。
        /// - FLOW_EXPORSHR：扩缩容流程。
        /// - FLOW_UpgradeArch：实例架构升级流程。
        /// - FLOW_MODIFYINSTANCEPARAMS：修改实例参数。
        /// - FLOW_MODIFYINSTACEREADONLY：只读变更流程。
        /// - FLOW_CLOSE：关闭实例。
        /// - FLOW_DELETE：删除实例。
        /// - FLOW_OPEN_WAN：开启外网。
        /// - FLOW_CLEAN：清空实例。      
        /// - FLOW_MODIFYINSTANCEACCOUNT：修改实例账号。
        /// - FLOW_ENABLEINSTANCE_REPLICATE：开启副本只读。
        /// - FLOW_DISABLEINSTANCE_REPLICATE: 关闭副本只读。
        /// - FLOW_SWITCHINSTANCEVIP：交换实例 VIP。
        /// - FLOW_CHANGE_REPLICA_TO_MSTER：副本节点升主节点。
        /// - FLOW_BACKUPINSTANCE：备份实例。
        /// </summary>
        [JsonProperty("TaskTypes")]
        public string[] TaskTypes{ get; set; }

        /// <summary>
        /// 任务执行的起始时间。格式如：2021-12-30 00:00:00。
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 任务运行的终止时间。格式如：2021-12-30 20:59:35
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 该参数为内部使用，请忽略。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long?[] TaskStatus{ get; set; }

        /// <summary>
        /// 任务执行状态。
        /// - 0：任务初始化。
        /// - 1：执行中。
        /// - 2：完成。
        /// - 4：失败。
        /// </summary>
        [JsonProperty("Result")]
        public long?[] Result{ get; set; }

        /// <summary>
        /// 该字段已废弃，使用OperateUin代替，请忽略。
        /// </summary>
        [JsonProperty("OperatorUin")]
        public long?[] OperatorUin{ get; set; }

        /// <summary>
        /// 操作者账号 ID，UIN。
        /// </summary>
        [JsonProperty("OperateUin")]
        public string[] OperateUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "Result.", this.Result);
            this.SetParamArraySimple(map, prefix + "OperatorUin.", this.OperatorUin);
            this.SetParamArraySimple(map, prefix + "OperateUin.", this.OperateUin);
        }
    }
}

