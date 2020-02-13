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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentGroup : AbstractModel
    {
        
        /// <summary>
        /// 拨测分组Id
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// 拨测分组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 是否默认拨测分组。1表示是，0表示否
        /// </summary>
        [JsonProperty("IsDefault")]
        public ulong? IsDefault{ get; set; }

        /// <summary>
        /// 使用本拨测分组的任务数
        /// </summary>
        [JsonProperty("TaskNum")]
        public ulong? TaskNum{ get; set; }

        /// <summary>
        /// 拨测结点列表
        /// </summary>
        [JsonProperty("GroupDetail")]
        public CatAgent[] GroupDetail{ get; set; }

        /// <summary>
        /// 最大拨测分组数
        /// </summary>
        [JsonProperty("MaxGroupNum")]
        public ulong? MaxGroupNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "TaskNum", this.TaskNum);
            this.SetParamArrayObj(map, prefix + "GroupDetail.", this.GroupDetail);
            this.SetParamSimple(map, prefix + "MaxGroupNum", this.MaxGroupNum);
        }
    }
}

