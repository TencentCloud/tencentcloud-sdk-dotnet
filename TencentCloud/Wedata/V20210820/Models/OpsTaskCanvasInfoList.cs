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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpsTaskCanvasInfoList : AbstractModel
    {
        
        /// <summary>
        /// 画布任务信息
        /// </summary>
        [JsonProperty("TasksList")]
        public OpsTaskCanvasDto[] TasksList{ get; set; }

        /// <summary>
        /// 画布任务链接信息
        /// </summary>
        [JsonProperty("LinksList")]
        public OpsTaskLinkInfoDto[] LinksList{ get; set; }

        /// <summary>
        /// 画布循环依赖任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CirculateTaskList")]
        public OpsTaskCanvasDto[] CirculateTaskList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TasksList.", this.TasksList);
            this.SetParamArrayObj(map, prefix + "LinksList.", this.LinksList);
            this.SetParamArrayObj(map, prefix + "CirculateTaskList.", this.CirculateTaskList);
        }
    }
}

