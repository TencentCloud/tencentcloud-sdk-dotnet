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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBackUpScheduleRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 操作类型 create(创建) update(编辑修改)
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// 编辑时需要传
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// 选择的星期 逗号分隔
        /// 废弃：使用ScheduleInfo
        /// </summary>
        [JsonProperty("WeekDays")]
        [System.Obsolete]
        public string WeekDays{ get; set; }

        /// <summary>
        /// 执行小时
        /// 废弃：使用ScheduleInfo
        /// </summary>
        [JsonProperty("ExecuteHour")]
        [System.Obsolete]
        public long? ExecuteHour{ get; set; }

        /// <summary>
        /// 备份表列表
        /// </summary>
        [JsonProperty("BackUpTables")]
        public BackupTableContent[] BackUpTables{ get; set; }

        /// <summary>
        /// 0为默认。1时是对远端的doris进行备份，不周期，一次性
        /// </summary>
        [JsonProperty("BackupType")]
        [System.Obsolete]
        public long? BackupType{ get; set; }

        /// <summary>
        /// 远端doris集群的连接信息
        /// </summary>
        [JsonProperty("DorisSourceInfo")]
        [System.Obsolete]
        public DorisSourceInfo DorisSourceInfo{ get; set; }

        /// <summary>
        /// 0为周期备份。1时是立即备份。3时是定时备份。
        /// </summary>
        [JsonProperty("BackupTimeType")]
        public long? BackupTimeType{ get; set; }

        /// <summary>
        /// 0为默认。1时是备份完成后立即恢复
        /// </summary>
        [JsonProperty("RestoreType")]
        [System.Obsolete]
        public long? RestoreType{ get; set; }

        /// <summary>
        /// 0为默认。1时是提供自定义的secret连接cos
        /// </summary>
        [JsonProperty("AuthType")]
        [System.Obsolete]
        public long? AuthType{ get; set; }

        /// <summary>
        /// cos认证的信息
        /// </summary>
        [JsonProperty("CosSourceInfo")]
        [System.Obsolete]
        public CosSourceInfo CosSourceInfo{ get; set; }

        /// <summary>
        /// 调度任务名
        /// </summary>
        [JsonProperty("ScheduleName")]
        public string ScheduleName{ get; set; }

        /// <summary>
        /// 调度信息
        /// </summary>
        [JsonProperty("ScheduleInfo")]
        public ScheduleInfo ScheduleInfo{ get; set; }

        /// <summary>
        /// 更新任务状态：
        /// 3-暂停,
        /// 2-删除,
        /// 1-启动
        /// </summary>
        [JsonProperty("UpdateStatus")]
        public long? UpdateStatus{ get; set; }

        /// <summary>
        /// 当前任务的cos桶信息
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// 快照保留策略
        /// </summary>
        [JsonProperty("SnapshotRemainPolicy")]
        public SnapshotRemainPolicy SnapshotRemainPolicy{ get; set; }

        /// <summary>
        /// 备份数据所在地域，当前地域应该为空
        /// </summary>
        [JsonProperty("DataRemoteRegion")]
        public string DataRemoteRegion{ get; set; }

        /// <summary>
        /// 托管桶类型：standard-标准，maz-多可用区
        /// </summary>
        [JsonProperty("BucketType")]
        public string BucketType{ get; set; }

        /// <summary>
        /// 是否开启安全锁：0-未开启，1-开启
        /// </summary>
        [JsonProperty("EnableSecurityLock")]
        public long? EnableSecurityLock{ get; set; }

        /// <summary>
        /// 宽限期（天数）
        /// </summary>
        [JsonProperty("GracePeriod")]
        public ulong? GracePeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamSimple(map, prefix + "WeekDays", this.WeekDays);
            this.SetParamSimple(map, prefix + "ExecuteHour", this.ExecuteHour);
            this.SetParamArrayObj(map, prefix + "BackUpTables.", this.BackUpTables);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamObj(map, prefix + "DorisSourceInfo.", this.DorisSourceInfo);
            this.SetParamSimple(map, prefix + "BackupTimeType", this.BackupTimeType);
            this.SetParamSimple(map, prefix + "RestoreType", this.RestoreType);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamObj(map, prefix + "CosSourceInfo.", this.CosSourceInfo);
            this.SetParamSimple(map, prefix + "ScheduleName", this.ScheduleName);
            this.SetParamObj(map, prefix + "ScheduleInfo.", this.ScheduleInfo);
            this.SetParamSimple(map, prefix + "UpdateStatus", this.UpdateStatus);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamObj(map, prefix + "SnapshotRemainPolicy.", this.SnapshotRemainPolicy);
            this.SetParamSimple(map, prefix + "DataRemoteRegion", this.DataRemoteRegion);
            this.SetParamSimple(map, prefix + "BucketType", this.BucketType);
            this.SetParamSimple(map, prefix + "EnableSecurityLock", this.EnableSecurityLock);
            this.SetParamSimple(map, prefix + "GracePeriod", this.GracePeriod);
        }
    }
}

