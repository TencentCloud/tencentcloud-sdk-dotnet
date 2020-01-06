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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PurgeTask : AbstractModel
    {
        
        /// <summary>
        /// 刷新任务 ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 刷新 URL
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 刷新任务状态
        /// fail：刷新失败
        /// done：刷新成功
        /// process：刷新中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 刷新类型
        /// url：URL 刷新
        /// path：目录刷新
        /// </summary>
        [JsonProperty("PurgeType")]
        public string PurgeType{ get; set; }

        /// <summary>
        /// 刷新方式
        /// flush：刷新更新资源（仅目录刷新时有此类型）
        /// delete：刷新全部资源
        /// </summary>
        [JsonProperty("FlushType")]
        public string FlushType{ get; set; }

        /// <summary>
        /// 刷新任务提交时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PurgeType", this.PurgeType);
            this.SetParamSimple(map, prefix + "FlushType", this.FlushType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

