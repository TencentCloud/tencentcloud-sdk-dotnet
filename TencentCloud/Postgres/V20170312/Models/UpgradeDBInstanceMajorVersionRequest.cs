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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDBInstanceMajorVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。可通过[DescribeDBInstances](https://cloud.tencent.com/document/api/409/16773)接口获取
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 目标内核版本号，可以通过API [DescribeDBVersions](https://cloud.tencent.com/document/product/409/89018)获取可以升级的目标内核版本号。
        /// </summary>
        [JsonProperty("TargetDBKernelVersion")]
        public string TargetDBKernelVersion{ get; set; }

        /// <summary>
        /// 是否为校验模式，若UpgradeCheck为True，表示仅进行内核版本兼容性检查，不会进行实质性的升级操作，对原实例无影响。检查结果可以通过升级日志查看。
        /// </summary>
        [JsonProperty("UpgradeCheck")]
        public bool? UpgradeCheck{ get; set; }

        /// <summary>
        /// 升级前备份选项。True，表示升级前需要创建全量备份，False，表示升级前不需要创建全量备份。当实例已有备份集可以恢复到升级前的状态时，可选择False，否则需要指定为True。UpgradeCheck为True时，此参数无效。
        /// </summary>
        [JsonProperty("BackupBeforeUpgrade")]
        public bool? BackupBeforeUpgrade{ get; set; }

        /// <summary>
        /// 统计信息收集选项，对主例运行 ANALYZE 以在升级后更新系统统计信息。可选值包括，
        /// 0：不需要收集统计信息；
        /// 1：实例恢复写之前收集统计信息；
        /// 3：实例恢复写之后收集统计信息。
        /// UpgradeCheck为True时，此参数无效。
        /// </summary>
        [JsonProperty("StatisticsRefreshOption")]
        public long? StatisticsRefreshOption{ get; set; }

        /// <summary>
        /// 插件升级选项，pg_upgrade不会升级任何插件，需要在升级完成后在创建过插件的库上执行"ALTER EXTENSION UPDATE"。发起升级实例大版本时可以指定在实例恢复写前/后是否需要升级任务自动升级插件版本。可选值包括：
        /// 0：不需要自动升级插件；
        /// 1：恢复写之前升级插件；
        /// 2：恢复写之后升级插件。
        /// UpgradeCheck为True时，此参数无效。
        /// </summary>
        [JsonProperty("ExtensionUpgradeOption")]
        public long? ExtensionUpgradeOption{ get; set; }

        /// <summary>
        /// 升级时间选项，升级过程中会有一段时间实例只读，并会有一次秒级闪断，发起升级时需要选择这段影响的时间窗。可选值包括：
        /// 0：自动执行，不需要指定时间窗；
        /// 1：指定本次升级任务的时间窗，通过参数UpgradeTimeBegin和UpgradeTimeEnd设置；
        /// 2：在实例运维时间窗内执行。
        /// UpgradeCheck为True时，此参数无效。
        /// </summary>
        [JsonProperty("UpgradeTimeOption")]
        public long? UpgradeTimeOption{ get; set; }

        /// <summary>
        /// 升级时间窗开始时间，时间格式：HH:MM:SS，例如：01:00:00。当UpgradeTimeOption为1时，该参数有效。
        /// UpgradeCheck为True时，此参数无效。
        /// </summary>
        [JsonProperty("UpgradeTimeBegin")]
        public string UpgradeTimeBegin{ get; set; }

        /// <summary>
        /// 升级时间窗截止时间，时间格式：HH:MM:SS，例如：02:00:00。当UpgradeTimeOption为1时，该参数有效。
        /// UpgradeCheck为True时，此参数无效。
        /// </summary>
        [JsonProperty("UpgradeTimeEnd")]
        public string UpgradeTimeEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "TargetDBKernelVersion", this.TargetDBKernelVersion);
            this.SetParamSimple(map, prefix + "UpgradeCheck", this.UpgradeCheck);
            this.SetParamSimple(map, prefix + "BackupBeforeUpgrade", this.BackupBeforeUpgrade);
            this.SetParamSimple(map, prefix + "StatisticsRefreshOption", this.StatisticsRefreshOption);
            this.SetParamSimple(map, prefix + "ExtensionUpgradeOption", this.ExtensionUpgradeOption);
            this.SetParamSimple(map, prefix + "UpgradeTimeOption", this.UpgradeTimeOption);
            this.SetParamSimple(map, prefix + "UpgradeTimeBegin", this.UpgradeTimeBegin);
            this.SetParamSimple(map, prefix + "UpgradeTimeEnd", this.UpgradeTimeEnd);
        }
    }
}

