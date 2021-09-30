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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PerStructDifference : AbstractModel
    {
        
        /// <summary>
        /// 子任务ID
        /// </summary>
        [JsonProperty("SubTaskId")]
        public string SubTaskId{ get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 修改的项
        /// </summary>
        [JsonProperty("ModifyItems")]
        public StructureModifyItem[] ModifyItems{ get; set; }

        /// <summary>
        /// 新增的项
        /// </summary>
        [JsonProperty("NewItems")]
        public StructureOneItem[] NewItems{ get; set; }

        /// <summary>
        /// 删除的项
        /// </summary>
        [JsonProperty("RemoveItems")]
        public StructureOneItem[] RemoveItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubTaskId", this.SubTaskId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "ModifyItems.", this.ModifyItems);
            this.SetParamArrayObj(map, prefix + "NewItems.", this.NewItems);
            this.SetParamArrayObj(map, prefix + "RemoveItems.", this.RemoveItems);
        }
    }
}

