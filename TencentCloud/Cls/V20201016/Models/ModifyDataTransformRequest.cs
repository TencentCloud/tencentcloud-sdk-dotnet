/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDataTransformRequest : AbstractModel
    {
        
        /// <summary>
        /// 加工任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 加工任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 加工逻辑函数
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// 任务启动状态. 默认为1，正常开启,  2关闭
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// 加工任务目的topic_id以及别名
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
        }
    }
}

