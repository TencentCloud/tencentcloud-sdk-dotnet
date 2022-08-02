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

namespace TencentCloud.Acp.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceUsageInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源计费项名称(为空时，则根据TaskType和Platform进行查询)
        /// </summary>
        [JsonProperty("PriceName")]
        public string PriceName{ get; set; }

        /// <summary>
        /// 任务类型, 0:基础版, 1:专家版
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 应用平台, 0:android
        /// </summary>
        [JsonProperty("Platform")]
        public long? Platform{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PriceName", this.PriceName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
        }
    }
}

