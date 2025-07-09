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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// 任务 ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 任务开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务类型。
        /// - FLOW_CREATE: "001"，新建实例
        /// - FLOW_RESIZE ： "002"，配置变更
        /// - FLOW_CLOSE："003"，关闭实例
        /// - FLOW_CLEAN： "004"，清空实例
        /// - FLOW_STARTUP："005"，实例启用。
        /// - FLOW_DELETE："006"，删除实例。
        /// - FLOW_SETPWD："007"，重置密码。
        /// - FLOW_EXPORTBACKUP："009"，导出备份文件。
        /// - FLOW_RESTOREBACKUP："010"，恢复备份。
        /// - FLOW_BACKUPINSTANCE："012"，备份实例。
        /// - FLOW_MIGRATEINSTANCE："013"，迁移实例。
        /// - FLOW_DELBACKUP："014"，删除备份。
        /// - FLOW_EXCHANGEINSTANCE： "016"，切换实例流程。
        /// - FLOW_AUTOBACKUP："017"，自动备份实例。
        /// - FLOW_MIGRATECHECK： "022"，迁移参数校验。
        /// - FLOW_MIGRATETASK："023"，数据迁移中。
        /// - FLOW_CLEANDB："025"，清空数据库。
        /// - FLOW_CLONEBACKUP："026"，克隆备份。
        /// - FLOW_CHANGEVIP： "027"，改变vip地址。
        /// - FLOW_EXPORSHR ："028"，扩缩容。
        /// - FLOW_ADDNODES："029"，加（减）节点。
        /// - FLOW_CHANGENET："031"，改变网络类型。
        /// - FLOW_MODIFYINSTACEREADONLY："033"，只读策略变更。
        /// - FLOW_MODIFYINSTANCEPARAMS："034"，修改实例参数。
        /// - FLOW_MODIFYINSTANCEPASSWORDFREE："035"，设置免密。
        /// - FLOW_SWITCHINSTANCEVIP："036"，实例VIP切换。
        /// - FLOW_MODIFYINSTANCEACCOUNT："037"，实例账号变更。
        /// - FLOW_MODIFYINSTANCEBANDWIDTH："038"，实例带宽变更。
        /// - FLOW_ENABLEINSTANCE_REPLICATE："039"，开启副本只读。
        /// - FLOW_DISABLEINSTANCE_REPLICATE："040"，关闭副本只读。
        /// - FLOW_UpgradeArch："041"，实例架构升级，主从升集群。
        /// - FLOW_DowngradeArch： "042"，实例架构降级，集群降主从。
        /// - FLOW_UpgradeVersion： "043"，版本升级。
        /// - FLOW_MODIFYCONNECTIONCONFIG："044"，带宽连接数调整。
        /// - FLOW_CLEARNETWORK："045"，更换网络，
        /// - FLOW_REMOVE_BACKUP_FILE："046"，删除备份。
        /// - FLOW_UPGRADE_SUPPORT_MULTI_AZ："047"，升级实例支持多可用区。
        /// - FLOW_SHUTDOWN_MASTER："048"，模拟故障。
        /// - FLOW_CHANGE_REPLICA_TO_MASTER："049"，手动提主。
        /// - FLOW_CODE_ADD_REPLICATION_INSTANCE："050"，新增复制组。
        /// - FLOW_OPEN_WAN："052"，开通外网。
        /// - FLOW_CLOSE_WAN："053"，关闭外网
        /// - FLOW_CODE_DELETE_REPLICATION_INSTANCE："055"，解绑复制组。
        /// - FLOW_CODE_CHANGE_MASTER_INSTANCE："056"，复制组实例切主。
        /// - FLOW_CODE_CHANGE_INSTANCE_ROLE： "057"，更改复制组实例角色。
        /// - FLOW_MIGRATE_NODE："058"，迁移节点。
        /// - FLOW_SWITCH_NODE："059"，切换节点。
        /// - FLOW_UPGRADE_SMALL_VERSION："060"，升级 Redis版本。
        /// - FLOW_UPGRADE_PROXY_VERSION："061"，升级 Proxy 版本。
        /// - FLOW_MODIFY_INSTANCE_NETWORK： "062"，实例修改网络。
        /// - FLOW_MIGRATE_PROXY_NODE："063"，迁移 proxy节点。
        /// - FLOW_MIGRATION_INSTANCE_ZONE："066"，实例可用区迁移中。
        /// - FLOW_UPGRADE_INSTANCE_CACHE_AND_PROXY： "067"，实例版本升级中。
        /// - FLOW_MODIFY_PROXY_NUM："069"，加（减）Proxy 节点。
        /// - FLOW_MODIFYBACKUPMOD："070"，变更实例备份模式。
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 任务进度。
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// 任务执行结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务执行状态。
        /// 
        /// 0：任务初始化。
        /// 1：执行中。
        /// 2：完成。
        /// 4：失败。
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Result", this.Result);
        }
    }
}

