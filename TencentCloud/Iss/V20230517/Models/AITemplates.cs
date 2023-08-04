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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AITemplates : AbstractModel
    {
        
        /// <summary>
        /// AI 类别。可选值 AI(AI 分析)和 Snapshot(截图)，Templates 列表中只能出现一种类型。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// AI 分析配置。和"SnapshotConfig"二选一。
        /// </summary>
        [JsonProperty("AIConfig")]
        public AIConfig AIConfig{ get; set; }

        /// <summary>
        /// 截图配置。和"AIConfig"二选一。
        /// </summary>
        [JsonProperty("SnapshotConfig")]
        public SnapshotConfig SnapshotConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamObj(map, prefix + "AIConfig.", this.AIConfig);
            this.SetParamObj(map, prefix + "SnapshotConfig.", this.SnapshotConfig);
        }
    }
}

