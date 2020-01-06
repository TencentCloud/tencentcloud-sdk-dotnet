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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RsgAsGroupActivity : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组活动 ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 关联的伸缩组 ID
        /// </summary>
        [JsonProperty("RsgAsGroupId")]
        public string RsgAsGroupId{ get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// 状态的编码
        /// </summary>
        [JsonProperty("StatusCode")]
        public string StatusCode{ get; set; }

        /// <summary>
        /// 状态的消息
        /// </summary>
        [JsonProperty("StatusMessage")]
        public string StatusMessage{ get; set; }

        /// <summary>
        /// 活动原因
        /// </summary>
        [JsonProperty("Cause")]
        public string Cause{ get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 活动创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 活动相关联的节点
        /// </summary>
        [JsonProperty("RsgAsActivityRelatedInstance")]
        public RsgAsActivityRelatedInstance[] RsgAsActivityRelatedInstance{ get; set; }

        /// <summary>
        /// 简略的状态消息
        /// </summary>
        [JsonProperty("StatusMessageSimplified")]
        public string StatusMessageSimplified{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RsgAsGroupId", this.RsgAsGroupId);
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "StatusMessage", this.StatusMessage);
            this.SetParamSimple(map, prefix + "Cause", this.Cause);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "RsgAsActivityRelatedInstance.", this.RsgAsActivityRelatedInstance);
            this.SetParamSimple(map, prefix + "StatusMessageSimplified", this.StatusMessageSimplified);
        }
    }
}

