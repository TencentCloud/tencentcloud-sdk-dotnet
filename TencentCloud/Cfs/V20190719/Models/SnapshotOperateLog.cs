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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SnapshotOperateLog : AbstractModel
    {
        
        /// <summary>
        /// 操作类型
        /// CreateCfsSnapshot：创建快照
        /// DeleteCfsSnapshot：删除快照
        /// CreateCfsFileSystem：创建文件系统
        /// UpdateCfsSnapshotAttribute：更新快照
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }

        /// <summary>
        /// 操作名称
        /// CreateCfsSnapshot
        /// DeleteCfsSnapshot
        /// CreateCfsFileSystem
        /// UpdateCfsSnapshotAttribute
        /// </summary>
        [JsonProperty("ActionName")]
        public string ActionName{ get; set; }

        /// <summary>
        /// 操作者uin
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 1-任务进行中；2-任务成功；3-任务失败
        /// </summary>
        [JsonProperty("Result")]
        public ulong? Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "ActionTime", this.ActionTime);
            this.SetParamSimple(map, prefix + "ActionName", this.ActionName);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Result", this.Result);
        }
    }
}

