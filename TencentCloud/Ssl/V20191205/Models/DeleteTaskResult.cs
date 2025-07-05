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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 证书ID
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 异步查询结果： 0表示任务进行中、 1表示任务成功、 2表示任务失败、3表示未授权服务角色导致任务失败、4表示有未解绑的云资源导致任务失败、5表示查询关联云资源超时导致任务失败
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("Error")]
        public string Error{ get; set; }

        /// <summary>
        /// 当前结果缓存时间
        /// </summary>
        [JsonProperty("CacheTime")]
        public string CacheTime{ get; set; }

        /// <summary>
        /// 包含的域名
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Error", this.Error);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
        }
    }
}

