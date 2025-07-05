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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunChangePwdTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("OperationId")]
        public string OperationId{ get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }

        /// <summary>
        /// 改密任务详情
        /// </summary>
        [JsonProperty("Details")]
        public RunChangePwdTaskDetail[] Details{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperationId", this.OperationId);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
        }
    }
}

