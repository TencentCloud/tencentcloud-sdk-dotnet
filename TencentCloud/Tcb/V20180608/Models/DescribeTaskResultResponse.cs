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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskResultResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务类型</p><p>枚举值：</p><ul><li>PGUserMigration： PG Migrate 任务</li><li>PGDump： PG 数据库整库导出任务</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>任务状态</p><p>枚举值：</p><ul><li>Failed： 失败</li><li>Succeed： 成功</li><li>Accepted： 已接收</li><li>Running： 运行中</li><li>Pending： 已受理，等待工作流启动</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>任务当前执行步骤。PGDump 任务可能为 Queued（排队）、Preparing（准备）、Dumping（导出）、Validating（校验）、Uploading（上传）、Finalizing（收尾）、Completed（完成）；其他任务的步骤由任务类型决定。</p>
        /// </summary>
        [JsonProperty("Phase")]
        public string Phase{ get; set; }

        /// <summary>
        /// <p>失败原因。PGDump 任务返回稳定业务码：PGDumpPermissionDenied、PGDumpToolVersionMismatch、PGDumpSizeExceeded、PGDumpTimeout、PGDumpProcessFailed、PGDumpUploadFailed、PGDumpSourceChanged；成功时为空。其他任务按原有失败原因返回。</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：2026-05-26T11:26:14+08:00</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>最后更新时间</p><p>参数格式：2026-05-26T11:26:14+08:00</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// <p>任务参数键值对列表，Value 均为字符串。PGDump 成功任务包含 file_name（文件名）、file_size_bytes（字节数）、checksum_sha256（SHA256）、source_db_version（源库版本）、dump_tool_version（工具版本）、file_expires_at（RFC3339 过期时间）。文件未过期且对象存在时返回 download_url；URL 过期后可重新查询，勿记录或持久化签名 URL。仅对象确认缺失时返回 file_missing=true；文件过期不返回下载 URL。归档查询或签名临时故障返回系统错误，任务终态不变。</p>
        /// </summary>
        [JsonProperty("Params")]
        public ObjectKV[] Params{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Phase", this.Phase);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

