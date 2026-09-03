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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnnotationContext : AbstractModel
    {
        
        /// <summary>
        /// <p>任务目标（整段视频的总目标）</p>
        /// </summary>
        [JsonProperty("TaskGoal")]
        public string TaskGoal{ get; set; }

        /// <summary>
        /// <p>关键物体列表</p>
        /// </summary>
        [JsonProperty("KeyObjects")]
        public string[] KeyObjects{ get; set; }

        /// <summary>
        /// <p>原子动词参考列表</p>
        /// </summary>
        [JsonProperty("AtomicVerbs")]
        public string[] AtomicVerbs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGoal", this.TaskGoal);
            this.SetParamArraySimple(map, prefix + "KeyObjects.", this.KeyObjects);
            this.SetParamArraySimple(map, prefix + "AtomicVerbs.", this.AtomicVerbs);
        }
    }
}

