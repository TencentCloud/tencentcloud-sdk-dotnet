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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyBackupGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 回滚的备份组ID。
        /// </summary>
        [JsonProperty("BackupGroupId")]
        public string BackupGroupId{ get; set; }

        /// <summary>
        /// 回滚的备份ID、云硬盘ID列表。
        /// </summary>
        [JsonProperty("ApplyDisks")]
        public ApplyDisk[] ApplyDisks{ get; set; }

        /// <summary>
        /// 回滚备份前是否执行自动关机，如果回滚的盘挂载在实例上且实例处于运行状态，可传入该参数。
        /// </summary>
        [JsonProperty("AutoStopInstance")]
        public bool? AutoStopInstance{ get; set; }

        /// <summary>
        /// 回滚备份完成后是否执行自动开机。
        /// </summary>
        [JsonProperty("AutoStartInstance")]
        public bool? AutoStartInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupGroupId", this.BackupGroupId);
            this.SetParamArrayObj(map, prefix + "ApplyDisks.", this.ApplyDisks);
            this.SetParamSimple(map, prefix + "AutoStopInstance", this.AutoStopInstance);
            this.SetParamSimple(map, prefix + "AutoStartInstance", this.AutoStartInstance);
        }
    }
}

