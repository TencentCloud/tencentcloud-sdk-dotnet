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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteSecurityAuditLogExportTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 安全审计组Id。
        /// </summary>
        [JsonProperty("SecAuditGroupId")]
        public string SecAuditGroupId{ get; set; }

        /// <summary>
        /// 日志导出任务Id列表，接口会忽略不存在或已删除的任务Id。
        /// </summary>
        [JsonProperty("AsyncRequestIds")]
        public ulong?[] AsyncRequestIds{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值： "mysql" - 云数据库 MySQL。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecAuditGroupId", this.SecAuditGroupId);
            this.SetParamArraySimple(map, prefix + "AsyncRequestIds.", this.AsyncRequestIds);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

