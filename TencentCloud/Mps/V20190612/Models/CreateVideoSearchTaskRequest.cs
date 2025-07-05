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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVideoSearchTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 用于检索任务的输入
        /// </summary>
        [JsonProperty("SearchValueInput")]
        public SearchValueInput SearchValueInput{ get; set; }

        /// <summary>
        /// 返回视频的最大数量，取值范围[1,20]，将返回最相近的前Limit条视频,默认为5
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 可选，用于检索任务完成后向回调方发送检索结果，目前仅支持URL方式
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public TaskNotifyConfig TaskNotifyConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SearchValueInput.", this.SearchValueInput);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
        }
    }
}

