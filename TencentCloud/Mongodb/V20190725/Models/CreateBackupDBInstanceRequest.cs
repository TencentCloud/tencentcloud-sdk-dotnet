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

    public class CreateBackupDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。例如：cmgo-p8vn****。请登录 <a href="https://console.cloud.tencent.com/mongodb">MongoDB 控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>设置备份方式。</p><ul><li>0：逻辑备份。</li><li>1：物理备份。</li><li>3：快照备份。<br><strong>说明</strong>:</li><li>通用版实例支持逻辑备份与物理备份。云盘版实例支持物理备份与快照备份，暂不支持逻辑备份。</li><li>实例开通存储加密，则备份方式不能为物理备份。</li></ul>
        /// </summary>
        [JsonProperty("BackupMethod")]
        public long? BackupMethod{ get; set; }

        /// <summary>
        /// <p>备份备注信息。</p>
        /// </summary>
        [JsonProperty("BackupRemark")]
        public string BackupRemark{ get; set; }

        /// <summary>
        /// <p>保存天数，-2-永久保留（不定期保留），-1-跟随长期保留时长，0-按配置天数，1~7300-自定义天数（最长20年）</p><p>单位：天</p>
        /// </summary>
        [JsonProperty("BackupRetentionDays")]
        public long? BackupRetentionDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupRemark", this.BackupRemark);
            this.SetParamSimple(map, prefix + "BackupRetentionDays", this.BackupRetentionDays);
        }
    }
}

