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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetBackupRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，例如：cmgo-p8vn****。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 设置自动备份方式。- 0：逻辑备份。- 1：物理备份。-3：快照备份(仅云盘版支持)。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public ulong? BackupMethod{ get; set; }

        /// <summary>
        /// 设置自动备份开始时间。取值范围为：[0,23]，例如：该参数设置为2，表示02:00开始备份。
        /// </summary>
        [JsonProperty("BackupTime")]
        public ulong? BackupTime{ get; set; }

        /// <summary>
        /// 设置自动备份发生错误时，是否发送失败告警。
        /// - true：发送。
        /// - false：不发送。
        /// </summary>
        [JsonProperty("Notify")]
        public bool? Notify{ get; set; }

        /// <summary>
        /// 指定备份数据保存天数。默认为 7 天，支持设置为7、30、90、180、365。
        /// </summary>
        [JsonProperty("BackupRetentionPeriod")]
        public ulong? BackupRetentionPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "Notify", this.Notify);
            this.SetParamSimple(map, prefix + "BackupRetentionPeriod", this.BackupRetentionPeriod);
        }
    }
}

