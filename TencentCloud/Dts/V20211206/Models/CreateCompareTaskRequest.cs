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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCompareTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务 Id，可通过[DescribeMigrationJobs](https://cloud.tencent.com/document/product/571/82084)接口获取。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 数据对比任务名称，若为空则默认给CompareTaskId相同值
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 数据对比对象模式，sameAsMigrate(全部迁移对象， 默认为此项配置)，custom(自定义模式)
        /// </summary>
        [JsonProperty("ObjectMode")]
        public string ObjectMode{ get; set; }

        /// <summary>
        /// 数据对比对象，当ObjectMode为custom时，此项需要填写。
        /// </summary>
        [JsonProperty("Objects")]
        public CompareObject Objects{ get; set; }

        /// <summary>
        /// 一致性校验选项
        /// </summary>
        [JsonProperty("Options")]
        public CompareOptions Options{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ObjectMode", this.ObjectMode);
            this.SetParamObj(map, prefix + "Objects.", this.Objects);
            this.SetParamObj(map, prefix + "Options.", this.Options);
        }
    }
}

