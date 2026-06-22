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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RepairTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>维修任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务类型ID<br>// - <code>101</code>：实例运行隐患<br>    // - <code>102</code>：实例运行异常<br>    // - <code>103</code>：实例硬盘异常<br>    // - <code>104</code>：实例网络连接异常<br>    // - <code>105</code>：实例运行预警<br>    // - <code>106</code>：实例硬盘预警<br>    // - <code>107</code>：实例维护升级</p>
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public ulong? TaskTypeId{ get; set; }

        /// <summary>
        /// <p>任务类型中文名</p>
        /// </summary>
        [JsonProperty("TaskTypeName")]
        public string TaskTypeName{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>任务详情</p>
        /// </summary>
        [JsonProperty("TaskDetail")]
        public string TaskDetail{ get; set; }

        /// <summary>
        /// <p>产品类型，支持取值：<br>    //<br>    // - <code>CVM</code>：云服务器<br>    // - <code>CDH</code>：专用宿主机<br>    // - <code>CPM2.0</code>：裸金属云服务器</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "TaskTypeName", this.TaskTypeName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TaskDetail", this.TaskDetail);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

